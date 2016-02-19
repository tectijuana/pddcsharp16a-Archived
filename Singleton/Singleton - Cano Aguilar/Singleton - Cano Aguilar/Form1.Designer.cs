namespace Singleton___Cano_Aguilar
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.singletonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conSingletonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinSingletonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singletonToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // singletonToolStripMenuItem
            // 
            this.singletonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conSingletonToolStripMenuItem,
            this.sinSingletonToolStripMenuItem});
            this.singletonToolStripMenuItem.Name = "singletonToolStripMenuItem";
            this.singletonToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.singletonToolStripMenuItem.Text = "Singleton";
            // 
            // conSingletonToolStripMenuItem
            // 
            this.conSingletonToolStripMenuItem.Name = "conSingletonToolStripMenuItem";
            this.conSingletonToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.conSingletonToolStripMenuItem.Text = "Con Singleton";
            this.conSingletonToolStripMenuItem.Click += new System.EventHandler(this.conSingletonToolStripMenuItem_Click);
            // 
            // sinSingletonToolStripMenuItem
            // 
            this.sinSingletonToolStripMenuItem.Name = "sinSingletonToolStripMenuItem";
            this.sinSingletonToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sinSingletonToolStripMenuItem.Text = "Sin Singleton";
            this.sinSingletonToolStripMenuItem.Click += new System.EventHandler(this.sinSIngletonToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
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

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem singletonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conSingletonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinSingletonToolStripMenuItem;
    }
}

