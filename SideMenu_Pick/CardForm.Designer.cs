namespace Card
{
    partial class CardForm
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
            this.cardimage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.counttimer = new System.Windows.Forms.Timer(this.components);
            this.count = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cardimage)).BeginInit();
            this.SuspendLayout();
            // 
            // cardimage
            // 
            this.cardimage.Location = new System.Drawing.Point(1, 0);
            this.cardimage.Name = "cardimage";
            this.cardimage.Size = new System.Drawing.Size(483, 416);
            this.cardimage.TabIndex = 0;
            this.cardimage.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.HotPink;
            this.label1.Location = new System.Drawing.Point(133, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "잠시만 기다려주세요...";
            // 
            // counttimer
            // 
            this.counttimer.Interval = 1000;
            this.counttimer.Tick += new System.EventHandler(this.counttimer_Tick);
            // 
            // count
            // 
            this.count.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.count.AutoSize = true;
            this.count.Location = new System.Drawing.Point(300, 431);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(0, 15);
            this.count.TabIndex = 3;
            this.count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.ControlBox = false;
            this.Controls.Add(this.count);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cardimage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CardForm";
            this.Text = "결제";
            this.Load += new System.EventHandler(this.CardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cardimage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox cardimage;
        private Label label1;
        private System.Windows.Forms.Timer counttimer;
        private Label count;
    }
}