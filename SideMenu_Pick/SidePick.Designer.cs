namespace SideMenu_Pick
{
    partial class SidePick
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_quantity = new System.Windows.Forms.TextBox();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.menuImage = new System.Windows.Forms.PictureBox();
            this.l_side1 = new System.Windows.Forms.Label();
            this.l_side2 = new System.Windows.Forms.Label();
            this.l_price = new System.Windows.Forms.Label();
            this.l_name = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.checkimage1 = new System.Windows.Forms.PictureBox();
            this.sideImageLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.sideNameLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.sidePriceLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.drinkNameLayout1 = new System.Windows.Forms.FlowLayoutPanel();
            this.drinkPriceLayout1 = new System.Windows.Forms.FlowLayoutPanel();
            this.drinkImageLayout1 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkimage2 = new System.Windows.Forms.PictureBox();
            this.drinkNameLayout2 = new System.Windows.Forms.FlowLayoutPanel();
            this.drinkPriceLayout2 = new System.Windows.Forms.FlowLayoutPanel();
            this.drinkImageLayout2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_cancle = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.menuImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkimage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkimage2)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_quantity
            // 
            this.tb_quantity.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_quantity.Location = new System.Drawing.Point(240, 150);
            this.tb_quantity.Name = "tb_quantity";
            this.tb_quantity.ReadOnly = true;
            this.tb_quantity.Size = new System.Drawing.Size(50, 29);
            this.tb_quantity.TabIndex = 0;
            this.tb_quantity.Text = "1";
            this.tb_quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_minus
            // 
            this.btn_minus.Location = new System.Drawing.Point(205, 150);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(30, 30);
            this.btn_minus.TabIndex = 1;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // btn_plus
            // 
            this.btn_plus.Location = new System.Drawing.Point(295, 150);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(30, 30);
            this.btn_plus.TabIndex = 2;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // menuImage
            // 
            this.menuImage.Location = new System.Drawing.Point(13, 13);
            this.menuImage.Name = "menuImage";
            this.menuImage.Size = new System.Drawing.Size(175, 175);
            this.menuImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuImage.TabIndex = 3;
            this.menuImage.TabStop = false;
            // 
            // l_side1
            // 
            this.l_side1.AutoSize = true;
            this.l_side1.BackColor = System.Drawing.Color.Transparent;
            this.l_side1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_side1.Location = new System.Drawing.Point(20, 200);
            this.l_side1.Name = "l_side1";
            this.l_side1.Size = new System.Drawing.Size(20, 25);
            this.l_side1.TabIndex = 4;
            this.l_side1.Text = "-";
            // 
            // l_side2
            // 
            this.l_side2.AutoSize = true;
            this.l_side2.BackColor = System.Drawing.Color.White;
            this.l_side2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_side2.Location = new System.Drawing.Point(20, 345);
            this.l_side2.Name = "l_side2";
            this.l_side2.Size = new System.Drawing.Size(20, 25);
            this.l_side2.TabIndex = 5;
            this.l_side2.Text = "-";
            // 
            // l_price
            // 
            this.l_price.AutoSize = true;
            this.l_price.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l_price.ForeColor = System.Drawing.Color.Tomato;
            this.l_price.Location = new System.Drawing.Point(205, 66);
            this.l_price.Name = "l_price";
            this.l_price.Size = new System.Drawing.Size(60, 22);
            this.l_price.TabIndex = 7;
            this.l_price.Text = "price";
            // 
            // l_name
            // 
            this.l_name.AutoSize = true;
            this.l_name.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l_name.ForeColor = System.Drawing.Color.Tomato;
            this.l_name.Location = new System.Drawing.Point(205, 13);
            this.l_name.Name = "l_name";
            this.l_name.Size = new System.Drawing.Size(159, 34);
            this.l_name.TabIndex = 9;
            this.l_name.Text = "menu name";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LightPink;
            this.pictureBox2.Location = new System.Drawing.Point(0, 200);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(634, 25);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.LightPink;
            this.pictureBox3.Location = new System.Drawing.Point(0, 345);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(634, 25);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // checkimage1
            // 
            this.checkimage1.BackColor = System.Drawing.Color.Transparent;
            this.checkimage1.Location = new System.Drawing.Point(454, 13);
            this.checkimage1.Name = "checkimage1";
            this.checkimage1.Size = new System.Drawing.Size(75, 75);
            this.checkimage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.checkimage1.TabIndex = 26;
            this.checkimage1.TabStop = false;
            // 
            // sideImageLayout
            // 
            this.sideImageLayout.Location = new System.Drawing.Point(20, 228);
            this.sideImageLayout.Margin = new System.Windows.Forms.Padding(1);
            this.sideImageLayout.Name = "sideImageLayout";
            this.sideImageLayout.Size = new System.Drawing.Size(590, 90);
            this.sideImageLayout.TabIndex = 27;
            // 
            // sideNameLayout
            // 
            this.sideNameLayout.Location = new System.Drawing.Point(20, 320);
            this.sideNameLayout.Margin = new System.Windows.Forms.Padding(1);
            this.sideNameLayout.Name = "sideNameLayout";
            this.sideNameLayout.Size = new System.Drawing.Size(590, 10);
            this.sideNameLayout.TabIndex = 28;
            // 
            // sidePriceLayout
            // 
            this.sidePriceLayout.Location = new System.Drawing.Point(20, 332);
            this.sidePriceLayout.Margin = new System.Windows.Forms.Padding(1);
            this.sidePriceLayout.Name = "sidePriceLayout";
            this.sidePriceLayout.Size = new System.Drawing.Size(590, 10);
            this.sidePriceLayout.TabIndex = 29;
            // 
            // drinkNameLayout1
            // 
            this.drinkNameLayout1.Location = new System.Drawing.Point(20, 466);
            this.drinkNameLayout1.Margin = new System.Windows.Forms.Padding(1);
            this.drinkNameLayout1.Name = "drinkNameLayout1";
            this.drinkNameLayout1.Size = new System.Drawing.Size(590, 10);
            this.drinkNameLayout1.TabIndex = 31;
            // 
            // drinkPriceLayout1
            // 
            this.drinkPriceLayout1.Location = new System.Drawing.Point(20, 478);
            this.drinkPriceLayout1.Margin = new System.Windows.Forms.Padding(1);
            this.drinkPriceLayout1.Name = "drinkPriceLayout1";
            this.drinkPriceLayout1.Size = new System.Drawing.Size(590, 10);
            this.drinkPriceLayout1.TabIndex = 32;
            // 
            // drinkImageLayout1
            // 
            this.drinkImageLayout1.Location = new System.Drawing.Point(20, 374);
            this.drinkImageLayout1.Margin = new System.Windows.Forms.Padding(1);
            this.drinkImageLayout1.Name = "drinkImageLayout1";
            this.drinkImageLayout1.Size = new System.Drawing.Size(590, 90);
            this.drinkImageLayout1.TabIndex = 30;
            // 
            // checkimage2
            // 
            this.checkimage2.Location = new System.Drawing.Point(535, 13);
            this.checkimage2.Name = "checkimage2";
            this.checkimage2.Size = new System.Drawing.Size(75, 75);
            this.checkimage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.checkimage2.TabIndex = 36;
            this.checkimage2.TabStop = false;
            // 
            // drinkNameLayout2
            // 
            this.drinkNameLayout2.Location = new System.Drawing.Point(20, 582);
            this.drinkNameLayout2.Margin = new System.Windows.Forms.Padding(1);
            this.drinkNameLayout2.Name = "drinkNameLayout2";
            this.drinkNameLayout2.Size = new System.Drawing.Size(590, 10);
            this.drinkNameLayout2.TabIndex = 34;
            // 
            // drinkPriceLayout2
            // 
            this.drinkPriceLayout2.Location = new System.Drawing.Point(20, 594);
            this.drinkPriceLayout2.Margin = new System.Windows.Forms.Padding(1);
            this.drinkPriceLayout2.Name = "drinkPriceLayout2";
            this.drinkPriceLayout2.Size = new System.Drawing.Size(590, 10);
            this.drinkPriceLayout2.TabIndex = 35;
            // 
            // drinkImageLayout2
            // 
            this.drinkImageLayout2.Location = new System.Drawing.Point(20, 490);
            this.drinkImageLayout2.Margin = new System.Windows.Forms.Padding(1);
            this.drinkImageLayout2.Name = "drinkImageLayout2";
            this.drinkImageLayout2.Size = new System.Drawing.Size(590, 90);
            this.drinkImageLayout2.TabIndex = 33;
            // 
            // btn_cancle
            // 
            this.btn_cancle.BackColor = System.Drawing.Color.Silver;
            this.btn_cancle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancle.Location = new System.Drawing.Point(20, 619);
            this.btn_cancle.Name = "btn_cancle";
            this.btn_cancle.Size = new System.Drawing.Size(150, 100);
            this.btn_cancle.TabIndex = 37;
            this.btn_cancle.Text = "취소";
            this.btn_cancle.UseVisualStyleBackColor = false;
            this.btn_cancle.Click += new System.EventHandler(this.btn_cancle_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.BackColor = System.Drawing.Color.Tomato;
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_OK.Location = new System.Drawing.Point(460, 619);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(150, 100);
            this.btn_OK.TabIndex = 38;
            this.btn_OK.Text = "확인";
            this.btn_OK.UseVisualStyleBackColor = false;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // SidePick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(634, 761);
            this.ControlBox = false;
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.btn_cancle);
            this.Controls.Add(this.checkimage1);
            this.Controls.Add(this.checkimage2);
            this.Controls.Add(this.drinkNameLayout2);
            this.Controls.Add(this.drinkPriceLayout2);
            this.Controls.Add(this.drinkImageLayout2);
            this.Controls.Add(this.drinkNameLayout1);
            this.Controls.Add(this.drinkPriceLayout1);
            this.Controls.Add(this.drinkImageLayout1);
            this.Controls.Add(this.sideNameLayout);
            this.Controls.Add(this.sidePriceLayout);
            this.Controls.Add(this.sideImageLayout);
            this.Controls.Add(this.l_name);
            this.Controls.Add(this.l_price);
            this.Controls.Add(this.l_side2);
            this.Controls.Add(this.l_side1);
            this.Controls.Add(this.menuImage);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.tb_quantity);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SidePick";
            this.Text = "Mom\'s Touch";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menuImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkimage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkimage2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb_quantity;
        private Button btn_minus;
        private Button btn_plus;
        private PictureBox menuImage;
        private Label l_side1;
        private Label l_side2;
        private Label l_price;
        private Label l_name;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox checkimage1;
        private FlowLayoutPanel sideImageLayout;
        private FlowLayoutPanel sideNameLayout;
        private FlowLayoutPanel sidePriceLayout;
        private FlowLayoutPanel drinkNameLayout1;
        private FlowLayoutPanel drinkPriceLayout1;
        private FlowLayoutPanel drinkImageLayout1;
        private FlowLayoutPanel drinkNameLayout2;
        private FlowLayoutPanel drinkPriceLayout2;
        private FlowLayoutPanel drinkImageLayout2;
        private PictureBox checkimage2;
        private Button btn_cancle;
        private Button btn_OK;
    }
}