using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAI_BibliotecaTP.Entidades;
using CAI_BibliotecaTP.Entidades.Entidades;
using CAI_BibliotecaTP.Negocio;
using Microsoft.Reporting.WebForms;

namespace CAI_BibliotecaTP.Formualarios
{
    public partial class frmReportePrestamosPorCliente : Form
    {
        PrestamoServicio _prestamoServicio;
        ClienteServicio _clienteServicio;
        internal int idcliente;
        public frmReportePrestamosPorCliente(int id)
        {
            InitializeComponent();
            _prestamoServicio = new PrestamoServicio();
            _clienteServicio = new ClienteServicio();
            idcliente = id;
        }

        private void frmReportePrestamosPorCliente_Load(object sender, EventArgs e)
        {

            PrestamoBindingSource.DataSource = _prestamoServicio.TrearPretamosPorIDCliente(idcliente);
            ClienteBindingSource.DataSource = _clienteServicio.TraerNombreClientePorID(idcliente);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }


    }
}
