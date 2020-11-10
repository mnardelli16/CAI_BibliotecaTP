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

    public partial class frmAgregarEjemplar : Form
    {
        private EjemplarServicio _ejemplarSerivicio;
        private LibroServicio _libroServicio;
        private List<Libro> _listaLibros;
        public frmAgregarEjemplar()
        {
            InitializeComponent();
            _ejemplarSerivicio = new EjemplarServicio();
            _libroServicio = new LibroServicio();
            CargarLibrosEnCombo();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarLibrosEnCombo()
        {
            _listaLibros = _libroServicio.TraerTodosLosLibros();

            foreach (Libro A in _listaLibros)
            {
                cbxLibro.Items.Add(A.Id + " - " + A.Titulo);
            }
        }

        private void btnAgregarEjemplares_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxLibro.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un libro");
                }
                else
                {
                    var obj = cbxLibro.SelectedItem;
                    string[] idv = obj.ToString().Split('-');
                    int _idLibro = Convert.ToInt32(idv[0]);

                    string _observaciones = txtObservaciones.Text;
                    string _STRprecio = txtPrecio.Text;
                    double _precio = 0;
                    string _fechaAlta = dateFechaAlta.Text;

                    string msj = "";



                    msj += Validaciones.ValidarSTRING(_observaciones, "Observaciones");
                    msj += Validaciones.ValidarPrecio(_STRprecio, "Precio", ref _precio);

                    if (!string.IsNullOrWhiteSpace(msj))
                    {
                        MessageBox.Show(msj, "ERRORES");
                    }
                    else
                    {
                        Ejemplar E = new Ejemplar(_idLibro, _observaciones, _precio, Convert.ToDateTime(_fechaAlta));

                        int id = _ejemplarSerivicio.InsertarEjemplar(E);
                        MessageBox.Show("Se agrego el ejemplar con ID: " + id.ToString(), "Mensaje del Sistema");
                        LimpiarBotones();
                    }
                }

            }
            catch(Exception ef)
            {
                MessageBox.Show(ef.Message);
            }
        }

        private void LimpiarBotones()
        {
            cbxLibro.SelectedIndex = -1;
            txtObservaciones.Clear();
            txtPrecio.Clear();
        }
    }
}
