using CAI_BibliotecaTP.Entidades;
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
    public partial class frmAgregarPrestamo : Form
    {
        private PrestamoServicio _prestamoServicio;
        private EjemplarServicio _ejemplarServicio;
        private ClienteServicio _clienteServicio;
        public frmAgregarPrestamo()
        {
            InitializeComponent();
            _prestamoServicio = new PrestamoServicio();
            _ejemplarServicio = new EjemplarServicio();
            _clienteServicio = new ClienteServicio();
            CargarClientes();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarClientes()
        {
            List<Cliente> lst = _clienteServicio.TraerClientes();

            foreach (Cliente A in lst)
            {
                cbxCliente.Items.Add(A.Nombre + " - " + A.Apellido);
            }
        }

        private void btnAgregarPrestamo_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch
            {

            }
        }

        private void btnEjemplar_Click(object sender, EventArgs e)
        {
            frmSeleccionEjemplar Seleccion = new frmSeleccionEjemplar();
            AddOwnedForm(Seleccion);
            Seleccion.Owner = this;  //le dice que este formulario es el propietario
            Seleccion.Show(); // abre el otro formulario
        }
    }
}
