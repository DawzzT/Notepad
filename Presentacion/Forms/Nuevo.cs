using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Forms
{
    public partial class Nuevo : Form
    {
        
        public string nombre { get; set; }
        public Nuevo()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == string.Empty )
            {
                MessageBox.Show("Ingrese un nombre");
            }
            else
            {
                nombre = textBox1.Text;
                this.Close();
            }
        }
    }
}
