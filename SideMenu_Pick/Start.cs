namespace START
{
    public partial class Start : Form
    {
        public static bool takeOut = false;
        public static int ordercount = 1;
        private int imageCount = 0;
        public Start()
        {
            InitializeComponent();
        }

        private void btn_Pack_Click(object sender, EventArgs e)
        {           
            takeOut = true;
            MENUSELECT.MenuSelect_Form menuSelect_Form = new MENUSELECT.MenuSelect_Form();
            Point parentPoint = this.Location;
            menuSelect_Form.StartPosition = FormStartPosition.Manual;
            menuSelect_Form.Location = new Point(parentPoint.X, parentPoint.Y);
            menuSelect_Form.Show();
            MAIN.Program.start.Hide();

        }

        private void btn_Mart_Click(object sender, EventArgs e)
        {
            takeOut = false;
            MENUSELECT.MenuSelect_Form menuSelect_Form = new MENUSELECT.MenuSelect_Form();
            Point parentPoint = this.Location;
            menuSelect_Form.StartPosition = FormStartPosition.Manual;
            menuSelect_Form.Location = new Point(parentPoint.X, parentPoint.Y);
            menuSelect_Form.Show();
            MAIN.Program.start.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (imageCount)
            {
                case 0:
                    eventImage.Load("ImageDB\\Event_Image\\event1.png");
                    break;
                case 1:
                    eventImage.Load("ImageDB\\Event_Image\\event2.png");
                    break;
                case 2:
                    eventImage.Load("ImageDB\\Event_Image\\event3.png");
                    break;
            }
            imageCount++;
            if (imageCount == 3)
                imageCount = 0;
        }
        private void Start_Load(object sender, EventArgs e)
        {
            eventImage.Load("ImageDB\\Event_Image\\event3.png");
            timer1.Enabled = true;
        
        }
    }
}
