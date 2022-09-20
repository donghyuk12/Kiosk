namespace START
{
    partial class Start
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
            this.components = new System.ComponentModel.Container();
            this.eventImage = new System.Windows.Forms.PictureBox();
            this.btn_Pack = new System.Windows.Forms.Button();
            this.btn_Mart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.eventImage)).BeginInit();
            this.SuspendLayout();
            // 
            // eventImage
            // 
            this.eventImage.Location = new System.Drawing.Point(0, 0);
            this.eventImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.eventImage.Name = "eventImage";
            this.eventImage.Size = new System.Drawing.Size(829, 807);
            this.eventImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eventImage.TabIndex = 1;
            this.eventImage.TabStop = false;
            // 
            // btn_Pack
            // 
            this.btn_Pack.BackColor = System.Drawing.Color.Tomato;
            this.btn_Pack.Font = new System.Drawing.Font("굴림", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Pack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Pack.Location = new System.Drawing.Point(15, 820);
            this.btn_Pack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Pack.Name = "btn_Pack";
            this.btn_Pack.Size = new System.Drawing.Size(300, 135);
            this.btn_Pack.TabIndex = 2;
            this.btn_Pack.Text = "포장";
            this.btn_Pack.UseVisualStyleBackColor = false;
            this.btn_Pack.Click += new System.EventHandler(this.btn_Pack_Click);
            // 
            // btn_Mart
            // 
            this.btn_Mart.BackColor = System.Drawing.Color.Tomato;
            this.btn_Mart.Font = new System.Drawing.Font("굴림", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Mart.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Mart.Location = new System.Drawing.Point(515, 820);
            this.btn_Mart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Mart.Name = "btn_Mart";
            this.btn_Mart.Size = new System.Drawing.Size(300, 135);
            this.btn_Mart.TabIndex = 4;
            this.btn_Mart.Text = "매장";
            this.btn_Mart.UseVisualStyleBackColor = false;
            this.btn_Mart.Click += new System.EventHandler(this.btn_Mart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 965);
            this.Controls.Add(this.btn_Mart);
            this.Controls.Add(this.btn_Pack);
            this.Controls.Add(this.eventImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Start";
            this.Text = "Mom\'s Touch";
            this.Load += new System.EventHandler(this.Start_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox eventImage;
        private System.Windows.Forms.Button btn_Pack;
        private System.Windows.Forms.Button btn_Mart;
        private System.Windows.Forms.Timer timer1;
    }
}