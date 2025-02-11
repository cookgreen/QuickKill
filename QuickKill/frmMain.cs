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
    }
}
