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
using System.Collections;

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

        //banderas de indican seleccion de combos
        bool ingresarpedido = false;
        bool ingresoproducto = false;

        bool seleccioninsercionordencompra = false;
        bool seleccioninsercionalmacen = false;

        bool seleccionalmacen = false;
        bool selecciondelproducto = false; 


        string idalmacen;
        string idproducto;
        private void Inventario_Load(object sender, EventArgs e)
        {
            this.Size = new Size(X, Y);
            this.Location = new Point(250, 56);

            //dateTimePicker2.Value = DateTime.Now;

            inventario();
            alertas();
            timer1.Start();
         
        }
        public void alertas()
        {
            string query = "select (select nombre_bodega from tbm_almacen where  tbm_almacen.idtbm_bodega=tbt_inventario.tbm_almacen_idtbm_bodega)as ALMACEN,(select medida_producto from tbm_producto_finalizado where tbm_producto_finalizado.idtbm_producto_finalizado=tbt_inventario.tbm_producto_finalizado_idtbm_producto_finalizado)as medida,(select tx_nombre from tbm_producto_finalizado where tbm_producto_finalizado.idtbm_producto_finalizado=tbt_inventario.tbm_producto_finalizado_idtbm_producto_finalizado)as Nombre,(inventario_minimo-cantidad)as 'PRODUCTO FALTANTE' from tbt_inventario where tbt_inventario .cantidad<tbt_inventario.inventario_minimo";
            dgv_alertas.DataSource = ((x.consulta_DataGridView(query)));
 
            dgv_alertas.Columns[1].Width = 60;
        }
        public void inventario()
        {
            string query2 = "select p.tx_nombre as 'Nombre del Producto', i.cantidad as 'Cantidad', b.nombre_bodega as 'Ubicado en Bodega', i.inventario_minimo as 'Cantidad mínima permitida' from tbt_inventario as i, tbm_almacen as b, tbm_producto_finalizado as p where i.tbm_almacen_idtbm_bodega = b.idtbm_bodega and i.tbm_producto_finalizado_idtbm_producto_finalizado = p.idtbm_producto_finalizado";
            dgv_vista.DataSource = ((x.consulta_DataGridView(query2)));
            
        }

        public void productos()
        {
            string consulta = "Select tx_nombre as 'Nombre', cantidad_producto_finalizado as 'Cantidad',medida_producto as 'Dimencional',precio_costo as 'Costo del producto', ultima_vez_modificado as 'Fecha de último ingreso' from tbm_producto_finalizado order by idtbm_producto_finalizado ";
            dgv_vista_consulta.DataSource = ((x.consulta_DataGridView(consulta)));
            
        }
       
        public void insertar()
        {
            if (ingresarpedido == true) 
            {
                string tabla1 = "tbm_producto_finalizado";
                string condicion = "where idtbm_ordendeproduccion = " + cmb_orden_p.SelectedValue.ToString();
                Dictionary<string, string> dict = new Dictionary<string, string>();
                //dict.Add("", .Text);
                //string condicion = "employee_no= " + txtNOEM.Text;
                
                x.actualizar("3",tabla1, dict,condicion);
                MessageBox.Show("Trae " + i3nRiqJson.RespuestaConexion.ToString());

                //selecciono los campos de mis textbox
                string nombre_b = cmb_bodega.SelectedValue.ToString();
                string ambiente = cmb_ambiente.SelectedValue.ToString();

                 

            }
            if (ingresoproducto == true)
            {
                string tabla1 = "tbm_producto_finalizado";
                Dictionary<string, string> dict = new Dictionary<string, string>();

                //dict.Add("medida_producto", txt_medida.Text);
                //dict.Add("precio_costo", txt_preciocompra.Text);

                x.insertar("1", tabla1, dict);
                MessageBox.Show("Trae " + i3nRiqJson.RespuestaConexion.ToString());

                //selecciono los campos de mis textbox
                string nombre_b = cmb_bodega.SelectedValue.ToString();
                string ambiente = cmb_ambiente.SelectedValue.ToString();


               
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

        private void cmb_seleccion_bodega_Click(object sender, EventArgs e)
        {
        comboalmacen();
        }
        public void comboalmacen()
        
        {
            string query = "select * from tbm_almacen";
            cmb_seleccion_bodega.DataSource = ((x.consulta_ComboBox(query)));
            cmb_seleccion_bodega.DisplayMember = "nombre_bodega";
            cmb_seleccion_bodega.ValueMember = "idtbm_bodega";

            idalmacen = cmb_seleccion_bodega.SelectedValue.ToString();
            //bandera de selección del almacén activa
            seleccionalmacen = true;

            string consulta = "Select p.tx_nombre as 'Nombre', i.cantidad as 'Cantidad',p.medida_producto as 'Dimencional',p.precio_costo as 'Costo del producto', p.ultima_vez_modificado as 'Fecha de ultimo ingreso' from tbm_producto_finalizado as p, tbt_inventario as i, tbm_almacen as a where "+idalmacen+" = a.idtbm_bodega and p.idtbm_producto_finalizado = i.tbm_producto_finalizado_idtbm_producto_finalizado order by p.idtbm_producto_finalizado";
            dgv_vista_consulta.DataSource = ((x.consulta_DataGridView(consulta)));

            if (selecciondelproducto == true)
            {
                string consultaprincipal = " Select p.tx_nombre as 'Nombre', i.cantidad as 'Cantidad',p.medida_producto as 'Dimencional',p.precio_costo as 'Costo del producto', p.ultima_vez_modificado as 'Fecha de ultimo ingreso' from tbm_producto_finalizado as p, tbt_inventario as i, tbm_almacen as a where " + idalmacen + " = a.idtbm_bodega and " + idproducto + " = i.tbm_producto_finalizado_idtbm_producto_finalizado order by p.idtbm_producto_finalizado";
                dgv_vista_consulta.DataSource = ((x.consulta_DataGridView(consultaprincipal)));
            }
            else
            {
                string consultaalmacen = "Select p.tx_nombre as 'Nombre', i.cantidad as 'Cantidad',p.medida_producto as 'Dimencional',p.precio_costo as 'Costo del producto', p.ultima_vez_modificado as 'Fecha de ultimo ingreso' from tbm_producto_finalizado as p, tbt_inventario as i, tbm_almacen as a where i.tbm_almacen_idtbm_bodega = a.idtbm_bodega and " + idproducto + " = i.tbm_producto_finalizado_idtbm_producto_finalizado order by p.idtbm_producto_finalizado";
                dgv_vista_consulta.DataSource = ((x.consulta_DataGridView(consultaalmacen)));
            } 
        }

        public void combobodega()
        {

            string query = "select * from tbm_almacen";
            cmb_almacen.DataSource = ((x.consulta_ComboBox(query)));
            cmb_almacen.DisplayMember = "nombre_bodega";
            cmb_almacen.ValueMember = "idtbm_bodega";

            idalmacen = cmb_almacen.SelectedValue.ToString();
        }
        
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string query = "Select p.tx_nombre as 'Nombre producto', p.cantidad_producto_finalizado as 'Cantidad', p.medida_producto as 'Medida',i.cantidad as 'Existencia actual', from tbm_producto_finalizado as p, tbm_inventario as i where t.id_producto_finalizado = i.tbm_producto_finalizado_idtbm_producto_finalizado and i.advertencia = '1'";
            dgv_consulta.DataSource = ((x.consulta_DataGridView(query)));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            alertas();
            inventario();
        }

        private void cmb_selección_producto_Click(object sender, EventArgs e)
        {
            string query = "select * from tbm_producto_finalizado";
            cmb_selección_producto.DataSource = ((x.consulta_ComboBox(query)));
            cmb_selección_producto.DisplayMember = "tx_nombre";
            cmb_selección_producto.ValueMember = "idtbm_producto_finalizado";

            idproducto = cmb_selección_producto.SelectedValue.ToString();
            selecciondelproducto = true;
 
            if (seleccionalmacen == true)
            {
                string consultaprincipal = " Select p.tx_nombre as 'Nombre', i.cantidad as 'Cantidad',p.medida_producto as 'Dimencional',p.precio_costo as 'Costo del producto', p.ultima_vez_modificado as 'Fecha de ultimo ingreso' from tbm_producto_finalizado as p, tbt_inventario as i, tbm_almacen as a where " + idalmacen + " = a.idtbm_bodega and " + idproducto + " = i.tbm_producto_finalizado_idtbm_producto_finalizado order by p.idtbm_producto_finalizado";
                dgv_vista_consulta.DataSource = ((x.consulta_DataGridView(consultaprincipal)));
            }
            else
            {
                string consultaproducto = "Select p.tx_nombre as 'Nombre', i.cantidad as 'Cantidad',p.medida_producto as 'Dimencional',p.precio_costo as 'Costo del producto', p.ultima_vez_modificado as 'Fecha de ultimo ingreso' from tbm_producto_finalizado as p, tbt_inventario as i, tbm_almacen as a where i.tbm_almacen_idtbm_bodega = a.idtbm_bodega and " + idproducto + " = i.tbm_producto_finalizado_idtbm_producto_finalizado order by p.idtbm_producto_finalizado";
                dgv_vista_consulta.DataSource = ((x.consulta_DataGridView(consultaproducto)));
            } 
            
        }

        private void btn_insertar_Click(object sender, EventArgs e)
        {
            insertar();
            
        }

       

        private void cmb_orden_p_Click_1(object sender, EventArgs e)
        {
            string consulta = "select idtbm_ordendeproduccion from tbm_ordendeproduccion where estado = 1";
            cmb_orden_p.DataSource = ((x.consulta_ComboBox(consulta)));
            cmb_orden_p.DisplayMember = "idtbm_ordendeproduccion";
            cmb_orden_p.ValueMember =   "idtbm_ordendeproduccion";

            seleccioninsercionordencompra = true;

            string condicional = cmb_orden_p.SelectedValue.ToString();

            string query = "select tbm_producto_finalizado_idtbm_producto_finalizado as 'Numero de orden', (select f.tx_nombre from tbm_producto_finalizado as f, tbm_ordendeproduccion as pr where f.idtbm_producto_finalizado = pr.tbm_producto_finalizado_idtbm_producto_finalizado and pr.idtbm_ordendeproduccion = "+ condicional + ") as 'nombre',producto_requerido as 'cantidad' from tbm_ordendeproduccion where idtbm_ordendeproduccion = " + condicional + " ";
          
            ArrayList array = x.consultar(query);
            foreach (Dictionary<string, string> v in array)
            {

                lbl_nom_producto.Text = v["nombre"];
                lbl_numero.Text = v["cantidad"];
            }
            lbl_fecha.Text = DateTime.Now.ToString();

            //ingresarpedido = true;
        }

        private void cmb_almacen_Click(object sender, EventArgs e)
        {
            combobodega();
        }

        private void btn_cargar_Click_1(object sender, EventArgs e)
        {
            //cargar();
        }

        private void btn_bloquear_Click(object sender, EventArgs e)
        {
            lbl_fecha.Text= DateTime.Now.ToString();
            gpb_ingreso.Visible = true;
        }

   

       

    }
}

