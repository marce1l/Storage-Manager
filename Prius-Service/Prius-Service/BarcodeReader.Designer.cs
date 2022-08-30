
namespace Prius_Service
{
    partial class BarcodeReader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarcodeReader));
            this.barcode_textBox = new System.Windows.Forms.TextBox();
            this.title_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // barcode_textBox
            // 
            this.barcode_textBox.BackColor = System.Drawing.SystemColors.Window;
            this.barcode_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.barcode_textBox.ForeColor = System.Drawing.SystemColors.Control;
            this.barcode_textBox.Location = new System.Drawing.Point(100, 150);
            this.barcode_textBox.Multiline = true;
            this.barcode_textBox.Name = "barcode_textBox";
            this.barcode_textBox.Size = new System.Drawing.Size(282, 111);
            this.barcode_textBox.TabIndex = 0;
            this.barcode_textBox.TextChanged += new System.EventHandler(this.barcode_textBox_TextChanged);
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title_label.Location = new System.Drawing.Point(65, 22);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(360, 32);
            this.title_label.TabIndex = 1;
            this.title_label.Text = "Olvassa be a termék vonalkódját";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(417, 257);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // BarcodeReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 367);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.barcode_textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BarcodeReader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vonalkód Olvasó";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BarcodeReader_FormClosed);
            this.Load += new System.EventHandler(this.BarcodeReader_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BarcodeReader_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BarcodeReader_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox barcode_textBox;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}