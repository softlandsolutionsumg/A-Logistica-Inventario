namespace Comercial_Solutions.Forms.Areas.Logistica
{
    partial class frm_inventario
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
            this.label12 = new System.Windows.Forms.Label();
            this.btn_insertar = new System.Windows.Forms.PictureBox();
            this.btn_eliminar = new System.Windows.Forms.PictureBox();
            this.btn_actualizar = new System.Windows.Forms.PictureBox();
            this.btn_bloquear = new System.Windows.Forms.PictureBox();
            this.dgv_alertas = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.g = new System.Windows.Forms.TabPage();
            this.gpb_consulta = new System.Windows.Forms.GroupBox();
            this.dgv_vista = new System.Windows.Forms.DataGridView();
            this.gpb_ingreso = new System.Windows.Forms.GroupBox();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_nom_producto = new System.Windows.Forms.Label();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_almacen = new System.Windows.Forms.ComboBox();
            this.cmb_orden_p = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cmb_selección_producto = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dgv_vista_consulta = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_seleccion_bodega = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_ambiente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_bodega = new System.Windows.Forms.ComboBox();
            this.dgv_consulta = new System.Windows.Forms.DataGridView();
            this.tab_consulta = new System.Windows.Forms.TabControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_cargar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_insertar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_eliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_actualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_bloquear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alertas)).BeginInit();
            this.g.SuspendLayout();
            this.gpb_consulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vista)).BeginInit();
            this.gpb_ingreso.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vista_consulta)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consulta)).BeginInit();
            this.tab_consulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cargar)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(38, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 31);
            this.label12.TabIndex = 1;
            this.label12.Text = "Inventarios";
            // 
            // btn_insertar
            // 
            this.btn_insertar.Image = global::Comercial_Solutions.Properties.Resources.save;
            this.btn_insertar.Location = new System.Drawing.Point(128, 66);
            this.btn_insertar.Name = "btn_insertar";
            this.btn_insertar.Size = new System.Drawing.Size(50, 50);
            this.btn_insertar.TabIndex = 17;
            this.btn_insertar.TabStop = false;
            this.btn_insertar.Click += new System.EventHandler(this.btn_insertar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Image = global::Comercial_Solutions.Properties.Resources.delete;
            this.btn_eliminar.Location = new System.Drawing.Point(240, 66);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(50, 50);
            this.btn_eliminar.TabIndex = 18;
            this.btn_eliminar.TabStop = false;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Image = global::Comercial_Solutions.Properties.Resources.refresh;
            this.btn_actualizar.Location = new System.Drawing.Point(72, 66);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(50, 50);
            this.btn_actualizar.TabIndex = 19;
            this.btn_actualizar.TabStop = false;
            this.btn_actualizar.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // btn_bloquear
            // 
            this.btn_bloquear.Image = global::Comercial_Solutions.Properties.Resources.edit;
            this.btn_bloquear.Location = new System.Drawing.Point(184, 66);
            this.btn_bloquear.Name = "btn_bloquear";
            this.btn_bloquear.Size = new System.Drawing.Size(50, 50);
            this.btn_bloquear.TabIndex = 20;
            this.btn_bloquear.TabStop = false;
            this.btn_bloquear.Click += new System.EventHandler(this.btn_bloquear_Click);
            // 
            // dgv_alertas
            // 
            this.dgv_alertas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_alertas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_alertas.Location = new System.Drawing.Point(390, 75);
            this.dgv_alertas.Name = "dgv_alertas";
            this.dgv_alertas.RowHeadersVisible = false;
            this.dgv_alertas.Size = new System.Drawing.Size(370, 80);
            this.dgv_alertas.TabIndex = 21;
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Alerta de existencia de productos.";
            // 
            // g
            // 
            this.g.Controls.Add(this.gpb_consulta);
            this.g.Controls.Add(this.gpb_ingreso);
            this.g.Location = new System.Drawing.Point(4, 22);
            this.g.Name = "g";
            this.g.Padding = new System.Windows.Forms.Padding(3);
            this.g.Size = new System.Drawing.Size(730, 314);
            this.g.TabIndex = 3;
            this.g.Text = "Inventarios";
            this.g.UseVisualStyleBackColor = true;
            // 
            // gpb_consulta
            // 
            this.gpb_consulta.Controls.Add(this.dgv_vista);
            this.gpb_consulta.Location = new System.Drawing.Point(6, 25);
            this.gpb_consulta.Name = "gpb_consulta";
            this.gpb_consulta.Size = new System.Drawing.Size(436, 260);
            this.gpb_consulta.TabIndex = 1;
            this.gpb_consulta.TabStop = false;
            this.gpb_consulta.Text = "Vista";
            // 
            // dgv_vista
            // 
            this.dgv_vista.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_vista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vista.Location = new System.Drawing.Point(9, 19);
            this.dgv_vista.Name = "dgv_vista";
            this.dgv_vista.RowHeadersVisible = false;
            this.dgv_vista.Size = new System.Drawing.Size(408, 235);
            this.dgv_vista.TabIndex = 23;
            // 
            // gpb_ingreso
            // 
            this.gpb_ingreso.Controls.Add(this.lbl_fecha);
            this.gpb_ingreso.Controls.Add(this.label10);
            this.gpb_ingreso.Controls.Add(this.lbl_nom_producto);
            this.gpb_ingreso.Controls.Add(this.lbl_numero);
            this.gpb_ingreso.Controls.Add(this.label8);
            this.gpb_ingreso.Controls.Add(this.cmb_almacen);
            this.gpb_ingreso.Controls.Add(this.cmb_orden_p);
            this.gpb_ingreso.Controls.Add(this.label7);
            this.gpb_ingreso.Controls.Add(this.label6);
            this.gpb_ingreso.Controls.Add(this.label5);
            this.gpb_ingreso.Location = new System.Drawing.Point(475, 42);
            this.gpb_ingreso.Name = "gpb_ingreso";
            this.gpb_ingreso.Size = new System.Drawing.Size(200, 237);
            this.gpb_ingreso.TabIndex = 0;
            this.gpb_ingreso.TabStop = false;
            this.gpb_ingreso.Text = "Ingresos";
            this.gpb_ingreso.Visible = false;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Location = new System.Drawing.Point(82, 215);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(0, 13);
            this.lbl_fecha.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Fecha ";
            // 
            // lbl_nom_producto
            // 
            this.lbl_nom_producto.AutoSize = true;
            this.lbl_nom_producto.Location = new System.Drawing.Point(82, 148);
            this.lbl_nom_producto.Name = "lbl_nom_producto";
            this.lbl_nom_producto.Size = new System.Drawing.Size(0, 13);
            this.lbl_nom_producto.TabIndex = 8;
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Location = new System.Drawing.Point(82, 185);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(0, 13);
            this.lbl_numero.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Cantidad";
            // 
            // cmb_almacen
            // 
            this.cmb_almacen.FormattingEnabled = true;
            this.cmb_almacen.Location = new System.Drawing.Point(82, 101);
            this.cmb_almacen.Name = "cmb_almacen";
            this.cmb_almacen.Size = new System.Drawing.Size(106, 21);
            this.cmb_almacen.TabIndex = 4;
            this.cmb_almacen.Click += new System.EventHandler(this.cmb_almacen_Click);
            // 
            // cmb_orden_p
            // 
            this.cmb_orden_p.FormattingEnabled = true;
            this.cmb_orden_p.Location = new System.Drawing.Point(82, 60);
            this.cmb_orden_p.Name = "cmb_orden_p";
            this.cmb_orden_p.Size = new System.Drawing.Size(106, 21);
            this.cmb_orden_p.TabIndex = 3;
            this.cmb_orden_p.Click += new System.EventHandler(this.cmb_orden_p_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Producto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Almacén";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "Orden de\r\nProducción";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.cmb_selección_producto);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.dgv_vista_consulta);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.cmb_seleccion_bodega);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(730, 314);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Productos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Location = new System.Drawing.Point(498, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 246);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingresos";
            this.groupBox2.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(114, 172);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(90, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(114, 139);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(90, 20);
            this.textBox4.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(114, 108);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(90, 20);
            this.textBox3.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(114, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(90, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(90, 20);
            this.textBox1.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 26);
            this.label9.TabIndex = 7;
            this.label9.Text = "Fecha de ultima\r\n modificacion";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 133);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 26);
            this.label14.TabIndex = 6;
            this.label14.Text = "Medida de \r\nproducción";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 109);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Precio Costo";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 82);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Cantidad";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 51);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Nombre";
            // 
            // cmb_selección_producto
            // 
            this.cmb_selección_producto.FormattingEnabled = true;
            this.cmb_selección_producto.Location = new System.Drawing.Point(74, 36);
            this.cmb_selección_producto.Name = "cmb_selección_producto";
            this.cmb_selección_producto.Size = new System.Drawing.Size(121, 21);
            this.cmb_selección_producto.TabIndex = 4;
            this.cmb_selección_producto.Click += new System.EventHandler(this.cmb_selección_producto_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Producto";
            // 
            // dgv_vista_consulta
            // 
            this.dgv_vista_consulta.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_vista_consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vista_consulta.Location = new System.Drawing.Point(12, 68);
            this.dgv_vista_consulta.Name = "dgv_vista_consulta";
            this.dgv_vista_consulta.Size = new System.Drawing.Size(457, 226);
            this.dgv_vista_consulta.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Bodega";
            // 
            // cmb_seleccion_bodega
            // 
            this.cmb_seleccion_bodega.FormattingEnabled = true;
            this.cmb_seleccion_bodega.Location = new System.Drawing.Point(74, 9);
            this.cmb_seleccion_bodega.Name = "cmb_seleccion_bodega";
            this.cmb_seleccion_bodega.Size = new System.Drawing.Size(121, 21);
            this.cmb_seleccion_bodega.TabIndex = 0;
            this.cmb_seleccion_bodega.Click += new System.EventHandler(this.cmb_seleccion_bodega_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmb_ambiente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmb_bodega);
            this.groupBox1.Location = new System.Drawing.Point(15, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 259);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Almacenaje";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(84, 104);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 26);
            this.label4.TabIndex = 13;
            this.label4.Text = "Orden de\r\nProducción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Almacen";
            // 
            // cmb_ambiente
            // 
            this.cmb_ambiente.FormattingEnabled = true;
            this.cmb_ambiente.Location = new System.Drawing.Point(84, 57);
            this.cmb_ambiente.Name = "cmb_ambiente";
            this.cmb_ambiente.Size = new System.Drawing.Size(100, 21);
            this.cmb_ambiente.TabIndex = 12;
            this.cmb_ambiente.Click += new System.EventHandler(this.cmb_ambiente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Producto";
            // 
            // cmb_bodega
            // 
            this.cmb_bodega.FormattingEnabled = true;
            this.cmb_bodega.Location = new System.Drawing.Point(84, 27);
            this.cmb_bodega.Name = "cmb_bodega";
            this.cmb_bodega.Size = new System.Drawing.Size(100, 21);
            this.cmb_bodega.TabIndex = 11;
            this.cmb_bodega.Click += new System.EventHandler(this.cmb_bodega_Click);
            // 
            // dgv_consulta
            // 
            this.dgv_consulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_consulta.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_consulta.Location = new System.Drawing.Point(247, 24);
            this.dgv_consulta.Name = "dgv_consulta";
            this.dgv_consulta.Size = new System.Drawing.Size(465, 259);
            this.dgv_consulta.TabIndex = 15;
            // 
            // tab_consulta
            // 
            this.tab_consulta.Controls.Add(this.tabPage2);
            this.tab_consulta.Controls.Add(this.g);
            this.tab_consulta.Location = new System.Drawing.Point(33, 161);
            this.tab_consulta.Name = "tab_consulta";
            this.tab_consulta.SelectedIndex = 0;
            this.tab_consulta.Size = new System.Drawing.Size(738, 340);
            this.tab_consulta.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Comercial_Solutions.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(296, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // btn_cargar
            // 
            this.btn_cargar.Image = global::Comercial_Solutions.Properties.Resources.folder;
            this.btn_cargar.Location = new System.Drawing.Point(16, 66);
            this.btn_cargar.Name = "btn_cargar";
            this.btn_cargar.Size = new System.Drawing.Size(50, 50);
            this.btn_cargar.TabIndex = 24;
            this.btn_cargar.TabStop = false;
            this.btn_cargar.Click += new System.EventHandler(this.btn_cargar_Click_1);
            // 
            // frm_inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 513);
            this.Controls.Add(this.btn_cargar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_alertas);
            this.Controls.Add(this.btn_bloquear);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_insertar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tab_consulta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_inventario";
            this.Text = "l";
            this.Load += new System.EventHandler(this.Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_insertar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_eliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_actualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_bloquear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alertas)).EndInit();
            this.g.ResumeLayout(false);
            this.gpb_consulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vista)).EndInit();
            this.gpb_ingreso.ResumeLayout(false);
            this.gpb_ingreso.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vista_consulta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consulta)).EndInit();
            this.tab_consulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cargar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox btn_insertar;
        private System.Windows.Forms.PictureBox btn_eliminar;
        private System.Windows.Forms.PictureBox btn_actualizar;
        private System.Windows.Forms.PictureBox btn_bloquear;
        private System.Windows.Forms.DataGridView dgv_alertas;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage g;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cmb_selección_producto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgv_vista_consulta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmb_seleccion_bodega;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_ambiente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_bodega;
        private System.Windows.Forms.DataGridView dgv_consulta;
        private System.Windows.Forms.TabControl tab_consulta;
        private System.Windows.Forms.GroupBox gpb_consulta;
        private System.Windows.Forms.DataGridView dgv_vista;
        private System.Windows.Forms.GroupBox gpb_ingreso;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_almacen;
        private System.Windows.Forms.ComboBox cmb_orden_p;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_nom_producto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox btn_cargar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_fecha;

    }
}