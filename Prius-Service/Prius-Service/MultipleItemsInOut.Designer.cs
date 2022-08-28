
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tLabel1 = new Prius_Service.TransparentLabel();
            this.beKi_richTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView.Location = new System.Drawing.Point(23, 88);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(859, 509);
            this.dataGridView.TabIndex = 4;
            // 
            // tLabel1
            // 
            this.tLabel1.Location = new System.Drawing.Point(23, 21);
            this.tLabel1.Name = "tLabel1";
            this.tLabel1.Size = new System.Drawing.Size(361, 46);
            this.tLabel1.TabIndex = 8;
            this.tLabel1.Visible = false;
            // 
            // beKi_richTextBox
            // 
            this.beKi_richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.beKi_richTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.beKi_richTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.beKi_richTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.beKi_richTextBox.Location = new System.Drawing.Point(23, 34);
            this.beKi_richTextBox.Multiline = false;
            this.beKi_richTextBox.Name = "beKi_richTextBox";
            this.beKi_richTextBox.ReadOnly = true;
            this.beKi_richTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.beKi_richTextBox.ShortcutsEnabled = false;
            this.beKi_richTextBox.Size = new System.Drawing.Size(362, 21);
            this.beKi_richTextBox.TabIndex = 9;
            this.beKi_richTextBox.TabStop = false;
            this.beKi_richTextBox.Text = "Eddig bevitt termékek";
            // 
            // MultipleItemsInOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 630);
            this.Controls.Add(this.beKi_richTextBox);
            this.Controls.Add(this.tLabel1);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MultipleItemsInOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ömlesztett Bevitel";
            this.Load += new System.EventHandler(this.MultipleItemsInOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView dataGridView;
        private TransparentLabel tLabel1;
        private System.Windows.Forms.RichTextBox beKi_richTextBox;
    }
}