namespace Pay
{
    partial class PayForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            orderlist = new System.Windows.Forms.ListView();
            this.menu = new System.Windows.Forms.ColumnHeader();
            this.count = new System.Windows.Forms.ColumnHeader();
            this.price = new System.Windows.Forms.ColumnHeader();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ordercount = new System.Windows.Forms.Label();
            this.orderprice = new System.Windows.Forms.Label();
            this.pavingbtn = new System.Windows.Forms.Button();
            this.burialbtn = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightPink;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(585, 34);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightPink;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(249, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "결제 선택";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(177, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "결제수단을 선택해주세요";
            // 
            // orderlist
            // 
            orderlist.BackColor = System.Drawing.Color.White;
            orderlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            orderlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.menu,
            this.count,
            this.price});
            orderlist.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            orderlist.LabelWrap = false;
            orderlist.Location = new System.Drawing.Point(9, 149);
            orderlist.MultiSelect = false;
            orderlist.Name = "orderlist";
            orderlist.Size = new System.Drawing.Size(564, 195);
            orderlist.TabIndex = 3;
            orderlist.TabStop = false;
            orderlist.UseCompatibleStateImageBehavior = false;
            orderlist.View = System.Windows.Forms.View.Details;
            // 
            // menu
            // 
            this.menu.Text = "메뉴";
            this.menu.Width = 365;
            // 
            // count
            // 
            this.count.Text = "수량";
            this.count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // price
            // 
            this.price.Text = "금액";
            this.price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.price.Width = 120;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LightPink;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 111);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(585, 30);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightPink;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(8, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "메뉴";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightPink;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(397, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "수량";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightPink;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(528, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "금액";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.LightPink;
            this.pictureBox3.Location = new System.Drawing.Point(-1, 350);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(585, 15);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(8, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "주문수량";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(446, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "주문금액";
            // 
            // ordercount
            // 
            this.ordercount.AutoSize = true;
            this.ordercount.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ordercount.Location = new System.Drawing.Point(74, 379);
            this.ordercount.Name = "ordercount";
            this.ordercount.Size = new System.Drawing.Size(16, 17);
            this.ordercount.TabIndex = 11;
            this.ordercount.Text = "1";
            this.ordercount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // orderprice
            // 
            this.orderprice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.orderprice.AutoSize = true;
            this.orderprice.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.orderprice.Location = new System.Drawing.Point(512, 379);
            this.orderprice.Name = "orderprice";
            this.orderprice.Size = new System.Drawing.Size(40, 17);
            this.orderprice.TabIndex = 12;
            this.orderprice.Text = "5000";
            this.orderprice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pavingbtn
            // 
            this.pavingbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pavingbtn.BackColor = System.Drawing.Color.White;
            this.pavingbtn.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pavingbtn.ForeColor = System.Drawing.Color.LightPink;
            this.pavingbtn.Location = new System.Drawing.Point(128, 420);
            this.pavingbtn.Name = "pavingbtn";
            this.pavingbtn.Size = new System.Drawing.Size(150, 49);
            this.pavingbtn.TabIndex = 13;
            this.pavingbtn.Text = "포장";
            this.pavingbtn.UseVisualStyleBackColor = false;
            this.pavingbtn.Click += new System.EventHandler(this.pavingbtn_Click);
            // 
            // burialbtn
            // 
            this.burialbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.burialbtn.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.burialbtn.ForeColor = System.Drawing.Color.LightPink;
            this.burialbtn.Location = new System.Drawing.Point(304, 420);
            this.burialbtn.Name = "burialbtn";
            this.burialbtn.Size = new System.Drawing.Size(150, 49);
            this.burialbtn.TabIndex = 14;
            this.burialbtn.Text = "매장";
            this.burialbtn.UseVisualStyleBackColor = false;
            this.burialbtn.Click += new System.EventHandler(this.burialbtn_Click);
            // 
            // cancel
            // 
            this.cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancel.BackColor = System.Drawing.Color.Pink;
            this.cancel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancel.Location = new System.Drawing.Point(165, 501);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(113, 61);
            this.cancel.TabIndex = 15;
            this.cancel.Text = "취소";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.Pink;
            this.button2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(304, 501);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 61);
            this.button2.TabIndex = 16;
            this.button2.Text = "신용카드";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 586);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.burialbtn);
            this.Controls.Add(this.pavingbtn);
            this.Controls.Add(this.orderprice);
            this.Controls.Add(this.ordercount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(orderlist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PayForm";
            this.Text = "Mom\'s Touch";
            this.Load += new System.EventHandler(this.PayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        public static ListView orderlist;
        private ColumnHeader menu;
        private ColumnHeader count;
        private ColumnHeader price;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox3;
        private Label label6;
        private Label label7;
        private Label ordercount;
        private Label orderprice;
        private Button pavingbtn;
        private Button burialbtn;
        private Button cancel;
        private Button button2;
    }
}