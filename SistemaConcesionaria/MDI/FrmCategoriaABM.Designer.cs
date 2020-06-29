namespace Concesionarias.MDI
{
    partial class FrmCategoriaABM
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
            System.Windows.Forms.Label nombreLabel;
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Id = new System.Windows.Forms.TextBox();
            nombreLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(6, 48);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 13;
            nombreLabel.Text = "Nombre:";
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.AutoSize = true;
            this.Btn_Aceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Btn_Aceptar.Image = global::Concesionarias.Properties.Resources._1318513485_Check;
            this.Btn_Aceptar.Location = new System.Drawing.Point(127, 94);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(86, 38);
            this.Btn_Aceptar.TabIndex = 51;
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
            this.Btn_Cancelar.Location = new System.Drawing.Point(219, 94);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(91, 38);
            this.Btn_Cancelar.TabIndex = 50;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(nombreLabel);
            this.groupBox1.Controls.Add(this.nombreTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Txt_Id);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 76);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(79, 45);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(208, 20);
            this.nombreTextBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Id:";
            // 
            // Txt_Id
            // 
            this.Txt_Id.Enabled = false;
            this.Txt_Id.Location = new System.Drawing.Point(79, 19);
            this.Txt_Id.MaxLength = 6;
            this.Txt_Id.Name = "Txt_Id";
            this.Txt_Id.Size = new System.Drawing.Size(73, 20);
            this.Txt_Id.TabIndex = 9;
            this.Txt_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FrmCategoriaABM
            // 
            this.AcceptButton = this.Btn_Aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Btn_Cancelar;
            this.ClientSize = new System.Drawing.Size(319, 141);
            this.Controls.Add(this.Btn_Aceptar);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(335, 179);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(335, 179);
            this.Name = "FrmCategoriaABM";
            this.ShowIcon = false;
            this.Text = "Nuevo/Editar Cilindrada";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Id;

    }
}