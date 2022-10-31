namespace Check_on_click
{
    partial class Form1
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
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_theme_ligth = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_theme_darck = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_theme_green = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_theme_ligth,
            this.mi_theme_darck,
            this.mi_theme_green});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.themeToolStripMenuItem.Text = "Theme";
            // 
            // mi_theme_ligth
            // 
            this.mi_theme_ligth.Checked = true;
            this.mi_theme_ligth.CheckOnClick = true;
            this.mi_theme_ligth.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mi_theme_ligth.Name = "mi_theme_ligth";
            this.mi_theme_ligth.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.mi_theme_ligth.Size = new System.Drawing.Size(184, 22);
            this.mi_theme_ligth.Text = "Light theme";
            this.mi_theme_ligth.Click += new System.EventHandler(this.mi_theme_ligth_Click);
            // 
            // mi_theme_darck
            // 
            this.mi_theme_darck.CheckOnClick = true;
            this.mi_theme_darck.Name = "mi_theme_darck";
            this.mi_theme_darck.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.mi_theme_darck.Size = new System.Drawing.Size(184, 22);
            this.mi_theme_darck.Text = "Darck theme";
            this.mi_theme_darck.Click += new System.EventHandler(this.mi_theme_darck_Click);
            // 
            // mi_theme_green
            // 
            this.mi_theme_green.CheckOnClick = true;
            this.mi_theme_green.Name = "mi_theme_green";
            this.mi_theme_green.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.mi_theme_green.Size = new System.Drawing.Size(184, 22);
            this.mi_theme_green.Text = "Green theme";
            this.mi_theme_green.Click += new System.EventHandler(this.mi_theme_green_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mi_theme_ligth;
        private System.Windows.Forms.ToolStripMenuItem mi_theme_darck;
        private System.Windows.Forms.ToolStripMenuItem mi_theme_green;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

