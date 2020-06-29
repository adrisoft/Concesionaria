namespace Concesionarias.MDI
{
    partial class FrmHistorialArticulo
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
            this.DG_Datos = new System.Windows.Forms.DataGridView();
            this.BarraEstado = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Datos)).BeginInit();
            this.BarraEstado.SuspendLayout();
            this.SuspendLayout();
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
            this.DG_Datos.Location = new System.Drawing.Point(0, 0);
            this.DG_Datos.MultiSelect = false;
            this.DG_Datos.Name = "DG_Datos";
            this.DG_Datos.ReadOnly = true;
            this.DG_Datos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_Datos.Size = new System.Drawing.Size(602, 498);
            this.DG_Datos.TabIndex = 1;
            // 
            // BarraEstado
            // 
            this.BarraEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.BarraEstado.Location = new System.Drawing.Point(0, 476);
            this.BarraEstado.Name = "BarraEstado";
            this.BarraEstado.Size = new System.Drawing.Size(602, 22);
            this.BarraEstado.TabIndex = 2;
            this.BarraEstado.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(114, 17);
            this.toolStripStatusLabel1.Text = "Lbl_CantidadRegistros";
            // 
            // FrmHistorialArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 498);
            this.Controls.Add(this.BarraEstado);
            this.Controls.Add(this.DG_Datos);
            this.Name = "FrmHistorialArticulo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Historial del articulo";
            this.Load += new System.EventHandler(this.FrmHistorialArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Datos)).EndInit();
            this.BarraEstado.ResumeLayout(false);
            this.BarraEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_Datos;
        private System.Windows.Forms.StatusStrip BarraEstado;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}