﻿using CAI_BibliotecaTP.Entidades;
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
            List<Cliente> lst = _clienteServicio.TraerClientes();

            //forma de hacer un datasource pero personalizado
            dgvMostrarClientes.Columns.Add("id", "ID");
            dgvMostrarClientes.Columns.Add("dni", "Dni");
            dgvMostrarClientes.Columns.Add("nombre", "Nombre");
            dgvMostrarClientes.Columns.Add("apellido", "Apellido");
            dgvMostrarClientes.Columns.Add("direccion", "Direccion");
            dgvMostrarClientes.Columns.Add("email", "Email");

            foreach (Cliente c in lst)
            {
                dgvMostrarClientes.Rows.Add(c.Id, c.Dni, c.Nombre, c.Apellido, c.Direccion, c.Email);
            }
        }
    }
}
