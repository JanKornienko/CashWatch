namespace Financial_App
{
    partial class Categories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categories));
            this.catTxt = new System.Windows.Forms.TextBox();
            this.backButt = new System.Windows.Forms.PictureBox();
            this.newButt = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.backButt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newButt)).BeginInit();
            this.SuspendLayout();
            // 
            // catTxt
            // 
            this.catTxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.catTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.catTxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.catTxt.Location = new System.Drawing.Point(12, 12);
            this.catTxt.Name = "catTxt";
            this.catTxt.Size = new System.Drawing.Size(180, 21);
            this.catTxt.TabIndex = 0;
            // 
            // backButt
            // 
            this.backButt.BackColor = System.Drawing.Color.Transparent;
            this.backButt.Image = ((System.Drawing.Image)(resources.GetObject("backButt.Image")));
            this.backButt.Location = new System.Drawing.Point(12, 39);
            this.backButt.Name = "backButt";
            this.backButt.Size = new System.Drawing.Size(40, 40);
            this.backButt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backButt.TabIndex = 14;
            this.backButt.TabStop = false;
            this.backButt.Click += new System.EventHandler(this.backButt_Click);
            // 
            // newButt
            // 
            this.newButt.BackColor = System.Drawing.Color.Transparent;
            this.newButt.Image = ((System.Drawing.Image)(resources.GetObject("newButt.Image")));
            this.newButt.Location = new System.Drawing.Point(152, 39);
            this.newButt.Name = "newButt";
            this.newButt.Size = new System.Drawing.Size(40, 40);
            this.newButt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.newButt.TabIndex = 15;
            this.newButt.TabStop = false;
            this.newButt.Click += new System.EventHandler(this.newButt_Click);
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(204, 88);
            this.ControlBox = false;
            this.Controls.Add(this.newButt);
            this.Controls.Add(this.backButt);
            this.Controls.Add(this.catTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Categories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categories";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Categories_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.backButt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newButt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox catTxt;
        private System.Windows.Forms.PictureBox backButt;
        private System.Windows.Forms.PictureBox newButt;
    }
}