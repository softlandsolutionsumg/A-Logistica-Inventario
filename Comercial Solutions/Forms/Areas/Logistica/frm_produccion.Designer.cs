namespace Comercial_Solutions.Forms.Areas.Logistica
{
    partial class frm_produccion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_produccion = new System.Windows.Forms.Label();
            this.gpb_datos = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_consulta_produccion = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_medida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpb_datos.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consulta_produccion)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Comercial_Solutions.Properties.Resources.search;
            this.pictureBox4.Location = new System.Drawing.Point(205, 72);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.TabIndex = 25;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Comercial_Solutions.Properties.Resources.refresh;
            this.pictureBox3.Location = new System.Drawing.Point(149, 72);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Comercial_Solutions.Properties.Resources.delete;
            this.pictureBox2.Location = new System.Drawing.Point(93, 72);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Comercial_Solutions.Properties.Resources.check;
            this.pictureBox1.Location = new System.Drawing.Point(37, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_produccion
            // 
            this.lbl_produccion.AutoSize = true;
            this.lbl_produccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_produccion.Location = new System.Drawing.Point(31, 24);
            this.lbl_produccion.Name = "lbl_produccion";
            this.lbl_produccion.Size = new System.Drawing.Size(150, 31);
            this.lbl_produccion.TabIndex = 21;
            this.lbl_produccion.Text = "Producción";
            // 
            // gpb_datos
            // 
            this.gpb_datos.Controls.Add(this.txt_precio);
            this.gpb_datos.Controls.Add(this.label4);
            this.gpb_datos.Controls.Add(this.txt_medida);
            this.gpb_datos.Controls.Add(this.label3);
            this.gpb_datos.Controls.Add(this.txt_cantidad);
            this.gpb_datos.Controls.Add(this.label2);
            this.gpb_datos.Controls.Add(this.txt_nombre);
            this.gpb_datos.Controls.Add(this.label1);
            this.gpb_datos.Location = new System.Drawing.Point(37, 169);
            this.gpb_datos.Name = "gpb_datos";
            this.gpb_datos.Size = new System.Drawing.Size(218, 203);
            this.gpb_datos.TabIndex = 26;
            this.gpb_datos.TabStop = false;
            this.gpb_datos.Text = "Insercion";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_consulta_produccion);
            this.groupBox2.Location = new System.Drawing.Point(291, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 285);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consulta";
            // 
            // dgv_consulta_produccion
            // 
            this.dgv_consulta_produccion.AllowUserToAddRows = false;
            this.dgv_consulta_produccion.AllowUserToDeleteRows = false;
            this.dgv_consulta_produccion.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_consulta_produccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_consulta_produccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_consulta_produccion.Location = new System.Drawing.Point(18, 31);
            this.dgv_consulta_produccion.Name = "dgv_consulta_produccion";
            this.dgv_consulta_produccion.RowHeadersVisible = false;
            this.dgv_consulta_produccion.Size = new System.Drawing.Size(321, 238);
            this.dgv_consulta_produccion.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(106, 50);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 1;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(106, 86);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(100, 20);
            this.txt_cantidad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad ";
            // 
            // txt_medida
            // 
            this.txt_medida.Location = new System.Drawing.Point(106, 123);
            this.txt_medida.Name = "txt_medida";
            this.txt_medida.Size = new System.Drawing.Size(100, 20);
            this.txt_medida.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Medida";
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(106, 162);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(100, 20);
            this.txt_precio.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Precio costo";
            // 
            // timer1
            // 
            this.timer1.Interval = 40000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // frm_produccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 424);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gpb_datos);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_produccion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_produccion";
            this.Load += new System.EventHandler(this.frm_produccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpb_datos.ResumeLayout(false);
            this.gpb_datos.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consulta_produccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_produccion;
        private System.Windows.Forms.GroupBox gpb_datos;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_medida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_consulta_produccion;
        private System.Windows.Forms.Timer timer1;
    }
}