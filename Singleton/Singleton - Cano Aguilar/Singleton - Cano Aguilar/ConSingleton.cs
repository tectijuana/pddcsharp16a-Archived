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
    public partial class ConSingleton : Form
    {
        public ConSingleton()
        {
            InitializeComponent();
        }

        private static ConSingleton instancia = null;

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
