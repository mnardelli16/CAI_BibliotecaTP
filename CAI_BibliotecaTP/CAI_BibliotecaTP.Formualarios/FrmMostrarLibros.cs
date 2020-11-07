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
    public partial class FrmMostrarLibros : Form
    {
        LibroServicio _libroServicio;
        List<Libro> _listaLibro;
        public FrmMostrarLibros()
        {
            InitializeComponent();
            _libroServicio = new LibroServicio();
            CargarLibrosEnLista();



        }

        private void CargarLibrosEnLista()
        {
            _listaLibro = _libroServicio.TraerTodosLosLibros();

            foreach(Libro A in _listaLibro)
            {
                lstLibros.Items.Add(A.Id + " - " + A.Titulo);
            }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstLibros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstLibros.SelectedIndex == -1)
            {
                MessageBox.Show("Debe Seleccionar un Libro", "Mensaje del sistema");
            }
            else
            {
                var obj = lstLibros.SelectedItem;

                string[] idv = obj.ToString().Split('-');

                int id = Convert.ToInt32(idv[0]);

                Libro L = BuscarLibroPorID(id);

                if (L != null)
                {
                    CompletarCampos(L);
                }
            }

        }

        private void CompletarCampos(Libro L)
        {
            txtAutor.Text = L.Autor;
            txtEdicion.Text = L.Edicion.ToString();
            txtEditorial.Text = L.Editorial;
            txtPagina.Text = L.Paginas.ToString();
            txtTema.Text = L.Tema;
        }

        private Libro BuscarLibroPorID(int id)
        {
            return _listaLibro.Find(x => x.Id == id);
        }
    }
}
