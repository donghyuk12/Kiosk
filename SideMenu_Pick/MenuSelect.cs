using System.Text.RegularExpressions;

namespace MENUSELECT
{
    public partial class MenuSelect_Form : Form
    {
        public static bool ispay = false;
        private string soldOutImage = "ImageDB\\Setting\\soldout.png";

        public MenuSelect_Form()
        {
            InitializeComponent();
            this.FormClosed += Form_Closing!;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            orderView.Items.Clear();

            PictureBox[] PB_imageBuger = new PictureBox[] { Image_buger1, Image_buger2, Image_buger3, Image_buger4, Image_buger5, Image_buger6, Image_buger7
            , Image_buger8, Image_buger9,Image_buger10,Image_buger11,Image_buger12,Image_buger13,Image_buger14,Image_buger15,Image_buger16,Image_buger17
            ,Image_buger18,Image_buger19,Image_buger20,Image_buger21,Image_buger22,Image_buger23,Image_buger24};
            Label[] LB_nameBuger = new Label[] { Label_buger1, Label_buger2, Label_buger3, Label_buger4, Label_buger5, Label_buger6, Label_buger7
            ,Label_buger8, Label_buger9, Label_buger10,Label_buger11,Label_buger12,Label_buger13,Label_buger14,Label_buger15,Label_buger16,Label_buger17
            ,Label_buger18,Label_buger19,Label_buger20,Label_buger21,Label_buger22,Label_buger23,Label_buger24};
            Label[] LB_priceBuger = new Label[] { Label_bugerPrice1, Label_bugerPrice2, Label_bugerPrice3, Label_bugerPrice4, Label_bugerPrice5,
            Label_bugerPrice6, Label_bugerPrice7,Label_bugerPrice8,Label_bugerPrice9,Label_bugerPrice10,Label_bugerPrice11,Label_bugerPrice12,
            Label_bugerPrice13,Label_bugerPrice14,Label_bugerPrice15,Label_bugerPrice16,Label_bugerPrice17,Label_bugerPrice18,Label_bugerPrice19,
            Label_bugerPrice20,Label_bugerPrice21,Label_bugerPrice22,Label_bugerPrice23,Label_bugerPrice24};

            for (int i = 0; i < 24; i++)
            {
                MENU.Menu menuBuger = DB.DataBase.GetMenuByName("buger" + (i + 1).ToString());
                if (menuBuger.isSoldout == 1)
                {
                    PB_imageBuger[i].Load(soldOutImage);
                    PB_imageBuger[i].Tag = true;
                }
                else
                {
                    PB_imageBuger[i].Load(menuBuger.image);
                    PB_imageBuger[i].Tag = false;
                }
                LB_nameBuger[i].Text = menuBuger.name;
                LB_priceBuger[i].Text = $"\\ {menuBuger.price.ToString()}";
            }

            PictureBox[] PB_imageChicken = new PictureBox[] { Image_chicken1, Image_chicken2, Image_chicken3, Image_chicken4, Image_chicken5, Image_chicken6
            , Image_chicken7, Image_chicken8,Image_chicken9,Image_chicken10,Image_chicken11,Image_chicken12,Image_chicken13,Image_chicken14,Image_chicken15
            ,Image_chicken16,Image_chicken17,Image_chicken18,Image_chicken19,Image_chicken20,Image_chicken21};
            Label[] LB_nameChicken = new Label[] { Label_chicken1, Label_chicken2, Label_chicken3, Label_chicken4, Label_chicken5, Label_chicken6,
            Label_chicken7, Label_chicken8,Label_chicken9,Label_chicken10,Label_chicken11,Label_chicken12,Label_chicken13,Label_chicken14,Label_chicken15
            ,Label_chicken16,Label_chicken17,Label_chicken18,Label_chicken19,Label_chicken20,Label_chicken21};
            Label[] LB_priceChicken = new Label[] { Label_chickenPrice1, Label_chickenPrice2, Label_chickenPrice3, Label_chickenPrice4, Label_chickenPrice5
            , Label_chickenPrice6,Label_chickenPrice7,Label_chickenPrice8,Label_chickenPrice9,Label_chickenPrice10,Label_chickenPrice11,Label_chickenPrice12
            ,Label_chickenPrice13,Label_chickenPrice14,Label_chickenPrice15,Label_chickenPrice16,Label_chickenPrice17,Label_chickenPrice18,
            Label_chickenPrice19,Label_chickenPrice20,Label_chickenPrice21};

            for (int i = 0; i < 21; i++)
            {
                MENU.Menu menuChicken = DB.DataBase.GetMenuByName("Chicken" + (i + 1).ToString());
                if (menuChicken.isSoldout == 1)
                {
                    PB_imageChicken[i].Load(soldOutImage);
                    PB_imageChicken[i].Tag = true;
                }
                else
                {
                    PB_imageChicken[i].Load(menuChicken.image);
                    PB_imageChicken[i].Tag = false;
                }
                LB_nameChicken[i].Text = menuChicken.name;
                LB_priceChicken[i].Text = $"\\ {menuChicken.price.ToString()}";
            }

            PictureBox[] PB_imageSet = new PictureBox[] { Image_set1, Image_set2, Image_set3, Image_set4, Image_set5, Image_set6, Image_set7, Image_set8
            ,Image_set9,Image_set10,Image_set11,Image_set12,Image_set13,Image_set14,Image_set15,Image_set16,Image_set17,Image_set18,Image_set19,Image_set20
            ,Image_set21,Image_set22,Image_set23,Image_set24,Image_set25,Image_set26,Image_set27,Image_set28,Image_set29,Image_set30,Image_set31};
            Label[] LB_nameSet = new Label[] { Label_set1, Label_set2, Label_set3, Label_set4, Label_set5, Label_set6, Label_set7, Label_set8, Label_set9
            ,Label_set10,Label_set11,Label_set12,Label_set13,Label_set14,Label_set15,Label_set16,Label_set17,Label_set18,Label_set19,Label_set20,Label_set21
            ,Label_set22,Label_set23,Label_set24,Label_set25,Label_set26,Label_set27,Label_set28,Label_set29,Label_set30,Label_set31};
            Label[] LB_priceSet = new Label[] { Label_setPrice1, Label_setPrice2, Label_setPrice3, Label_setPrice4, Label_setPrice5, Label_setPrice6
            ,Label_setPrice7,Label_setPrice8,Label_setPrice9,Label_setPrice10,Label_setPrice11,Label_setPrice12,Label_setPrice13,Label_setPrice14,
             Label_setPrice15,Label_setPrice16,Label_setPrice17,Label_setPrice18,Label_setPrice19,Label_setPrice20,Label_setPrice21,Label_setPrice22
            ,Label_setPrice23,Label_setPrice24,Label_setPrice25,Label_setPrice26,Label_setPrice27,Label_setPrice28,Label_setPrice29,
             Label_setPrice30,Label_setPrice31};

            for (int i = 0; i < 31; i++)
            {
                MENU.Menu menuSet = DB.DataBase.GetMenuByName("setmenu" + (i + 1).ToString());
                if (menuSet.isSoldout == 1)
                {
                    PB_imageSet[i].Load(soldOutImage);
                    PB_imageSet[i].Tag = true;
                }
                else
                {
                    PB_imageSet[i].Load(menuSet.image);
                    PB_imageSet[i].Tag = false;
                }
                LB_nameSet[i].Text = menuSet.name;
                LB_priceSet[i].Text = $"\\ {menuSet.price.ToString()}";
            }

            PictureBox[] PB_imageSide = new PictureBox[] { Image_side1, Image_side2, Image_side3, Image_side4, Image_side5, Image_side6, Image_side7,
            Image_side8,Image_side9,Image_side10,Image_side11,Image_side12,Image_side13,Image_side14,Image_side15,Image_side16,Image_side17,Image_side18
            ,Image_side19,Image_side20,Image_side21,Image_side22,Image_side23};
            Label[] LB_nameSide = new Label[] { Label_side1, Label_side2, Label_side3, Label_side4, Label_side5, Label_side6, Label_side7, Label_side8,
            Label_side9,Label_side10,Label_side11,Label_side12,Label_side13,Label_side14,Label_side15,Label_side16,Label_side17,Label_side18,Label_side19
            ,Label_side20,Label_side21,Label_side22,Label_side23};
            Label[] LB_priceSide = new Label[] { Label_sidePrice1, Label_sidePrice2, Label_sidePrice3, Label_sidePrice4, Label_sidePrice5, Label_sidePrice6
            ,Label_sidePrice7,Label_sidePrice8,Label_sidePrice9,Label_sidePrice10,Label_sidePrice11,Label_sidePrice12,Label_sidePrice13,Label_sidePrice14
            ,Label_sidePrice15,Label_sidePrice16,Label_sidePrice17,Label_sidePrice18,Label_sidePrice19,Label_sidePrice20,Label_sidePrice21,Label_sidePrice22
            ,Label_sidePrice23};

            for (int i = 0; i < 23; i++)
            {
                MENU.Menu menuSide = DB.DataBase.GetMenuByName("side" + (i + 1).ToString());
                if (menuSide.isSoldout == 1)
                {
                    PB_imageSide[i].Load(soldOutImage);
                    PB_imageSide[i].Tag = true;
                }
                else
                {
                    PB_imageSide[i].Load(menuSide.image);
                    PB_imageSide[i].Tag = false;
                }
                LB_nameSide[i].Text = menuSide.name;
                LB_priceSide[i].Text = $"\\ {menuSide.price.ToString()}";
            }

            PictureBox[] PB_imageDrink = new PictureBox[] { Image_drink1, Image_drink2, Image_drink3, Image_drink4, Image_drink5, Image_drink6, Image_drink7
            ,Image_drink8,Image_drink9};
            Label[] LB_nameDrink = new Label[] { Label_drink1, Label_drink2, Label_drink3, Label_drink4, Label_drink5, Label_drink6, Label_drink7,
            Label_drink8,Label_drink9};
            Label[] LB_priceDrink = new Label[] { Label_drinkPrice1, Label_drinkPrice2, Label_drinkPrice3, Label_drinkPrice4, Label_drinkPrice5,
            Label_drinkPrice6,Label_drinkPrice7,Label_drinkPrice8,Label_drinkPrice9};

            for (int i = 0; i < 9; i++)
            {
                MENU.Menu menuDrink = DB.DataBase.GetMenuByName("drink" + (i + 1).ToString());
                if (menuDrink.isSoldout == 1)
                {
                    PB_imageDrink[i].Load(soldOutImage);
                    PB_imageDrink[i].Tag = true;
                }
                else
                {
                    PB_imageDrink[i].Load(menuDrink.image);
                    PB_imageDrink[i].Tag = false;
                }
                LB_nameDrink[i].Text = menuDrink.name;
                LB_priceDrink[i].Text = $"\\ {menuDrink.price.ToString()}";
            }
        }

        private void Image_buger1_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "간장마늘싸이버거", 4400);
        }

        private void Image_buger2_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "갈릭바베큐치킨버거", 5600);
        }

        private void Image_buger3_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "딥치즈버거", 4500);
        }

        private void Image_buger4_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "딥치즈싸이버거", 4800);
        }

        private void Image_buger5_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "불고기버거", 3500);
        }

        private void Image_buger6_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "불싸이버거", 4400);
        }

        private void Image_buger7_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "새우불고기버거", 5100);
        }

        private void Image_buger8_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "쉬립프싸이플렉스버거", 6500);
        }

        private void Image_buger9_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "싸이버거", 4300);
        }

        private void Image_buger10_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "싸이플렉스버거", 7200);
        }

        private void Image_buger11_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "양념치킨싸이버거", 4400);
        }

        private void Image_buger12_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "어메이징매콤마요버거", 5600);
        }

        private void Image_buger13_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "언빌리버블버거", 5600);
        }

        private void Image_buger14_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "에그불고기버거", 4300);
        }

        private void Image_buger15_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "인크레더블버거", 5400);
        }

        private void Image_buger16_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "치즈홀릭버거(에멘탈)", 5600);
        }

        private void Image_buger17_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "치즈홀릭버거(체다)", 5600);
        }

        private void Image_buger18_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "텍사스바베큐치킨버거", 5800);
        }

        private void Image_buger19_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "트리플딥치즈싸이버거", 5100);
        }

        private void Image_buger20_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "할라피뇨통살버거", 4400);
        }

        private void Image_buger21_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "햄치즈휠렛버거", 4600);
        }

        private void Image_buger22_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "화이트갈릭버거", 4600);
        }

        private void Image_buger23_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "화이트갈릭싸이버거", 4900);
        }

        private void Image_buger24_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "휠렛버거", 4100);
        }

        private void Image_chicken1_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "간장마늘떡강정", 12000);
        }

        private void Image_chicken2_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "간장마늘싸이순살", 12900);
        }

        private void Image_chicken3_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "간장마늘치킨", 18900);
        }

        private void Image_chicken4_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "군옥수수뿌치", 18900);
        }

        private void Image_chicken5_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "군옥수수뿌치싸이순살", 12900);
        }

        private void Image_chicken6_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "맘스양념싸이순살", 12900);
        }

        private void Image_chicken7_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "맘스양념치킨", 18900);
        }

        private void Image_chicken8_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "반반치킨", 17900);
        }

        private void Image_chicken9_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "치즈뿌치(체다)", 18900);
        }

        private void Image_chicken10_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "치즈뿌치싸이순살(체다)", 12900);
        }

        private void Image_chicken11_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "치즈뿌치텐더", 9500);
        }

        private void Image_chicken12_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "치파오떡강정", 12000);
        }

        private void Image_chicken13_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "치파오싸이순살", 12900);
        }

        private void Image_chicken14_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "케이준떡강정", 11500);
        }

        private void Image_chicken15_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "핫치즈싸이순살", 13500);
        }

        private void Image_chicken16_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "허니버터뿌치", 18900);
        }

        private void Image_chicken17_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "허니뿌치싸이순살", 12900);
        }

        private void Image_chicken18_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "후라이드싸이순살", 10900);
        }

        private void Image_chicken19_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "후라이드치킨", 16900);
        }

        private void Image_chicken20_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "후라이드텐더", 7500);
        }

        private void Image_chicken21_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "후라이드통다리(1조각)", 4500);
        }

        private void Image_set1_Click(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            if (Convert.ToBoolean(box.Tag) == true)
            {
                return;
            }

            Point parentPoint = this.Location;
            SideMenu_Pick.SidePick sidePickForm = new SideMenu_Pick.SidePick("setmenu1");
            sidePickForm.StartPosition = FormStartPosition.Manual;
            sidePickForm.Location = new Point(parentPoint.X + 100, parentPoint.Y + 100);
            sidePickForm.ShowDialog();
            Update_tb_PayPrice();
        }

        private void Image_set2_Click(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            if (Convert.ToBoolean(box.Tag) == true)
            {
                return;
            }

            Point parentPoint = this.Location;
            SideMenu_Pick.SidePick sidePickForm = new SideMenu_Pick.SidePick("setmenu2");
            sidePickForm.StartPosition = FormStartPosition.Manual;
            sidePickForm.Location = new Point(parentPoint.X + 100, parentPoint.Y + 100);
            sidePickForm.ShowDialog();
            Update_tb_PayPrice();

        }

        private void Image_set3_Click(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            if (Convert.ToBoolean(box.Tag) == true)
            {
                return;
            }

            Point parentPoint = this.Location;
            SideMenu_Pick.SidePick sidePickForm = new SideMenu_Pick.SidePick("setmenu3");
            sidePickForm.StartPosition = FormStartPosition.Manual;
            sidePickForm.Location = new Point(parentPoint.X + 100, parentPoint.Y + 100);
            sidePickForm.ShowDialog();
            Update_tb_PayPrice();

        }

        private void Image_set4_Click(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            if (Convert.ToBoolean(box.Tag) == true)
            {
                return;
            }

            Point parentPoint = this.Location;
            SideMenu_Pick.SidePick sidePickForm = new SideMenu_Pick.SidePick("setmenu4");
            sidePickForm.StartPosition = FormStartPosition.Manual;
            sidePickForm.Location = new Point(parentPoint.X + 100, parentPoint.Y + 100);
            sidePickForm.ShowDialog();
            Update_tb_PayPrice();

        }

        private void Image_set5_Click(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            if (Convert.ToBoolean(box.Tag) == true)
            {
                return;
            }

            Point parentPoint = this.Location;
            SideMenu_Pick.SidePick sidePickForm = new SideMenu_Pick.SidePick("setmenu5");
            sidePickForm.StartPosition = FormStartPosition.Manual;
            sidePickForm.Location = new Point(parentPoint.X + 100, parentPoint.Y + 100);
            sidePickForm.ShowDialog();
            Update_tb_PayPrice();
        }

        private void Image_set6_Click(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            if (Convert.ToBoolean(box.Tag) == true)
            {
                return;
            }

            Point parentPoint = this.Location;
            SideMenu_Pick.SidePick sidePickForm = new SideMenu_Pick.SidePick("setmenu6");
            sidePickForm.StartPosition = FormStartPosition.Manual;
            sidePickForm.Location = new Point(parentPoint.X + 100, parentPoint.Y + 100);
            sidePickForm.ShowDialog();
            Update_tb_PayPrice();
        }

        private void Image_set7_Click(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            if (Convert.ToBoolean(box.Tag) == true)
            {
                return;
            }

            Point parentPoint = this.Location;
            SideMenu_Pick.SidePick sidePickForm = new SideMenu_Pick.SidePick("setmenu7");
            sidePickForm.StartPosition = FormStartPosition.Manual;
            sidePickForm.Location = new Point(parentPoint.X + 100, parentPoint.Y + 100);
            sidePickForm.ShowDialog();
            Update_tb_PayPrice();
        }

        private void Image_set8_Click(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            if (Convert.ToBoolean(box.Tag) == true)
            {
                return;
            }

            Point parentPoint = this.Location;
            SideMenu_Pick.SidePick sidePickForm = new SideMenu_Pick.SidePick("setmenu8");
            sidePickForm.StartPosition = FormStartPosition.Manual;
            sidePickForm.Location = new Point(parentPoint.X + 100, parentPoint.Y + 100);
            sidePickForm.ShowDialog();
            Update_tb_PayPrice();
        }

        private void Image_set9_Click(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            if (Convert.ToBoolean(box.Tag) == true)
            {
                return;
            }

            Point parentPoint = this.Location;
            SideMenu_Pick.SidePick sidePickForm = new SideMenu_Pick.SidePick("setmenu9");
            sidePickForm.StartPosition = FormStartPosition.Manual;
            sidePickForm.Location = new Point(parentPoint.X + 100, parentPoint.Y + 100);
            sidePickForm.ShowDialog();
            Update_tb_PayPrice();
        }

        private void Image_set10_Click(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            if (Convert.ToBoolean(box.Tag) == true)
            {
                return;
            }

            Point parentPoint = this.Location;
            SideMenu_Pick.SidePick sidePickForm = new SideMenu_Pick.SidePick("setmenu10");
            sidePickForm.StartPosition = FormStartPosition.Manual;
            sidePickForm.Location = new Point(parentPoint.X + 100, parentPoint.Y + 100);
            sidePickForm.ShowDialog();
            Update_tb_PayPrice();
        }

        private void Image_set11_Click(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            if (Convert.ToBoolean(box.Tag) == true)
            {
                return;
            }

            Point parentPoint = this.Location;
            SideMenu_Pick.SidePick sidePickForm = new SideMenu_Pick.SidePick("setmenu11");
            sidePickForm.StartPosition = FormStartPosition.Manual;
            sidePickForm.Location = new Point(parentPoint.X + 100, parentPoint.Y + 100);
            sidePickForm.ShowDialog();
            Update_tb_PayPrice();
        }

        private void Image_set12_Click(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            if (Convert.ToBoolean(box.Tag) == true)
            {
                return;
            }

            Point parentPoint = this.Location;
            SideMenu_Pick.SidePick sidePickForm = new SideMenu_Pick.SidePick("setmenu12");
            sidePickForm.StartPosition = FormStartPosition.Manual;
            sidePickForm.Location = new Point(parentPoint.X + 100, parentPoint.Y + 100);
            sidePickForm.ShowDialog();
            Update_tb_PayPrice();
        }

        private void Image_set13_Click(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            if (Convert.ToBoolean(box.Tag) == true)
            {
                return;
            }

            Point parentPoint = this.Location;
            SideMenu_Pick.SidePick sidePickForm = new SideMenu_Pick.SidePick("setmenu13");
            sidePickForm.StartPosition = FormStartPosition.Manual;
            sidePickForm.Location = new Point(parentPoint.X + 100, parentPoint.Y + 100);
            sidePickForm.ShowDialog();
            Update_tb_PayPrice();
        }

        private void Image_set14_Click(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            if (Convert.ToBoolean(box.Tag) == true)
            {
                return;
            }

            Point parentPoint = this.Location;
            SideMenu_Pick.SidePick sidePickForm = new SideMenu_Pick.SidePick("setmenu14");
            sidePickForm.StartPosition = FormStartPosition.Manual;
            sidePickForm.Location = new Point(parentPoint.X + 100, parentPoint.Y + 100);
            sidePickForm.ShowDialog();
            Update_tb_PayPrice();
        }

        private void Image_set15_Click(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            if (Convert.ToBoolean(box.Tag) == true)
            {
                return;
            }

            Point parentPoint = this.Location;
            SideMenu_Pick.SidePick sidePickForm = new SideMenu_Pick.SidePick("setmenu15");
            sidePickForm.StartPosition = FormStartPosition.Manual;
            sidePickForm.Location = new Point(parentPoint.X + 100, parentPoint.Y + 100);
            sidePickForm.ShowDialog();
            Update_tb_PayPrice();
        }

        private void Image_set16_Click(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            if (Convert.ToBoolean(box.Tag) == true)
            {
                return;
            }

            Point parentPoint = this.Location;
            SideMenu_Pick.SidePick sidePickForm = new SideMenu_Pick.SidePick("setmenu16");
            sidePickForm.StartPosition = FormStartPosition.Manual;
            sidePickForm.Location = new Point(parentPoint.X + 100, parentPoint.Y + 100);
            sidePickForm.ShowDialog();
            Update_tb_PayPrice();
        }

        private void Image_set17_Click(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            if (Convert.ToBoolean(box.Tag) == true)
            {
                return;
            }

            Point parentPoint = this.Location;
            SideMenu_Pick.SidePick sidePickForm = new SideMenu_Pick.SidePick("setmenu17");
            sidePickForm.StartPosition = FormStartPosition.Manual;
            sidePickForm.Location = new Point(parentPoint.X + 100, parentPoint.Y + 100);
            sidePickForm.ShowDialog();
            Update_tb_PayPrice();
        }

        private void Image_set18_Click(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            if (Convert.ToBoolean(box.Tag) == true)
            {
                return;
            }

            Point parentPoint = this.Location;
            SideMenu_Pick.SidePick sidePickForm = new SideMenu_Pick.SidePick("setmenu18");
            sidePickForm.StartPosition = FormStartPosition.Manual;
            sidePickForm.Location = new Point(parentPoint.X + 100, parentPoint.Y + 100);
            sidePickForm.ShowDialog();
            Update_tb_PayPrice();
        }

        private void Image_set19_Click(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            if (Convert.ToBoolean(box.Tag) == true)
            {
                return;
            }

            Point parentPoint = this.Location;
            SideMenu_Pick.SidePick sidePickForm = new SideMenu_Pick.SidePick("setmenu19");
            sidePickForm.StartPosition = FormStartPosition.Manual;
            sidePickForm.Location = new Point(parentPoint.X + 100, parentPoint.Y + 100);
            sidePickForm.ShowDialog();
            Update_tb_PayPrice();
        }

        private void Image_set20_Click(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            if (Convert.ToBoolean(box.Tag) == true)
            {
                return;
            }

            Point parentPoint = this.Location;
            SideMenu_Pick.SidePick sidePickForm = new SideMenu_Pick.SidePick("setmenu20");
            sidePickForm.StartPosition = FormStartPosition.Manual;
            sidePickForm.Location = new Point(parentPoint.X + 100, parentPoint.Y + 100);
            sidePickForm.ShowDialog();
            Update_tb_PayPrice();
        }

        private void Image_set21_Click(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            if (Convert.ToBoolean(box.Tag) == true)
            {
                return;
            }

            Point parentPoint = this.Location;
            SideMenu_Pick.SidePick sidePickForm = new SideMenu_Pick.SidePick("setmenu21");
            sidePickForm.StartPosition = FormStartPosition.Manual;
            sidePickForm.Location = new Point(parentPoint.X + 100, parentPoint.Y + 100);
            sidePickForm.ShowDialog();
            Update_tb_PayPrice();
        }

        private void Image_set22_Click(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            if (Convert.ToBoolean(box.Tag) == true)
            {
                return;
            }

            Point parentPoint = this.Location;
            SideMenu_Pick.SidePick sidePickForm = new SideMenu_Pick.SidePick("setmenu22");
            sidePickForm.StartPosition = FormStartPosition.Manual;
            sidePickForm.Location = new Point(parentPoint.X + 100, parentPoint.Y + 100);
            sidePickForm.ShowDialog();
            Update_tb_PayPrice();
        }

        private void Image_set23_Click(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            if (Convert.ToBoolean(box.Tag) == true)
            {
                return;
            }

            Point parentPoint = this.Location;
            SideMenu_Pick.SidePick sidePickForm = new SideMenu_Pick.SidePick("setmenu23");
            sidePickForm.StartPosition = FormStartPosition.Manual;
            sidePickForm.Location = new Point(parentPoint.X + 100, parentPoint.Y + 100);
            sidePickForm.ShowDialog();
            Update_tb_PayPrice();
        }

        private void Image_set24_Click(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            if (Convert.ToBoolean(box.Tag) == true)
            {
                return;
            }

            Point parentPoint = this.Location;
            SideMenu_Pick.SidePick sidePickForm = new SideMenu_Pick.SidePick("setmenu24");
            sidePickForm.StartPosition = FormStartPosition.Manual;
            sidePickForm.Location = new Point(parentPoint.X + 100, parentPoint.Y + 100);
            sidePickForm.ShowDialog();
            Update_tb_PayPrice();
        }

        private void Image_set25_Click(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            if (Convert.ToBoolean(box.Tag) == true)
            {
                return;
            }

            Point parentPoint = this.Location;
            SideMenu_Pick.SidePick sidePickForm = new SideMenu_Pick.SidePick("setmenu25");
            sidePickForm.StartPosition = FormStartPosition.Manual;
            sidePickForm.Location = new Point(parentPoint.X + 100, parentPoint.Y + 100);
            sidePickForm.ShowDialog();
            Update_tb_PayPrice();
        }

        private void Image_set26_Click(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            if (Convert.ToBoolean(box.Tag) == true)
            {
                return;
            }

            Point parentPoint = this.Location;
            SideMenu_Pick.SidePick sidePickForm = new SideMenu_Pick.SidePick("setmenu26");
            sidePickForm.StartPosition = FormStartPosition.Manual;
            sidePickForm.Location = new Point(parentPoint.X + 100, parentPoint.Y + 100);
            sidePickForm.ShowDialog();
            Update_tb_PayPrice();
        }

        private void Image_set27_Click(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            if (Convert.ToBoolean(box.Tag) == true)
            {
                return;
            }

            Point parentPoint = this.Location;
            SideMenu_Pick.SidePick sidePickForm = new SideMenu_Pick.SidePick("setmenu27");
            sidePickForm.StartPosition = FormStartPosition.Manual;
            sidePickForm.Location = new Point(parentPoint.X + 100, parentPoint.Y + 100);
            sidePickForm.ShowDialog();
            Update_tb_PayPrice();
        }

        private void Image_set28_Click(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            if (Convert.ToBoolean(box.Tag) == true)
            {
                return;
            }

            Point parentPoint = this.Location;
            SideMenu_Pick.SidePick sidePickForm = new SideMenu_Pick.SidePick("setmenu28");
            sidePickForm.StartPosition = FormStartPosition.Manual;
            sidePickForm.Location = new Point(parentPoint.X + 100, parentPoint.Y + 100);
            sidePickForm.ShowDialog();
            Update_tb_PayPrice();
        }

        private void Image_set29_Click(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            if (Convert.ToBoolean(box.Tag) == true)
            {
                return;
            }

            Point parentPoint = this.Location;
            SideMenu_Pick.SidePick sidePickForm = new SideMenu_Pick.SidePick("setmenu29");
            sidePickForm.StartPosition = FormStartPosition.Manual;
            sidePickForm.Location = new Point(parentPoint.X + 100, parentPoint.Y + 100);
            sidePickForm.ShowDialog();
            Update_tb_PayPrice();
        }

        private void Image_set30_Click(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            if (Convert.ToBoolean(box.Tag) == true)
            {
                return;
            }

            Point parentPoint = this.Location;
            SideMenu_Pick.SidePick sidePickForm = new SideMenu_Pick.SidePick("setmenu30");
            sidePickForm.StartPosition = FormStartPosition.Manual;
            sidePickForm.Location = new Point(parentPoint.X + 100, parentPoint.Y + 100);
            sidePickForm.ShowDialog();
            Update_tb_PayPrice();
        }

        private void Image_set31_Click(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            if (Convert.ToBoolean(box.Tag) == true)
            {
                return;
            }

            Point parentPoint = this.Location;
            SideMenu_Pick.SidePick sidePickForm = new SideMenu_Pick.SidePick("setmenu31");
            sidePickForm.StartPosition = FormStartPosition.Manual;
            sidePickForm.Location = new Point(parentPoint.X + 100, parentPoint.Y + 100);
            sidePickForm.ShowDialog();
            Update_tb_PayPrice();
        }

        private void Image_side1_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "갈릭김떡만", 3500);
        }

        private void Image_side2_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "고구마치즈팝콘볼", 4000);
        }

        private void Image_side3_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "공룡치킨", 3200);
        }

        private void Image_side4_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "달콤초코볼", 4000);
        }

        private void Image_side5_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "달콤카라멜볼", 4000);
        }

        private void Image_side6_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "도깨비치즈볼", 4000);
        }

        private void Image_side7_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "랜치소스", 1000);
        }

        private void Image_side8_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "맘스스낵볼세트", 4200);
        }

        private void Image_side9_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "맘스양념소스", 1000);
        }

        private void Image_side10_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "매콤김떡만", 3500);
        }

        private void Image_side11_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "바삭크림치즈볼", 4000);
        }

        private void Image_side12_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "베이컨에그랩", 4500);
        }

        private void Image_side13_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "어니언치즈감자", 3200);
        }

        private void Image_side14_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "에그랩", 4000);
        }

        private void Image_side15_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "치즈감자", 2800);
        }

        private void Image_side16_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "치즈스틱(2조각)", 2000);
        }

        private void Image_side17_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "치킨무", 500);
        }

        private void Image_side18_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "케이준양념감자", 3500);
        }

        private void Image_side19_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "코울슬로", 1800);
        }

        private void Image_side20_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "콘샐러드", 1800);
        }

        private void Image_side21_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "팝콘볼", 3500);
        }

        private void Image_side22_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "할라피뇨너겟", 4500);
        }

        private void Image_side23_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "휠랩", 4000);
        }

        private void Image_drink1_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "레몬에이드", 2200);
        }

        private void Image_drink2_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "마운틴듀", 1600);
        }

        private void Image_drink3_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "미린다", 1600);
        }

        private void Image_drink4_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "사이다", 1600);
        }

        private void Image_drink5_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "아메리카노(HOT)", 1500);
        }

        private void Image_drink6_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "아메리카노(ICE)", 2000);
        }

        private void Image_drink7_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "오렌지주스", 2000);
        }

        private void Image_drink8_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "청포도에이드", 2200);
        }

        private void Image_drink9_Click(object sender, EventArgs e)
        {
            SetListviewData(sender, "콜라", 1600);
        }

        private void SetListviewData(object sender, string menuName, int price)
        {
            PictureBox box = (PictureBox)sender;
            if (Convert.ToBoolean(box.Tag) == true)
            {
                return;
            }

            int numOfItem = orderView.Items.Count;

            for (int i = 0; i < numOfItem; i++)
            {
                if (orderView.Items[i].SubItems[0].Text == menuName)
                {
                    int quantity = Convert.ToInt32(orderView.Items[i].SubItems[1].Text);
                    orderView.Items[i].SubItems[1].Text = (++quantity).ToString();
                    orderView.Items[i].SubItems[2].Text = String.Format($"{quantity * price}원");
                    Update_tb_PayPrice();
                    return;
                }
            }
            string[] data = { menuName, "1", String.Format($"{price}원") };
            ListViewItem item = new ListViewItem(data);
            orderView.Items.Add(item);
            Update_tb_PayPrice();
            return;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            MAIN.Program.start.Show();
            this.Close();
        }

        private void Form_Closing(object sender, FormClosedEventArgs e)
        {
            Message.MessageForm.odrnumber++;
            MAIN.Program.start.Show();
        }

        private void btn_Pay_Click(object sender, EventArgs e)
        {
            if (orderView.Items.Count == 0)
                return;
            
            Point parentPoint = this.Location;
            Pay.PayForm payform = new Pay.PayForm();
            payform.StartPosition = FormStartPosition.Manual;
            payform.Location = new Point(parentPoint.X + 120, parentPoint.Y + 150);
            payform.ShowDialog();
            if (ispay == true)
            {
                ispay = false;
                this.Close();
            }
        }

        private void momsLogoImage_DoubleClick(object sender, EventArgs e)
        {
            Point parentPoint = this.Location;
            Admin.AdminPage admin = new Admin.AdminPage();
            admin.StartPosition = FormStartPosition.Manual;
            admin.Location = new Point(parentPoint.X + 100, parentPoint.Y + 100);
            admin.ShowDialog();
            Form1_Load(sender, e);
        }

        private void Update_tb_PayPrice()
        {
            int index = orderView.Items.Count;
            int totalPrice = 0;
            string pricestr = "";

            for (int i = 0; i < index; i++)
            {
                pricestr = orderView.Items[i].SubItems[2].Text;
                totalPrice += int.Parse(Regex.Replace(pricestr, @"\D", ""));
            }
            tb_PayPrice.Text = String.Format($"{totalPrice}원");
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            if (0 == orderView.SelectedItems.Count)
                return;
            else
            {
                int quantity = Convert.ToInt32(orderView.SelectedItems[0].SubItems[1].Text);
                string pricestr = orderView.SelectedItems[0].SubItems[2].Text;
                int price = int.Parse(Regex.Replace(pricestr, @"\D", "")) / quantity;
                orderView.SelectedItems[0].SubItems[1].Text = (++quantity).ToString();
                orderView.SelectedItems[0].SubItems[2].Text = String.Format($"{quantity * price}원");
            }
            Update_tb_PayPrice();
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            if (0 == orderView.SelectedItems.Count)
                return;
            else
            {
                int quantity = Convert.ToInt32(orderView.SelectedItems[0].SubItems[1].Text);
                string pricestr = orderView.SelectedItems[0].SubItems[2].Text;
                int price = int.Parse(Regex.Replace(pricestr, @"\D", "")) / quantity;
                if (1 == quantity)
                {
                    orderView.SelectedItems[0].Remove();
                    Update_tb_PayPrice();
                    return;
                }
                orderView.SelectedItems[0].SubItems[1].Text = (--quantity).ToString();
                orderView.SelectedItems[0].SubItems[2].Text = String.Format($"{quantity * price}원");
            }
            Update_tb_PayPrice();
        }
    }
}
