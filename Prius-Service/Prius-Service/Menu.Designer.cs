
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
            this.Be_Button = new System.Windows.Forms.Button();
            this.Ki_Button = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Settings_StripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Help_StripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.About_StripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.AddItem_Button = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Be_Button
            // 
            this.Be_Button.Location = new System.Drawing.Point(287, 249);
            this.Be_Button.Name = "Be_Button";
            this.Be_Button.Size = new System.Drawing.Size(132, 117);
            this.Be_Button.TabIndex = 0;
            this.Be_Button.Text = "Bevitel";
            this.Be_Button.UseVisualStyleBackColor = true;
            // 
            // Ki_Button
            // 
            this.Ki_Button.Location = new System.Drawing.Point(586, 249);
            this.Ki_Button.Name = "Ki_Button";
            this.Ki_Button.Size = new System.Drawing.Size(132, 117);
            this.Ki_Button.TabIndex = 1;
            this.Ki_Button.Text = "Kivitel";
            this.Ki_Button.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Settings_StripMenu,
            this.Help_StripMenu,
            this.About_StripMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1022, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Settings_StripMenu
            // 
            this.Settings_StripMenu.Name = "Settings_StripMenu";
            this.Settings_StripMenu.Size = new System.Drawing.Size(75, 20);
            this.Settings_StripMenu.Text = "Beállítások";
            this.Settings_StripMenu.ToolTipText = "Beállítások";
            // 
            // Help_StripMenu
            // 
            this.Help_StripMenu.Name = "Help_StripMenu";
            this.Help_StripMenu.Size = new System.Drawing.Size(46, 20);
            this.Help_StripMenu.Text = "Sugó";
            this.Help_StripMenu.ToolTipText = "Súgó";
            // 
            // About_StripMenu
            // 
            this.About_StripMenu.Name = "About_StripMenu";
            this.About_StripMenu.Size = new System.Drawing.Size(62, 20);
            this.About_StripMenu.Text = "Névjegy";
            this.About_StripMenu.ToolTipText = "Névjegy";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 552);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1022, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // AddItem_Button
            // 
            this.AddItem_Button.Location = new System.Drawing.Point(71, 111);
            this.AddItem_Button.Name = "AddItem_Button";
            this.AddItem_Button.Size = new System.Drawing.Size(100, 71);
            this.AddItem_Button.TabIndex = 5;
            this.AddItem_Button.Text = "Új termék";
            this.AddItem_Button.UseVisualStyleBackColor = true;
            this.AddItem_Button.Click += new System.EventHandler(this.AddItem_Button_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 574);
            this.Controls.Add(this.AddItem_Button);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Ki_Button);
            this.Controls.Add(this.Be_Button);
            this.Name = "Menu";
            this.Text = "Raktár Program";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Button AddItem_Button;
    }
}

