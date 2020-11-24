using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;

namespace CapaVista
{
    public partial class bitaco : Form
    {
        Controlador cn = new Controlador();
        public bitaco()
        {
            InitializeComponent();
           
        }

        private void bitaco_Load(object sender, EventArgs e)
        {

        }
        public void actualizardatagriew()
        {
            DataTable dt = cn.llenarTbl("bitacora");
            dgvRegistro.DataSource = dt;

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            actualizardatagriew();
        }
    }
}
