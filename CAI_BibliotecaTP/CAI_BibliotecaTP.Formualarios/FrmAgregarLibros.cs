using CAI_BibliotecaTP.Entidades.Entidades;
using CAI_BibliotecaTP.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAI_BibliotecaTP.Formualarios
{
    public partial class FrmAgregarLibros : Form
    {
        LibroServicio _libroServicio;
        public FrmAgregarLibros()
        {
            InitializeComponent();
            _libroServicio = new LibroServicio();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            try
            {
                string _titulo = txtTitulo.Text;
                string _autor = txtAutor.Text;
                string _editorial = txtEditorial.Text;
                int _edicion = 0;
                string _strEdicion = txtEdicion.Text;
                string _tema = txtTema.Text;
                int _paginas = 0;
                string _strPaginas = txtPaginas.Text;


                string msj = "";

                msj += Validaciones.ValidarSTRING(_titulo, "Titulo");
                msj += Validaciones.ValidarSTRING(_autor, "Autor");
                msj += Validaciones.ValidarSTRING(_editorial, "Editorial");
                msj += Validaciones.ValidarNumero(_strEdicion, "Edicion", ref _edicion);
                msj += Validaciones.ValidarSTRING(_tema, "Tema");
                msj += Validaciones.ValidarNumero(_strPaginas, "Paginas", ref _paginas);

                if (!string.IsNullOrWhiteSpace(msj))
                {
                    MessageBox.Show(msj, "ERRORES");
                }
                else
                {
                    Libro L = new Libro(_titulo, _autor, _edicion,_editorial, _paginas, _tema);

                    int id =_libroServicio.InsertarLibro(L);

                    MessageBox.Show("Se agrego el libro con ID: " + id.ToString(), "Mensaje del Sistema");
                    LimpiarBotones();
                }



            }
            catch(Exception xe)
            {
                MessageBox.Show(xe.Message);
                LimpiarBotones();
            }
        }

        private void LimpiarBotones()
        {
            txtAutor.Clear();
            txtEdicion.Clear();
            txtEditorial.Clear();
            txtPaginas.Clear();
            txtTema.Clear();
            txtTitulo.Clear();
        }
    }
}
