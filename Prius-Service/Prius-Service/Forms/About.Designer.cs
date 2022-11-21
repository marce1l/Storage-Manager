
namespace Prius_Service
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.fejleszto_label = new System.Windows.Forms.Label();
            this.appName_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.email_linkLabel = new System.Windows.Forms.LinkLabel();
            this.version_linkLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // fejleszto_label
            // 
            this.fejleszto_label.AutoSize = true;
            this.fejleszto_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fejleszto_label.Location = new System.Drawing.Point(92, 285);
            this.fejleszto_label.Name = "fejleszto_label";
            this.fejleszto_label.Size = new System.Drawing.Size(100, 20);
            this.fejleszto_label.TabIndex = 1;
            this.fejleszto_label.Text = "Mikes Marcell";
            // 
            // appName_label
            // 
            this.appName_label.AutoSize = true;
            this.appName_label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.appName_label.Location = new System.Drawing.Point(85, 28);
            this.appName_label.Name = "appName_label";
            this.appName_label.Size = new System.Drawing.Size(112, 25);
            this.appName_label.TabIndex = 2;
            this.appName_label.Text = "Raktár App";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(66, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // email_linkLabel
            // 
            this.email_linkLabel.AutoSize = true;
            this.email_linkLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.email_linkLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.email_linkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.email_linkLabel.Location = new System.Drawing.Point(66, 317);
            this.email_linkLabel.Name = "email_linkLabel";
            this.email_linkLabel.Size = new System.Drawing.Size(155, 17);
            this.email_linkLabel.TabIndex = 0;
            this.email_linkLabel.TabStop = true;
            this.email_linkLabel.Text = "mikesmarcell@gmail.com";
            this.email_linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.email_linkLabel_LinkClicked);
            // 
            // version_linkLabel
            // 
            this.version_linkLabel.ActiveLinkColor = System.Drawing.Color.Black;
            this.version_linkLabel.AutoSize = true;
            this.version_linkLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.version_linkLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.version_linkLabel.LinkColor = System.Drawing.Color.Black;
            this.version_linkLabel.Location = new System.Drawing.Point(115, 64);
            this.version_linkLabel.Name = "version_linkLabel";
            this.version_linkLabel.Size = new System.Drawing.Size(50, 20);
            this.version_linkLabel.TabIndex = 4;
            this.version_linkLabel.TabStop = true;
            this.version_linkLabel.Text = "1.0.0.0";
            this.version_linkLabel.VisitedLinkColor = System.Drawing.Color.Black;
            this.version_linkLabel.Click += new System.EventHandler(this.version_linkLabel_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 354);
            this.Controls.Add(this.version_linkLabel);
            this.Controls.Add(this.email_linkLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.appName_label);
            this.Controls.Add(this.fejleszto_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Névjegy";
            this.Load += new System.EventHandler(this.About_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label fejleszto_label;
        private System.Windows.Forms.Label appName_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel email_linkLabel;
        private System.Windows.Forms.LinkLabel version_linkLabel;
    }
}