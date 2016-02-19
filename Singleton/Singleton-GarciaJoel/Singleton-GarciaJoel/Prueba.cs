using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Singleton_GarciaJoel
{
    public partial class Pruebas : Form
    {
        public Pruebas()
        {
            InitializeComponent();
        }
        private void conSingletonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConSingleton.Instancia.Show();
        }
        private void sinSingletonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SinSingleton sinSin = new SinSingleton();
            sinSin.Show();
        }
    }
}