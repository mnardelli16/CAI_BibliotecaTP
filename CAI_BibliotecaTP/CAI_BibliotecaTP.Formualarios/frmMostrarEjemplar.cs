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
    public partial class frmMostrarEjemplar : Form
    {
        private EjemplarServicio _ejemplarServicio;
        private LibroServicio _libroServicio;
        List<Libro> _listaLibro;
        List<Ejemplar> _listaEjemplar;
        public frmMostrarEjemplar()
        {
            InitializeComponent();
            _ejemplarServicio = new EjemplarServicio();
            _libroServicio = new LibroServicio();
            CargarEjemplares();
            CargarLibros();
        }

        private void CargarLibros()
        {
            _listaLibro = _libroServicio.TraerTodosLosLibros();

            foreach (Libro A in _listaLibro)
            {
                comboBox1.Items.Add(A.Id + " - " + A.Titulo);
            }
        }

        private void CargarEjemplares()
        {
            _listaEjemplar = _ejemplarServicio.TraerEjemplares();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvMostrarEjemplares.Columns.Clear();
            dgvMostrarEjemplares.Rows.Clear();


            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una opcion");
            }
            else
            {
                var obj = comboBox1.SelectedItem;

                string[] idv = obj.ToString().Split('-');

                int id = Convert.ToInt32(idv[0]);

                List<Ejemplar> E = BuscarEjemplarPorIdLibro(id);

                if (E != null)
                {

                    CompletarComboBox(E);

                }
            }
        }

        private List<Ejemplar> BuscarEjemplarPorIdLibro(int id)
        {
            List<Ejemplar> aux = new List<Ejemplar>();

            foreach(Ejemplar E in _listaEjemplar)
            {
                if (id == E.IdLibro)
                {
                    aux.Add(E);
                }
            }

            return aux;
        }

        private void CompletarComboBox(List<Ejemplar> E)
        {
            dgvMostrarEjemplares.Columns.Add("id", "ID EJEMPLAR");
            dgvMostrarEjemplares.Columns.Add("observaciones", "OBSERVACIONES");
            dgvMostrarEjemplares.Columns.Add("precio", "PRECIO");
            dgvMostrarEjemplares.Columns.Add("fechaalta", "FECHA ALTA");

            foreach (Ejemplar c in E)
            {
                dgvMostrarEjemplares.Rows.Add(c.Id, c.Observaciones, c.Precio, c.FechaAlta);
            }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
