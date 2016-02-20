using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Singleton___Cano_Aguilar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sinSIngletonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SinSingleton sinSin = new SinSingleton();
            sinSin.Show();
        }

        private void conSingletonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConSingleton.Instancia.Show();
        }
    }
}
