
namespace Prius_Service
{
    partial class MultipleItemsInOut
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tLabel1 = new Prius_Service.TransparentLabel();
            this.beKi_richTextBox = new System.Windows.Forms.RichTextBox();
            this.osszesAr_label = new System.Windows.Forms.Label();
            this.osszesArData_label = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.barcode_textBox = new System.Windows.Forms.TextBox();
            this.igen_button = new System.Windows.Forms.Button();
            this.nem_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tLabel2 = new Prius_Service.TransparentLabel();
            this.beKiConfirm_richTextBox = new System.Windows.Forms.RichTextBox();
            this.beolvasFigyelmezteto_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tLabel1
            // 
            this.tLabel1.Location = new System.Drawing.Point(12, 22);
            this.tLabel1.Name = "tLabel1";
            this.tLabel1.Size = new System.Drawing.Size(361, 46);
            this.tLabel1.TabIndex = 8;
            this.tLabel1.Visible = false;
            // 
            // beKi_richTextBox
            // 
            this.beKi_richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.beKi_richTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.beKi_richTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.beKi_richTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.beKi_richTextBox.Location = new System.Drawing.Point(23, 22);
            this.beKi_richTextBox.Multiline = false;
            this.beKi_richTextBox.Name = "beKi_richTextBox";
            this.beKi_richTextBox.ReadOnly = true;
            this.beKi_richTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.beKi_richTextBox.ShortcutsEnabled = false;
            this.beKi_richTextBox.Size = new System.Drawing.Size(373, 33);
            this.beKi_richTextBox.TabIndex = 9;
            this.beKi_richTextBox.TabStop = false;
            this.beKi_richTextBox.Text = "Eddig bevitt termékek";
            // 
            // osszesAr_label
            // 
            this.osszesAr_label.AutoSize = true;
            this.osszesAr_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.osszesAr_label.Location = new System.Drawing.Point(609, 460);
            this.osszesAr_label.Name = "osszesAr_label";
            this.osszesAr_label.Size = new System.Drawing.Size(150, 21);
            this.osszesAr_label.TabIndex = 14;
            this.osszesAr_label.Text = "Összes eladási ára:";
            // 
            // osszesArData_label
            // 
            this.osszesArData_label.AutoSize = true;
            this.osszesArData_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.osszesArData_label.Location = new System.Drawing.Point(765, 460);
            this.osszesArData_label.Name = "osszesArData_label";
            this.osszesArData_label.Size = new System.Drawing.Size(36, 21);
            this.osszesArData_label.TabIndex = 19;
            this.osszesArData_label.Text = "0 Ft";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView.Location = new System.Drawing.Point(23, 64);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(843, 315);
            this.dataGridView.TabIndex = 3;
            // 
            // barcode_textBox
            // 
            this.barcode_textBox.BackColor = System.Drawing.SystemColors.Window;
            this.barcode_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.barcode_textBox.ForeColor = System.Drawing.SystemColors.Control;
            this.barcode_textBox.Location = new System.Drawing.Point(297, 157);
            this.barcode_textBox.Multiline = true;
            this.barcode_textBox.Name = "barcode_textBox";
            this.barcode_textBox.Size = new System.Drawing.Size(282, 111);
            this.barcode_textBox.TabIndex = 0;
            this.barcode_textBox.TextChanged += new System.EventHandler(this.Barcode_textBox_TextChanged);
            // 
            // igen_button
            // 
            this.igen_button.BackColor = System.Drawing.Color.Lime;
            this.igen_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.igen_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.igen_button.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.igen_button.Location = new System.Drawing.Point(120, 63);
            this.igen_button.Name = "igen_button";
            this.igen_button.Size = new System.Drawing.Size(96, 58);
            this.igen_button.TabIndex = 1;
            this.igen_button.Text = "Igen";
            this.igen_button.UseVisualStyleBackColor = false;
            this.igen_button.Click += new System.EventHandler(this.Igen_button_Click);
            // 
            // nem_button
            // 
            this.nem_button.BackColor = System.Drawing.Color.Red;
            this.nem_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nem_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.nem_button.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nem_button.Location = new System.Drawing.Point(282, 63);
            this.nem_button.Name = "nem_button";
            this.nem_button.Size = new System.Drawing.Size(96, 58);
            this.nem_button.TabIndex = 2;
            this.nem_button.Text = "Nem";
            this.nem_button.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tLabel2);
            this.panel1.Controls.Add(this.beKiConfirm_richTextBox);
            this.panel1.Controls.Add(this.nem_button);
            this.panel1.Controls.Add(this.igen_button);
            this.panel1.Location = new System.Drawing.Point(23, 396);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 150);
            this.panel1.TabIndex = 23;
            // 
            // tLabel2
            // 
            this.tLabel2.Location = new System.Drawing.Point(91, 17);
            this.tLabel2.Name = "tLabel2";
            this.tLabel2.Size = new System.Drawing.Size(312, 40);
            this.tLabel2.TabIndex = 24;
            this.tLabel2.Visible = false;
            // 
            // beKiConfirm_richTextBox
            // 
            this.beKiConfirm_richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.beKiConfirm_richTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.beKiConfirm_richTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.beKiConfirm_richTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.beKiConfirm_richTextBox.Location = new System.Drawing.Point(109, 24);
            this.beKiConfirm_richTextBox.Multiline = false;
            this.beKiConfirm_richTextBox.Name = "beKiConfirm_richTextBox";
            this.beKiConfirm_richTextBox.ReadOnly = true;
            this.beKiConfirm_richTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.beKiConfirm_richTextBox.ShortcutsEnabled = false;
            this.beKiConfirm_richTextBox.Size = new System.Drawing.Size(278, 33);
            this.beKiConfirm_richTextBox.TabIndex = 25;
            this.beKiConfirm_richTextBox.TabStop = false;
            this.beKiConfirm_richTextBox.Text = "Ki szeretnéd vinni ezeket a termékeket?";
            // 
            // beolvasFigyelmezteto_label
            // 
            this.beolvasFigyelmezteto_label.AutoSize = true;
            this.beolvasFigyelmezteto_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.beolvasFigyelmezteto_label.Location = new System.Drawing.Point(626, 34);
            this.beolvasFigyelmezteto_label.Name = "beolvasFigyelmezteto_label";
            this.beolvasFigyelmezteto_label.Size = new System.Drawing.Size(240, 21);
            this.beolvasFigyelmezteto_label.TabIndex = 24;
            this.beolvasFigyelmezteto_label.Text = "Kezdje el beolvasni a termékeket!";
            // 
            // MultipleItemsInOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 558);
            this.Controls.Add(this.beolvasFigyelmezteto_label);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.osszesArData_label);
            this.Controls.Add(this.beKi_richTextBox);
            this.Controls.Add(this.tLabel1);
            this.Controls.Add(this.osszesAr_label);
            this.Controls.Add(this.barcode_textBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MultipleItemsInOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MultipleItemsInOut_FormClosing);
            this.Load += new System.EventHandler(this.MultipleItemsInOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TransparentLabel tLabel1;
        private System.Windows.Forms.RichTextBox beKi_richTextBox;
        private System.Windows.Forms.Label osszesAr_label;
        private System.Windows.Forms.Label osszesArData_label;
        internal System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox barcode_textBox;
        private System.Windows.Forms.Button igen_button;
        private System.Windows.Forms.Button nem_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox beKiConfirm_richTextBox;
        private TransparentLabel tLabel2;
        private System.Windows.Forms.Label beolvasFigyelmezteto_label;
    }
}