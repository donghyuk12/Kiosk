namespace Admin
{
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            Logo_Image.Load("ImageDB\\Setting\\Logo.png");
        }

        private void btn_soldout_Click(object sender, EventArgs e)
        {
            Soldout soldout = new Soldout();
            soldout.StartPosition = FormStartPosition.CenterScreen;
            soldout.Location = new Point(100, 20);
            soldout.ShowDialog();
        }

        private void btn_inspection_Click(object sender, EventArgs e)
        {
            Inspection inspection = new Inspection();
            inspection.StartPosition = FormStartPosition.CenterScreen;
            inspection.Location = new Point(100, 20);
            inspection.ShowDialog();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
