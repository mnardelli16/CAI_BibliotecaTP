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
    public partial class frmMostrarPrestamos : Form
    {
        PrestamoServicio _prestamoServicio;
        ClienteServicio _clienteServicio;
        public frmMostrarPrestamos()
        {
            InitializeComponent();
            _prestamoServicio = new PrestamoServicio();
            _clienteServicio = new ClienteServicio();
        
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargarPrestamos_Click(object sender, EventArgs e)
        {
            bool flag = FlagMostrarPrestamos();

            if (flag == false)
            {
                List<Prestamo> lst = _prestamoServicio.TrearPretamosDeClientes();

                //forma de hacer un datasource pero personalizado
                dgvMostrarPrestamos.Columns.Add("id", "ID PRESTAMO");
                dgvMostrarPrestamos.Columns.Add("idCliente", "CLIENTE");
                dgvMostrarPrestamos.Columns.Add("idEjemplar", "ID EJEMPLAR");
                dgvMostrarPrestamos.Columns.Add("plazo", "PLAZO");
                dgvMostrarPrestamos.Columns.Add("abierto", "ESTADO");
                dgvMostrarPrestamos.Columns.Add("fechaPrestamo", "FECHA ALTA");
                dgvMostrarPrestamos.Columns.Add("fechadevtentativa", "FECHA DEV TENTATIVA");
                dgvMostrarPrestamos.Columns.Add("fechadevreal", "FECHA DEV REAL");



                foreach (Prestamo c in lst.OrderBy(x => x.Id))
                {
                    dgvMostrarPrestamos.Rows.Add(c.Id, TraerClientePorID(c.IdCliente), c.IdEjemplar, c.Plazo, DeterminarEstado(c.Estado), c.FechaPrestamo.ToShortDateString(), c.FechaDevolucionTentativa.ToShortDateString(), c.FechaDevolucionReal.ToShortDateString());
                }
            }
            else
            {
                MessageBox.Show("El listado ya esta actualizado.","MESAJE DEL SISTEMA");
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

        private string DeterminarEstado(bool _estado)
        {
            if (_estado)
            {
                return "Abierto";
            }
            else
            {
                return "Cerrado";
            }
        }

        private bool FlagMostrarPrestamos() //validar que la grilla no se cargue varias veces al "Cargar Prestamos"
        {
            bool b = false;
            if (dgvMostrarPrestamos.Rows.Count != 0)
            {
                b = true;
            }
            return b;
        }
    }
}
