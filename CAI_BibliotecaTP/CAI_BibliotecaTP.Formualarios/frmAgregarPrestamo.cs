using CAI_BibliotecaTP.Entidades;
using CAI_BibliotecaTP.Entidades.Entidades;
using CAI_BibliotecaTP.Negocio.Exceptions;
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
            numPlazo.Value = 1;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarClientes()
        {
            List<Cliente> lst = _clienteServicio.TraerClientes();

            cbxCliente.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach (Cliente A in lst)
            {
                if (A.Activo) // TRAIGO SOLO CLIENTES ACTIVOS
                {
                    cbxCliente.Items.Add(A.Dni + " - " + A.Nombre + " - " + A.Apellido);
                }
            }
        }

        private void btnAgregarPrestamo_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxCliente.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un cliente");
                }
                else
                {
                    var obj = cbxCliente.SelectedItem;

                    string[] idv = obj.ToString().Split('-');

                    int dni = Convert.ToInt32(idv[0]);

                    Cliente C = _clienteServicio.TraerClientePorDNI(dni);

                    int _idCliente = C.Id;

                    string _STRejemplar = txtEjemplar.Text;
                    int _ejemplar = 0;
                    string _STRplazo = numPlazo.Value.ToString();
                    int _plazo = 0;
                    DateTime fechaalta = dateFechaAlta.Value;
                    DateTime fechatentantiva = dateFechaDevTentativa.Value;
                    DateTime fechabaja = DateTime.Now;

                    bool _abierto = true;

                    string msj = "";

                    msj += Validaciones.ValidarNumero(_STRejemplar, "Ejemplar", ref _ejemplar);
                    msj += Validaciones.ValidarPlazo(_STRplazo, "Plazo", ref _plazo);

                    if (!string.IsNullOrWhiteSpace(msj))
                    {
                        MessageBox.Show(msj, "ERRORES");
                    }
                    else if (fechaalta > DateTime.Now)
                    {
                        throw new FechaFuturaException();
                    }
                    else
                    {
                        Prestamo P = new Prestamo(_idCliente, _ejemplar, _plazo, _abierto, fechaalta, fechatentantiva, fechabaja);

                        int id = _prestamoServicio.InsertarPrestamo(P);

                        MessageBox.Show("Se agrego el prestamo con ID: " + id.ToString(), "Mensaje del Sistema");
                        LimpiarBotones();
                    }

                }
            }
            catch(FechaFuturaException ee)
            {
                MessageBox.Show(ee.Message, "Mensaje del Sistema");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimpiarBotones()
        {
            cbxCliente.SelectedIndex = -1;
            txtEjemplar.Clear();
            numPlazo.Value = 0;
        }
        private void btnEjemplar_Click(object sender, EventArgs e)
        {
            frmSeleccionEjemplar Seleccion = new frmSeleccionEjemplar();
            AddOwnedForm(Seleccion);
            Seleccion.Owner = this;  //le dice que este formulario es el propietario
            Seleccion.Show(); // abre el otro formulario
        }

        private void numPlazo_ValueChanged(object sender, EventArgs e)
        {
            dateFechaDevTentativa.Value = dateFechaAlta.Value.AddDays(Convert.ToDouble(numPlazo.Value));
        }

        private void dateFechaAlta_ValueChanged(object sender, EventArgs e)
        {
            dateFechaDevTentativa.Value = dateFechaAlta.Value.AddDays(Convert.ToDouble(numPlazo.Value));

        }
    }
}
