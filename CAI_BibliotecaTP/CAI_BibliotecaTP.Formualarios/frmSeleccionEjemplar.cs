using CAI_BibliotecaTP.Entidades.Entidades;
using CAI_BibliotecaTP.Negocio;
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
    public partial class frmSeleccionEjemplar : Form
    {
        EjemplarServicio _ejemplarServicio;
        public frmSeleccionEjemplar()
        {
            InitializeComponent();
            _ejemplarServicio = new EjemplarServicio();
            CargarEjemplares();
        }


        private void CargarEjemplares()
        {
            List<Ejemplar> ejemplar = _ejemplarServicio.TraerEjemplares();

            dgvMostrarEjemplares.Columns.Add("id", "ID EJEMPLAR");    // FALTA ALGREGAR EL NOMBRE DEL LIBRO
            dgvMostrarEjemplares.Columns.Add("observaciones", "OBSERVACIONES");
            dgvMostrarEjemplares.Columns.Add("precio", "PRECIO");
            dgvMostrarEjemplares.Columns.Add("fechaalta", "FECHA ALTA");

            foreach (Ejemplar c in ejemplar)
            {
                dgvMostrarEjemplares.Rows.Add(c.Id, c.Observaciones, c.Precio, c.FechaAlta);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }


        private void btnSeleccionar_Click_1(object sender, EventArgs e)
        {
            frmAgregarPrestamo prestamo = Owner as frmAgregarPrestamo;

            if (dgvMostrarEjemplares.CurrentRow.Index == -1)
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
            else
            {
                prestamo.txtEjemplar.Text = dgvMostrarEjemplares.CurrentRow.Cells[0].Value.ToString();

                this.Close();
            }


        }
    }
}
