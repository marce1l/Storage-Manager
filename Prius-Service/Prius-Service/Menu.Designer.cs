
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adatok_StripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.importálásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportálásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Settings_StripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.rosszVonalkodOlvaso_Setting = new System.Windows.Forms.ToolStripMenuItem();
            this.Help_StripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.About_StripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_statusStrip = new System.Windows.Forms.StatusStrip();
            this.alwaysOnToolTip = new System.Windows.Forms.ToolStripStatusLabel();
            this.time_label = new System.Windows.Forms.ToolStripStatusLabel();
            this.AddItem_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.keresesVonalkod_Button = new System.Windows.Forms.Button();
            this.raktarListazas_Button = new System.Windows.Forms.Button();
            this.omlesztettBe_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.omlesztettKi_button = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.menu_statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Be_Button
            // 
            this.Be_Button.BackColor = System.Drawing.Color.Lime;
            this.Be_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.Be_Button, "Be_Button");
            this.Be_Button.Name = "Be_Button";
            this.Be_Button.UseVisualStyleBackColor = false;
            this.Be_Button.Click += new System.EventHandler(this.Be_Button_Click);
            // 
            // Ki_Button
            // 
            this.Ki_Button.BackColor = System.Drawing.Color.Red;
            this.Ki_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.Ki_Button, "Ki_Button");
            this.Ki_Button.Name = "Ki_Button";
            this.Ki_Button.UseVisualStyleBackColor = false;
            this.Ki_Button.Click += new System.EventHandler(this.Ki_Button_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adatok_StripMenu,
            this.Settings_StripMenu,
            this.Help_StripMenu,
            this.About_StripMenu});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // adatok_StripMenu
            // 
            this.adatok_StripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importálásToolStripMenuItem,
            this.exportálásToolStripMenuItem});
            this.adatok_StripMenu.Name = "adatok_StripMenu";
            resources.ApplyResources(this.adatok_StripMenu, "adatok_StripMenu");
            // 
            // importálásToolStripMenuItem
            // 
            this.importálásToolStripMenuItem.Name = "importálásToolStripMenuItem";
            resources.ApplyResources(this.importálásToolStripMenuItem, "importálásToolStripMenuItem");
            // 
            // exportálásToolStripMenuItem
            // 
            this.exportálásToolStripMenuItem.Name = "exportálásToolStripMenuItem";
            resources.ApplyResources(this.exportálásToolStripMenuItem, "exportálásToolStripMenuItem");
            // 
            // Settings_StripMenu
            // 
            this.Settings_StripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rosszVonalkodOlvaso_Setting});
            this.Settings_StripMenu.Name = "Settings_StripMenu";
            resources.ApplyResources(this.Settings_StripMenu, "Settings_StripMenu");
            // 
            // rosszVonalkodOlvaso_Setting
            // 
            this.rosszVonalkodOlvaso_Setting.CheckOnClick = true;
            this.rosszVonalkodOlvaso_Setting.Name = "rosszVonalkodOlvaso_Setting";
            resources.ApplyResources(this.rosszVonalkodOlvaso_Setting, "rosszVonalkodOlvaso_Setting");
            this.rosszVonalkodOlvaso_Setting.CheckedChanged += new System.EventHandler(this.rosszVonalkodOlvaso_Setting_CheckedChanged);
            // 
            // Help_StripMenu
            // 
            this.Help_StripMenu.Name = "Help_StripMenu";
            resources.ApplyResources(this.Help_StripMenu, "Help_StripMenu");
            // 
            // About_StripMenu
            // 
            this.About_StripMenu.Name = "About_StripMenu";
            resources.ApplyResources(this.About_StripMenu, "About_StripMenu");
            // 
            // menu_statusStrip
            // 
            resources.ApplyResources(this.menu_statusStrip, "menu_statusStrip");
            this.menu_statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alwaysOnToolTip,
            this.time_label});
            this.menu_statusStrip.Name = "menu_statusStrip";
            this.menu_statusStrip.SizingGrip = false;
            // 
            // alwaysOnToolTip
            // 
            resources.ApplyResources(this.alwaysOnToolTip, "alwaysOnToolTip");
            this.alwaysOnToolTip.Name = "alwaysOnToolTip";
            // 
            // time_label
            // 
            resources.ApplyResources(this.time_label, "time_label");
            this.time_label.Name = "time_label";
            this.time_label.Spring = true;
            // 
            // AddItem_Button
            // 
            this.AddItem_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.AddItem_Button, "AddItem_Button");
            this.AddItem_Button.Name = "AddItem_Button";
            this.AddItem_Button.UseVisualStyleBackColor = true;
            this.AddItem_Button.Click += new System.EventHandler(this.AddItem_Button_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // keresesVonalkod_Button
            // 
            resources.ApplyResources(this.keresesVonalkod_Button, "keresesVonalkod_Button");
            this.keresesVonalkod_Button.Name = "keresesVonalkod_Button";
            this.keresesVonalkod_Button.UseVisualStyleBackColor = true;
            this.keresesVonalkod_Button.Click += new System.EventHandler(this.keresesVonalkod_Button_Click);
            // 
            // raktarListazas_Button
            // 
            resources.ApplyResources(this.raktarListazas_Button, "raktarListazas_Button");
            this.raktarListazas_Button.Name = "raktarListazas_Button";
            this.raktarListazas_Button.UseVisualStyleBackColor = true;
            this.raktarListazas_Button.Click += new System.EventHandler(this.raktarListazas_Button_Click);
            // 
            // omlesztettBe_button
            // 
            resources.ApplyResources(this.omlesztettBe_button, "omlesztettBe_button");
            this.omlesztettBe_button.Name = "omlesztettBe_button";
            this.omlesztettBe_button.UseVisualStyleBackColor = true;
            this.omlesztettBe_button.Click += new System.EventHandler(this.omlesztettBe_button_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // omlesztettKi_button
            // 
            resources.ApplyResources(this.omlesztettKi_button, "omlesztettKi_button");
            this.omlesztettKi_button.Name = "omlesztettKi_button";
            this.omlesztettKi_button.UseVisualStyleBackColor = true;
            this.omlesztettKi_button.Click += new System.EventHandler(this.omlesztettKi_button_Click);
            // 
            // Menu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.omlesztettKi_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.omlesztettBe_button);
            this.Controls.Add(this.raktarListazas_Button);
            this.Controls.Add(this.keresesVonalkod_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddItem_Button);
            this.Controls.Add(this.menu_statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Ki_Button);
            this.Controls.Add(this.Be_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menu_statusStrip.ResumeLayout(false);
            this.menu_statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Be_Button;
        private System.Windows.Forms.Button Ki_Button;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Settings_StripMenu;
        private System.Windows.Forms.ToolStripMenuItem Help_StripMenu;
        private System.Windows.Forms.ToolStripMenuItem About_StripMenu;
        private System.Windows.Forms.StatusStrip menu_statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel alwaysOnToolTip;
        private System.Windows.Forms.ToolStripStatusLabel time_label;
        private System.Windows.Forms.Button AddItem_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button keresesVonalkod_Button;
        private System.Windows.Forms.Button raktarListazas_Button;
        private System.Windows.Forms.Button omlesztettBe_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem adatok_StripMenu;
        private System.Windows.Forms.ToolStripMenuItem importálásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportálásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rosszVonalkodOlvaso_Setting;
        private System.Windows.Forms.Button omlesztettKi_button;
    }
}

