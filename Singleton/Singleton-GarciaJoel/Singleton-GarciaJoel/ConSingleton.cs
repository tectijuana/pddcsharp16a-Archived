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
    public partial class ConSingleton : Form
    {
        private static ConSingleton instancia = null;
        private ConSingleton()
        {
            InitializeComponent();
        }
        public static ConSingleton Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ConSingleton();
                }
                return instancia;
            }
        }
        private void ConSingleton_Load(object sender, EventArgs e)
        {
        }
    }
}