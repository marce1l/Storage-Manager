
namespace Prius_Service
{
    partial class InOutItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InOutItem));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.inOutQuantity_numericUpAndDown = new System.Windows.Forms.NumericUpDown();
            this.igen_button = new System.Windows.Forms.Button();
            this.nem_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.transparentLabel1 = new Prius_Service.TransparentLabel();
            this.inOut_richTextBox = new System.Windows.Forms.RichTextBox();
            this.confirm_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inOutQuantity_numericUpAndDown)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.dataGridView.Location = new System.Drawing.Point(30, 29);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(859, 146);
            this.dataGridView.TabIndex = 4;
            this.dataGridView.TabStop = false;
            // 
            // BeKiDarabszam_numericUpAndDown
            // 
            this.inOutQuantity_numericUpAndDown.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inOutQuantity_numericUpAndDown.Location = new System.Drawing.Point(163, 106);
            this.inOutQuantity_numericUpAndDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.inOutQuantity_numericUpAndDown.Name = "BeKiDarabszam_numericUpAndDown";
            this.inOutQuantity_numericUpAndDown.Size = new System.Drawing.Size(108, 46);
            this.inOutQuantity_numericUpAndDown.TabIndex = 0;
            this.inOutQuantity_numericUpAndDown.ThousandsSeparator = true;
            this.inOutQuantity_numericUpAndDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // igen_button
            // 
            this.igen_button.BackColor = System.Drawing.Color.Lime;
            this.igen_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.igen_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.igen_button.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.igen_button.Location = new System.Drawing.Point(496, 106);
            this.igen_button.Name = "igen_button";
            this.igen_button.Size = new System.Drawing.Size(96, 58);
            this.igen_button.TabIndex = 2;
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
            this.nem_button.Location = new System.Drawing.Point(685, 106);
            this.nem_button.Name = "nem_button";
            this.nem_button.Size = new System.Drawing.Size(96, 58);
            this.nem_button.TabIndex = 3;
            this.nem_button.Text = "Nem";
            this.nem_button.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.transparentLabel1);
            this.panel1.Controls.Add(this.inOut_richTextBox);
            this.panel1.Controls.Add(this.confirm_label);
            this.panel1.Controls.Add(this.nem_button);
            this.panel1.Controls.Add(this.igen_button);
            this.panel1.Controls.Add(this.inOutQuantity_numericUpAndDown);
            this.panel1.Location = new System.Drawing.Point(30, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(858, 234);
            this.panel1.TabIndex = 5;
            // 
            // tLabel1
            // 
            this.transparentLabel1.Location = new System.Drawing.Point(36, 26);
            this.transparentLabel1.Name = "tLabel1";
            this.transparentLabel1.Size = new System.Drawing.Size(361, 46);
            this.transparentLabel1.TabIndex = 5;
            this.transparentLabel1.Visible = false;
            // 
            // beKi_richTextBox
            // 
            this.inOut_richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inOut_richTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.inOut_richTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inOut_richTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.inOut_richTextBox.Location = new System.Drawing.Point(45, 36);
            this.inOut_richTextBox.Multiline = false;
            this.inOut_richTextBox.Name = "beKi_richTextBox";
            this.inOut_richTextBox.ReadOnly = true;
            this.inOut_richTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.inOut_richTextBox.ShortcutsEnabled = false;
            this.inOut_richTextBox.Size = new System.Drawing.Size(362, 21);
            this.inOut_richTextBox.TabIndex = 6;
            this.inOut_richTextBox.TabStop = false;
            this.inOut_richTextBox.Text = "Hány darabot szeretnél ebből a termékből bevinni?";
            // 
            // confirm_label
            // 
            this.confirm_label.AutoSize = true;
            this.confirm_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirm_label.Location = new System.Drawing.Point(524, 36);
            this.confirm_label.Name = "confirm_label";
            this.confirm_label.Size = new System.Drawing.Size(224, 21);
            this.confirm_label.TabIndex = 6;
            this.confirm_label.Text = "Bizotsan hozzá szeretnéd adni?";
            // 
            // InOutItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(920, 467);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InOutItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.InOutItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inOutQuantity_numericUpAndDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.NumericUpDown inOutQuantity_numericUpAndDown;
        private System.Windows.Forms.Button igen_button;
        private System.Windows.Forms.Button nem_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label confirm_label;
        private System.Windows.Forms.RichTextBox inOut_richTextBox;
        private TransparentLabel transparentLabel1;
    }
}