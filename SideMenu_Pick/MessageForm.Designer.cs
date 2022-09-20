namespace Message
{
    partial class MessageForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.ordernumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timetxt = new System.Windows.Forms.Label();
            this.receiptlist = new System.Windows.Forms.ListView();
            this.menu = new System.Windows.Forms.ColumnHeader();
            this.count = new System.Windows.Forms.ColumnHeader();
            this.price = new System.Windows.Forms.ColumnHeader();
            this.label4 = new System.Windows.Forms.Label();
            this.totaltxt = new System.Windows.Forms.Label();
            this.barcodebox = new System.Windows.Forms.PictureBox();
            this.l_takeout = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barcodebox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(138, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "주문번호 ";
            // 
            // ordernumber
            // 
            this.ordernumber.AutoSize = true;
            this.ordernumber.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ordernumber.Location = new System.Drawing.Point(217, 22);
            this.ordernumber.Name = "ordernumber";
            this.ordernumber.Size = new System.Drawing.Size(15, 17);
            this.ordernumber.TabIndex = 1;
            this.ordernumber.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "[영수증] 맘스터치";
            // 
            // timetxt
            // 
            this.timetxt.AutoSize = true;
            this.timetxt.Location = new System.Drawing.Point(21, 96);
            this.timetxt.Name = "timetxt";
            this.timetxt.Size = new System.Drawing.Size(14, 15);
            this.timetxt.TabIndex = 3;
            this.timetxt.Text = "0";
            // 
            // receiptlist
            // 
            this.receiptlist.BackColor = System.Drawing.Color.White;
            this.receiptlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.receiptlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.menu,
            this.count,
            this.price});
            this.receiptlist.Font = new System.Drawing.Font("맑은 고딕", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.receiptlist.Location = new System.Drawing.Point(1, 146);
            this.receiptlist.Name = "receiptlist";
            this.receiptlist.Size = new System.Drawing.Size(382, 120);
            this.receiptlist.TabIndex = 4;
            this.receiptlist.UseCompatibleStateImageBehavior = false;
            this.receiptlist.View = System.Windows.Forms.View.Details;
            // 
            // menu
            // 
            this.menu.Text = "상품명";
            this.menu.Width = 265;
            // 
            // count
            // 
            this.count.Text = "수량";
            this.count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.count.Width = 30;
            // 
            // price
            // 
            this.price.Text = "가격";
            this.price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.price.Width = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "합계금액";
            // 
            // totaltxt
            // 
            this.totaltxt.AutoSize = true;
            this.totaltxt.Location = new System.Drawing.Point(311, 269);
            this.totaltxt.Name = "totaltxt";
            this.totaltxt.Size = new System.Drawing.Size(14, 15);
            this.totaltxt.TabIndex = 6;
            this.totaltxt.Text = "0";
            this.totaltxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // barcodebox
            // 
            this.barcodebox.Location = new System.Drawing.Point(65, 299);
            this.barcodebox.Name = "barcodebox";
            this.barcodebox.Size = new System.Drawing.Size(244, 50);
            this.barcodebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.barcodebox.TabIndex = 7;
            this.barcodebox.TabStop = false;
            // 
            // l_takeout
            // 
            this.l_takeout.AutoSize = true;
            this.l_takeout.Location = new System.Drawing.Point(333, 96);
            this.l_takeout.Name = "l_takeout";
            this.l_takeout.Size = new System.Drawing.Size(14, 15);
            this.l_takeout.TabIndex = 8;
            this.l_takeout.Text = "0";
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.l_takeout);
            this.Controls.Add(this.barcodebox);
            this.Controls.Add(this.totaltxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.receiptlist);
            this.Controls.Add(this.timetxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ordernumber);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MessageForm";
            this.Text = "영수증";
            this.Load += new System.EventHandler(this.MessageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barcodebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label ordernumber;
        private Label label3;
        private Label timetxt;
        private ColumnHeader menu;
        private ColumnHeader count;
        private ColumnHeader price;
        private Label label4;
        private Label totaltxt;
        private PictureBox barcodebox;
        public ListView receiptlist;
        private Label l_takeout;
    }
}