namespace FarmaciaWinFormsEF.Views
{
    partial class MedicamentosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicamentosForm));
            dateTimePickerExpiacion = new DateTimePicker();
            dataGridViewDATOS = new DataGridView();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnAgregar = new Button();
            checkBox1 = new CheckBox();
            lblFecha = new Label();
            txtStock = new TextBox();
            lblStock = new Label();
            txtPrecio = new TextBox();
            lblPrecio = new Label();
            txtDescripcion = new TextBox();
            lblDescripcion = new Label();
            txtTipo = new TextBox();
            lblTipo = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDATOS).BeginInit();
            SuspendLayout();
            // 
            // dateTimePickerExpiacion
            // 
            dateTimePickerExpiacion.Location = new Point(263, 158);
            dateTimePickerExpiacion.Name = "dateTimePickerExpiacion";
            dateTimePickerExpiacion.Size = new Size(200, 23);
            dateTimePickerExpiacion.TabIndex = 36;
            // 
            // dataGridViewDATOS
            // 
            dataGridViewDATOS.BackgroundColor = SystemColors.Menu;
            dataGridViewDATOS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDATOS.Location = new Point(12, 199);
            dataGridViewDATOS.Name = "dataGridViewDATOS";
            dataGridViewDATOS.Size = new Size(585, 212);
            dataGridViewDATOS.TabIndex = 35;
            dataGridViewDATOS.Click += dataGridViewDATOS_SelectionChanged;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.LightBlue;
            btnLimpiar.Location = new Point(507, 154);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(90, 23);
            btnLimpiar.TabIndex = 34;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.IndianRed;
            btnEliminar.Location = new Point(507, 125);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(90, 23);
            btnEliminar.TabIndex = 33;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.LightBlue;
            btnActualizar.Location = new Point(507, 96);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(90, 23);
            btnActualizar.TabIndex = 32;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.LightCyan;
            btnAgregar.Location = new Point(507, 67);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(90, 23);
            btnAgregar.TabIndex = 31;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(507, 42);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(60, 19);
            checkBox1.TabIndex = 30;
            checkBox1.Text = "Activo";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(263, 140);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(107, 15);
            lblFecha.TabIndex = 29;
            lblFecha.Text = "Fecha de Expiación";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(258, 104);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(205, 23);
            txtStock.TabIndex = 28;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(263, 86);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(36, 15);
            lblStock.TabIndex = 27;
            lblStock.Text = "Stock";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(258, 51);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(205, 23);
            txtPrecio.TabIndex = 26;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(263, 33);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 25;
            lblPrecio.Text = "Precio";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(12, 158);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(220, 23);
            txtDescripcion.TabIndex = 24;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(17, 140);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 23;
            lblDescripcion.Text = "Descripción";
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(12, 104);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(220, 23);
            txtTipo.TabIndex = 22;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(17, 86);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(31, 15);
            lblTipo.TabIndex = 21;
            lblTipo.Text = "Tipo";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 51);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(220, 23);
            txtNombre.TabIndex = 20;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(17, 33);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 19;
            lblNombre.Text = "Nombre";
            // 
            // MedicamentosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(622, 424);
            Controls.Add(dateTimePickerExpiacion);
            Controls.Add(dataGridViewDATOS);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(checkBox1);
            Controls.Add(lblFecha);
            Controls.Add(txtStock);
            Controls.Add(lblStock);
            Controls.Add(txtPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(txtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(txtTipo);
            Controls.Add(lblTipo);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MedicamentosForm";
            Text = "Medicamentos";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDATOS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePickerExpiacion;
        private DataGridView dataGridViewDATOS;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnAgregar;
        private CheckBox checkBox1;
        private Label lblFecha;
        private TextBox txtStock;
        private Label lblStock;
        private TextBox txtPrecio;
        private Label lblPrecio;
        private TextBox txtDescripcion;
        private Label lblDescripcion;
        private TextBox txtTipo;
        private Label lblTipo;
        private TextBox txtNombre;
        private Label lblNombre;
    }
}