namespace Concesionarias.MDI
{
    partial class FrmDocumentoABM
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
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label id_TerceroLabel;
            System.Windows.Forms.Label label2;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt_NombreTercero = new System.Windows.Forms.TextBox();
            this.Btn_BuscarFactura = new System.Windows.Forms.Button();
            this.id_FacturaTextBox = new System.Windows.Forms.TextBox();
            this.FechaEntregaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ObservacionesTextBox = new System.Windows.Forms.TextBox();
            this.ProvError = new System.Windows.Forms.ErrorProvider(this.components);
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.ImprimirDocumento = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.Btn_VistaPrevia = new System.Windows.Forms.Button();
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Papel = new System.Windows.Forms.Button();
            this.Btn_Opciones = new System.Windows.Forms.Button();
            this.Txt_Dominio = new System.Windows.Forms.TextBox();
            nombreLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            id_TerceroLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProvError)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(6, 93);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(81, 13);
            nombreLabel.TabIndex = 13;
            nombreLabel.Text = "Observaciones:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 44);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(40, 13);
            label1.TabIndex = 16;
            label1.Text = "Fecha:";
            // 
            // id_TerceroLabel
            // 
            id_TerceroLabel.AutoSize = true;
            id_TerceroLabel.Location = new System.Drawing.Point(6, 16);
            id_TerceroLabel.Name = "id_TerceroLabel";
            id_TerceroLabel.Size = new System.Drawing.Size(46, 13);
            id_TerceroLabel.TabIndex = 155;
            id_TerceroLabel.Text = "Factura:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(this.Txt_Dominio);
            this.groupBox1.Controls.Add(this.Txt_NombreTercero);
            this.groupBox1.Controls.Add(this.Btn_BuscarFactura);
            this.groupBox1.Controls.Add(this.id_FacturaTextBox);
            this.groupBox1.Controls.Add(id_TerceroLabel);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.FechaEntregaDateTimePicker);
            this.groupBox1.Controls.Add(nombreLabel);
            this.groupBox1.Controls.Add(this.ObservacionesTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 188);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // Txt_NombreTercero
            // 
            this.Txt_NombreTercero.Enabled = false;
            this.Txt_NombreTercero.Location = new System.Drawing.Point(174, 13);
            this.Txt_NombreTercero.Name = "Txt_NombreTercero";
            this.Txt_NombreTercero.Size = new System.Drawing.Size(292, 20);
            this.Txt_NombreTercero.TabIndex = 158;
            // 
            // Btn_BuscarFactura
            // 
            this.Btn_BuscarFactura.AutoSize = true;
            this.Btn_BuscarFactura.Image = global::Concesionarias.Properties.Resources.mini_search;
            this.Btn_BuscarFactura.Location = new System.Drawing.Point(142, 12);
            this.Btn_BuscarFactura.Name = "Btn_BuscarFactura";
            this.Btn_BuscarFactura.Size = new System.Drawing.Size(26, 22);
            this.Btn_BuscarFactura.TabIndex = 157;
            this.Btn_BuscarFactura.UseVisualStyleBackColor = true;
            this.Btn_BuscarFactura.Click += new System.EventHandler(this.Btn_BuscarFactura_Click);
            // 
            // id_FacturaTextBox
            // 
            this.id_FacturaTextBox.Enabled = false;
            this.id_FacturaTextBox.Location = new System.Drawing.Point(93, 12);
            this.id_FacturaTextBox.Name = "id_FacturaTextBox";
            this.id_FacturaTextBox.Size = new System.Drawing.Size(43, 20);
            this.id_FacturaTextBox.TabIndex = 156;
            // 
            // FechaEntregaDateTimePicker
            // 
            this.FechaEntregaDateTimePicker.Location = new System.Drawing.Point(93, 38);
            this.FechaEntregaDateTimePicker.Name = "FechaEntregaDateTimePicker";
            this.FechaEntregaDateTimePicker.Size = new System.Drawing.Size(373, 20);
            this.FechaEntregaDateTimePicker.TabIndex = 15;
            // 
            // ObservacionesTextBox
            // 
            this.ObservacionesTextBox.Location = new System.Drawing.Point(93, 90);
            this.ObservacionesTextBox.Multiline = true;
            this.ObservacionesTextBox.Name = "ObservacionesTextBox";
            this.ObservacionesTextBox.Size = new System.Drawing.Size(373, 88);
            this.ObservacionesTextBox.TabIndex = 14;
            // 
            // ProvError
            // 
            this.ProvError.ContainerControl = this;
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.ImprimirDocumento;
            // 
            // ImprimirDocumento
            // 
            this.ImprimirDocumento.DocumentName = "Entrega de documentación";
            this.ImprimirDocumento.OriginAtMargins = true;
            this.ImprimirDocumento.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.ImprimirDocumento_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.AllowCurrentPage = true;
            this.printDialog1.AllowSelection = true;
            this.printDialog1.AllowSomePages = true;
            this.printDialog1.Document = this.ImprimirDocumento;
            this.printDialog1.UseEXDialog = true;
            // 
            // Btn_VistaPrevia
            // 
            this.Btn_VistaPrevia.Location = new System.Drawing.Point(199, 206);
            this.Btn_VistaPrevia.Name = "Btn_VistaPrevia";
            this.Btn_VistaPrevia.Size = new System.Drawing.Size(81, 38);
            this.Btn_VistaPrevia.TabIndex = 177;
            this.Btn_VistaPrevia.Text = "Vista previa";
            this.Btn_VistaPrevia.UseVisualStyleBackColor = true;
            this.Btn_VistaPrevia.Click += new System.EventHandler(this.Btn_VistaPrevia_Click);
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.AutoSize = true;
            this.Btn_Aceptar.Image = global::Concesionarias.Properties.Resources._1318513485_Check;
            this.Btn_Aceptar.Location = new System.Drawing.Point(286, 206);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(126, 38);
            this.Btn_Aceptar.TabIndex = 163;
            this.Btn_Aceptar.Text = "Aceptar/Imprimir";
            this.Btn_Aceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Aceptar.UseVisualStyleBackColor = true;
            this.Btn_Aceptar.Click += new System.EventHandler(this.Btn_Aceptar_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.AutoSize = true;
            this.Btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Cancelar.Image = global::Concesionarias.Properties.Resources._1318513490_Log_Out;
            this.Btn_Cancelar.Location = new System.Drawing.Point(418, 206);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(91, 38);
            this.Btn_Cancelar.TabIndex = 53;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_Papel
            // 
            this.Btn_Papel.AutoSize = true;
            this.Btn_Papel.Image = global::Concesionarias.Properties.Resources._1318516983_document_32;
            this.Btn_Papel.Location = new System.Drawing.Point(12, 206);
            this.Btn_Papel.Name = "Btn_Papel";
            this.Btn_Papel.Size = new System.Drawing.Size(80, 38);
            this.Btn_Papel.TabIndex = 161;
            this.Btn_Papel.Text = "Papel";
            this.Btn_Papel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Papel.UseVisualStyleBackColor = true;
            this.Btn_Papel.Visible = false;
            this.Btn_Papel.Click += new System.EventHandler(this.Btn_Papel_Click);
            // 
            // Btn_Opciones
            // 
            this.Btn_Opciones.AutoSize = true;
            this.Btn_Opciones.Image = global::Concesionarias.Properties.Resources._1318516999_document_print;
            this.Btn_Opciones.Location = new System.Drawing.Point(98, 206);
            this.Btn_Opciones.Name = "Btn_Opciones";
            this.Btn_Opciones.Size = new System.Drawing.Size(95, 38);
            this.Btn_Opciones.TabIndex = 162;
            this.Btn_Opciones.Text = "Impresora";
            this.Btn_Opciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Opciones.UseVisualStyleBackColor = true;
            this.Btn_Opciones.Click += new System.EventHandler(this.Btn_Opciones_Click);
            // 
            // Txt_Dominio
            // 
            this.Txt_Dominio.Location = new System.Drawing.Point(93, 64);
            this.Txt_Dominio.Name = "Txt_Dominio";
            this.Txt_Dominio.Size = new System.Drawing.Size(373, 20);
            this.Txt_Dominio.TabIndex = 159;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 67);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(48, 13);
            label2.TabIndex = 160;
            label2.Text = "Dominio:";
            // 
            // FrmDocumentoABM
            // 
            this.AcceptButton = this.Btn_Aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Btn_Cancelar;
            this.ClientSize = new System.Drawing.Size(514, 251);
            this.Controls.Add(this.Btn_VistaPrevia);
            this.Controls.Add(this.Btn_Aceptar);
            this.Controls.Add(this.Btn_Papel);
            this.Controls.Add(this.Btn_Opciones);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(530, 289);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(530, 289);
            this.Name = "FrmDocumentoABM";
            this.ShowIcon = false;
            this.Text = "Entrega de documentación";
            this.Load += new System.EventHandler(this.FrmDocumentoABM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProvError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker FechaEntregaDateTimePicker;
        private System.Windows.Forms.TextBox ObservacionesTextBox;
        private System.Windows.Forms.TextBox Txt_NombreTercero;
        private System.Windows.Forms.Button Btn_BuscarFactura;
        private System.Windows.Forms.TextBox id_FacturaTextBox;
        private System.Windows.Forms.Button Btn_Papel;
        private System.Windows.Forms.Button Btn_Opciones;
        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.ErrorProvider ProvError;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Drawing.Printing.PrintDocument ImprimirDocumento;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button Btn_VistaPrevia;
        private System.Windows.Forms.TextBox Txt_Dominio;
    }
}