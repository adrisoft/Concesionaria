namespace Concesionarias.MDI
{
    partial class FrmArticulos
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Txt_TotalVenta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_TotalLista = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_CantidadRegistros = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DG_Datos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.MostrarAnuladoscheckBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.IvaIncluidocheckBox1 = new System.Windows.Forms.CheckBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Stock_Repocicion_radioButton3 = new System.Windows.Forms.RadioButton();
            this.Stock_ConStock_radioButton2 = new System.Windows.Forms.RadioButton();
            this.Stock_Todos_radioButton1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_NombreTercero = new System.Windows.Forms.TextBox();
            this.Btn_BuscarTercero = new System.Windows.Forms.Button();
            this.id_TerceroTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Codigo = new System.Windows.Forms.TextBox();
            this.Cbo_Categoria = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CboLinea = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Id = new System.Windows.Forms.TextBox();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Baja = new System.Windows.Forms.Button();
            this.Btn_Alta = new System.Windows.Forms.Button();
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.Btn_Editar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.ImgIcono = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Btn_VistaPrevia = new System.Windows.Forms.Button();
            this.Btn_Papel = new System.Windows.Forms.Button();
            this.Btn_Opciones = new System.Windows.Forms.Button();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.MyPrintDocument = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Datos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.Txt_TotalVenta);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.Txt_TotalLista);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.Txt_CantidadRegistros);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(5, 349);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1178, 50);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Totales";
            // 
            // Txt_TotalVenta
            // 
            this.Txt_TotalVenta.Enabled = false;
            this.Txt_TotalVenta.Location = new System.Drawing.Point(546, 17);
            this.Txt_TotalVenta.Name = "Txt_TotalVenta";
            this.Txt_TotalVenta.Size = new System.Drawing.Size(102, 20);
            this.Txt_TotalVenta.TabIndex = 6;
            this.Txt_TotalVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(452, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Total (venta + iva):";
            // 
            // Txt_TotalLista
            // 
            this.Txt_TotalLista.Enabled = false;
            this.Txt_TotalLista.Location = new System.Drawing.Point(353, 17);
            this.Txt_TotalLista.Name = "Txt_TotalLista";
            this.Txt_TotalLista.Size = new System.Drawing.Size(93, 20);
            this.Txt_TotalLista.TabIndex = 4;
            this.Txt_TotalLista.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Total (lista + iva):";
            // 
            // Txt_CantidadRegistros
            // 
            this.Txt_CantidadRegistros.Enabled = false;
            this.Txt_CantidadRegistros.Location = new System.Drawing.Point(123, 17);
            this.Txt_CantidadRegistros.Name = "Txt_CantidadRegistros";
            this.Txt_CantidadRegistros.Size = new System.Drawing.Size(61, 20);
            this.Txt_CantidadRegistros.TabIndex = 2;
            this.Txt_CantidadRegistros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cantidad de registros:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.DG_Datos);
            this.groupBox2.Location = new System.Drawing.Point(5, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1178, 188);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Articulos";
            // 
            // DG_Datos
            // 
            this.DG_Datos.AllowUserToAddRows = false;
            this.DG_Datos.AllowUserToDeleteRows = false;
            this.DG_Datos.AllowUserToOrderColumns = true;
            this.DG_Datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DG_Datos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DG_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Datos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DG_Datos.Location = new System.Drawing.Point(3, 16);
            this.DG_Datos.MultiSelect = false;
            this.DG_Datos.Name = "DG_Datos";
            this.DG_Datos.ReadOnly = true;
            this.DG_Datos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_Datos.Size = new System.Drawing.Size(1172, 169);
            this.DG_Datos.TabIndex = 0;
            this.DG_Datos.Click += new System.EventHandler(this.DG_Datos_Click);
            this.DG_Datos.DoubleClick += new System.EventHandler(this.DG_Datos_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.MostrarAnuladoscheckBox2);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Txt_NombreTercero);
            this.groupBox1.Controls.Add(this.Btn_BuscarTercero);
            this.groupBox1.Controls.Add(this.id_TerceroTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Txt_Codigo);
            this.groupBox1.Controls.Add(this.Cbo_Categoria);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.CboLinea);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Txt_Id);
            this.groupBox1.Controls.Add(this.Btn_Buscar);
            this.groupBox1.Location = new System.Drawing.Point(139, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1044, 144);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 20);
            this.button1.TabIndex = 161;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MostrarAnuladoscheckBox2
            // 
            this.MostrarAnuladoscheckBox2.AutoSize = true;
            this.MostrarAnuladoscheckBox2.Checked = true;
            this.MostrarAnuladoscheckBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MostrarAnuladoscheckBox2.Location = new System.Drawing.Point(581, 19);
            this.MostrarAnuladoscheckBox2.Name = "MostrarAnuladoscheckBox2";
            this.MostrarAnuladoscheckBox2.Size = new System.Drawing.Size(107, 17);
            this.MostrarAnuladoscheckBox2.TabIndex = 160;
            this.MostrarAnuladoscheckBox2.Text = "Mostrar anulados";
            this.MostrarAnuladoscheckBox2.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.IvaIncluidocheckBox1);
            this.groupBox5.Controls.Add(this.radioButton4);
            this.groupBox5.Controls.Add(this.radioButton5);
            this.groupBox5.Location = new System.Drawing.Point(450, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(124, 126);
            this.groupBox5.TabIndex = 159;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Precio";
            // 
            // IvaIncluidocheckBox1
            // 
            this.IvaIncluidocheckBox1.AutoSize = true;
            this.IvaIncluidocheckBox1.Checked = true;
            this.IvaIncluidocheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IvaIncluidocheckBox1.Location = new System.Drawing.Point(5, 19);
            this.IvaIncluidocheckBox1.Name = "IvaIncluidocheckBox1";
            this.IvaIncluidocheckBox1.Size = new System.Drawing.Size(113, 17);
            this.IvaIncluidocheckBox1.TabIndex = 3;
            this.IvaIncluidocheckBox1.Text = "Con I.V.A. incluido";
            this.IvaIncluidocheckBox1.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 65);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(100, 17);
            this.radioButton4.TabIndex = 2;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Precio de venta";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.Visible = false;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(6, 42);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(91, 17);
            this.radioButton5.TabIndex = 1;
            this.radioButton5.Text = "Precio de lista";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Stock_Repocicion_radioButton3);
            this.groupBox4.Controls.Add(this.Stock_ConStock_radioButton2);
            this.groupBox4.Controls.Add(this.Stock_Todos_radioButton1);
            this.groupBox4.Location = new System.Drawing.Point(346, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(98, 126);
            this.groupBox4.TabIndex = 158;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Stock";
            // 
            // Stock_Repocicion_radioButton3
            // 
            this.Stock_Repocicion_radioButton3.AutoSize = true;
            this.Stock_Repocicion_radioButton3.Location = new System.Drawing.Point(13, 65);
            this.Stock_Repocicion_radioButton3.Name = "Stock_Repocicion_radioButton3";
            this.Stock_Repocicion_radioButton3.Size = new System.Drawing.Size(79, 17);
            this.Stock_Repocicion_radioButton3.TabIndex = 2;
            this.Stock_Repocicion_radioButton3.Text = "Repocición";
            this.Stock_Repocicion_radioButton3.UseVisualStyleBackColor = true;
            // 
            // Stock_ConStock_radioButton2
            // 
            this.Stock_ConStock_radioButton2.AutoSize = true;
            this.Stock_ConStock_radioButton2.Location = new System.Drawing.Point(13, 42);
            this.Stock_ConStock_radioButton2.Name = "Stock_ConStock_radioButton2";
            this.Stock_ConStock_radioButton2.Size = new System.Drawing.Size(75, 17);
            this.Stock_ConStock_radioButton2.TabIndex = 1;
            this.Stock_ConStock_radioButton2.Text = "Con Stock";
            this.Stock_ConStock_radioButton2.UseVisualStyleBackColor = true;
            // 
            // Stock_Todos_radioButton1
            // 
            this.Stock_Todos_radioButton1.AutoSize = true;
            this.Stock_Todos_radioButton1.Checked = true;
            this.Stock_Todos_radioButton1.Location = new System.Drawing.Point(13, 19);
            this.Stock_Todos_radioButton1.Name = "Stock_Todos_radioButton1";
            this.Stock_Todos_radioButton1.Size = new System.Drawing.Size(55, 17);
            this.Stock_Todos_radioButton1.TabIndex = 0;
            this.Stock_Todos_radioButton1.TabStop = true;
            this.Stock_Todos_radioButton1.Text = "Todos";
            this.Stock_Todos_radioButton1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 157;
            this.label3.Text = "Proveedor:";
            // 
            // Txt_NombreTercero
            // 
            this.Txt_NombreTercero.Enabled = false;
            this.Txt_NombreTercero.Location = new System.Drawing.Point(151, 119);
            this.Txt_NombreTercero.Name = "Txt_NombreTercero";
            this.Txt_NombreTercero.Size = new System.Drawing.Size(157, 20);
            this.Txt_NombreTercero.TabIndex = 156;
            // 
            // Btn_BuscarTercero
            // 
            this.Btn_BuscarTercero.AutoSize = true;
            this.Btn_BuscarTercero.Image = global::Concesionarias.Properties.Resources.mini_search;
            this.Btn_BuscarTercero.Location = new System.Drawing.Point(119, 118);
            this.Btn_BuscarTercero.Name = "Btn_BuscarTercero";
            this.Btn_BuscarTercero.Size = new System.Drawing.Size(26, 22);
            this.Btn_BuscarTercero.TabIndex = 155;
            this.Btn_BuscarTercero.UseVisualStyleBackColor = true;
            this.Btn_BuscarTercero.Click += new System.EventHandler(this.Btn_BuscarTercero_Click);
            // 
            // id_TerceroTextBox
            // 
            this.id_TerceroTextBox.Enabled = false;
            this.id_TerceroTextBox.Location = new System.Drawing.Point(70, 118);
            this.id_TerceroTextBox.Name = "id_TerceroTextBox";
            this.id_TerceroTextBox.Size = new System.Drawing.Size(43, 20);
            this.id_TerceroTextBox.TabIndex = 154;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Código:";
            // 
            // Txt_Codigo
            // 
            this.Txt_Codigo.Location = new System.Drawing.Point(70, 39);
            this.Txt_Codigo.Name = "Txt_Codigo";
            this.Txt_Codigo.Size = new System.Drawing.Size(270, 20);
            this.Txt_Codigo.TabIndex = 13;
            // 
            // Cbo_Categoria
            // 
            this.Cbo_Categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Categoria.FormattingEnabled = true;
            this.Cbo_Categoria.Location = new System.Drawing.Point(70, 91);
            this.Cbo_Categoria.Name = "Cbo_Categoria";
            this.Cbo_Categoria.Size = new System.Drawing.Size(270, 21);
            this.Cbo_Categoria.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Cilindrada:";
            // 
            // CboLinea
            // 
            this.CboLinea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboLinea.FormattingEnabled = true;
            this.CboLinea.Location = new System.Drawing.Point(70, 65);
            this.CboLinea.Name = "CboLinea";
            this.CboLinea.Size = new System.Drawing.Size(270, 21);
            this.CboLinea.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Modelo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Id:";
            // 
            // Txt_Id
            // 
            this.Txt_Id.Location = new System.Drawing.Point(70, 13);
            this.Txt_Id.Name = "Txt_Id";
            this.Txt_Id.Size = new System.Drawing.Size(270, 20);
            this.Txt_Id.TabIndex = 3;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Buscar.AutoSize = true;
            this.Btn_Buscar.Image = global::Concesionarias.Properties.Resources._1318513582_Search;
            this.Btn_Buscar.Location = new System.Drawing.Point(955, 100);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(82, 38);
            this.Btn_Buscar.TabIndex = 2;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Cancelar.AutoSize = true;
            this.Btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Cancelar.Image = global::Concesionarias.Properties.Resources._1318513490_Log_Out;
            this.Btn_Cancelar.Location = new System.Drawing.Point(1092, 407);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(91, 38);
            this.Btn_Cancelar.TabIndex = 36;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_Baja
            // 
            this.Btn_Baja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Baja.AutoSize = true;
            this.Btn_Baja.Image = global::Concesionarias.Properties.Resources._1318513493_Stock_Index_Down;
            this.Btn_Baja.Location = new System.Drawing.Point(513, 407);
            this.Btn_Baja.Name = "Btn_Baja";
            this.Btn_Baja.Size = new System.Drawing.Size(105, 38);
            this.Btn_Baja.TabIndex = 58;
            this.Btn_Baja.Text = "Dar de Baja";
            this.Btn_Baja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Baja.UseVisualStyleBackColor = true;
            this.Btn_Baja.Click += new System.EventHandler(this.Btn_Baja_Click);
            // 
            // Btn_Alta
            // 
            this.Btn_Alta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Alta.AutoSize = true;
            this.Btn_Alta.Image = global::Concesionarias.Properties.Resources._1318513503_Stock_Index_Up;
            this.Btn_Alta.Location = new System.Drawing.Point(406, 407);
            this.Btn_Alta.Name = "Btn_Alta";
            this.Btn_Alta.Size = new System.Drawing.Size(101, 38);
            this.Btn_Alta.TabIndex = 57;
            this.Btn_Alta.Text = "Dar de alta";
            this.Btn_Alta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Alta.UseVisualStyleBackColor = true;
            this.Btn_Alta.Click += new System.EventHandler(this.Btn_Alta_Click);
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Aceptar.AutoSize = true;
            this.Btn_Aceptar.Image = global::Concesionarias.Properties.Resources._1318513485_Check;
            this.Btn_Aceptar.Location = new System.Drawing.Point(731, 407);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(86, 38);
            this.Btn_Aceptar.TabIndex = 40;
            this.Btn_Aceptar.Text = "Aceptar";
            this.Btn_Aceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Aceptar.UseVisualStyleBackColor = true;
            this.Btn_Aceptar.Click += new System.EventHandler(this.Btn_Aceptar_Click);
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Editar.AutoSize = true;
            this.Btn_Editar.Image = global::Concesionarias.Properties.Resources._1318513465_Edit;
            this.Btn_Editar.Location = new System.Drawing.Point(1006, 407);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(80, 38);
            this.Btn_Editar.TabIndex = 39;
            this.Btn_Editar.Text = "Editar";
            this.Btn_Editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Editar.UseVisualStyleBackColor = true;
            this.Btn_Editar.Click += new System.EventHandler(this.Btn_Editar_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Eliminar.AutoSize = true;
            this.Btn_Eliminar.Image = global::Concesionarias.Properties.Resources._1318513481_Delete;
            this.Btn_Eliminar.Location = new System.Drawing.Point(915, 407);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(85, 38);
            this.Btn_Eliminar.TabIndex = 38;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Agregar.AutoSize = true;
            this.Btn_Agregar.Image = global::Concesionarias.Properties.Resources._1318513498_Add;
            this.Btn_Agregar.Location = new System.Drawing.Point(823, 407);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(86, 38);
            this.Btn_Agregar.TabIndex = 37;
            this.Btn_Agregar.Text = "Agregar";
            this.Btn_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Agregar.UseVisualStyleBackColor = true;
            this.Btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // ImgIcono
            // 
            this.ImgIcono.BackColor = System.Drawing.Color.Transparent;
            this.ImgIcono.Image = global::Concesionarias.Properties.Resources._1318512153_Box_content;
            this.ImgIcono.Location = new System.Drawing.Point(5, 12);
            this.ImgIcono.Name = "ImgIcono";
            this.ImgIcono.Size = new System.Drawing.Size(134, 131);
            this.ImgIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ImgIcono.TabIndex = 33;
            this.ImgIcono.TabStop = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.AutoSize = true;
            this.button2.Image = global::Concesionarias.Properties.Resources.HistorialArticulo;
            this.button2.Location = new System.Drawing.Point(624, 407);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 38);
            this.button2.TabIndex = 59;
            this.button2.Text = "Historial";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Btn_VistaPrevia
            // 
            this.Btn_VistaPrevia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_VistaPrevia.Location = new System.Drawing.Point(156, 407);
            this.Btn_VistaPrevia.Name = "Btn_VistaPrevia";
            this.Btn_VistaPrevia.Size = new System.Drawing.Size(81, 38);
            this.Btn_VistaPrevia.TabIndex = 195;
            this.Btn_VistaPrevia.Text = "Vista previa";
            this.Btn_VistaPrevia.UseVisualStyleBackColor = true;
            this.Btn_VistaPrevia.Click += new System.EventHandler(this.Btn_VistaPrevia_Click);
            // 
            // Btn_Papel
            // 
            this.Btn_Papel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Papel.AutoSize = true;
            this.Btn_Papel.Image = global::Concesionarias.Properties.Resources._1318516983_document_32;
            this.Btn_Papel.Location = new System.Drawing.Point(-31, 407);
            this.Btn_Papel.Name = "Btn_Papel";
            this.Btn_Papel.Size = new System.Drawing.Size(80, 38);
            this.Btn_Papel.TabIndex = 193;
            this.Btn_Papel.Text = "Papel";
            this.Btn_Papel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Papel.UseVisualStyleBackColor = true;
            this.Btn_Papel.Visible = false;
            this.Btn_Papel.Click += new System.EventHandler(this.Btn_Papel_Click);
            // 
            // Btn_Opciones
            // 
            this.Btn_Opciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Opciones.AutoSize = true;
            this.Btn_Opciones.Image = global::Concesionarias.Properties.Resources._1318516999_document_print;
            this.Btn_Opciones.Location = new System.Drawing.Point(55, 407);
            this.Btn_Opciones.Name = "Btn_Opciones";
            this.Btn_Opciones.Size = new System.Drawing.Size(95, 38);
            this.Btn_Opciones.TabIndex = 194;
            this.Btn_Opciones.Text = "Impresora";
            this.Btn_Opciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Opciones.UseVisualStyleBackColor = true;
            this.Btn_Opciones.Click += new System.EventHandler(this.Btn_Opciones_Click);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnImprimir.AutoSize = true;
            this.BtnImprimir.Image = global::Concesionarias.Properties.Resources._1318516999_document_print;
            this.BtnImprimir.Location = new System.Drawing.Point(243, 407);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(157, 38);
            this.BtnImprimir.TabIndex = 192;
            this.BtnImprimir.Text = "Imprimir lista de precios";
            this.BtnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnImprimir.UseVisualStyleBackColor = true;
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // MyPrintDocument
            // 
            this.MyPrintDocument.DocumentName = "Entrega de documentación";
            this.MyPrintDocument.OriginAtMargins = true;
            this.MyPrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.ImprimirDocumento_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.AllowCurrentPage = true;
            this.printDialog1.AllowSelection = true;
            this.printDialog1.AllowSomePages = true;
            this.printDialog1.Document = this.MyPrintDocument;
            this.printDialog1.UseEXDialog = true;
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.MyPrintDocument;
            // 
            // FrmArticulos
            // 
            this.AcceptButton = this.Btn_Buscar;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.CancelButton = this.Btn_Cancelar;
            this.ClientSize = new System.Drawing.Size(1188, 450);
            this.Controls.Add(this.Btn_VistaPrevia);
            this.Controls.Add(this.Btn_Papel);
            this.Controls.Add(this.Btn_Opciones);
            this.Controls.Add(this.BtnImprimir);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Btn_Baja);
            this.Controls.Add(this.Btn_Alta);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Btn_Aceptar);
            this.Controls.Add(this.Btn_Editar);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Agregar);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ImgIcono);
            this.Name = "FrmArticulos";
            this.ShowIcon = false;
            this.Text = "Articulos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmArticulos_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Datos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox Txt_CantidadRegistros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.Button Btn_Editar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DG_Datos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Id;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.PictureBox ImgIcono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Codigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_NombreTercero;
        private System.Windows.Forms.Button Btn_BuscarTercero;
        private System.Windows.Forms.TextBox id_TerceroTextBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton Stock_Repocicion_radioButton3;
        private System.Windows.Forms.RadioButton Stock_ConStock_radioButton2;
        private System.Windows.Forms.RadioButton Stock_Todos_radioButton1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.CheckBox IvaIncluidocheckBox1;
        private System.Windows.Forms.CheckBox MostrarAnuladoscheckBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Btn_Baja;
        private System.Windows.Forms.Button Btn_Alta;
        private System.Windows.Forms.TextBox Txt_TotalVenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_TotalLista;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox Cbo_Categoria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CboLinea;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btn_VistaPrevia;
        private System.Windows.Forms.Button Btn_Papel;
        private System.Windows.Forms.Button Btn_Opciones;
        private System.Windows.Forms.Button BtnImprimir;
        private System.Drawing.Printing.PrintDocument MyPrintDocument;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
    }
}