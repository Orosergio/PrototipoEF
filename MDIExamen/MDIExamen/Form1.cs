using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVista;
using CapaVistaSeguridad;

namespace MDIExamen
{
    public partial class Form1 : Form
    {
        clsFuncionesSeguridad seguridad = new clsFuncionesSeguridad();
        clsVistaBitacora bit = new clsVistaBitacora();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void iNICIOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void monedaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (seguridad.PermisosAcceso("1303", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso a la aplicacion Tipo de moneda", 1303);
                TipoMoneda frm = new TipoMoneda(txtUsuario.Text, this);
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar a la aplicacion Cuenta Bancaria", 1305);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtUsuario.Text = frm.usuario();
            }
            

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmCambioContraseña cambioContraseña = new frmCambioContraseña(txtUsuario.Text);
            cambioContraseña.MdiParent = this;
            cambioContraseña.Show();
        }

        private void bancosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
