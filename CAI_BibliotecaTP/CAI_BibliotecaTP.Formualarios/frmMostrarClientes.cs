using CAI_BibliotecaTP.Entidades;
using CAI_BibliotecaTP.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAI_BibliotecaTP.Formualarios
{
    public partial class frmMostrarClientes : Form
    {
        private ClienteServicio _clienteServicio;
        public frmMostrarClientes()
        {
            InitializeComponent();
            _clienteServicio = new ClienteServicio();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }


        private void btnMostrar_Click(object sender, EventArgs e)
        {
            bool flag = FlagMostrarCliente();

            if (flag == false)
            {
                List<Cliente> lst = _clienteServicio.TraerClientes();

                //forma de hacer un datasource pero personalizado
                dgvMostrarClientes.Columns.Add("id", "ID");
                dgvMostrarClientes.Columns.Add("dni", "Dni");
                dgvMostrarClientes.Columns.Add("nombre", "Nombre");
                dgvMostrarClientes.Columns.Add("apellido", "Apellido");
                dgvMostrarClientes.Columns.Add("direccion", "Direccion");
                dgvMostrarClientes.Columns.Add("email", "Email");
                dgvMostrarClientes.Columns.Add("tefono", "Telefono");
                dgvMostrarClientes.Columns.Add("fechanacimiento", "F. Nacimiento");
                dgvMostrarClientes.Columns.Add("fechaalta", "F. Alta");
                dgvMostrarClientes.Columns.Add("activo", "Activo");

                foreach (Cliente c in lst)
                {
                    dgvMostrarClientes.Rows.Add(c.Id, c.Dni, c.Nombre, c.Apellido, c.Direccion, c.Email, c.Telefono, c.FechaNacimiento.ToShortDateString(), c.FechaAlta.ToShortDateString(), DeterminarCliente(c.Activo));
                }

            }
            else
            {
                MessageBox.Show("El listado ya esta actualizado.", "MESAJE DEL SISTEMA");
            }
        }

        private string DeterminarCliente(bool a)
        {
            string estado;
            if (a)
            {
                estado = "Activo";
            }
            else
            {
                estado = "Inactivo";
            }
            return estado;
        }
        private bool FlagMostrarCliente() //validar que la grilla no se cargue varias veces al "Cargar Cliente"
        {
            bool b = false;
            if(dgvMostrarClientes.Rows.Count != 0)
            {
                b = true;
            }
            return b;
        }
    }
}
