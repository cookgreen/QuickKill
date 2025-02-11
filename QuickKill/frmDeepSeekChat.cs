using DeepSeekAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickKill
{
    public partial class frmDeepSeekChat : Form
    {
        private DeepSeekApi deepSeekApi;

        public frmDeepSeekChat(DeepSeekApi deepSeekApi)
        {
            this.deepSeekApi = deepSeekApi;
            InitializeComponent();
            getModels();
        }

        private async void getModels()
        {
            var retValue = await deepSeekApi.GetModelList();
            if (retValue.Item2 == "data")
            {
                DeepSeekModelReturnValue ret = retValue.Item1 as DeepSeekModelReturnValue;
                foreach (var item in ret.data)
                {
                    cmbModelList.Items.Add(item.id);
                }
                if (cmbModelList.Items.Count > 0) 
                {
                    cmbModelList.SelectedIndex = 0;
                }
            }
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtChatMessage.Text))
            {
                MessageBox.Show("Please input valid message!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            chatList.Items.Add(txtChatMessage.Text);

            var retVal = await deepSeekApi.Chat(txtChatMessage.Text, cmbModelList.SelectedItem.ToString());
            if (retVal.Item2 == "error")
            {
                var msg = (DeepSeekErrorMessageReturnValue)retVal.Item1;
                chatList.Items.Add("Error: " + msg.error.message);
            }
            else
            {
                var responseMsg = (DeepSeekChatResponseMessage)retVal.Item1;
                chatList.Items.Add(responseMsg.choices[0].message);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lbBalance.Text = ((DeepSeekBalance)deepSeekApi.GetBalance().Result.Item1).info.total_balance;
        }
    }
}
