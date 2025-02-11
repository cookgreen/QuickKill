using DeepSeekAPI;

namespace QuickKill
{
    public partial class frmMain : Form
    {
        private DeepSeekApi deepSeekApi;

        public frmMain(string apikey)
        {
            deepSeekApi = new DeepSeekApi(apikey);
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lbBalance.Text = ((DeepSeekBalance)deepSeekApi.GetBalance().Result.Item1).info.total_balance;
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuToolChat_Click(object sender, EventArgs e)
        {
            frmDeepSeekChat chatWin = new frmDeepSeekChat(deepSeekApi);
            chatWin.ShowDialog();
        }
    }
}
