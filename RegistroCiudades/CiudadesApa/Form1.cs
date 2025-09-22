using CiudadesLibrary.Dao;
using CiudadesLibrary.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CiudadesApa
{
    public partial class Form1 : Form
    {
        CiudadDao lista = new CiudadDao();
        public Form1()
        {
            InitializeComponent();
        }

        private void dgvRegistros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Ciudad ciudad = new Ciudad();
            ciudad.Nombre = tbNombre.Text;
            ciudad.Poblacion = int.Parse(tbPoblacion.Text);
            ciudad.FechaFundacion = dtpFundacion.Value;
            lista.AgregarCiudad(ciudad);
            LLenarDataGrid();
        }
        private void LLenarDataGrid()
        {
            dgvRegistros.DataSource = lista.MostrarCiudad();
            dgvRegistros.Refresh();
        }
    }
}
