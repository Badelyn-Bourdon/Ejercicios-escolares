using System.Text;

namespace Desafio_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Inicializar ComboBox con tipos de habitación
            cmbTipoHabitacion.Items.Add("Individual");
            cmbTipoHabitacion.Items.Add("Doble");
            cmbTipoHabitacion.Items.Add("Suite");

            // Establecer valores predeterminados para los campos
            dtpFechaEntrada.Value = DateTime.Now;
            dtpFechaSalida.Value = DateTime.Now.AddDays(1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una reserva
            if (lstReservas.SelectedItem != null)
            {
                // Obtener la reserva seleccionada
                Reserva reservaSeleccionada = (Reserva)lstReservas.SelectedItem;

                // Generar el contenido de la factura
                string contenidoFactura = GenerarFactura(reservaSeleccionada);

                // Obtener la ruta donde se guardará el archivo de texto
                string rutaArchivo = @"C:\Users\user\Documents\Instituto Politecnico Pedro Feliciano Martinez\Informatica\Desarrollo de Aplicaciones\Practicas Escolares\Desafio_3\Reservas" + reservaSeleccionada.NombreCliente + ".txt";

                // Guardar el archivo de texto
                try
                {
                    // Escribir el contenido en el archivo
                    File.WriteAllText(rutaArchivo, contenidoFactura);

                    MessageBox.Show("Factura guardada exitosamente en: " + rutaArchivo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar la factura: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una reserva para guardar como factura.");
            }


        }

        // Método que genera el contenido de la factura
        private string GenerarFactura(Reserva reserva)
        {
            // Aquí puedes personalizar el contenido de la factura
            StringBuilder factura = new StringBuilder();

            factura.AppendLine("----------- FACTURA DE RESERVA -----------");
            factura.AppendLine("Nombre del Cliente: " + reserva.NombreCliente);
            factura.AppendLine("Fecha de Entrada: " + reserva.FechaEntrada.ToShortDateString());
            factura.AppendLine("Fecha de Salida: " + reserva.FechaSalida.ToShortDateString());
            factura.AppendLine("Tipo de Habitación: " + reserva.TipoHabitacion);
            factura.AppendLine("Cantidad de Personas: " + reserva.CantidadPersonas);

            // Aquí puedes agregar el cálculo del total según la habitación y cantidad de personas
            decimal precioPorPersona = 5000; // Suponiendo un precio fijo por persona
            decimal total = reserva.CantidadPersonas * precioPorPersona;

            factura.AppendLine("Precio por Persona: $" + precioPorPersona.ToString("F2"));
            factura.AppendLine("Total a Pagar: $" + total.ToString("F2"));

            factura.AppendLine("----------------------------------------");
            factura.AppendLine("Gracias por su preferencia. ¡Vuelva pronto!");

            return factura.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Verificar que todos los campos estén completos
            if (string.IsNullOrEmpty(txtNombre.Text) || cmbTipoHabitacion.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            // Crear la nueva reserva con los datos ingresados
            Reserva nuevaReserva = new Reserva
            {
                NombreCliente = txtNombre.Text,
                FechaEntrada = dtpFechaEntrada.Value,
                FechaSalida = dtpFechaSalida.Value,
                TipoHabitacion = cmbTipoHabitacion.SelectedItem.ToString(),
                CantidadPersonas = (int)nudCantidadPersonas.Value
            };

            // Agregar la reserva al ListBox
            lstReservas.Items.Add(nuevaReserva);

            // Limpiar los campos de entrada para una nueva reserva


            LimpiarCampos();



        }
        private void LimpiarCampos()
        {
            // Limpiar los campos de texto y restablecer valores predeterminados
            txtNombre.Clear();
            cmbTipoHabitacion.SelectedIndex = -1;
            nudCantidadPersonas.Value = 1;
            dtpFechaEntrada.Value = DateTime.Now;
            dtpFechaSalida.Value = DateTime.Now.AddDays(1);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una reserva
            if (lstReservas.SelectedItem != null)
            {
                // Eliminar la reserva seleccionada del ListBox
                lstReservas.Items.Remove(lstReservas.SelectedItem);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una reserva para eliminar.");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            // Limpiar todos los campos de entrada para una nueva reserva
            LimpiarCampos();
        }
    }








    public class Reserva
    {
        public string NombreCliente { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }
        public string TipoHabitacion { get; set; }
        public int CantidadPersonas { get; set; }

        // Mostrar la reserva en formato de cadena
        public override string ToString()
        {
            return $"{NombreCliente} - {TipoHabitacion} - {FechaEntrada.ToShortDateString()} al {FechaSalida.ToShortDateString()}";
        }
    }


}
    


