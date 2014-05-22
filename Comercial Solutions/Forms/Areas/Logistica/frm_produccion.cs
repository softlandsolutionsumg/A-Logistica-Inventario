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
    public partial class frm_produccion : Form
    {
        
        int X = 0;
        int Y = 0;
        public frm_produccion()
        {
            
            X = Propp.X;
            Y = Propp.Y;
            InitializeComponent();
        }
        i3nRiqJson x = new i3nRiqJson();
        private void frm_produccion_Load(object sender, EventArgs e)
        {
            this.Size = new Size(X, Y);
            this.Location = new Point(250, 56);
            cargar();
            timer1.Start();


        }

        public void cargar()
        {
            string query = "select tx_nombre as 'Nombre', cantidad_producto_finalizado as 'Cantidad', medida_producto as 'Medida', precio_costo as 'Precio' from tbm_producto_finalizado";
            dgv_consulta_produccion.DataSource = ((x.consulta_DataGridView(query)));
            dgv_consulta_produccion.Columns[1].Width = 60;
            dgv_consulta_produccion.Columns[2].Width = 60;
            dgv_consulta_produccion.Columns[3].Width = 60;

        }
        public void inserta()
        {
            string tabla = "tbm_producto_finalizado";
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("cantidad_producto_finalizado", txt_cantidad.Text);
            dict.Add("precio_costo", txt_precio.Text);
            dict.Add("medida_producto", txt_medida.Text);
            dict.Add("tx_nombre", txt_nombre.Text);
            x.insertar("1", tabla, dict);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            inserta();
        }
       

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            cargar();
        }
    }
}
