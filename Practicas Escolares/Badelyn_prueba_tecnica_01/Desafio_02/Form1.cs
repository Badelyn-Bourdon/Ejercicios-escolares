namespace Desafio_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Ingresar tu nombre ");
            string nombre = Console.ReadLine();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3, nota4, promedio;

            nota1 = double.Parse(txtNota1.Text);
            nota2 = double.Parse(txtNota2.Text);
            nota3 = double.Parse(txtNota3.Text);
            nota4 = double.Parse(txtNota4.Text);

            promedio = nota1 + nota2 + nota3 + nota4;
            promedio = promedio / 4;

            txtPromedio.Text = promedio.ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            txtNota4.Clear();
            txtPromedio.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(50, 150);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 13);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Estado: ";
        }
    }
}
