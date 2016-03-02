using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    public partial class Pruebas : Form
    {
        public Pruebas()
        {
            InitializeComponent();
        }

        private void conSingletonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conSingleton.Instancia.Show();
        }

        private void sinSingletonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sinSingleton sinSin = new sinSingleton();
            sinSin.Show();
        }
    }
    public partial class conSingleton : Form
    {
        private static conSingleton instancia = null;
        public conSingleton()
        {
            InitializeComponent();
        }
        public static conSingleton Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new conSingleton();
                }
                return instancia;
            }
        }
    }
    public partial class sinSingleton : Form
    {
        public sinSingleton()
        {
            InitializeComponent();
        }
    }
}