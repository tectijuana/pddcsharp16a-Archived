namespace SINGLETON
{
    partial class Pruebas
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pRUEBASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conSingletonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinSingletonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pRUEBASToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pRUEBASToolStripMenuItem
            // 
            this.pRUEBASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conSingletonToolStripMenuItem,
            this.sinSingletonToolStripMenuItem});
            this.pRUEBASToolStripMenuItem.Name = "pRUEBASToolStripMenuItem";
            this.pRUEBASToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.pRUEBASToolStripMenuItem.Text = "PRUEBAS";

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
            this.sinSingletonToolStripMenuItem.Text = "sin Singleton";
            this.sinSingletonToolStripMenuItem.Click += new System.EventHandler(this.sinSingletonToolStripMenuItem_Click);
            // 
            // Pruebas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Pruebas";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pRUEBASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conSingletonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinSingletonToolStripMenuItem;
    }
}

