
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
            this.nev_TextBox = new System.Windows.Forms.TextBox();
            this.cikkszam_TextBox = new System.Windows.Forms.TextBox();
            this.vonalkod_textBox = new System.Windows.Forms.TextBox();
            this.marka_TextBox = new System.Windows.Forms.TextBox();
            this.darabszam_TextBox = new System.Windows.Forms.TextBox();
            this.nev_label = new System.Windows.Forms.Label();
            this.cikkszam_label = new System.Windows.Forms.Label();
            this.vonalkod_label = new System.Windows.Forms.Label();
            this.marka_label = new System.Windows.Forms.Label();
            this.darabszam_label = new System.Windows.Forms.Label();
            this.ár_label = new System.Windows.Forms.Label();
            this.ar_textBox = new System.Windows.Forms.TextBox();
            this.Mentes_Button = new System.Windows.Forms.Button();
            this.Elvetes_Button = new System.Windows.Forms.Button();
            this.minDarabszam_textBox = new System.Windows.Forms.TextBox();
            this.minDarabszam_label = new System.Windows.Forms.Label();
            this.befejezes_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VonalkodBeolvas_Button
            // 
            this.VonalkodBeolvas_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VonalkodBeolvas_Button.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VonalkodBeolvas_Button.Location = new System.Drawing.Point(722, 278);
            this.VonalkodBeolvas_Button.Name = "VonalkodBeolvas_Button";
            this.VonalkodBeolvas_Button.Size = new System.Drawing.Size(94, 62);
            this.VonalkodBeolvas_Button.TabIndex = 6;
            this.VonalkodBeolvas_Button.Text = "Beolvas";
            this.VonalkodBeolvas_Button.UseVisualStyleBackColor = true;
            this.VonalkodBeolvas_Button.Click += new System.EventHandler(this.VonalkodBeolvas_Button_Click);
            // 
            // nev_TextBox
            // 
            this.nev_TextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nev_TextBox.Location = new System.Drawing.Point(39, 176);
            this.nev_TextBox.Name = "nev_TextBox";
            this.nev_TextBox.Size = new System.Drawing.Size(167, 29);
            this.nev_TextBox.TabIndex = 0;
            // 
            // cikkszam_TextBox
            // 
            this.cikkszam_TextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cikkszam_TextBox.Location = new System.Drawing.Point(253, 176);
            this.cikkszam_TextBox.Name = "cikkszam_TextBox";
            this.cikkszam_TextBox.Size = new System.Drawing.Size(167, 29);
            this.cikkszam_TextBox.TabIndex = 1;
            // 
            // vonalkod_textBox
            // 
            this.vonalkod_textBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vonalkod_textBox.Location = new System.Drawing.Point(472, 295);
            this.vonalkod_textBox.Name = "vonalkod_textBox";
            this.vonalkod_textBox.Size = new System.Drawing.Size(167, 29);
            this.vonalkod_textBox.TabIndex = 7;
            // 
            // marka_TextBox
            // 
            this.marka_TextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.marka_TextBox.Location = new System.Drawing.Point(683, 176);
            this.marka_TextBox.Name = "marka_TextBox";
            this.marka_TextBox.Size = new System.Drawing.Size(167, 29);
            this.marka_TextBox.TabIndex = 3;
            // 
            // darabszam_TextBox
            // 
            this.darabszam_TextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.darabszam_TextBox.Location = new System.Drawing.Point(39, 295);
            this.darabszam_TextBox.Name = "darabszam_TextBox";
            this.darabszam_TextBox.Size = new System.Drawing.Size(167, 29);
            this.darabszam_TextBox.TabIndex = 4;
            this.darabszam_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.cikkszam_label.Location = new System.Drawing.Point(253, 152);
            this.cikkszam_label.Name = "cikkszam_label";
            this.cikkszam_label.Size = new System.Drawing.Size(83, 21);
            this.cikkszam_label.TabIndex = 12;
            this.cikkszam_label.Text = "Cikkszám*";
            // 
            // vonalkod_label
            // 
            this.vonalkod_label.AutoSize = true;
            this.vonalkod_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vonalkod_label.Location = new System.Drawing.Point(472, 271);
            this.vonalkod_label.Name = "vonalkod_label";
            this.vonalkod_label.Size = new System.Drawing.Size(75, 21);
            this.vonalkod_label.TabIndex = 17;
            this.vonalkod_label.Text = "Vonalkód";
            // 
            // marka_label
            // 
            this.marka_label.AutoSize = true;
            this.marka_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.marka_label.Location = new System.Drawing.Point(683, 152);
            this.marka_label.Name = "marka_label";
            this.marka_label.Size = new System.Drawing.Size(54, 21);
            this.marka_label.TabIndex = 14;
            this.marka_label.Text = "Márka";
            // 
            // darabszam_label
            // 
            this.darabszam_label.AutoSize = true;
            this.darabszam_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.darabszam_label.Location = new System.Drawing.Point(39, 271);
            this.darabszam_label.Name = "darabszam_label";
            this.darabszam_label.Size = new System.Drawing.Size(88, 21);
            this.darabszam_label.TabIndex = 15;
            this.darabszam_label.Text = "Darabszám";
            // 
            // ár_label
            // 
            this.ár_label.AutoSize = true;
            this.ár_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ár_label.Location = new System.Drawing.Point(472, 152);
            this.ár_label.Name = "ár_label";
            this.ár_label.Size = new System.Drawing.Size(26, 21);
            this.ár_label.TabIndex = 13;
            this.ár_label.Text = "Ár";
            // 
            // ar_textBox
            // 
            this.ar_textBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ar_textBox.Location = new System.Drawing.Point(472, 176);
            this.ar_textBox.Name = "ar_textBox";
            this.ar_textBox.Size = new System.Drawing.Size(167, 29);
            this.ar_textBox.TabIndex = 2;
            this.ar_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Mentes_Button
            // 
            this.Mentes_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Mentes_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Mentes_Button.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Mentes_Button.Location = new System.Drawing.Point(58, 32);
            this.Mentes_Button.Name = "Mentes_Button";
            this.Mentes_Button.Size = new System.Drawing.Size(95, 64);
            this.Mentes_Button.TabIndex = 8;
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
            this.Elvetes_Button.TabIndex = 9;
            this.Elvetes_Button.Text = "Elvetés";
            this.Elvetes_Button.UseVisualStyleBackColor = true;
            // 
            // minDarabszam_textBox
            // 
            this.minDarabszam_textBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minDarabszam_textBox.Location = new System.Drawing.Point(253, 296);
            this.minDarabszam_textBox.Name = "minDarabszam_textBox";
            this.minDarabszam_textBox.Size = new System.Drawing.Size(167, 29);
            this.minDarabszam_textBox.TabIndex = 5;
            this.minDarabszam_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // minDarabszam_label
            // 
            this.minDarabszam_label.AutoSize = true;
            this.minDarabszam_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minDarabszam_label.Location = new System.Drawing.Point(253, 271);
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
            this.befejezes_Button.TabIndex = 10;
            this.befejezes_Button.Text = "Befejezés";
            this.befejezes_Button.UseVisualStyleBackColor = true;
            this.befejezes_Button.Click += new System.EventHandler(this.befejezes_Button_Click);
            // 
            // AddItemPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(912, 375);
            this.Controls.Add(this.befejezes_Button);
            this.Controls.Add(this.minDarabszam_label);
            this.Controls.Add(this.minDarabszam_textBox);
            this.Controls.Add(this.Elvetes_Button);
            this.Controls.Add(this.Mentes_Button);
            this.Controls.Add(this.ar_textBox);
            this.Controls.Add(this.ár_label);
            this.Controls.Add(this.darabszam_label);
            this.Controls.Add(this.marka_label);
            this.Controls.Add(this.vonalkod_label);
            this.Controls.Add(this.cikkszam_label);
            this.Controls.Add(this.nev_label);
            this.Controls.Add(this.darabszam_TextBox);
            this.Controls.Add(this.marka_TextBox);
            this.Controls.Add(this.vonalkod_textBox);
            this.Controls.Add(this.cikkszam_TextBox);
            this.Controls.Add(this.nev_TextBox);
            this.Controls.Add(this.VonalkodBeolvas_Button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddItemPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Új Termék";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button VonalkodBeolvas_Button;
        private System.Windows.Forms.TextBox nev_TextBox;
        private System.Windows.Forms.TextBox cikkszam_TextBox;
        private System.Windows.Forms.TextBox vonalkod_textBox;
        private System.Windows.Forms.TextBox marka_TextBox;
        private System.Windows.Forms.TextBox darabszam_TextBox;
        private System.Windows.Forms.Label nev_label;
        private System.Windows.Forms.Label cikkszam_label;
        private System.Windows.Forms.Label vonalkod_label;
        private System.Windows.Forms.Label marka_label;
        private System.Windows.Forms.Label darabszam_label;
        private System.Windows.Forms.Label ár_label;
        private System.Windows.Forms.TextBox ar_textBox;
        private System.Windows.Forms.Button Mentes_Button;
        private System.Windows.Forms.Button Elvetes_Button;
        private System.Windows.Forms.TextBox minDarabszam_textBox;
        private System.Windows.Forms.Label minDarabszam_label;
        private System.Windows.Forms.Button befejezes_Button;
    }
}