
namespace Prius_Service
{
    partial class ListProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListProducts));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.AddItem_Button = new System.Windows.Forms.Button();
            this.DeleteItem_Button = new System.Windows.Forms.Button();
            this.EditItem_Button = new System.Windows.Forms.Button();
            this.kereso_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
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
            this.dataGridView.Location = new System.Drawing.Point(28, 29);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(911, 497);
            this.dataGridView.TabIndex = 4;
            this.dataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellEndEdit);
            // 
            // AddItem_Button
            // 
            this.AddItem_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddItem_Button.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddItem_Button.Location = new System.Drawing.Point(997, 130);
            this.AddItem_Button.Name = "AddItem_Button";
            this.AddItem_Button.Size = new System.Drawing.Size(113, 87);
            this.AddItem_Button.TabIndex = 1;
            this.AddItem_Button.Text = "Új termék hozzáadás";
            this.AddItem_Button.UseVisualStyleBackColor = true;
            this.AddItem_Button.Click += new System.EventHandler(this.AddItem_Button_Click);
            // 
            // DeleteItem_Button
            // 
            this.DeleteItem_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteItem_Button.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteItem_Button.Location = new System.Drawing.Point(997, 396);
            this.DeleteItem_Button.Name = "DeleteItem_Button";
            this.DeleteItem_Button.Size = new System.Drawing.Size(113, 87);
            this.DeleteItem_Button.TabIndex = 3;
            this.DeleteItem_Button.Text = "Termék törlése";
            this.DeleteItem_Button.UseVisualStyleBackColor = true;
            this.DeleteItem_Button.Click += new System.EventHandler(this.DeleteItem_Button_Click);
            // 
            // EditItem_Button
            // 
            this.EditItem_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditItem_Button.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditItem_Button.Location = new System.Drawing.Point(997, 259);
            this.EditItem_Button.Name = "EditItem_Button";
            this.EditItem_Button.Size = new System.Drawing.Size(113, 87);
            this.EditItem_Button.TabIndex = 2;
            this.EditItem_Button.Text = "Termék módosítása";
            this.EditItem_Button.UseVisualStyleBackColor = true;
            this.EditItem_Button.Click += new System.EventHandler(this.EditItem_Button_Click);
            // 
            // kereso_textBox
            // 
            this.kereso_textBox.Location = new System.Drawing.Point(962, 59);
            this.kereso_textBox.Name = "kereso_textBox";
            this.kereso_textBox.Size = new System.Drawing.Size(176, 23);
            this.kereso_textBox.TabIndex = 5;
            // 
            // ListProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 555);
            this.Controls.Add(this.kereso_textBox);
            this.Controls.Add(this.EditItem_Button);
            this.Controls.Add(this.DeleteItem_Button);
            this.Controls.Add(this.AddItem_Button);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kilistázott Termékek";
            this.Load += new System.EventHandler(this.ListProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button AddItem_Button;
        private System.Windows.Forms.Button DeleteItem_Button;
        private System.Windows.Forms.Button EditItem_Button;
        private System.Windows.Forms.TextBox kereso_textBox;
    }
}