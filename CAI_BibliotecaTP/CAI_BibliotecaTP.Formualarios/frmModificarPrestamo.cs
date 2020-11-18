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
    public partial class frmModificarPrestamo : Form
    {
        PrestamoServicio _prestamoServicio;
        ClienteServicio _clienteServicio;
        private List<Prestamo> _lstPrestamo;
        public frmModificarPrestamo()
        {
            InitializeComponent();
            _prestamoServicio = new PrestamoServicio();
            _clienteServicio = new ClienteServicio();
            _lstPrestamo = _prestamoServicio.TrearPretamosDeClientes();
            CargarPrestamos();

        }

        private void CargarPrestamos()
        {

            cbxPrestamos.DropDownStyle = ComboBoxStyle.DropDownList; // indico que no se puede modificar el combobox

            foreach (Prestamo P in _lstPrestamo.OrderBy(x => x.Id))
            {
                if (P.Estado)
                {
                    cbxPrestamos.Items.Add(P.Id + " - " + TraerClientePorID(P.IdCliente));
                }
            }
        }

        private string TraerClientePorID(int idcliente)
        {
            Cliente cliente = _clienteServicio.TraerClientePorID(idcliente);
            string nombre = "";

            if (cliente is null)
            {
                nombre = "NO ES MI CLIENTE";
            }
            else
            {
                nombre = cliente.Nombre + " " + cliente.Apellido;

            }

            return nombre;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificarPrestamo_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxPrestamos.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un prestamo");
                }
                else
                {
                    var obj = cbxPrestamos.SelectedItem;

                    string[] idv = obj.ToString().Split('-');

                    int id = Convert.ToInt32(idv[0]);

                    Prestamo P = _prestamoServicio.TrearPretamoPorID(id);

                    DateTime fechabaja = dateFechadeBaja.Value;

                    if(fechabaja.Date <= dateFechaAlta.Value)
                    {
                        throw new Exception("La fecha de baja no puede ser menor o igual a la fecha de alta");
                    }
                    else if(txtEjemplar.Text == "")
                    {
                        throw new Exception("El ejemplar no puede quedar vacio");

                    }
                    else
                    {
                        // cuando da la baja del prestamo pasa su estado a cerrado (false)
                        Prestamo P2 = new Prestamo(P.IdCliente, P.IdEjemplar, P.Plazo, false, P.FechaPrestamo, P.FechaDevolucionTentativa, fechabaja); 

                        int id2 = _prestamoServicio.ModificarPrestamo(P2, P.Id);

                        MessageBox.Show("Se dio de baja el prestamo con ID: " + id2.ToString(), "Mensaje del Sistema");

                        _lstPrestamo.Remove(P);
                        LimpiarBotones();
                        cbxPrestamos.Items.Clear();
                        CargarPrestamos();

                    }


                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message,"Mensaje del sistema");
            }
        }

        private void LimpiarBotones()
        {
            txtEjemplar.Clear();

        }

        private void cbxPrestamos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxPrestamos.SelectedIndex == -1)
            {
                MessageBox.Show("Debe Seleccionar un Prestamo", "Mensaje del sistema");
            }
            else
            {
                var obj = cbxPrestamos.SelectedItem;

                string[] idv = obj.ToString().Split('-');

                int id = Convert.ToInt32(idv[0]);

                Prestamo P = _prestamoServicio.TrearPretamoPorID(id);

                txtEjemplar.Text = P.IdEjemplar.ToString();

                dateFechaAlta.Value = P.FechaPrestamo;
            }
        }
    }
}
