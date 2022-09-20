namespace Message
{
    public partial class MessageForm : Form
    {
  
        public static int odrnumber = 1;
        
        public MessageForm()
        {
            InitializeComponent();
        }

        private void MessageForm_Load(object sender, EventArgs e)
        {
            timetxt.Text = DateTime.Now.ToString();
            receiptlist.Items.Clear();

            foreach (ListViewItem item in Pay.PayForm.orderlist.Items)
            {

                receiptlist.Items.Add((ListViewItem)item.Clone());
            }

            totaltxt.Text = String.Format($"{Pay.PayForm.orderlistprice,0:N0}원");
            barcodebox.Load("ImageDB\\Setting\\barcode.jpg");

            string takeout = "매장";
            if (START.Start.takeOut == true)
                takeout = "포장";

            l_takeout.Text = takeout;
            ordernumber.Text = odrnumber.ToString();            
           
        }
    }
}
