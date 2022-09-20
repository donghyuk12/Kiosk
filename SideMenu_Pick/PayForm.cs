using System.Text.RegularExpressions;

namespace Pay
{
    public partial class PayForm : Form
    {
        
        public string odrmenu = "";
        public int odrcount = 0;
        public int odrprice = 0;
        public static int orderlistprice = 0;

        public PayForm()
        {
            InitializeComponent();
        }

        private void PayForm_Load(object sender, EventArgs e)
        {
            orderlist.Items.Clear();

            foreach (ListViewItem item in MENUSELECT.MenuSelect_Form.orderView.Items)
            {
                orderlist.Items.Add((ListViewItem)item.Clone());
            }

            int index = orderlist.Items.Count;
            int orderlistcount = 0;


            for (int i = 0; i < index; i++)
            {
                orderlistcount += Convert.ToInt32(orderlist.Items[i].SubItems[1].Text);
                string str = orderlist.Items[i].SubItems[2].Text;
                string str2 = Regex.Replace(str, @"\D", "");
                orderlistprice += int.Parse(str2);
            }
            ordercount.Text = orderlistcount.ToString();
            orderprice.Text = string.Format($"{orderlistprice,0:N0}원");
            
            if (START.Start.takeOut == true)
            {
                burialbtn.FlatStyle = FlatStyle.Standard;
                pavingbtn.FlatStyle = FlatStyle.Flat;
            }
            else
            {
                pavingbtn.FlatStyle = FlatStyle.Standard;
                burialbtn.FlatStyle = FlatStyle.Flat;
            }
            this.ActiveControl = button2;
        }

        private void pavingbtn_Click(object sender, EventArgs e)
        {
            burialbtn.FlatStyle = FlatStyle.Standard;
            pavingbtn.FlatStyle = FlatStyle.Flat;
            START.Start.takeOut = true;
        }

        private void burialbtn_Click(object sender, EventArgs e)
        {
            pavingbtn.FlatStyle = FlatStyle.Standard;
            burialbtn.FlatStyle = FlatStyle.Flat;
            START.Start.takeOut = false;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Point parentPoint = this.Location;
            Card.CardForm frm3 = new Card.CardForm();
            frm3.StartPosition = FormStartPosition.Manual;
            frm3.Location = new Point(parentPoint.X + 50, parentPoint.Y + 50);
            frm3.ShowDialog();
            MENUSELECT.MenuSelect_Form.ispay = true;
            this.Close();
        }
    }
}
