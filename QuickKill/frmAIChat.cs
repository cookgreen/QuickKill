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
    public partial class frmAIChat : Form
    {
        private System.Timers.Timer timer;
        private IAIApiProvider aiApi;
        private delegate void SetLabelTextDelegate(Label label, string text);
        private SetLabelTextDelegate setLabelTextDelegateObject;

        public frmAIChat(IAIApiProvider aiApi)
        {
            this.aiApi = aiApi;
            InitializeComponent();

            Text = "Chat with AI - [" + aiApi.ProviderName + "]";

            setLabelTextDelegateObject = new SetLabelTextDelegate(SetLabelTextDelegateMethod);

            timer = new System.Timers.Timer(150);
            timer.AutoReset = true;
            timer.Elapsed += (o, e) =>
            {
                var balanceInfo = ((DeepSeekBalance)aiApi
                .GetBalance().Result.Data)
                .balance_infos[0];

                string balance = string.Format("{0} {1}", balanceInfo.total_balance, balanceInfo.currency);

                SetLabelTextDelegateMethod(lbBalance, balance);
            };
            timer.Start();

            getModels();
        }

        private void SetLabelTextDelegateMethod(Label label, string text)
        {
            if (label.InvokeRequired)
            {
                label.Invoke(setLabelTextDelegateObject, label, text);
            }
            else
            {
                label.Text = text;
                lbBalance.Left = Width - 20 - lbBalance.Width;
                lbBalanceText.Left = lbBalance.Left - lbBalance.Width - 15;
            }
        }

        private void frmDeepSeekChat_Load(object sender, EventArgs e)
        {
        }

        private async void getModels()
        {
            var retValue = await aiApi.GetModelList();
            if (retValue.Result)
            {
                DeepSeekModelReturnValue ret = retValue.Data as DeepSeekModelReturnValue;
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

            var retVal = await aiApi.Chat(txtChatMessage.Text, cmbModelList.SelectedItem.ToString());
            if (!retVal.Result)
            {
                var msg = (DeepSeekErrorMessageReturnValue)retVal.Data;
                chatList.Items.Add("Error: " + msg.error.message);
            }
            else
            {
                var responseMsg = (DeepSeekChatResponseMessage)retVal.Data;
                chatList.Items.Add(responseMsg.choices[0].message);
            }
        }

        private void frmDeepSeekChat_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Stop();
        }
    }
}
