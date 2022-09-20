namespace Card
{
    public partial class CardForm : Form
    {
        private int counter = 5;       
        public CardForm()
        {
            InitializeComponent();
        }
        private void CardForm_Load(object sender, EventArgs e)
        {
            cardimage.Load("ImageDB\\Setting\\card.gif");
            count.Text = counter.ToString();
            counttimer.Interval = 1000;
            counttimer.Enabled = true;                       
        }

        private void counttimer_Tick(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                counttimer.Enabled = false;

                Point parentPoint = this.Location;
                Message.MessageForm messageform = new Message.MessageForm();
                messageform.StartPosition = FormStartPosition.Manual;
                messageform.Location = new Point(parentPoint.X + 50, parentPoint.Y + 50);
                messageform.ShowDialog();               
                this.Close();               
            }
            else
            {
                counter = counter - 1;
                count.Text = counter.ToString();
            }
        }
    }
}
