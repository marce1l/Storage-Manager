
namespace Prius_Service
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.Be_Button = new System.Windows.Forms.Button();
            this.Ki_Button = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.adatok_StripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.importalas_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportalas_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Settings_StripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.rosszVonalkodOlvaso_Setting = new System.Windows.Forms.ToolStripMenuItem();
            this.Help_StripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.About_StripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_statusStrip = new System.Windows.Forms.StatusStrip();
            this.alwaysOnToolTip = new System.Windows.Forms.ToolStripStatusLabel();
            this.time_label = new System.Windows.Forms.ToolStripStatusLabel();
            this.AddItem_Button = new System.Windows.Forms.Button();
            this.keresesVonalkod_Button = new System.Windows.Forms.Button();
            this.raktarListazas_Button = new System.Windows.Forms.Button();
            this.omlesztettBe_button = new System.Windows.Forms.Button();
            this.ertesitesek_label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.omlesztettKi_button = new System.Windows.Forms.Button();
            this.ertesitesek_richTextBox = new System.Windows.Forms.RichTextBox();
            this.tLabel = new Prius_Service.TransparentLabel();
            this.menuStrip.SuspendLayout();
            this.menu_statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Be_Button
            // 
            this.Be_Button.BackColor = System.Drawing.Color.Lime;
            this.Be_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Be_Button.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Be_Button.Location = new System.Drawing.Point(149, 275);
            this.Be_Button.Name = "Be_Button";
            this.Be_Button.Size = new System.Drawing.Size(223, 185);
            this.Be_Button.TabIndex = 4;
            this.Be_Button.Text = "Bevitel";
            this.Be_Button.UseVisualStyleBackColor = false;
            this.Be_Button.Click += new System.EventHandler(this.Be_Button_Click);
            // 
            // Ki_Button
            // 
            this.Ki_Button.BackColor = System.Drawing.Color.Red;
            this.Ki_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ki_Button.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ki_Button.Location = new System.Drawing.Point(501, 275);
            this.Ki_Button.Name = "Ki_Button";
            this.Ki_Button.Size = new System.Drawing.Size(232, 182);
            this.Ki_Button.TabIndex = 5;
            this.Ki_Button.Text = "Kivitel";
            this.Ki_Button.UseVisualStyleBackColor = false;
            this.Ki_Button.Click += new System.EventHandler(this.Ki_Button_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adatok_StripMenu,
            this.Settings_StripMenu,
            this.Help_StripMenu,
            this.About_StripMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1229, 25);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip";
            // 
            // adatok_StripMenu
            // 
            this.adatok_StripMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.adatok_StripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importalas_ToolStripMenuItem,
            this.exportalas_ToolStripMenuItem});
            this.adatok_StripMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.adatok_StripMenu.Name = "adatok_StripMenu";
            this.adatok_StripMenu.Size = new System.Drawing.Size(61, 21);
            this.adatok_StripMenu.Text = "Adatok";
            // 
            // importalas_ToolStripMenuItem
            // 
            this.importalas_ToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.importalas_ToolStripMenuItem.Enabled = false;
            this.importalas_ToolStripMenuItem.Name = "importalas_ToolStripMenuItem";
            this.importalas_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importalas_ToolStripMenuItem.Text = "Importálás";
            this.importalas_ToolStripMenuItem.Click += new System.EventHandler(this.importalas_ToolStripMenuItem_Click);
            // 
            // exportalas_ToolStripMenuItem
            // 
            this.exportalas_ToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.exportalas_ToolStripMenuItem.Name = "exportalas_ToolStripMenuItem";
            this.exportalas_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportalas_ToolStripMenuItem.Text = "Exportálás";
            this.exportalas_ToolStripMenuItem.Click += new System.EventHandler(this.exportalas_ToolStripMenuItem_Click);
            // 
            // Settings_StripMenu
            // 
            this.Settings_StripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rosszVonalkodOlvaso_Setting});
            this.Settings_StripMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Settings_StripMenu.Name = "Settings_StripMenu";
            this.Settings_StripMenu.Size = new System.Drawing.Size(81, 21);
            this.Settings_StripMenu.Text = "Beállítások";
            this.Settings_StripMenu.ToolTipText = "Beállítások";
            // 
            // rosszVonalkodOlvaso_Setting
            // 
            this.rosszVonalkodOlvaso_Setting.CheckOnClick = true;
            this.rosszVonalkodOlvaso_Setting.Name = "rosszVonalkodOlvaso_Setting";
            this.rosszVonalkodOlvaso_Setting.Size = new System.Drawing.Size(209, 22);
            this.rosszVonalkodOlvaso_Setting.Text = "Rossz vonalkód olvasó";
            this.rosszVonalkodOlvaso_Setting.CheckedChanged += new System.EventHandler(this.rosszVonalkodOlvaso_Setting_CheckedChanged);
            // 
            // Help_StripMenu
            // 
            this.Help_StripMenu.Enabled = false;
            this.Help_StripMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Help_StripMenu.Name = "Help_StripMenu";
            this.Help_StripMenu.Size = new System.Drawing.Size(50, 21);
            this.Help_StripMenu.Text = "Sugó";
            this.Help_StripMenu.ToolTipText = "Súgó";
            // 
            // About_StripMenu
            // 
            this.About_StripMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.About_StripMenu.Name = "About_StripMenu";
            this.About_StripMenu.Size = new System.Drawing.Size(67, 21);
            this.About_StripMenu.Text = "Névjegy";
            this.About_StripMenu.ToolTipText = "Névjegy";
            this.About_StripMenu.Click += new System.EventHandler(this.About_StripMenu_Click);
            // 
            // menu_statusStrip
            // 
            this.menu_statusStrip.AutoSize = false;
            this.menu_statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alwaysOnToolTip,
            this.time_label});
            this.menu_statusStrip.Location = new System.Drawing.Point(0, 581);
            this.menu_statusStrip.Name = "menu_statusStrip";
            this.menu_statusStrip.Size = new System.Drawing.Size(1229, 38);
            this.menu_statusStrip.SizingGrip = false;
            this.menu_statusStrip.TabIndex = 0;
            // 
            // alwaysOnToolTip
            // 
            this.alwaysOnToolTip.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.alwaysOnToolTip.Name = "alwaysOnToolTip";
            this.alwaysOnToolTip.Size = new System.Drawing.Size(0, 33);
            // 
            // time_label
            // 
            this.time_label.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.time_label.Name = "time_label";
            this.time_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.time_label.Size = new System.Drawing.Size(1214, 33);
            this.time_label.Spring = true;
            this.time_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddItem_Button
            // 
            this.AddItem_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddItem_Button.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddItem_Button.Location = new System.Drawing.Point(30, 110);
            this.AddItem_Button.Name = "AddItem_Button";
            this.AddItem_Button.Size = new System.Drawing.Size(123, 86);
            this.AddItem_Button.TabIndex = 1;
            this.AddItem_Button.Text = "Új termék";
            this.AddItem_Button.UseVisualStyleBackColor = true;
            this.AddItem_Button.Click += new System.EventHandler(this.AddItem_Button_Click);
            // 
            // keresesVonalkod_Button
            // 
            this.keresesVonalkod_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.keresesVonalkod_Button.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.keresesVonalkod_Button.Location = new System.Drawing.Point(197, 110);
            this.keresesVonalkod_Button.Name = "keresesVonalkod_Button";
            this.keresesVonalkod_Button.Size = new System.Drawing.Size(123, 86);
            this.keresesVonalkod_Button.TabIndex = 2;
            this.keresesVonalkod_Button.Text = "Keresés vonalkód alapján";
            this.keresesVonalkod_Button.UseVisualStyleBackColor = true;
            this.keresesVonalkod_Button.Click += new System.EventHandler(this.keresesVonalkod_Button_Click);
            // 
            // raktarListazas_Button
            // 
            this.raktarListazas_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.raktarListazas_Button.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.raktarListazas_Button.Location = new System.Drawing.Point(717, 110);
            this.raktarListazas_Button.Name = "raktarListazas_Button";
            this.raktarListazas_Button.Size = new System.Drawing.Size(123, 86);
            this.raktarListazas_Button.TabIndex = 3;
            this.raktarListazas_Button.Text = "Raktár listázása";
            this.raktarListazas_Button.UseVisualStyleBackColor = true;
            this.raktarListazas_Button.Click += new System.EventHandler(this.raktarListazas_Button_Click);
            // 
            // omlesztettBe_button
            // 
            this.omlesztettBe_button.Enabled = false;
            this.omlesztettBe_button.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.omlesztettBe_button.Location = new System.Drawing.Point(373, 110);
            this.omlesztettBe_button.Name = "omlesztettBe_button";
            this.omlesztettBe_button.Size = new System.Drawing.Size(123, 86);
            this.omlesztettBe_button.TabIndex = 8;
            this.omlesztettBe_button.Text = "Ömlesztett Bevitel";
            this.omlesztettBe_button.UseVisualStyleBackColor = true;
            this.omlesztettBe_button.Click += new System.EventHandler(this.omlesztettBe_button_Click);
            // 
            // ertesitesek_label
            // 
            this.ertesitesek_label.AutoSize = true;
            this.ertesitesek_label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ertesitesek_label.Location = new System.Drawing.Point(1004, 50);
            this.ertesitesek_label.Name = "ertesitesek_label";
            this.ertesitesek_label.Size = new System.Drawing.Size(101, 25);
            this.ertesitesek_label.TabIndex = 10;
            this.ertesitesek_label.Text = "Értesítések";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // omlesztettKi_button
            // 
            this.omlesztettKi_button.Enabled = false;
            this.omlesztettKi_button.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.omlesztettKi_button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.omlesztettKi_button.Location = new System.Drawing.Point(543, 110);
            this.omlesztettKi_button.Name = "omlesztettKi_button";
            this.omlesztettKi_button.Size = new System.Drawing.Size(123, 86);
            this.omlesztettKi_button.TabIndex = 9;
            this.omlesztettKi_button.Text = "Ömlesztett Kivitel";
            this.omlesztettKi_button.UseVisualStyleBackColor = true;
            this.omlesztettKi_button.Click += new System.EventHandler(this.omlesztettKi_button_Click);
            // 
            // ertesitesek_richTextBox
            // 
            this.ertesitesek_richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ertesitesek_richTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.ertesitesek_richTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ertesitesek_richTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ertesitesek_richTextBox.Location = new System.Drawing.Point(897, 110);
            this.ertesitesek_richTextBox.Name = "ertesitesek_richTextBox";
            this.ertesitesek_richTextBox.ReadOnly = true;
            this.ertesitesek_richTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.ertesitesek_richTextBox.Size = new System.Drawing.Size(332, 468);
            this.ertesitesek_richTextBox.TabIndex = 12;
            this.ertesitesek_richTextBox.TabStop = false;
            this.ertesitesek_richTextBox.Text = "";
            // 
            // tLabel
            // 
            this.tLabel.Location = new System.Drawing.Point(862, 96);
            this.tLabel.Name = "tLabel";
            this.tLabel.Size = new System.Drawing.Size(346, 499);
            this.tLabel.TabIndex = 13;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1229, 619);
            this.Controls.Add(this.tLabel);
            this.Controls.Add(this.ertesitesek_richTextBox);
            this.Controls.Add(this.omlesztettKi_button);
            this.Controls.Add(this.ertesitesek_label);
            this.Controls.Add(this.omlesztettBe_button);
            this.Controls.Add(this.raktarListazas_Button);
            this.Controls.Add(this.keresesVonalkod_Button);
            this.Controls.Add(this.AddItem_Button);
            this.Controls.Add(this.menu_statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.Ki_Button);
            this.Controls.Add(this.Be_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raktár Program";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.menu_statusStrip.ResumeLayout(false);
            this.menu_statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Be_Button;
        private System.Windows.Forms.Button Ki_Button;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem Settings_StripMenu;
        private System.Windows.Forms.ToolStripMenuItem Help_StripMenu;
        private System.Windows.Forms.ToolStripMenuItem About_StripMenu;
        private System.Windows.Forms.StatusStrip menu_statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel alwaysOnToolTip;
        private System.Windows.Forms.ToolStripStatusLabel time_label;
        private System.Windows.Forms.Button AddItem_Button;
        private System.Windows.Forms.Button keresesVonalkod_Button;
        private System.Windows.Forms.Button raktarListazas_Button;
        private System.Windows.Forms.Button omlesztettBe_button;
        private System.Windows.Forms.Label ertesitesek_label;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem adatok_StripMenu;
        private System.Windows.Forms.ToolStripMenuItem importalas_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportalas_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rosszVonalkodOlvaso_Setting;
        private System.Windows.Forms.Button omlesztettKi_button;
        private System.Windows.Forms.RichTextBox ertesitesek_richTextBox;
        private TransparentLabel tLabel;
    }
}

