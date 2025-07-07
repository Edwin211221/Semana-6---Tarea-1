using System;
using System.Windows.Forms;
using FarmaciaWinFormsEF.Controllers;
using FarmaciaWinFormsEF.Models;

namespace FarmaciaWinFormsEF.Views
{
    public partial class MedicamentosForm : Form
    {
        MedicamentoController medicamentoCtrl = new MedicamentoController();
        int? idSeleccionado = null;

        public MedicamentosForm()
        {
            InitializeComponent();
            CargarMedicamentos();

            btnAgregar.Click += btnAgregar_Click;
            btnActualizar.Click += btnActualizar_Click;
            btnEliminar.Click += btnEliminar_Click;
            btnLimpiar.Click += btnLimpiar_Click;
            dataGridViewDATOS.SelectionChanged += dataGridViewDATOS_SelectionChanged;
        }

        private void CargarMedicamentos()
        {
            dataGridViewDATOS.DataSource = null;
            dataGridViewDATOS.DataSource = medicamentoCtrl.ObtenerMedicamentos();
            dataGridViewDATOS.ClearSelection();
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtTipo.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            dateTimePickerExpiacion.Value = DateTime.Today;
            checkBox1.Checked = false;
            idSeleccionado = null;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.");
                return;
            }

            var medicamento = new Medicamento
            {
                Nombre = txtNombre.Text,
                Tipo = txtTipo.Text,
                Descripcion = txtDescripcion.Text,
                Precio = decimal.TryParse(txtPrecio.Text, out decimal precio) ? precio : 0,
                Stock = int.TryParse(txtStock.Text, out int stock) ? stock : 0,
                FechaExpiracion = dateTimePickerExpiacion.Value,
                Activo = checkBox1.Checked
            };

            medicamentoCtrl.AgregarMedicamento(medicamento);
            MessageBox.Show("Medicamento agregado correctamente.");
            CargarMedicamentos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == null)
            {
                MessageBox.Show("Selecciona un medicamento para actualizar.");
                return;
            }

            var medicamento = new Medicamento
            {
                MedicamentoId = idSeleccionado.Value,
                Nombre = txtNombre.Text,
                Tipo = txtTipo.Text,
                Descripcion = txtDescripcion.Text,
                Precio = decimal.TryParse(txtPrecio.Text, out decimal precio) ? precio : 0,
                Stock = int.TryParse(txtStock.Text, out int stock) ? stock : 0,
                FechaExpiracion = dateTimePickerExpiacion.Value,
                Activo = checkBox1.Checked
            };

            medicamentoCtrl.ActualizarMedicamento(medicamento);
            MessageBox.Show("Medicamento actualizado correctamente.");
            CargarMedicamentos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == null)
            {
                MessageBox.Show("Selecciona un medicamento para eliminar.");
                return;
            }

            medicamentoCtrl.EliminarMedicamento(idSeleccionado.Value);
            MessageBox.Show("Medicamento eliminado correctamente.");
            CargarMedicamentos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dataGridViewDATOS_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewDATOS.SelectedRows.Count > 0)
            {
                var fila = dataGridViewDATOS.SelectedRows[0];
                var medicamento = fila.DataBoundItem as Medicamento;
                if (medicamento != null)
                {
                    idSeleccionado = medicamento.MedicamentoId;
                    txtNombre.Text = medicamento.Nombre;
                    txtTipo.Text = medicamento.Tipo;
                    txtDescripcion.Text = medicamento.Descripcion;
                    txtPrecio.Text = medicamento.Precio.ToString("0.00");
                    txtStock.Text = medicamento.Stock.ToString();
                    dateTimePickerExpiacion.Value = medicamento.FechaExpiracion;
                    checkBox1.Checked = medicamento.Activo;
                }
            }
        }
    }
}