
namespace Parcial1
{
    partial class frmParcial1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtHorasL = new System.Windows.Forms.TextBox();
            this.txtRcargo1 = new System.Windows.Forms.TextBox();
            this.txtRecargo2 = new System.Windows.Forms.TextBox();
            this.txtBonifi = new System.Windows.Forms.TextBox();
            this.txtPocReten = new System.Windows.Forms.TextBox();
            this.grbACalculo = new System.Windows.Forms.GroupBox();
            this.lblSalarioTot = new System.Windows.Forms.Label();
            this.lblAuxTransporte = new System.Windows.Forms.Label();
            this.lblVretencion = new System.Windows.Forms.Label();
            this.lblHtripe = new System.Windows.Forms.Label();
            this.lblHdoble = new System.Windows.Forms.Label();
            this.lblHoraOrdinaria = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.grbACalculo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Condensed", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(107, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de nomina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salario Base";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Horas Totales";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Porc Recargo H1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Porc Recargo H2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(55, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Porc Binificación";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(54, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Porc Retención";
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.Location = new System.Drawing.Point(265, 86);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 26);
            this.txtSalario.TabIndex = 7;
            // 
            // txtHorasL
            // 
            this.txtHorasL.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorasL.Location = new System.Drawing.Point(265, 113);
            this.txtHorasL.Name = "txtHorasL";
            this.txtHorasL.Size = new System.Drawing.Size(100, 26);
            this.txtHorasL.TabIndex = 8;
            // 
            // txtRcargo1
            // 
            this.txtRcargo1.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRcargo1.Location = new System.Drawing.Point(265, 141);
            this.txtRcargo1.Name = "txtRcargo1";
            this.txtRcargo1.Size = new System.Drawing.Size(100, 26);
            this.txtRcargo1.TabIndex = 9;
            // 
            // txtRecargo2
            // 
            this.txtRecargo2.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecargo2.Location = new System.Drawing.Point(265, 169);
            this.txtRecargo2.Name = "txtRecargo2";
            this.txtRecargo2.Size = new System.Drawing.Size(100, 26);
            this.txtRecargo2.TabIndex = 10;
            // 
            // txtBonifi
            // 
            this.txtBonifi.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBonifi.Location = new System.Drawing.Point(265, 197);
            this.txtBonifi.Name = "txtBonifi";
            this.txtBonifi.Size = new System.Drawing.Size(100, 26);
            this.txtBonifi.TabIndex = 11;
            // 
            // txtPocReten
            // 
            this.txtPocReten.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPocReten.Location = new System.Drawing.Point(265, 225);
            this.txtPocReten.Name = "txtPocReten";
            this.txtPocReten.Size = new System.Drawing.Size(100, 26);
            this.txtPocReten.TabIndex = 12;
            // 
            // grbACalculo
            // 
            this.grbACalculo.Controls.Add(this.lblSalarioTot);
            this.grbACalculo.Controls.Add(this.lblAuxTransporte);
            this.grbACalculo.Controls.Add(this.lblVretencion);
            this.grbACalculo.Controls.Add(this.lblHtripe);
            this.grbACalculo.Controls.Add(this.lblHdoble);
            this.grbACalculo.Controls.Add(this.lblHoraOrdinaria);
            this.grbACalculo.Controls.Add(this.label14);
            this.grbACalculo.Controls.Add(this.label13);
            this.grbACalculo.Controls.Add(this.label11);
            this.grbACalculo.Controls.Add(this.label10);
            this.grbACalculo.Controls.Add(this.label9);
            this.grbACalculo.Controls.Add(this.label8);
            this.grbACalculo.Location = new System.Drawing.Point(38, 263);
            this.grbACalculo.Name = "grbACalculo";
            this.grbACalculo.Size = new System.Drawing.Size(396, 235);
            this.grbACalculo.TabIndex = 13;
            this.grbACalculo.TabStop = false;
            this.grbACalculo.Text = "    Area de Calculo    ";
            this.grbACalculo.Visible = false;
            // 
            // lblSalarioTot
            // 
            this.lblSalarioTot.AutoSize = true;
            this.lblSalarioTot.BackColor = System.Drawing.Color.Silver;
            this.lblSalarioTot.Location = new System.Drawing.Point(256, 186);
            this.lblSalarioTot.MinimumSize = new System.Drawing.Size(120, 26);
            this.lblSalarioTot.Name = "lblSalarioTot";
            this.lblSalarioTot.Size = new System.Drawing.Size(120, 26);
            this.lblSalarioTot.TabIndex = 14;
            // 
            // lblAuxTransporte
            // 
            this.lblAuxTransporte.AutoSize = true;
            this.lblAuxTransporte.BackColor = System.Drawing.Color.Silver;
            this.lblAuxTransporte.Location = new System.Drawing.Point(276, 147);
            this.lblAuxTransporte.MinimumSize = new System.Drawing.Size(100, 26);
            this.lblAuxTransporte.Name = "lblAuxTransporte";
            this.lblAuxTransporte.Size = new System.Drawing.Size(100, 26);
            this.lblAuxTransporte.TabIndex = 13;
            // 
            // lblVretencion
            // 
            this.lblVretencion.AutoSize = true;
            this.lblVretencion.BackColor = System.Drawing.Color.Silver;
            this.lblVretencion.Location = new System.Drawing.Point(276, 116);
            this.lblVretencion.MinimumSize = new System.Drawing.Size(100, 26);
            this.lblVretencion.Name = "lblVretencion";
            this.lblVretencion.Size = new System.Drawing.Size(100, 26);
            this.lblVretencion.TabIndex = 12;
            // 
            // lblHtripe
            // 
            this.lblHtripe.AutoSize = true;
            this.lblHtripe.BackColor = System.Drawing.Color.Silver;
            this.lblHtripe.Location = new System.Drawing.Point(276, 86);
            this.lblHtripe.MinimumSize = new System.Drawing.Size(100, 26);
            this.lblHtripe.Name = "lblHtripe";
            this.lblHtripe.Size = new System.Drawing.Size(100, 26);
            this.lblHtripe.TabIndex = 11;
            // 
            // lblHdoble
            // 
            this.lblHdoble.AutoSize = true;
            this.lblHdoble.BackColor = System.Drawing.Color.Silver;
            this.lblHdoble.Location = new System.Drawing.Point(276, 55);
            this.lblHdoble.MinimumSize = new System.Drawing.Size(100, 26);
            this.lblHdoble.Name = "lblHdoble";
            this.lblHdoble.Size = new System.Drawing.Size(100, 26);
            this.lblHdoble.TabIndex = 10;
            // 
            // lblHoraOrdinaria
            // 
            this.lblHoraOrdinaria.AutoSize = true;
            this.lblHoraOrdinaria.BackColor = System.Drawing.Color.Silver;
            this.lblHoraOrdinaria.Location = new System.Drawing.Point(276, 24);
            this.lblHoraOrdinaria.MinimumSize = new System.Drawing.Size(100, 26);
            this.lblHoraOrdinaria.Name = "lblHoraOrdinaria";
            this.lblHoraOrdinaria.Size = new System.Drawing.Size(100, 26);
            this.lblHoraOrdinaria.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(22, 143);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(136, 23);
            this.label14.TabIndex = 8;
            this.label14.Text = "Aux Transporte";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(18, 189);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(214, 23);
            this.label13.TabIndex = 7;
            this.label13.Text = "Total salario debengado";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(22, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 23);
            this.label11.TabIndex = 5;
            this.label11.Text = "Retencion";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 23);
            this.label10.TabIndex = 4;
            this.label10.Text = "Valor hora extra T2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 23);
            this.label9.TabIndex = 3;
            this.label9.Text = "Valor hora extra T1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 23);
            this.label8.TabIndex = 2;
            this.label8.Text = "Valor hora ordinaria";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLimpiar.Location = new System.Drawing.Point(438, 89);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(98, 51);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCalcular.Location = new System.Drawing.Point(438, 156);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(98, 51);
            this.btnCalcular.TabIndex = 15;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            // 
            // btnTerminar
            // 
            this.btnTerminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTerminar.Location = new System.Drawing.Point(449, 430);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(98, 51);
            this.btnTerminar.TabIndex = 16;
            this.btnTerminar.Text = "Terminar";
            this.btnTerminar.UseVisualStyleBackColor = false;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // frmParcial1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(559, 510);
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.grbACalculo);
            this.Controls.Add(this.txtPocReten);
            this.Controls.Add(this.txtBonifi);
            this.Controls.Add(this.txtRecargo2);
            this.Controls.Add(this.txtRcargo1);
            this.Controls.Add(this.txtHorasL);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmParcial1";
            this.Text = "Parcial1";
            this.grbACalculo.ResumeLayout(false);
            this.grbACalculo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtHorasL;
        private System.Windows.Forms.TextBox txtRcargo1;
        private System.Windows.Forms.TextBox txtRecargo2;
        private System.Windows.Forms.TextBox txtBonifi;
        private System.Windows.Forms.TextBox txtPocReten;
        private System.Windows.Forms.GroupBox grbACalculo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label lblSalarioTot;
        public System.Windows.Forms.Label lblAuxTransporte;
        public System.Windows.Forms.Label lblVretencion;
        public System.Windows.Forms.Label lblHtripe;
        public System.Windows.Forms.Label lblHdoble;
        public System.Windows.Forms.Label lblHoraOrdinaria;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnTerminar;
    }
}

