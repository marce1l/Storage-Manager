﻿
namespace Prius_Service
{
    partial class AddItemPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItemPopup));
            this.VonalkodBeolvas_Button = new System.Windows.Forms.Button();
            this.name_TextBox = new System.Windows.Forms.TextBox();
            this.itemNumber_TextBox = new System.Windows.Forms.TextBox();
            this.barcode_textBox = new System.Windows.Forms.TextBox();
            this.quantity_TextBox = new System.Windows.Forms.TextBox();
            this.nev_label = new System.Windows.Forms.Label();
            this.cikkszam_label = new System.Windows.Forms.Label();
            this.vonalkod_label = new System.Windows.Forms.Label();
            this.marka_label = new System.Windows.Forms.Label();
            this.darabszam_label = new System.Windows.Forms.Label();
            this.beszerzesiAr_label = new System.Windows.Forms.Label();
            this.costPrice_textBox = new System.Windows.Forms.TextBox();
            this.Mentes_Button = new System.Windows.Forms.Button();
            this.Elvetes_Button = new System.Windows.Forms.Button();
            this.minQuantity_textBox = new System.Windows.Forms.TextBox();
            this.minDarabszam_label = new System.Windows.Forms.Label();
            this.befejezes_Button = new System.Windows.Forms.Button();
            this.sellPrice_Textbox = new System.Windows.Forms.TextBox();
            this.eladasiAr_label = new System.Windows.Forms.Label();
            this.manufacturer_comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // VonalkodBeolvas_Button
            // 
            this.VonalkodBeolvas_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VonalkodBeolvas_Button.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VonalkodBeolvas_Button.Location = new System.Drawing.Point(377, 357);
            this.VonalkodBeolvas_Button.Name = "VonalkodBeolvas_Button";
            this.VonalkodBeolvas_Button.Size = new System.Drawing.Size(94, 62);
            this.VonalkodBeolvas_Button.TabIndex = 8;
            this.VonalkodBeolvas_Button.Text = "Beolvas";
            this.VonalkodBeolvas_Button.UseVisualStyleBackColor = true;
            this.VonalkodBeolvas_Button.Click += new System.EventHandler(this.VonalkodBeolvas_Button_Click);
            // 
            // name_TextBox
            // 
            this.name_TextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name_TextBox.Location = new System.Drawing.Point(39, 176);
            this.name_TextBox.Name = "name_TextBox";
            this.name_TextBox.Size = new System.Drawing.Size(343, 29);
            this.name_TextBox.TabIndex = 0;
            // 
            // itemNumber_TextBox
            // 
            this.itemNumber_TextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.itemNumber_TextBox.Location = new System.Drawing.Point(682, 176);
            this.itemNumber_TextBox.Name = "itemNumber_TextBox";
            this.itemNumber_TextBox.Size = new System.Drawing.Size(167, 29);
            this.itemNumber_TextBox.TabIndex = 2;
            // 
            // barcode_textBox
            // 
            this.barcode_textBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.barcode_textBox.Location = new System.Drawing.Point(144, 374);
            this.barcode_textBox.Name = "barcode_textBox";
            this.barcode_textBox.Size = new System.Drawing.Size(167, 29);
            this.barcode_textBox.TabIndex = 7;
            // 
            // quantity_TextBox
            // 
            this.quantity_TextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quantity_TextBox.Location = new System.Drawing.Point(39, 275);
            this.quantity_TextBox.Name = "quantity_TextBox";
            this.quantity_TextBox.Size = new System.Drawing.Size(138, 29);
            this.quantity_TextBox.TabIndex = 3;
            this.quantity_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.quantity_TextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.darabszam_TextBox_KeyUp);
            // 
            // nev_label
            // 
            this.nev_label.AutoSize = true;
            this.nev_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nev_label.Location = new System.Drawing.Point(39, 152);
            this.nev_label.Name = "nev_label";
            this.nev_label.Size = new System.Drawing.Size(45, 21);
            this.nev_label.TabIndex = 11;
            this.nev_label.Text = "Név*";
            // 
            // cikkszam_label
            // 
            this.cikkszam_label.AutoSize = true;
            this.cikkszam_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cikkszam_label.Location = new System.Drawing.Point(682, 152);
            this.cikkszam_label.Name = "cikkszam_label";
            this.cikkszam_label.Size = new System.Drawing.Size(83, 21);
            this.cikkszam_label.TabIndex = 12;
            this.cikkszam_label.Text = "Cikkszám*";
            // 
            // vonalkod_label
            // 
            this.vonalkod_label.AutoSize = true;
            this.vonalkod_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vonalkod_label.Location = new System.Drawing.Point(144, 350);
            this.vonalkod_label.Name = "vonalkod_label";
            this.vonalkod_label.Size = new System.Drawing.Size(75, 21);
            this.vonalkod_label.TabIndex = 17;
            this.vonalkod_label.Text = "Vonalkód";
            // 
            // marka_label
            // 
            this.marka_label.AutoSize = true;
            this.marka_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.marka_label.Location = new System.Drawing.Point(452, 151);
            this.marka_label.Name = "marka_label";
            this.marka_label.Size = new System.Drawing.Size(54, 21);
            this.marka_label.TabIndex = 14;
            this.marka_label.Text = "Márka";
            // 
            // darabszam_label
            // 
            this.darabszam_label.AutoSize = true;
            this.darabszam_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.darabszam_label.Location = new System.Drawing.Point(39, 251);
            this.darabszam_label.Name = "darabszam_label";
            this.darabszam_label.Size = new System.Drawing.Size(88, 21);
            this.darabszam_label.TabIndex = 15;
            this.darabszam_label.Text = "Darabszám";
            // 
            // beszerzesiAr_label
            // 
            this.beszerzesiAr_label.AutoSize = true;
            this.beszerzesiAr_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.beszerzesiAr_label.Location = new System.Drawing.Point(452, 251);
            this.beszerzesiAr_label.Name = "beszerzesiAr_label";
            this.beszerzesiAr_label.Size = new System.Drawing.Size(101, 21);
            this.beszerzesiAr_label.TabIndex = 13;
            this.beszerzesiAr_label.Text = "Beszerzési Ár";
            // 
            // costPrice_textBox
            // 
            this.costPrice_textBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.costPrice_textBox.Location = new System.Drawing.Point(455, 275);
            this.costPrice_textBox.Name = "costPrice_textBox";
            this.costPrice_textBox.PlaceholderText = "Ft";
            this.costPrice_textBox.Size = new System.Drawing.Size(167, 29);
            this.costPrice_textBox.TabIndex = 5;
            this.costPrice_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.costPrice_textBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.beszerzesiAr_textBox_KeyUp);
            // 
            // Mentes_Button
            // 
            this.Mentes_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Mentes_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Mentes_Button.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Mentes_Button.Location = new System.Drawing.Point(58, 32);
            this.Mentes_Button.Name = "Mentes_Button";
            this.Mentes_Button.Size = new System.Drawing.Size(95, 64);
            this.Mentes_Button.TabIndex = 9;
            this.Mentes_Button.Text = "Mentés";
            this.Mentes_Button.UseVisualStyleBackColor = true;
            this.Mentes_Button.Click += new System.EventHandler(this.Mentes_Button_Click);
            // 
            // Elvetes_Button
            // 
            this.Elvetes_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Elvetes_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Elvetes_Button.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Elvetes_Button.Location = new System.Drawing.Point(205, 32);
            this.Elvetes_Button.Name = "Elvetes_Button";
            this.Elvetes_Button.Size = new System.Drawing.Size(95, 64);
            this.Elvetes_Button.TabIndex = 10;
            this.Elvetes_Button.Text = "Elvetés";
            this.Elvetes_Button.UseVisualStyleBackColor = true;
            // 
            // minQuantity_textBox
            // 
            this.minQuantity_textBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minQuantity_textBox.Location = new System.Drawing.Point(222, 275);
            this.minQuantity_textBox.Name = "minQuantity_textBox";
            this.minQuantity_textBox.PlaceholderText = "0";
            this.minQuantity_textBox.Size = new System.Drawing.Size(160, 29);
            this.minQuantity_textBox.TabIndex = 4;
            this.minQuantity_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.minQuantity_textBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.minDarabszam_textBox_KeyUp);
            // 
            // minDarabszam_label
            // 
            this.minDarabszam_label.AutoSize = true;
            this.minDarabszam_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minDarabszam_label.Location = new System.Drawing.Point(222, 251);
            this.minDarabszam_label.Name = "minDarabszam_label";
            this.minDarabszam_label.Size = new System.Drawing.Size(160, 21);
            this.minDarabszam_label.TabIndex = 16;
            this.minDarabszam_label.Text = "Minimum Darabszám";
            // 
            // befejezes_Button
            // 
            this.befejezes_Button.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.befejezes_Button.Location = new System.Drawing.Point(353, 32);
            this.befejezes_Button.Name = "befejezes_Button";
            this.befejezes_Button.Size = new System.Drawing.Size(95, 64);
            this.befejezes_Button.TabIndex = 11;
            this.befejezes_Button.Text = "Befejezés";
            this.befejezes_Button.UseVisualStyleBackColor = true;
            this.befejezes_Button.Click += new System.EventHandler(this.befejezes_Button_Click);
            // 
            // sellPrice_Textbox
            // 
            this.sellPrice_Textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sellPrice_Textbox.Location = new System.Drawing.Point(682, 275);
            this.sellPrice_Textbox.Name = "sellPrice_Textbox";
            this.sellPrice_Textbox.PlaceholderText = "Ft";
            this.sellPrice_Textbox.Size = new System.Drawing.Size(167, 29);
            this.sellPrice_Textbox.TabIndex = 6;
            this.sellPrice_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sellPrice_Textbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.eladasiAr_Textbox_KeyUp);
            // 
            // eladasiAr_label
            // 
            this.eladasiAr_label.AutoSize = true;
            this.eladasiAr_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eladasiAr_label.Location = new System.Drawing.Point(679, 251);
            this.eladasiAr_label.Name = "eladasiAr_label";
            this.eladasiAr_label.Size = new System.Drawing.Size(78, 21);
            this.eladasiAr_label.TabIndex = 19;
            this.eladasiAr_label.Text = "Eladási Ár";
            // 
            // manufacturer_comboBox
            // 
            this.manufacturer_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.manufacturer_comboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.manufacturer_comboBox.FormattingEnabled = true;
            this.manufacturer_comboBox.Location = new System.Drawing.Point(455, 176);
            this.manufacturer_comboBox.MaxDropDownItems = 12;
            this.manufacturer_comboBox.Name = "manufacturer_comboBox";
            this.manufacturer_comboBox.Size = new System.Drawing.Size(170, 29);
            this.manufacturer_comboBox.TabIndex = 1;
            // 
            // AddItemPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(899, 454);
            this.Controls.Add(this.manufacturer_comboBox);
            this.Controls.Add(this.sellPrice_Textbox);
            this.Controls.Add(this.eladasiAr_label);
            this.Controls.Add(this.befejezes_Button);
            this.Controls.Add(this.minDarabszam_label);
            this.Controls.Add(this.minQuantity_textBox);
            this.Controls.Add(this.Elvetes_Button);
            this.Controls.Add(this.Mentes_Button);
            this.Controls.Add(this.costPrice_textBox);
            this.Controls.Add(this.beszerzesiAr_label);
            this.Controls.Add(this.darabszam_label);
            this.Controls.Add(this.marka_label);
            this.Controls.Add(this.vonalkod_label);
            this.Controls.Add(this.cikkszam_label);
            this.Controls.Add(this.nev_label);
            this.Controls.Add(this.quantity_TextBox);
            this.Controls.Add(this.barcode_textBox);
            this.Controls.Add(this.itemNumber_TextBox);
            this.Controls.Add(this.name_TextBox);
            this.Controls.Add(this.VonalkodBeolvas_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddItemPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Új Termék";
            this.Load += new System.EventHandler(this.AddItemPopup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button VonalkodBeolvas_Button;
        private System.Windows.Forms.TextBox name_TextBox;
        private System.Windows.Forms.TextBox itemNumber_TextBox;
        private System.Windows.Forms.TextBox barcode_textBox;
        private System.Windows.Forms.TextBox quantity_TextBox;
        private System.Windows.Forms.Label nev_label;
        private System.Windows.Forms.Label cikkszam_label;
        private System.Windows.Forms.Label vonalkod_label;
        private System.Windows.Forms.Label marka_label;
        private System.Windows.Forms.Label darabszam_label;
        private System.Windows.Forms.Label beszerzesiAr_label;
        private System.Windows.Forms.TextBox costPrice_textBox;
        private System.Windows.Forms.Button Mentes_Button;
        private System.Windows.Forms.Button Elvetes_Button;
        private System.Windows.Forms.TextBox minQuantity_textBox;
        private System.Windows.Forms.Label minDarabszam_label;
        private System.Windows.Forms.Button befejezes_Button;
        private System.Windows.Forms.TextBox sellPrice_Textbox;
        private System.Windows.Forms.Label eladasiAr_label;
        private System.Windows.Forms.ComboBox manufacturer_comboBox;
    }
}