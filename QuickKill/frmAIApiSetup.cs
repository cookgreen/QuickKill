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
    public partial class frmAIApiSetup : Form
    {
        private IAIApiProvider aiApi;
        public IAIApiProvider AiApi { get { return aiApi; } }

        public frmAIApiSetup()
        {
            InitializeComponent();
            cmbProviders.SelectedIndex = 0;
        }

        private async void btnOK_Click(object sender, EventArgs e)
        {
            btnOK.Enabled = false;

            if (string.IsNullOrEmpty(txtAPI.Text))
            {
                MessageBox.Show("Please input a valid API key!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnOK.Enabled = true;
                return;
            }

            aiApi = DeepSeekApiFactory.Instance.CreateApiByProvider(
                txtAPI.Text, cmbProviders.SelectedItem.ToString());

            var returnVal = await aiApi.GetBalance();

            btnOK.Enabled = true;

            if (!returnVal.Result)
            {
                MessageBox.Show("Autherized Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
