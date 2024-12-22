namespace Desafio_01
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
            nombre = new Label();
            ingreso = new Label();
            extras = new Label();
            dobles = new Label();
            txtHorasdobles = new ComboBox();
            txtHorasextras = new ComboBox();
            Titulo = new Label();
            txtNombre = new ComboBox();
            txtIngresobruto = new ComboBox();
            lstResultado = new ListBox();
            btnCalcular = new Button();
            btnlimpiar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // nombre
            // 
            nombre.AutoSize = true;
            nombre.Location = new Point(12, 104);
            nombre.Name = "nombre";
            nombre.Size = new Size(163, 25);
            nombre.TabIndex = 1;
            nombre.Text = "Empleado Nombre";
            // 
            // ingreso
            // 
            ingreso.AutoSize = true;
            ingreso.Location = new Point(24, 165);
            ingreso.Name = "ingreso";
            ingreso.Size = new Size(120, 25);
            ingreso.TabIndex = 2;
            ingreso.Text = "Ingreso Bruto";
            // 
            // extras
            // 
            extras.AutoSize = true;
            extras.Location = new Point(411, 104);
            extras.Name = "extras";
            extras.Size = new Size(110, 25);
            extras.TabIndex = 3;
            extras.Text = "Horas Extras";
            // 
            // dobles
            // 
            dobles.AutoSize = true;
            dobles.Location = new Point(401, 173);
            dobles.Name = "dobles";
            dobles.Size = new Size(120, 25);
            dobles.TabIndex = 4;
            dobles.Text = "Horas Dobles";
            // 
            // txtHorasdobles
            // 
            txtHorasdobles.FormattingEnabled = true;
            txtHorasdobles.Location = new Point(530, 165);
            txtHorasdobles.Name = "txtHorasdobles";
            txtHorasdobles.Size = new Size(182, 33);
            txtHorasdobles.TabIndex = 5;
            // 
            // txtHorasextras
            // 
            txtHorasextras.FormattingEnabled = true;
            txtHorasextras.Location = new Point(530, 101);
            txtHorasextras.Name = "txtHorasextras";
            txtHorasextras.Size = new Size(182, 33);
            txtHorasextras.TabIndex = 6;
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.BackColor = SystemColors.Info;
            Titulo.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Titulo.ForeColor = SystemColors.Desktop;
            Titulo.Location = new Point(268, 27);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(246, 29);
            Titulo.TabIndex = 7;
            Titulo.Text = "Calculo de Nomina";
            // 
            // txtNombre
            // 
            txtNombre.FormattingEnabled = true;
            txtNombre.Location = new Point(181, 101);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(182, 33);
            txtNombre.TabIndex = 8;
            // 
            // txtIngresobruto
            // 
            txtIngresobruto.FormattingEnabled = true;
            txtIngresobruto.Location = new Point(181, 165);
            txtIngresobruto.Name = "txtIngresobruto";
            txtIngresobruto.Size = new Size(182, 33);
            txtIngresobruto.TabIndex = 9;
            // 
            // lstResultado
            // 
            lstResultado.FormattingEnabled = true;
            lstResultado.ItemHeight = 25;
            lstResultado.Location = new Point(253, 241);
            lstResultado.Name = "lstResultado";
            lstResultado.Size = new Size(307, 104);
            lstResultado.TabIndex = 13;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.Salmon;
            btnCalcular.Location = new Point(328, 404);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(142, 44);
            btnCalcular.TabIndex = 14;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnlimpiar
            // 
            btnlimpiar.BackColor = Color.LightGreen;
            btnlimpiar.Location = new Point(124, 401);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(144, 47);
            btnlimpiar.TabIndex = 15;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.UseVisualStyleBackColor = false;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.LemonChiffon;
            btnSalir.Location = new Point(530, 401);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(138, 49);
            btnSalir.TabIndex = 16;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnlimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(lstResultado);
            Controls.Add(txtIngresobruto);
            Controls.Add(txtNombre);
            Controls.Add(Titulo);
            Controls.Add(txtHorasextras);
            Controls.Add(txtHorasdobles);
            Controls.Add(dobles);
            Controls.Add(extras);
            Controls.Add(ingreso);
            Controls.Add(nombre);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label nombre;
        private Label ingreso;
        private Label extras;
        private Label dobles;
        private ComboBox txtHorasdobles;
        private ComboBox txtHorasextras;
        private Label Titulo;
        private ComboBox txtNombre;
        private ComboBox txtIngresobruto;
        private ListBox lstResultado;
        private Button btnCalcular;
        private Button btnlimpiar;
        private Button btnSalir;
    }
}
