namespace SideMenu_Pick
{
    public partial class SidePick : Form
    {
        PictureBox? picbox;
        Label? label;
     
        public string ordermenu = "";
        public int count = 1;
        public string sidemenu = "";
        public string drinkmenu = "";
        public int baseprice = 0;
        public int sideprice = 0;
        public int drinkprice = 0;
        public int totalprice = 0;
        private string menuname = "";

        public SidePick(string data)
        {
            InitializeComponent();
            menuname = data;
        }

        private void SetTotalPriceLabel()
        {
            totalprice = baseprice + sideprice + drinkprice;
            l_price.Text = String.Format($"{totalprice,0:N0}¿ø");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MENU.Menu menu = DB.DataBase.GetMenuByName(menuname);

            this.menuname = menu.name;
            this.baseprice = menu.price;

            checkimage1.Load("ImageDB\\Setting\\check.png");
            checkimage2.Load("ImageDB\\Setting\\check.png");

            MENU.Menu[] sidemenu = DB.DataBase.GetPickSide();
            for (int i = 0; i < 4; i++)
            {
                picbox = new PictureBox();
                picbox.Load($"{sidemenu[i].image}");
                picbox.Name = sidemenu[i].name;
                picbox.Tag = sidemenu[i].price;
                picbox.Size = new Size(90, 80);
                picbox.SizeMode = PictureBoxSizeMode.StretchImage;
                picbox.Click += new_side_click!;
                sideImageLayout.Controls.Add(picbox);
                if (i == 0)
                    new_side_click(picbox, e);

                label = new Label();
                label.Text = sidemenu[i].name;
                label.Font = new Font(label.Font.Name, 7);
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Size = new Size(90, 10);
                sideNameLayout.Controls.Add(label);

                label = new Label();
                label.Text = sidemenu[i].price.ToString();
                label.Font = new Font(label.Font.Name, 7);
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Size = new Size(90, 10);
                sidePriceLayout.Controls.Add(label);
            }

            MENU.Menu[] drinkmenu = DB.DataBase.GetPickDrink();
            for (int i = 0; i < 5; i++)
            {
                picbox = new PictureBox();
                picbox.Load($"{drinkmenu[i].image}");
                picbox.Name = drinkmenu[i].name;
                picbox.Tag = drinkmenu[i].price;
                picbox.Size = new Size(90, 80);
                picbox.SizeMode = PictureBoxSizeMode.StretchImage;
                picbox.Click += new_drink_click!;
                drinkImageLayout1.Controls.Add(picbox);
                if (i == 0)
                    new_drink_click(picbox, e);

                label = new Label();
                label.Text = drinkmenu[i].name;
                label.Font = new Font(label.Font.Name, 7);
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Size = new Size(90, 10);
                drinkNameLayout1.Controls.Add(label);

                label = new Label();
                label.Text = drinkmenu[i].price.ToString();
                label.Font = new Font(label.Font.Name, 7);
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Size = new Size(90, 10);
                drinkPriceLayout1.Controls.Add(label);
            }

            for (int i = 5; i < 9; i++)
            {
                picbox = new PictureBox();
                picbox.Load($"{drinkmenu[i].image}");
                picbox.Name = drinkmenu[i].name;
                picbox.Tag = drinkmenu[i].price;
                picbox.Size = new Size(90, 80);
                picbox.SizeMode = PictureBoxSizeMode.StretchImage;
                picbox.Click += new_drink_click!;
                drinkImageLayout2.Controls.Add(picbox);

                label = new Label();
                label.Text = drinkmenu[i].name;
                label.Font = new Font(label.Font.Name, 7);
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Size = new Size(90, 10);
                drinkNameLayout2.Controls.Add(label);

                label = new Label();
                label.Text = drinkmenu[i].price.ToString();
                label.Font = new Font(label.Font.Name, 7);
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Size = new Size(90, 10);
                drinkPriceLayout2.Controls.Add(label);
            }

            menuImage.Load(menu.image);
            l_name.Text = menu.name;
            SetTotalPriceLabel();
        }
        
        private void btn_plus_Click(object sender, EventArgs e)
        {
            tb_quantity.Text = (++count).ToString();
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            if (count <= 1)
            {
                return;
            }
            else
            {
                tb_quantity.Text = (--count).ToString();
            }
        }

        private void new_side_click(object sender, EventArgs e)
        {
            PictureBox picture = (PictureBox)sender;
            checkimage1.Parent = picture;
            checkimage1.BackColor = Color.Transparent;
            checkimage1.Location = new Point(0, 0);
            this.sidemenu = picture.Name;
            this.sideprice = Convert.ToInt32(picture.Tag);
            SetTotalPriceLabel();
        }

        private void new_drink_click(object sender, EventArgs e)
        {
            PictureBox picture = (PictureBox)sender;
            checkimage2.Parent = picture;
            checkimage2.BackColor = Color.Transparent;
            checkimage2.Location = new Point(0, 0);
            this.drinkmenu = picture.Name;
            this.drinkprice = Convert.ToInt32(picture.Tag);
            SetTotalPriceLabel();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.ordermenu = string.Format($"{this.menuname}+{this.sidemenu}+{this.drinkmenu}");
            string Price = string.Format($"{this.totalprice * this.count,0:N0}¿ø");
            string[] orderlist = new string[] { this.ordermenu, this.count.ToString(), Price };
            ListViewItem OrderlistItem = new ListViewItem(orderlist);
            MENUSELECT.MenuSelect_Form.orderView.Items.Add(OrderlistItem);
            this.Close();
        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}