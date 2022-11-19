
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultipleItemsInOut));
            this.transparentLabel1 = new Prius_Service.TransparentLabel();
            this.inOut_richTextBox = new System.Windows.Forms.RichTextBox();
            this.sumPrice_label = new System.Windows.Forms.Label();
            this.sumPriceData_label = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.barcode_textBox = new System.Windows.Forms.TextBox();
            this.igen_button = new System.Windows.Forms.Button();
            this.nem_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.transparentLabel2 = new Prius_Service.TransparentLabel();
            this.inOutConfirm_richTextBox = new System.Windows.Forms.RichTextBox();
            this.scanPrompt_label = new System.Windows.Forms.Label();
            this.osszesDarab_label = new System.Windows.Forms.Label();
            this.sumQuantityData_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tLabel1
            // 
            this.transparentLabel1.Location = new System.Drawing.Point(12, 22);
            this.transparentLabel1.Name = "tLabel1";
            this.transparentLabel1.Size = new System.Drawing.Size(361, 46);
            this.transparentLabel1.TabIndex = 8;
            this.transparentLabel1.Visible = false;
            // 
            // beKi_richTextBox
            // 
            this.inOut_richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inOut_richTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.inOut_richTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inOut_richTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.inOut_richTextBox.Location = new System.Drawing.Point(23, 22);
            this.inOut_richTextBox.Multiline = false;
            this.inOut_richTextBox.Name = "beKi_richTextBox";
            this.inOut_richTextBox.ReadOnly = true;
            this.inOut_richTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.inOut_richTextBox.ShortcutsEnabled = false;
            this.inOut_richTextBox.Size = new System.Drawing.Size(373, 33);
            this.inOut_richTextBox.TabIndex = 9;
            this.inOut_richTextBox.TabStop = false;
            this.inOut_richTextBox.Text = "Eddig bevitt termékek";
            // 
            // osszesAr_label
            // 
            this.sumPrice_label.AutoSize = true;
            this.sumPrice_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sumPrice_label.Location = new System.Drawing.Point(607, 478);
            this.sumPrice_label.Name = "osszesAr_label";
            this.sumPrice_label.Size = new System.Drawing.Size(150, 21);
            this.sumPrice_label.TabIndex = 14;
            this.sumPrice_label.Text = "Összes eladási ára:";
            // 
            // osszesArData_label
            // 
            this.sumPriceData_label.AutoSize = true;
            this.sumPriceData_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sumPriceData_label.Location = new System.Drawing.Point(763, 478);
            this.sumPriceData_label.Name = "osszesArData_label";
            this.sumPriceData_label.Size = new System.Drawing.Size(36, 21);
            this.sumPriceData_label.TabIndex = 19;
            this.sumPriceData_label.Text = "0 Ft";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
            this.panel1.Controls.Add(this.transparentLabel2);
            this.panel1.Controls.Add(this.inOutConfirm_richTextBox);
            this.panel1.Controls.Add(this.nem_button);
            this.panel1.Controls.Add(this.igen_button);
            this.panel1.Location = new System.Drawing.Point(23, 396);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 150);
            this.panel1.TabIndex = 23;
            // 
            // tLabel2
            // 
            this.transparentLabel2.Location = new System.Drawing.Point(91, 17);
            this.transparentLabel2.Name = "tLabel2";
            this.transparentLabel2.Size = new System.Drawing.Size(312, 40);
            this.transparentLabel2.TabIndex = 24;
            this.transparentLabel2.Visible = false;
            // 
            // beKiConfirm_richTextBox
            // 
            this.inOutConfirm_richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inOutConfirm_richTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.inOutConfirm_richTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inOutConfirm_richTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.inOutConfirm_richTextBox.Location = new System.Drawing.Point(109, 24);
            this.inOutConfirm_richTextBox.Multiline = false;
            this.inOutConfirm_richTextBox.Name = "beKiConfirm_richTextBox";
            this.inOutConfirm_richTextBox.ReadOnly = true;
            this.inOutConfirm_richTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.inOutConfirm_richTextBox.ShortcutsEnabled = false;
            this.inOutConfirm_richTextBox.Size = new System.Drawing.Size(278, 33);
            this.inOutConfirm_richTextBox.TabIndex = 25;
            this.inOutConfirm_richTextBox.TabStop = false;
            this.inOutConfirm_richTextBox.Text = "Ki szeretnéd vinni ezeket a termékeket?";
            // 
            // beolvasFigyelmezteto_label
            // 
            this.scanPrompt_label.AutoSize = true;
            this.scanPrompt_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scanPrompt_label.Location = new System.Drawing.Point(626, 34);
            this.scanPrompt_label.Name = "beolvasFigyelmezteto_label";
            this.scanPrompt_label.Size = new System.Drawing.Size(240, 21);
            this.scanPrompt_label.TabIndex = 24;
            this.scanPrompt_label.Text = "Kezdje el beolvasni a termékeket!";
            // 
            // osszesDarab_label
            // 
            this.osszesDarab_label.AutoSize = true;
            this.osszesDarab_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.osszesDarab_label.Location = new System.Drawing.Point(597, 433);
            this.osszesDarab_label.Name = "osszesDarab_label";
            this.osszesDarab_label.Size = new System.Drawing.Size(160, 21);
            this.osszesDarab_label.TabIndex = 25;
            this.osszesDarab_label.Text = "Összes darabszáma:";
            // 
            // osszesDarabData_label
            // 
            this.sumQuantityData_label.AutoSize = true;
            this.sumQuantityData_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sumQuantityData_label.Location = new System.Drawing.Point(763, 433);
            this.sumQuantityData_label.Name = "osszesDarabData_label";
            this.sumQuantityData_label.Size = new System.Drawing.Size(39, 21);
            this.sumQuantityData_label.TabIndex = 26;
            this.sumQuantityData_label.Text = "x db";
            // 
            // MultipleItemsInOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 558);
            this.Controls.Add(this.sumQuantityData_label);
            this.Controls.Add(this.osszesDarab_label);
            this.Controls.Add(this.scanPrompt_label);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.sumPriceData_label);
            this.Controls.Add(this.inOut_richTextBox);
            this.Controls.Add(this.transparentLabel1);
            this.Controls.Add(this.sumPrice_label);
            this.Controls.Add(this.barcode_textBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
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
        private TransparentLabel transparentLabel1;
        private System.Windows.Forms.RichTextBox inOut_richTextBox;
        private System.Windows.Forms.Label sumPrice_label;
        private System.Windows.Forms.Label sumPriceData_label;
        internal System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox barcode_textBox;
        private System.Windows.Forms.Button igen_button;
        private System.Windows.Forms.Button nem_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox inOutConfirm_richTextBox;
        private TransparentLabel transparentLabel2;
        private System.Windows.Forms.Label scanPrompt_label;
        private System.Windows.Forms.Label osszesDarab_label;
        private System.Windows.Forms.Label sumQuantityData_label;
    }
}