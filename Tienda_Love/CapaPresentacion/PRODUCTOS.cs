using System;
using System.Windows.Forms;
using Tienda_Love;


namespace CapaPresentacion
{
    

    public partial class PRODUCTOS : Form
    {
        ClsProductos objproducto = new ClsProductos();
        string Operacion = "Insertar";
        string idprod;
        public PRODUCTOS()
        {
            InitializeComponent();
        }



       
        private void PRODUCTOS_Load(object sender, EventArgs e)
        {

            ListarCategorias();
            ListarMarcas();
            ListarProductos();
        }


        private void ListarCategorias()
        {
            ClsProductos objProd = new ClsProductos();
            CmbCategoria.DataSource = objProd.ListarCategorias();
            CmbCategoria.DisplayMember = "CATEGORIA";
            CmbCategoria.ValueMember = "IDCATEG";
        }
        private void ListarMarcas()
        {
            ClsProductos objProd = new ClsProductos();
            CmbMarca.DataSource = objProd.ListarMarcas();
            CmbMarca.DisplayMember = "MARCA";
            CmbMarca.ValueMember = "IDMARCA";
        }

        private void ListarProductos()
        {
            ClsProductos objprod = new ClsProductos();
            dataGridView1.DataSource = objprod.ListarProductos();
        }

        private void LimpiarFormulario()
        {
            txtDescripcion.Clear();
            txtPrecio.Clear();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (Operacion == "Insertar")
            {
                objproducto._IdCategoria = Convert.ToInt32(CmbCategoria.SelectedValue);
                objproducto._IdMarca = Convert.ToInt32(CmbMarca.SelectedValue);
                objproducto._Descripcion = txtDescripcion.Text;
                objproducto._Precio = Convert.ToDouble(txtPrecio.Text);
                objproducto.InsertarProductos(Convert.ToInt32(CmbCategoria.SelectedValue),
                Convert.ToInt32(CmbMarca.SelectedValue),txtDescripcion.Text,Convert.ToDouble(txtPrecio.Text));
                MessageBox.Show("Se inserto correctamente");
            }
            else if (Operacion == "Editar")
            {
                objproducto._IdCategoria = Convert.ToInt32(CmbCategoria.SelectedValue);
                objproducto._IdMarca = Convert.ToInt32(CmbMarca.SelectedValue);
                objproducto._Descripcion = txtDescripcion.Text;
                objproducto._Precio = Convert.ToDouble(txtPrecio.Text);
                objproducto._Idprod = Convert.ToInt32(idprod);
                objproducto.EditarProductos();
                Operacion = "Insertar";
                MessageBox.Show("Se edito correctamente");
            }
            ListarProductos();
            //Limpiar texboxs
            LimpiarFormulario();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Operacion = "Editar";
                CmbCategoria.Text = dataGridView1.CurrentRow.Cells["CATEGORIA"].Value.ToString();
                CmbMarca.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtDescripcion.Text = dataGridView1.CurrentRow.Cells["DESCRIPCION"].Value.ToString();
                txtPrecio.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                idprod = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            }
            else
                MessageBox.Show("debe seleccionar una fila");
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                objproducto._Idprod = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                objproducto.EliminarProducto();
                MessageBox.Show("Se elimino satisfactoriamente");
                ListarProductos();
            }
            else
                MessageBox.Show("Seleccione una fila");
        }

        private void btn_Reportes_Click(object sender, EventArgs e)
        {

        }
    }
}
