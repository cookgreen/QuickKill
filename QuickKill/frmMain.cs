using DeepSeekAPI;
using System.ComponentModel;
using System.Timers;

namespace QuickKill
{
    public partial class frmMain : Form
    {
        private System.Timers.Timer timer;
        private IAIApiProvider aIApiProvider;
        private delegate void SetLabelTextDelegate(Label label, string text);
        private SetLabelTextDelegate setLabelTextDelegateObject;

        public frmMain(IAIApiProvider aIApiProvider)
        {
            this.aIApiProvider = aIApiProvider;
            InitializeComponent();

            setLabelTextDelegateObject = new SetLabelTextDelegate(SetLabelTextDelegateMethod);

            timer = new System.Timers.Timer(150);
            timer.AutoReset = true;
            timer.Elapsed += (o, e) =>
            {
                var balanceInfo = ((DeepSeekBalance)aIApiProvider
                .GetBalance().Result.Data)
                .balance_infos[0];

                string balance = string.Format("{0} {1}", balanceInfo.total_balance, balanceInfo.currency);

                SetLabelTextDelegateMethod(lbBalance, balance);
            };
            timer.Start();
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

        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        private void Worker_DoWork(object? sender, DoWorkEventArgs e)
        {
            while (true)
            {
            }
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuToolChat_Click(object sender, EventArgs e)
        {
            frmDeepSeekChat chatWin = new frmDeepSeekChat(aIApiProvider);
            chatWin.ShowDialog();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Stop();
        }
    }
}
