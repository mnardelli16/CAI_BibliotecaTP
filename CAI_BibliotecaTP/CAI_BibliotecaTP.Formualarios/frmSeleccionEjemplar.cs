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
        LibroServicio _libroServicio;
        public frmSeleccionEjemplar()
        {
            InitializeComponent();
            _ejemplarServicio = new EjemplarServicio();
            _libroServicio = new LibroServicio();
            CargarEjemplares();
        }


        private void CargarEjemplares()
        {
            List<Ejemplar> ejemplar = _ejemplarServicio.TraerEjemplares();

            dgvMostrarEjemplares.Columns.Add("id", "ID EJEMPLAR");   
            dgvMostrarEjemplares.Columns.Add("idLibro", "LIBRO");    
            dgvMostrarEjemplares.Columns.Add("observaciones", "OBSERVACIONES");
            dgvMostrarEjemplares.Columns.Add("precio", "PRECIO");
            dgvMostrarEjemplares.Columns.Add("fechaalta", "FECHA ALTA");

            foreach (Ejemplar c in ejemplar)
            {
                dgvMostrarEjemplares.Rows.Add(c.Id, TraerLibroPorID(c.IdLibro), c.Observaciones, c.Precio, c.FechaAlta);
            }

        }

        private string TraerLibroPorID(int id)
        {
            Libro L = _libroServicio.TraerLibroPorID(id);
            string msj;

            if(L is null)
            {
                return msj = "";
            }
            else
            {
                return msj = L.Titulo;
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
