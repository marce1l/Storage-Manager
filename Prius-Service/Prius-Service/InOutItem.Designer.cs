
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.beKi_label = new System.Windows.Forms.Label();
            this.BeKiDarabszam_numericUpAndDown = new System.Windows.Forms.NumericUpDown();
            this.igen_button = new System.Windows.Forms.Button();
            this.nem_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.confirm_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeKiDarabszam_numericUpAndDown)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.dataGridView.Location = new System.Drawing.Point(30, 29);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(859, 146);
            this.dataGridView.TabIndex = 3;
            // 
            // beKi_label
            // 
            this.beKi_label.AutoSize = true;
            this.beKi_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.beKi_label.Location = new System.Drawing.Point(33, 36);
            this.beKi_label.Name = "beKi_label";
            this.beKi_label.Size = new System.Drawing.Size(362, 21);
            this.beKi_label.TabIndex = 2;
            this.beKi_label.Text = "Hány darabot szeretnél ebből a termékből bevinni?";
            // 
            // BeKiDarabszam_numericUpAndDown
            // 
            this.BeKiDarabszam_numericUpAndDown.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BeKiDarabszam_numericUpAndDown.Location = new System.Drawing.Point(152, 106);
            this.BeKiDarabszam_numericUpAndDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.BeKiDarabszam_numericUpAndDown.Name = "BeKiDarabszam_numericUpAndDown";
            this.BeKiDarabszam_numericUpAndDown.Size = new System.Drawing.Size(108, 46);
            this.BeKiDarabszam_numericUpAndDown.TabIndex = 0;
            this.BeKiDarabszam_numericUpAndDown.ThousandsSeparator = true;
            // 
            // igen_button
            // 
            this.igen_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.igen_button.Location = new System.Drawing.Point(496, 106);
            this.igen_button.Name = "igen_button";
            this.igen_button.Size = new System.Drawing.Size(96, 58);
            this.igen_button.TabIndex = 1;
            this.igen_button.Text = "Igen";
            this.igen_button.UseVisualStyleBackColor = true;
            this.igen_button.Click += new System.EventHandler(this.igen_button_Click);
            // 
            // nem_button
            // 
            this.nem_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.nem_button.Location = new System.Drawing.Point(685, 106);
            this.nem_button.Name = "nem_button";
            this.nem_button.Size = new System.Drawing.Size(96, 58);
            this.nem_button.TabIndex = 2;
            this.nem_button.Text = "Nem";
            this.nem_button.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.confirm_label);
            this.panel1.Controls.Add(this.beKi_label);
            this.panel1.Controls.Add(this.nem_button);
            this.panel1.Controls.Add(this.igen_button);
            this.panel1.Controls.Add(this.BeKiDarabszam_numericUpAndDown);
            this.panel1.Location = new System.Drawing.Point(30, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(858, 234);
            this.panel1.TabIndex = 5;
            // 
            // confirm_label
            // 
            this.confirm_label.AutoSize = true;
            this.confirm_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirm_label.Location = new System.Drawing.Point(524, 36);
            this.confirm_label.Name = "confirm_label";
            this.confirm_label.Size = new System.Drawing.Size(224, 21);
            this.confirm_label.TabIndex = 5;
            this.confirm_label.Text = "Bizotsan hozzá szeretnéd adni?";
            // 
            // InOutItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 467);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView);
            this.Name = "InOutItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InOutItem";
            this.Load += new System.EventHandler(this.InOutItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeKiDarabszam_numericUpAndDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.NumericUpDown BeKiDarabszam_numericUpAndDown;
        private System.Windows.Forms.Button igen_button;
        private System.Windows.Forms.Button nem_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label confirm_label;
        internal System.Windows.Forms.Label beKi_label;
    }
}