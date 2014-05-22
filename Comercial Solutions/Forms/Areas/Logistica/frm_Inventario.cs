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
            alertas();
            timer1.Start();
         
        }
        public void alertas()
        {
            string query = "select (select nombre_bodega from tbm_almacen where  tbm_almacen.idtbm_bodega=tbt_inventario.tbm_almacen_idtbm_bodega)as ALMACEN,(select medida_producto from tbm_producto_finalizado where tbm_producto_finalizado.idtbm_producto_finalizado=tbt_inventario.tbm_producto_finalizado_idtbm_producto_finalizado)as medida,(select tx_nombre from tbm_producto_finalizado where tbm_producto_finalizado.idtbm_producto_finalizado=tbt_inventario.tbm_producto_finalizado_idtbm_producto_finalizado)as Nombre,(inventario_minimo-cantidad)as 'PRODUCTO FALTANTE' from tbt_inventario where tbt_inventario .cantidad<tbt_inventario.inventario_minimo";
            dgv_alertas.DataSource = ((x.consulta_DataGridView(query)));
            dgv_alertas.Columns[1].Width = 60;
        }
        private void btn_cargar_Click(object sender, EventArgs e)
        {

            string query = "Select * from tbm_producto_finalizado";
            dgv_consulta.DataSource = ((x.consulta_DataGridView(query)));
        }

        private void btn_insertar_Click(object sender, EventArgs e)
        {
            if (txt_cantidad.Text == "" &&  txt_medida.Text == "" )
            {

                MessageBox.Show("No ha ingresado los datos completos, reintente por favor");
            }
            else
            {
                string tabla1 = "tbm_producto_finalizado";
                Dictionary<string, string> dict = new Dictionary<string, string>();

                dict.Add("medida_producto", txt_medida.Text);
                dict.Add("precio_costo", txt_preciocompra.Text);
                //dict.Add("precio_venta", txt_largo.Text);
                //dict.Add("cantidad_producto_finalizado", txt_alto.Text);
                //dict.Add("tx_nombre", txt_ancho.Text);
                //
                // i3nRiqJson x = new i3nRiqJson();
                x.insertar("1", tabla1, dict);
                MessageBox.Show("Trae " + i3nRiqJson.RespuestaConexion.ToString());

                //selecciono los campos de mis textbox
                string nombre_b = cmb_bodega.SelectedValue.ToString();
                string ambiente = cmb_ambiente.SelectedValue.ToString();


                string tabla2 = "tbm_almacen";
                Dictionary<string, string> dict1 = new Dictionary<string, string>();

                dict.Add("nombre_bodega", nombre_b);
                dict.Add("tbm_ambiente_idtbm_ambiente", ambiente);
                dict.Add("tbm_medidas_idtbm_medidas", txt_medida.Text);
            //    dict.Add("alto", txt_alto.Text);
              //  dict.Add("ancho", txt_ancho.Text);
               // dict.Add("fondo", txt_largo.Text);
                //dict.Add("tx_nombre", txt_ancho.Text);
                //
                // i3nRiqJson x = new i3nRiqJson();
                x.insertar("1", tabla2, dict1);
                MessageBox.Show("Trae " + i3nRiqJson.RespuestaConexion.ToString());
            }
        }



        private void cmb_bodega_Click(object sender, EventArgs e)
        {
            string query = "Select * from  tbm_almacen ";
            cmb_bodega.DataSource = (x.consulta_ComboBox(query));
            cmb_bodega.DisplayMember = "nombre_bodega";
        }

        private void cmb_ambiente_Click(object sender, EventArgs e)
        {
            string query = "Select * from tbm_producto_finalizado";
            cmb_ambiente.DataSource = (x.consulta_ComboBox(query));
            cmb_ambiente.DisplayMember = "tx_nombre";
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            string query = "select * from";
            comboBox1.DataSource = ((x.consulta_DataGridView(query)));
            comboBox1.DisplayMember = "employee_name";
            comboBox1.ValueMember = "employee_no";

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if ( txt_cantidad.Text == "" && txt_medida.Text == "" )
            {

                MessageBox.Show("No ha ingresado los datos completos, reintente por favor");
            }
            else
            {
                string tabla1 = "tbm_producto_finalizado";
                Dictionary<string, string> dict = new Dictionary<string, string>();

                dict.Add("medida_producto", txt_medida.Text);
                dict.Add("precio_costo", txt_preciocompra.Text);
            //    dict.Add("precio_venta", txt_largo.Text);
              //  dict.Add("cantidad_producto_finalizado", txt_alto.Text);
                //dict.Add("tx_nombre", txt_ancho.Text);
                //
                // i3nRiqJson x = new i3nRiqJson();
                x.insertar("1", tabla1, dict);
                MessageBox.Show("Trae " + i3nRiqJson.RespuestaConexion.ToString());

                //selecciono los campos de mis textbox
                string nombre_b = cmb_bodega.SelectedValue.ToString();
                string ambiente = cmb_ambiente.SelectedValue.ToString();


                string tabla2 = "tbm_almacen";
                Dictionary<string, string> dict1 = new Dictionary<string, string>();

                dict.Add("nombre_bodega", nombre_b);
                dict.Add("tbm_ambiente_idtbm_ambiente", ambiente);
                dict.Add("tbm_medidas_idtbm_medidas", txt_medida.Text);
            //    dict.Add("alto", txt_alto.Text);
             //   dict.Add("ancho", txt_ancho.Text);
              //  dict.Add("fondo", txt_largo.Text);
                //dict.Add("tx_nombre", txt_ancho.Text);
                //
                // i3nRiqJson x = new i3nRiqJson();
                x.insertar("1", tabla2, dict1);
                MessageBox.Show("Trae " + i3nRiqJson.RespuestaConexion.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string query = "Select p.tx_nombre as 'Nombre producto', p.cantidad_producto_finalizado as 'Cantidad', p.medida_producto as 'Medida',i.cantidad as 'Existencia actual', from tbm_producto_finalizado as p, tbm_inventario as i where t.id_producto_finalizado = i.tbm_producto_finalizado_idtbm_producto_finalizado and i.advertencia = '1'";
            dgv_consulta.DataSource = ((x.consulta_DataGridView(query)));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            alertas();
        }

   

        // private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

    }
}

