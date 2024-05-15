using Negocio.Management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            PruebaDeConexion pruebaDeConexion = new PruebaDeConexion();

            if (pruebaDeConexion.pruebaDeConexion())
            {
                lblResultado.Text = "La conexión es correcta";
            }
            else
            {
                lblResultado.Text = "La conexión no ha sido correcta. Revise los datos";
            }
            lblResultado.Visible = true;
        }
    }
}
