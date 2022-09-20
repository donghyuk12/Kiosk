namespace Admin
{
    public partial class Soldout : Form
    {
        private MENU.Menu[] bugerData = DB.DataBase.GetMenuByType("buger");
        private MENU.Menu[] chickenData = DB.DataBase.GetMenuByType("chicken");
        private MENU.Menu[] setData = DB.DataBase.GetMenuByType("setmenu");
        private MENU.Menu[] sideData = DB.DataBase.GetMenuByType("side");
        private MENU.Menu[] drinkData = DB.DataBase.GetMenuByType("drink");

        public Soldout()
        {
            InitializeComponent();
        }

        private void Soldout_Load(object sender, EventArgs e)
        {
            LogoImage.Load("ImageDB\\Setting\\Logo.png");

            for (int i = 0; i < bugerData.Length; i++)
            {
                bugerListBox.Items.Add(bugerData[i].name);
                if (bugerData[i].isSoldout == 1)
                {
                    bugerListBox.SetItemCheckState(i, CheckState.Checked);
                }
            }
            
            for (int i = 0; i < chickenData.Length; i++)
            {
                chickenListBox.Items.Add(chickenData[i].name);
                if (chickenData[i].isSoldout == 1)
                {
                    chickenListBox.SetItemCheckState(i, CheckState.Checked);
                }
            }

            for (int i = 0; i < setData.Length; i++)
            {
                setListBox.Items.Add(setData[i].name);
                if (setData[i].isSoldout == 1)
                {
                    setListBox.SetItemCheckState(i, CheckState.Checked);
                }
            }

            for (int i = 0; i < sideData.Length; i++)
            {
                sideListBox.Items.Add(sideData[i].name);
                if (sideData[i].isSoldout == 1)
                {
                    sideListBox.SetItemCheckState(i, CheckState.Checked);
                }
            }

            for (int i = 0; i < drinkData.Length; i++)
            {
                drinkListBox.Items.Add(drinkData[i].name);
                if (drinkData[i].isSoldout == 1)
                {
                    drinkListBox.SetItemCheckState(i, CheckState.Checked);
                }
            }
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DB.DataBase.UpdateDB(bugerData);
            DB.DataBase.UpdateDB(chickenData);
            DB.DataBase.UpdateDB(setData);
            DB.DataBase.UpdateDB(sideData);
            DB.DataBase.UpdateDB(drinkData);
            MessageBox.Show("저장되었습니다.", "알림");
            this.Close();
        }

        private void ItemSelected(object sender, EventArgs e)
        {
            CheckedListBox box = (CheckedListBox)sender;
            switch (box.Name)
            {
                case "bugerListBox":
                    if (bugerData[box.SelectedIndex].isSoldout == 0)
                    {
                        bugerData[box.SelectedIndex].isSoldout = 1;
                    }
                    else
                    {
                        bugerData[box.SelectedIndex].isSoldout = 0;
                    }
                    break;
                case "chickenListBox":
                    if (chickenData[box.SelectedIndex].isSoldout == 0)
                    {
                        chickenData[box.SelectedIndex].isSoldout = 1;
                    }
                    else
                    {
                        chickenData[box.SelectedIndex].isSoldout = 0;
                    }
                    break;
                case "setListBox":
                    if (setData[box.SelectedIndex].isSoldout == 0)
                    {
                        setData[box.SelectedIndex].isSoldout = 1;
                    }
                    else
                    {
                        setData[box.SelectedIndex].isSoldout = 0;
                    }
                    break;
                case "sideListBox":
                    if (sideData[box.SelectedIndex].isSoldout == 0)
                    {
                        sideData[box.SelectedIndex].isSoldout = 1;
                    }
                    else
                    {
                        sideData[box.SelectedIndex].isSoldout = 0;
                    }
                    break;
                case "drinkListBox":
                    if (drinkData[box.SelectedIndex].isSoldout == 0)
                    {
                        drinkData[box.SelectedIndex].isSoldout = 1;
                    }
                    else
                    {
                        drinkData[box.SelectedIndex].isSoldout = 0;
                    }
                    break;
            }
        }

        /* 미완성*/
        //private void btnCheckApply_Click(object sender, EventArgs e)
        //{

        //    var strTemp = "";

        //    foreach (var item in bugerListBox.CheckedItems)
        //    {
        //        strTemp += item.ToString() + " ";
        //    }

        //    foreach (var item in setListBox.CheckedItems)
        //    {
        //        strTemp += item.ToString() + " ";
        //    }

        //    foreach (var item in sideListBox.CheckedItems)
        //    {
        //        strTemp += item.ToString() + " ";
        //    }

        //    foreach (var item in chickenListBox.CheckedItems)
        //    {
        //        strTemp += item.ToString() + " ";
        //    }
        //    foreach (var item in drinkListBox.CheckedItems)
        //    {
        //        strTemp += item.ToString() + " ";
        //    }

        //    if (bugerListBox.SelectedIndex == -1 && setListBox.SelectedIndex == -1 && sideListBox.SelectedIndex == -1 && chickenListBox.SelectedIndex == -1 && drinkListBox.SelectedIndex==-1)
        //    {
        //        MessageBox.Show("품절처리 항목이 없습니다.");
        //    }

        //    else
        //    {
        //        MessageBox.Show($"{strTemp}항목이 품절처리 되었습니다.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }

        //    AdminPage main = new AdminPage();
        //    main.Show();
        //    this.Hide();
        //}

        //private void clbMenu1_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        //private void clbMenu4_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //    //SideMenu_Pick.Menu menulist = DataBase.GetMenuByType("Type");
        //    //menulist.Load()
        //}

        //private void btnSoldOut_Load(object sender, EventArgs e)
        //{
        //    //for (int i = 0; i < 24; i++)
        //    //{
        //    //    Admin.Menu burgerMenu = Admin.DataBase.GetMenuByName("buger" + (i + 1).ToString());
        //    //    clbMenu1.Items.Add(burgerMenu.name);
        //    //}

        //    //for (int i = 0; i < 21; i++)
        //    //{
        //    //    Admin.Menu chickenMenu = Admin.DataBase.GetMenuByName("chicken" + (i + 1).ToString());
        //    //    clbMenu2.Items.Add(chickenMenu.name);
        //    //}

        //    //for (int i = 0; i < 23; i++)
        //    //{
        //    //    Admin.Menu sideMenu = Admin.DataBase.GetMenuByName("side" + (i + 1).ToString());
        //    //    clbMenu3.Items.Add(sideMenu.name);
        //    //}


        //    //for (int i = 0; i < 9; i++)
        //    //{
        //    //    Admin.Menu drinkMenu = Admin.DataBase.GetMenuByName("drink" + (i + 1).ToString());
        //    //    clbMenu4.Items.Add(drinkMenu.name);
        //    //}
        //}

        //private void btnSoldOut_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    Application.Exit();
        //}
    }
}
