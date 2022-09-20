namespace Admin
{
    partial class Inspection
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
            this.btn_return = new System.Windows.Forms.Button();
            this.l_inspection = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_return
            // 
            this.btn_return.BackColor = System.Drawing.Color.Black;
            this.btn_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_return.Location = new System.Drawing.Point(0, 0);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(75, 75);
            this.btn_return.TabIndex = 0;
            this.btn_return.UseVisualStyleBackColor = false;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // l_inspection
            // 
            this.l_inspection.AutoSize = true;
            this.l_inspection.Font = new System.Drawing.Font("맑은 고딕", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l_inspection.ForeColor = System.Drawing.Color.White;
            this.l_inspection.Location = new System.Drawing.Point(200, 500);
            this.l_inspection.Name = "l_inspection";
            this.l_inspection.Size = new System.Drawing.Size(438, 86);
            this.l_inspection.TabIndex = 1;
            this.l_inspection.Text = "점검중입니다.";
            // 
            // Inspection
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(843, 1004);
            this.Controls.Add(this.l_inspection);
            this.Controls.Add(this.btn_return);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inspection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_return;
        private Label l_inspection;
    }
}