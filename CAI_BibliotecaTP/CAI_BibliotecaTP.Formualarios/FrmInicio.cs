using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAI_BibliotecaTP.Formualarios
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
            DesactivarPaneles();
            lblFechayHora.Text = DateTime.Now.ToString();
        }

        private void DesactivarPaneles()
        {
            panelClientes.Visible = false;
            panelLibros.Visible = false;
            panelPrestamos.Visible = false;
            panelEjemplares.Visible = false;
            panelReportes.Visible = false;
        }

        private void OcultarSubMenu()
        {
            if (panelClientes.Visible)
                panelClientes.Visible = false;
            if (panelLibros.Visible)
                panelLibros.Visible = false;
            if (panelPrestamos.Visible)
                panelPrestamos.Visible = false;
            if (panelEjemplares.Visible)
                panelEjemplares.Visible = false;
            if (panelReportes.Visible)
                panelReportes.Visible = false;
        }

        private void MostrarSubmenu(Panel Submenu)
        {
            if (!Submenu.Visible)
            {
                OcultarSubMenu();
                Submenu.Visible = true;
            }
            else
            {
                Submenu.Visible = false;
            }

        }

        #region MenuClientes

        private void btnClientes_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelClientes);
        }

        private void btnAgregarClientes_Click(object sender, EventArgs e)
        {

            AbrirFormularioHijo(new frmAgregarCliente());

            // OcultarSubMenu();
        }

        private void btnMostrarClientes_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new frmMostrarClientes());

            //OcultarSubMenu();
        }

        #endregion

        #region MenuPrestamos
        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelPrestamos);
        }

        private void btnAgregarPrestamo_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new frmAgregarPrestamo());

            //OcultarSubMenu();
        }

        private void bntMostrarPrestamos_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new frmMostrarPrestamos());

            //OcultarSubMenu();
        }

        #endregion

        #region MenuLibros

        private void btnLibros_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelLibros);

        }

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmAgregarLibros());

            //OcultarSubMenu();
        }

        private void btnMostrarLibro_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmMostrarLibros());

            //OcultarSubMenu();
        }

        #endregion

        #region MenuEjemplares
        private void btnEjemplares_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelEjemplares);
        }

        private void btnAgregarEjemplares_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new frmAgregarEjemplar());

            //OcultarSubMenu();
        }

        private void btnMostrarEjemplares_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new frmListarEjemplares());

            //OcultarSubMenu();
        }
        #endregion

        #region MenuReportes

        private void btnReportes_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelReportes);

        }

        private void btnReportePrestamos_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new frmReportePrestamosPorCliente());
        }

        private void btnReporteEjemplaresPorLibro_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new frmMostrarEjemplar());
        }

        #endregion

        private Form _formActivo = null;
        internal void AbrirFormularioHijo(Form hijo)
        {
            if(_formActivo != null)
            {
                _formActivo.Close();
            }
            _formActivo = hijo;
            hijo.TopLevel = false;
            hijo.FormBorderStyle = FormBorderStyle.None;
            hijo.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(hijo);
            panelContenedor.Tag = hijo;
            hijo.BringToFront();
            hijo.Show();
        }

        
    }
}
