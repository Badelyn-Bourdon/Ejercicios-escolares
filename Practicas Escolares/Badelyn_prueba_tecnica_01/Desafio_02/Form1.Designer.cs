namespace Desafio_02
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
            label1 = new Label();
            lblNombre = new Label();
            lblCurso = new Label();
            lblSeccion = new Label();
            lblSexo = new Label();
            label6 = new Label();
            lblArea = new Label();
            lblOr = new Label();
            label9 = new Label();
            label10 = new Label();
            textNombre = new ComboBox();
            txtSeccion = new ComboBox();
            txtArea = new ComboBox();
            txtCurso = new ComboBox();
            label11 = new Label();
            label12 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            txtNota3 = new TextBox();
            txtNota4 = new TextBox();
            txtNota2 = new TextBox();
            txtNota1 = new TextBox();
            txtPromedio = new TextBox();
            label13 = new Label();
            lblStatus = new TextBox();
            label14 = new Label();
            txtSexoF = new RadioButton();
            txtSexoM = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.Font = new Font("Bauhaus 93", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(214, 19);
            label1.Name = "label1";
            label1.Size = new Size(208, 28);
            label1.TabIndex = 0;
            label1.Text = "Formulario Le Rose";
            label1.Click += label1_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(74, 79);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(89, 23);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            lblNombre.Click += label2_Click;
            // 
            // lblCurso
            // 
            lblCurso.AutoSize = true;
            lblCurso.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurso.Location = new Point(338, 83);
            lblCurso.Name = "lblCurso";
            lblCurso.Size = new Size(69, 23);
            lblCurso.TabIndex = 2;
            lblCurso.Text = "Curso";
            lblCurso.Click += label3_Click;
            // 
            // lblSeccion
            // 
            lblSeccion.AutoSize = true;
            lblSeccion.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSeccion.Location = new Point(74, 190);
            lblSeccion.Name = "lblSeccion";
            lblSeccion.Size = new Size(86, 23);
            lblSeccion.TabIndex = 3;
            lblSeccion.Text = "Session";
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSexo.Location = new Point(338, 130);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(57, 23);
            lblSexo.TabIndex = 4;
            lblSexo.Text = "Sexo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(84, 394);
            label6.Name = "label6";
            label6.Size = new Size(35, 25);
            label6.TabIndex = 5;
            label6.Text = "N2";
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblArea.Location = new Point(74, 132);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(57, 23);
            lblArea.TabIndex = 6;
            lblArea.Text = "Area";
            // 
            // lblOr
            // 
            lblOr.AutoSize = true;
            lblOr.Location = new Point(485, 130);
            lblOr.Name = "lblOr";
            lblOr.Size = new Size(29, 25);
            lblOr.TabIndex = 7;
            lblOr.Text = "or";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ActiveCaption;
            label9.Font = new Font("Bauhaus 93", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(241, 243);
            label9.Name = "label9";
            label9.Size = new Size(181, 25);
            label9.TabIndex = 14;
            label9.Text = "Entrada de Datos";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(84, 348);
            label10.Name = "label10";
            label10.Size = new Size(35, 25);
            label10.TabIndex = 15;
            label10.Text = "N1";
            // 
            // textNombre
            // 
            textNombre.FormattingEnabled = true;
            textNombre.Location = new Point(182, 75);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(132, 33);
            textNombre.TabIndex = 16;
            // 
            // txtSeccion
            // 
            txtSeccion.FormattingEnabled = true;
            txtSeccion.Location = new Point(182, 190);
            txtSeccion.Name = "txtSeccion";
            txtSeccion.Size = new Size(69, 33);
            txtSeccion.TabIndex = 17;
            // 
            // txtArea
            // 
            txtArea.FormattingEnabled = true;
            txtArea.Items.AddRange(new object[] { "Gastronomia", "Enfermeria", "Informatica", "Electricidad", "Contabilidad" });
            txtArea.Location = new Point(181, 132);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(133, 33);
            txtArea.TabIndex = 18;
            // 
            // txtCurso
            // 
            txtCurso.FormattingEnabled = true;
            txtCurso.Location = new Point(455, 79);
            txtCurso.Name = "txtCurso";
            txtCurso.Size = new Size(73, 33);
            txtCurso.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(222, 348);
            label11.Name = "label11";
            label11.Size = new Size(35, 25);
            label11.TabIndex = 26;
            label11.Text = "N3";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(222, 397);
            label12.Name = "label12";
            label12.Size = new Size(35, 25);
            label12.TabIndex = 27;
            label12.Text = "N4";
            // 
            // button1
            // 
            button1.Location = new Point(504, 533);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 28;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(283, 533);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 29;
            button2.Text = "calcular";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(74, 533);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 30;
            button3.Text = "Limpiar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // txtNota3
            // 
            txtNota3.Location = new Point(272, 348);
            txtNota3.Name = "txtNota3";
            txtNota3.Size = new Size(77, 31);
            txtNota3.TabIndex = 32;
            // 
            // txtNota4
            // 
            txtNota4.Location = new Point(272, 394);
            txtNota4.Name = "txtNota4";
            txtNota4.Size = new Size(77, 31);
            txtNota4.TabIndex = 33;
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(125, 391);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(77, 31);
            txtNota2.TabIndex = 35;
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(125, 345);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(77, 31);
            txtNota1.TabIndex = 34;
            // 
            // txtPromedio
            // 
            txtPromedio.Location = new Point(208, 461);
            txtPromedio.Name = "txtPromedio";
            txtPromedio.Size = new Size(77, 31);
            txtPromedio.TabIndex = 37;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(167, 464);
            label13.Name = "label13";
            label13.Size = new Size(22, 25);
            label13.TabIndex = 36;
            label13.Text = "P";
            // 
            // lblStatus
            // 
            lblStatus.BackColor = SystemColors.HighlightText;
            lblStatus.Cursor = Cursors.SizeWE;
            lblStatus.Location = new Point(467, 361);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(159, 31);
            lblStatus.TabIndex = 39;
            lblStatus.TextChanged += textBox1_TextChanged;
            // 
            // label14
            // 
            label14.AllowDrop = true;
            label14.AutoSize = true;
            label14.Location = new Point(401, 361);
            label14.Name = "label14";
            label14.Size = new Size(60, 25);
            label14.TabIndex = 38;
            label14.Text = "Status";
            // 
            // txtSexoF
            // 
            txtSexoF.AutoSize = true;
            txtSexoF.Location = new Point(418, 132);
            txtSexoF.Name = "txtSexoF";
            txtSexoF.Size = new Size(43, 29);
            txtSexoF.TabIndex = 40;
            txtSexoF.TabStop = true;
            txtSexoF.Text = "f";
            txtSexoF.UseVisualStyleBackColor = true;
            // 
            // txtSexoM
            // 
            txtSexoM.AutoSize = true;
            txtSexoM.Location = new Point(535, 133);
            txtSexoM.Name = "txtSexoM";
            txtSexoM.Size = new Size(53, 29);
            txtSexoM.TabIndex = 41;
            txtSexoM.TabStop = true;
            txtSexoM.Text = "M";
            txtSexoM.UseVisualStyleBackColor = true;
            txtSexoM.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 579);
            Controls.Add(txtSexoM);
            Controls.Add(txtSexoF);
            Controls.Add(lblStatus);
            Controls.Add(label14);
            Controls.Add(txtPromedio);
            Controls.Add(label13);
            Controls.Add(txtNota2);
            Controls.Add(txtNota1);
            Controls.Add(txtNota4);
            Controls.Add(txtNota3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(txtCurso);
            Controls.Add(txtArea);
            Controls.Add(txtSeccion);
            Controls.Add(textNombre);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(lblOr);
            Controls.Add(lblArea);
            Controls.Add(label6);
            Controls.Add(lblSexo);
            Controls.Add(lblSeccion);
            Controls.Add(lblCurso);
            Controls.Add(lblNombre);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblNombre;
        private Label lblCurso;
        private Label lblSeccion;
        private Label lblSexo;
        private Label label6;
        private Label lblArea;
        private Label lblOr;
        private Label label9;
        private Label label10;
        private ComboBox textNombre;
        private ComboBox txtSeccion;
        private ComboBox txtArea;
        private ComboBox txtCurso;
        private Label label11;
        private Label label12;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox txtNota3;
        private TextBox txtNota4;
        private TextBox txtNota2;
        private TextBox txtNota1;
        private TextBox txtPromedio;
        private Label label13;
        private TextBox lblStatus;
        private Label label14;
        private RadioButton txtSexoF;
        private RadioButton txtSexoM;
    }
}
