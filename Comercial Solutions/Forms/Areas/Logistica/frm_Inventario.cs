using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comercial_Solutions.Clases;
using i3nRiqJSON;

namespace Comercial_Solutions.Forms.Areas.Logistica
{
    public partial class frm_inventario : Form
    {
        int X = 0;
        int Y = 0;
        public frm_inventario()
        {
            X = Propp.X;
            Y = Propp.Y;
            InitializeComponent();
        }
        i3nRiqJson x = new i3nRiqJson();
        private void Inventario_Load(object sender, EventArgs e)
        {
            this.Size = new Size(X, Y);
            this.Location = new Point(250, 56);
        }

        private void btn_cargar_Click(object sender, EventArgs e)
        {
        
            string query = "Select * from tbm_producto_finalizado";
            dataGridView1.DataSource = ((x.consulta_DataGridView(query)));
        }

        private void btn_insertar_Click(object sender, EventArgs e)
        {
            string tabla = "tbm_producto_finalizado";
            Dictionary<string, string> dict = new Dictionary<string, string>();
           
            dict.Add("medida_producto", txt_medida.Text);
            dict.Add("precio_costo", txt_preciocompra.Text);
            dict.Add("precio_venta", txt_precioventa.Text); 
            dict.Add("cantidad_producto_finalizado", txt_cantidad.Text);
            dict.Add("tx_nombre", txt_nombre.Text);
            //
           // i3nRiqJson x = new i3nRiqJson();
            x.insertar("1", tabla, dict);
            MessageBox.Show("Trae " + i3nRiqJson.RespuestaConexion.ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            string query = "Select medida_producto from tbm_producto_finalizado";
            comboBox1.DataSource = (x.consulta_ComboBox(query));
            comboBox1.DisplayMember = "medida_producto";

        }
    }
}
