namespace Desafio_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblNombre = new Label();
            lblFechaEntrada = new Label();
            lblFechaSalida = new Label();
            lblTipoHabitacion = new Label();
            lblCantidadPersonas = new Label();
            txtNombre = new TextBox();
            cmbTipoHabitacion = new ComboBox();
            lstReservas = new ListBox();
            dtpFechaEntrada = new DateTimePicker();
            dtpFechaSalida = new DateTimePicker();
            nudCantidadPersonas = new NumericUpDown();
            btnGuardarReserva = new Button();
            btnEliminarReserva = new Button();
            btnNuevaReserva = new Button();
            label1 = new Label();
            btnGuardarFactura = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnNuevo = new Button();
            ((System.ComponentModel.ISupportInitialize)nudCantidadPersonas).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(207, 27);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(172, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Sistema de Reservas";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(41, 106);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(162, 25);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre Completo";
            // 
            // lblFechaEntrada
            // 
            lblFechaEntrada.AutoSize = true;
            lblFechaEntrada.Location = new Point(41, 158);
            lblFechaEntrada.Name = "lblFechaEntrada";
            lblFechaEntrada.Size = new Size(147, 25);
            lblFechaEntrada.TabIndex = 2;
            lblFechaEntrada.Text = "Fecha de Entrada";
            // 
            // lblFechaSalida
            // 
            lblFechaSalida.AutoSize = true;
            lblFechaSalida.Location = new Point(41, 202);
            lblFechaSalida.Name = "lblFechaSalida";
            lblFechaSalida.Size = new Size(134, 25);
            lblFechaSalida.TabIndex = 3;
            lblFechaSalida.Text = "Fecha de Salida";
            // 
            // lblTipoHabitacion
            // 
            lblTipoHabitacion.AutoSize = true;
            lblTipoHabitacion.Location = new Point(41, 252);
            lblTipoHabitacion.Name = "lblTipoHabitacion";
            lblTipoHabitacion.Size = new Size(162, 25);
            lblTipoHabitacion.TabIndex = 4;
            lblTipoHabitacion.Text = "Tipo de Habitacion";
            // 
            // lblCantidadPersonas
            // 
            lblCantidadPersonas.AutoSize = true;
            lblCantidadPersonas.Location = new Point(41, 308);
            lblCantidadPersonas.Name = "lblCantidadPersonas";
            lblCantidadPersonas.Size = new Size(183, 25);
            lblCantidadPersonas.TabIndex = 5;
            lblCantidadPersonas.Text = "Cantidad de Personas";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(244, 103);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 6;
            // 
            // cmbTipoHabitacion
            // 
            cmbTipoHabitacion.FormattingEnabled = true;
            cmbTipoHabitacion.Location = new Point(241, 252);
            cmbTipoHabitacion.Name = "cmbTipoHabitacion";
            cmbTipoHabitacion.Size = new Size(150, 33);
            cmbTipoHabitacion.TabIndex = 11;
            // 
            // lstReservas
            // 
            lstReservas.FormattingEnabled = true;
            lstReservas.ItemHeight = 25;
            lstReservas.Location = new Point(28, 499);
            lstReservas.Name = "lstReservas";
            lstReservas.Size = new Size(528, 129);
            lstReservas.TabIndex = 16;
            // 
            // dtpFechaEntrada
            // 
            dtpFechaEntrada.Location = new Point(244, 152);
            dtpFechaEntrada.Name = "dtpFechaEntrada";
            dtpFechaEntrada.Size = new Size(153, 31);
            dtpFechaEntrada.TabIndex = 17;
            // 
            // dtpFechaSalida
            // 
            dtpFechaSalida.Location = new Point(241, 196);
            dtpFechaSalida.Name = "dtpFechaSalida";
            dtpFechaSalida.Size = new Size(153, 31);
            dtpFechaSalida.TabIndex = 18;
            // 
            // nudCantidadPersonas
            // 
            nudCantidadPersonas.Location = new Point(241, 308);
            nudCantidadPersonas.Name = "nudCantidadPersonas";
            nudCantidadPersonas.Size = new Size(156, 31);
            nudCantidadPersonas.TabIndex = 19;
            // 
            // btnGuardarReserva
            // 
            btnGuardarReserva.Location = new Point(0, 0);
            btnGuardarReserva.Name = "btnGuardarReserva";
            btnGuardarReserva.Size = new Size(75, 23);
            btnGuardarReserva.TabIndex = 27;
            // 
            // btnEliminarReserva
            // 
            btnEliminarReserva.Location = new Point(0, 0);
            btnEliminarReserva.Name = "btnEliminarReserva";
            btnEliminarReserva.Size = new Size(75, 23);
            btnEliminarReserva.TabIndex = 26;
            // 
            // btnNuevaReserva
            // 
            btnNuevaReserva.Location = new Point(0, 0);
            btnNuevaReserva.Name = "btnNuevaReserva";
            btnNuevaReserva.Size = new Size(75, 23);
            btnNuevaReserva.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(217, 452);
            label1.Name = "label1";
            label1.Size = new Size(137, 25);
            label1.TabIndex = 23;
            label1.Text = "Lista de Reserva";
            // 
            // btnGuardarFactura
            // 
            btnGuardarFactura.Cursor = Cursors.PanSouth;
            btnGuardarFactura.Location = new Point(41, 647);
            btnGuardarFactura.Name = "btnGuardarFactura";
            btnGuardarFactura.Size = new Size(121, 34);
            btnGuardarFactura.TabIndex = 24;
            btnGuardarFactura.Text = "Guardar Factura";
            btnGuardarFactura.UseVisualStyleBackColor = true;
            btnGuardarFactura.Click += button7_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(28, 394);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 34);
            btnGuardar.TabIndex = 28;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(224, 394);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 29;
            btnEliminar.Text = "eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(373, 394);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(112, 34);
            btnNuevo.TabIndex = 30;
            btnNuevo.Text = "Nueva Reserva";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 693);
            Controls.Add(btnNuevo);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnGuardarFactura);
            Controls.Add(label1);
            Controls.Add(btnNuevaReserva);
            Controls.Add(btnEliminarReserva);
            Controls.Add(btnGuardarReserva);
            Controls.Add(nudCantidadPersonas);
            Controls.Add(dtpFechaSalida);
            Controls.Add(dtpFechaEntrada);
            Controls.Add(lstReservas);
            Controls.Add(cmbTipoHabitacion);
            Controls.Add(txtNombre);
            Controls.Add(lblCantidadPersonas);
            Controls.Add(lblTipoHabitacion);
            Controls.Add(lblFechaSalida);
            Controls.Add(lblFechaEntrada);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            Cursor = Cursors.PanSW;
            Name = "Form1";
            WindowState = FormWindowState.Minimized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudCantidadPersonas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNombre;
        private Label lblFechaEntrada;
        private Label lblFechaSalida;
        private Label lblTipoHabitacion;
        private Label lblCantidadPersonas;
        private TextBox txtNombre;
        private TextBox textBox3;
        private ComboBox cmbTipoHabitacion;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label7;
        private ListBox lstReservas;
        private DateTimePicker dtpFechaEntrada;
        private DateTimePicker dtpFechaSalida;
        private NumericUpDown nudCantidadPersonas;
        private Button btnGuardarReserva;
        private Button btnEliminarReserva;
        private Button btnNuevaReserva;
        private Label label1;
        private Button btnGuardarFactura;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnNuevo;
    }
}
