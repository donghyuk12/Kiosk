namespace Admin
{
    partial class AdminPage
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
            this.btn_soldout = new System.Windows.Forms.Button();
            this.L_Title = new System.Windows.Forms.Label();
            this.Logo_Image = new System.Windows.Forms.PictureBox();
            this.btn_inspection = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_soldout
            // 
            this.btn_soldout.Location = new System.Drawing.Point(64, 170);
            this.btn_soldout.Name = "btn_soldout";
            this.btn_soldout.Size = new System.Drawing.Size(150, 75);
            this.btn_soldout.TabIndex = 0;
            this.btn_soldout.Text = "품절관리";
            this.btn_soldout.UseVisualStyleBackColor = true;
            this.btn_soldout.Click += new System.EventHandler(this.btn_soldout_Click);
            // 
            // L_Title
            // 
            this.L_Title.Font = new System.Drawing.Font("휴먼옛체", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.L_Title.Location = new System.Drawing.Point(190, 45);
            this.L_Title.Name = "L_Title";
            this.L_Title.Size = new System.Drawing.Size(430, 35);
            this.L_Title.TabIndex = 1;
            this.L_Title.Text = "관리자 페이지 입니다";
            this.L_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Logo_Image
            // 
            this.Logo_Image.Location = new System.Drawing.Point(30, 30);
            this.Logo_Image.Name = "Logo_Image";
            this.Logo_Image.Size = new System.Drawing.Size(175, 75);
            this.Logo_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo_Image.TabIndex = 2;
            this.Logo_Image.TabStop = false;
            // 
            // btn_inspection
            // 
            this.btn_inspection.Location = new System.Drawing.Point(244, 170);
            this.btn_inspection.Name = "btn_inspection";
            this.btn_inspection.Size = new System.Drawing.Size(150, 75);
            this.btn_inspection.TabIndex = 3;
            this.btn_inspection.Text = "점검중";
            this.btn_inspection.UseVisualStyleBackColor = true;
            this.btn_inspection.Click += new System.EventHandler(this.btn_inspection_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(64, 270);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(150, 75);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "프로그램 종료";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(420, 170);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(150, 75);
            this.btn_return.TabIndex = 5;
            this.btn_return.Text = "판매화면";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 511);
            this.ControlBox = false;
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_inspection);
            this.Controls.Add(this.Logo_Image);
            this.Controls.Add(this.L_Title);
            this.Controls.Add(this.btn_soldout);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminPage";
            this.Text = "관리자 페이지";
            this.Load += new System.EventHandler(this.AdminPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo_Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_soldout;
        private Label L_Title;
        private PictureBox Logo_Image;
        private Button btn_inspection;
        private Button btn_exit;
        private Button btn_return;
    }
}