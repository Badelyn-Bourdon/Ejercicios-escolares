namespace Desafio_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Definir constantes para los porcentajes
        const double TasaAFP = 0.0625;  // 6.25% para AFP (ajusta según tu país)
        const double TasaSFA = 0.03;    // 3% para SFA (ajusta según tu país)
        const double TasaISR = 0.10;    // 10% para ISR (ajusta según tu país)
        const double TarifaHoraExtra = 1.5;  // 1.5 veces el salario por hora para horas extras
        const double TarifaHoraDoble = 2.0;  // 2 veces el salario por hora para horas dobles


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los valores de los controles
                string nombre = txtNombre.Text;
                double ingresoBase = Convert.ToDouble(txtIngresobruto.Text);
                double horasExtras = Convert.ToDouble(txtHorasextras.Text);
                double horasDobles = Convert.ToDouble(txtHorasdobles.Text);

                // Calcular el salario total por horas extras y horas dobles
                double salarioHora = ingresoBase / 160;  // Asumimos 160 horas mensuales
                double pagoHorasExtras = horasExtras * salarioHora * TarifaHoraExtra;
                double pagoHorasDobles = horasDobles * salarioHora * TarifaHoraDoble;

                // Calcular el salario total antes de los descuentos
                double salarioTotal = ingresoBase + pagoHorasExtras + pagoHorasDobles;

                // Calcular los descuentos
                double descuentoAFP = salarioTotal * TasaAFP;
                double descuentoSFA = salarioTotal * TasaSFA;
                double descuentoISR = salarioTotal * TasaISR;

                // Calcular el salario neto
                double salarioNeto = salarioTotal - descuentoAFP - descuentoSFA - descuentoISR;

                // Mostrar los resultados en el ListBox
                lstResultado.Items.Clear();  // Limpiar el ListBox
                lstResultado.Items.Add($"Nombre: {nombre}");
                lstResultado.Items.Add($"Ingreso Base: {ingresoBase:C}");
                lstResultado.Items.Add($"Horas Extras: {horasExtras} horas");
                lstResultado.Items.Add($"Horas Dobles: {horasDobles} horas");
                lstResultado.Items.Add($"Pago por Horas Extras: {pagoHorasExtras:C}");
                lstResultado.Items.Add($"Pago por Horas Dobles: {pagoHorasDobles:C}");
                lstResultado.Items.Add($"Salario Total: {salarioTotal:C}");
                lstResultado.Items.Add($"Descuento AFP (6.25%): {descuentoAFP:C}");
                lstResultado.Items.Add($"Descuento SFA (3%): {descuentoSFA:C}");
                lstResultado.Items.Add($"Descuento ISR (10%): {descuentoISR:C}");
                lstResultado.Items.Add($"Salario Neto: {salarioNeto:C}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            
            
                lstResultado.Items.Clear();  // Limpiar el ListBox
            txtNombre.Items.Clear();          // Elimina todos los ítems del ComboBox
            txtIngresobruto.Items.Clear();    // Elimina todos los ítems del ComboBox
            txtHorasextras.Items.Clear();     // Elimina todos los ítems del ComboBox
            txtHorasdobles.Items.Clear();     // Elimina todos los ítems del ComboBox


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            
            
                Application.Exit();  // Cerrar la aplicación
            
        }
    }
}
