using CAI_BibliotecaTP.Entidades;
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
    public partial class frmAgregarCliente : Form
    {
        private ClienteServicio _clienteServicio;
        public frmAgregarCliente()
        {
            InitializeComponent();
            _clienteServicio = new ClienteServicio();
        }

        private void btnAgregarClientes_Click(object sender, EventArgs e)
        {
            try
            {
                string _STRdni = txtDNI.Text;
                int _dni = 0;
                string _nombre = txtNombre.Text;
                string _apellido = txtApellido.Text;
                string _direccion = txtDireccion.Text;
                string _email = txtEmail.Text;
                string _STRtelefono = txtTelefono.Text;
                long _telefono = 0;
                string _STRfechaNacimiento = datetimePickerNacimiento.Text;
                bool _activo = false;

                if (checkActivo.Checked)
                {
                    _activo = true;
                }

                string msj = "";

                msj += Validaciones.ValidarNumero(_STRdni, "Dni", ref _dni);
                msj += Validaciones.ValidarSTRING(_nombre, "Nombre");
                msj += Validaciones.ValidarSTRING(_apellido, "Apellido");
                msj += Validaciones.ValidarSTRING(_direccion, "Direccion");
                msj += Validaciones.ValidarSTRING(_email, "Email");
                msj += Validaciones.ValidarTelefono(_STRtelefono, "Telefono", ref _telefono);

                if (!string.IsNullOrWhiteSpace(msj))
                {
                    MessageBox.Show(msj, "ERRORES");
                }
                else
                {
                    Cliente C = new Cliente(_dni, _nombre, _apellido, _direccion, _telefono, _email, _activo, _STRfechaNacimiento);

                    int salida = _clienteServicio.InsertarCliente(C);

                    MessageBox.Show("Cliente Agregado con exito ID: " + salida, "Mensaje del sistema");
                    LimpiarBotones();

                }
            }
            catch (Exception xe)
            {
                MessageBox.Show(xe.Message);
                LimpiarBotones();
            }
        }
        private void LimpiarBotones()
        {
             txtDNI.Clear();
             txtNombre.Clear();
             txtApellido.Clear();
             txtDireccion.Clear();
             txtEmail.Clear();
             txtTelefono.Clear();
             checkActivo.Checked = false;
        }
        
    }
}
