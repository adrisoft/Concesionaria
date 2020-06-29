namespace Concesionarias.MDI
{
    partial class FrmSeries
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
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RecibosnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.RemBnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.RemAnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecibosnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemBnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemAnumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.AutoSize = true;
            this.Btn_Aceptar.Image = global::Concesionarias.Properties.Resources._1318513485_Check;
            this.Btn_Aceptar.Location = new System.Drawing.Point(31, 85);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(86, 38);
            this.Btn_Aceptar.TabIndex = 63;
            this.Btn_Aceptar.Text = "Aceptar";
            this.Btn_Aceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Aceptar.UseVisualStyleBackColor = true;
            this.Btn_Aceptar.Click += new System.EventHandler(this.Btn_Aceptar_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.AutoSize = true;
            this.Btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Cancelar.Image = global::Concesionarias.Properties.Resources._1318513490_Log_Out;
            this.Btn_Cancelar.Location = new System.Drawing.Point(123, 85);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(91, 38);
            this.Btn_Cancelar.TabIndex = 62;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RecibosnumericUpDown);
            this.groupBox1.Controls.Add(this.RemBnumericUpDown);
            this.groupBox1.Controls.Add(this.RemAnumericUpDown);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 67);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // RecibosnumericUpDown
            // 
            this.RecibosnumericUpDown.Location = new System.Drawing.Point(83, 40);
            this.RecibosnumericUpDown.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.RecibosnumericUpDown.Name = "RecibosnumericUpDown";
            this.RecibosnumericUpDown.Size = new System.Drawing.Size(111, 20);
            this.RecibosnumericUpDown.TabIndex = 68;
            this.RecibosnumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // RemBnumericUpDown
            // 
            this.RemBnumericUpDown.Location = new System.Drawing.Point(83, 69);
            this.RemBnumericUpDown.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.RemBnumericUpDown.Name = "RemBnumericUpDown";
            this.RemBnumericUpDown.Size = new System.Drawing.Size(111, 20);
            this.RemBnumericUpDown.TabIndex = 67;
            this.RemBnumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.RemBnumericUpDown.Visible = false;
            // 
            // RemAnumericUpDown
            // 
            this.RemAnumericUpDown.Location = new System.Drawing.Point(83, 14);
            this.RemAnumericUpDown.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.RemAnumericUpDown.Name = "RemAnumericUpDown";
            this.RemAnumericUpDown.Size = new System.Drawing.Size(111, 20);
            this.RemAnumericUpDown.TabIndex = 66;
            this.RemAnumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Recibos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "Remitos B:";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Remitos X:";
            // 
            // FrmSeries
            // 
            this.AcceptButton = this.Btn_Aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Btn_Cancelar;
            this.ClientSize = new System.Drawing.Size(224, 128);
            this.Controls.Add(this.Btn_Aceptar);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(230, 156);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(230, 156);
            this.Name = "FrmSeries";
            this.ShowIcon = false;
            this.Text = "Series";
            this.Load += new System.EventHandler(this.FrmSeries_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecibosnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemBnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemAnumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown RemAnumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown RecibosnumericUpDown;
        private System.Windows.Forms.NumericUpDown RemBnumericUpDown;

    }
}