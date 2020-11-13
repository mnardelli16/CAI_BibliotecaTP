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
    public partial class frmEleccionClienteReportePrestamos : Form
    {
        ClienteServicio _clienteServicio;
        public frmEleccionClienteReportePrestamos()
        {
            _clienteServicio = new ClienteServicio();
            InitializeComponent();
            CargarClientes();
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            if(cbxCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un cliente de la lista", "MENSAJE DEL SISTEMA");
            }
            else
            {
                var obj = cbxCliente.SelectedItem;

                string[] idv = obj.ToString().Split('-');

                int dni = Convert.ToInt32(idv[0]);

                Cliente C = _clienteServicio.TraerClientePorDNI(dni);

                frmReportePrestamosPorCliente FORM = new frmReportePrestamosPorCliente(C.Id);
                FORM.Owner = this;
                FORM.Show();

            }

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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
