namespace Admin
{
    partial class Soldout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bugerListBox = new System.Windows.Forms.CheckedListBox();
            this.chickenListBox = new System.Windows.Forms.CheckedListBox();
            this.setListBox = new System.Windows.Forms.CheckedListBox();
            this.sideListBox = new System.Windows.Forms.CheckedListBox();
            this.ㅣ_bugger = new System.Windows.Forms.Label();
            this.l_chicken = new System.Windows.Forms.Label();
            this.l_set = new System.Windows.Forms.Label();
            this.l_side = new System.Windows.Forms.Label();
            this.drinkListBox = new System.Windows.Forms.CheckedListBox();
            this.l_drink = new System.Windows.Forms.Label();
            this.LogoImage = new System.Windows.Forms.PictureBox();
            this.btn_return = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // bugerListBox
            // 
            this.bugerListBox.CheckOnClick = true;
            this.bugerListBox.FormattingEnabled = true;
            this.bugerListBox.Location = new System.Drawing.Point(14, 128);
            this.bugerListBox.Name = "bugerListBox";
            this.bugerListBox.Size = new System.Drawing.Size(150, 310);
            this.bugerListBox.TabIndex = 0;
            this.bugerListBox.SelectedIndexChanged += new System.EventHandler(this.ItemSelected);
            // 
            // chickenListBox
            // 
            this.chickenListBox.CheckOnClick = true;
            this.chickenListBox.FormattingEnabled = true;
            this.chickenListBox.Location = new System.Drawing.Point(170, 128);
            this.chickenListBox.Name = "chickenListBox";
            this.chickenListBox.Size = new System.Drawing.Size(150, 310);
            this.chickenListBox.TabIndex = 1;
            this.chickenListBox.SelectedIndexChanged += new System.EventHandler(this.ItemSelected);
            // 
            // setListBox
            // 
            this.setListBox.CheckOnClick = true;
            this.setListBox.FormattingEnabled = true;
            this.setListBox.Location = new System.Drawing.Point(326, 128);
            this.setListBox.Name = "setListBox";
            this.setListBox.Size = new System.Drawing.Size(150, 310);
            this.setListBox.TabIndex = 2;
            this.setListBox.SelectedIndexChanged += new System.EventHandler(this.ItemSelected);
            // 
            // sideListBox
            // 
            this.sideListBox.CheckOnClick = true;
            this.sideListBox.FormattingEnabled = true;
            this.sideListBox.Location = new System.Drawing.Point(482, 128);
            this.sideListBox.Name = "sideListBox";
            this.sideListBox.Size = new System.Drawing.Size(150, 310);
            this.sideListBox.TabIndex = 3;
            this.sideListBox.SelectedIndexChanged += new System.EventHandler(this.ItemSelected);
            // 
            // ㅣ_bugger
            // 
            this.ㅣ_bugger.AutoSize = true;
            this.ㅣ_bugger.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ㅣ_bugger.Location = new System.Drawing.Point(14, 104);
            this.ㅣ_bugger.Name = "ㅣ_bugger";
            this.ㅣ_bugger.Size = new System.Drawing.Size(42, 21);
            this.ㅣ_bugger.TabIndex = 5;
            this.ㅣ_bugger.Text = "버거";
            // 
            // l_chicken
            // 
            this.l_chicken.AutoSize = true;
            this.l_chicken.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_chicken.Location = new System.Drawing.Point(170, 104);
            this.l_chicken.Name = "l_chicken";
            this.l_chicken.Size = new System.Drawing.Size(42, 21);
            this.l_chicken.TabIndex = 6;
            this.l_chicken.Text = "치킨";
            // 
            // l_set
            // 
            this.l_set.AutoSize = true;
            this.l_set.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_set.Location = new System.Drawing.Point(482, 104);
            this.l_set.Name = "l_set";
            this.l_set.Size = new System.Drawing.Size(58, 21);
            this.l_set.TabIndex = 7;
            this.l_set.Text = "사이드";
            // 
            // l_side
            // 
            this.l_side.AutoSize = true;
            this.l_side.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_side.Location = new System.Drawing.Point(326, 104);
            this.l_side.Name = "l_side";
            this.l_side.Size = new System.Drawing.Size(42, 21);
            this.l_side.TabIndex = 8;
            this.l_side.Text = "세트";
            // 
            // drinkListBox
            // 
            this.drinkListBox.CheckOnClick = true;
            this.drinkListBox.FormattingEnabled = true;
            this.drinkListBox.Location = new System.Drawing.Point(638, 128);
            this.drinkListBox.Name = "drinkListBox";
            this.drinkListBox.Size = new System.Drawing.Size(150, 310);
            this.drinkListBox.TabIndex = 9;
            this.drinkListBox.SelectedIndexChanged += new System.EventHandler(this.ItemSelected);
            // 
            // l_drink
            // 
            this.l_drink.AutoSize = true;
            this.l_drink.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_drink.Location = new System.Drawing.Point(638, 104);
            this.l_drink.Name = "l_drink";
            this.l_drink.Size = new System.Drawing.Size(42, 21);
            this.l_drink.TabIndex = 10;
            this.l_drink.Text = "음료";
            // 
            // LogoImage
            // 
            this.LogoImage.Location = new System.Drawing.Point(14, 12);
            this.LogoImage.Name = "LogoImage";
            this.LogoImage.Size = new System.Drawing.Size(200, 75);
            this.LogoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoImage.TabIndex = 11;
            this.LogoImage.TabStop = false;
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(688, 12);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(100, 50);
            this.btn_return.TabIndex = 12;
            this.btn_return.Text = "뒤로가기";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(580, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 50);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Soldout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 491);
            this.ControlBox = false;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.LogoImage);
            this.Controls.Add(this.l_drink);
            this.Controls.Add(this.drinkListBox);
            this.Controls.Add(this.l_side);
            this.Controls.Add(this.l_set);
            this.Controls.Add(this.l_chicken);
            this.Controls.Add(this.ㅣ_bugger);
            this.Controls.Add(this.sideListBox);
            this.Controls.Add(this.setListBox);
            this.Controls.Add(this.chickenListBox);
            this.Controls.Add(this.bugerListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Soldout";
            this.Text = "Soldout";
            this.Load += new System.EventHandler(this.Soldout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckedListBox bugerListBox;
        private CheckedListBox chickenListBox;
        private CheckedListBox setListBox;
        private CheckedListBox sideListBox;
        private Label ㅣ_bugger;
        private Label l_chicken;
        private Label l_set;
        private Label l_side;
        private CheckedListBox drinkListBox;
        private Label l_drink;
        private PictureBox LogoImage;
        private Button btn_return;
        private Button btnSave;
    }
}