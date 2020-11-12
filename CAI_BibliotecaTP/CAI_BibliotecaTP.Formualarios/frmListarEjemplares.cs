using CAI_BibliotecaTP.Negocio;
using CAI_BibliotecaTP.Entidades.Entidades;
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
    public partial class frmListarEjemplares : Form
    {
        EjemplarServicio _ejemplarServicio;
        LibroServicio _libroServicio;
        public frmListarEjemplares()
        {
            InitializeComponent();
            _ejemplarServicio = new EjemplarServicio();
            _libroServicio = new LibroServicio();

        }


        private void CargarEjemplares()
        {
            List<Ejemplar> ejemplar = _ejemplarServicio.TraerEjemplares();

            dgvMostrarEjemplares.Columns.Add("id", "ID EJEMPLAR");    // FALTA ALGREGAR EL NOMBRE DEL LIBRO
            dgvMostrarEjemplares.Columns.Add("idLibro", "LIBRO");    // FALTA ALGREGAR EL NOMBRE DEL LIBRO
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

            if (L is null)
            {
                return msj = "";
            }
            else
            {
                return msj = L.Titulo;
            }

        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListarEjemplares_Click(object sender, EventArgs e)
        {
            bool flag = FlagListarEjemplares();

            if (flag == false)
            {
                CargarEjemplares();
            }
            else
            {
                MessageBox.Show("El listado ya esta actualizado.", "MESAJE DEL SISTEMA");
            }
        }

        private bool FlagListarEjemplares()
        {
            bool b = false;
            if (dgvMostrarEjemplares.Rows.Count != 0)
            {
                b = true;
            }
            return b;
        }
    }
}
