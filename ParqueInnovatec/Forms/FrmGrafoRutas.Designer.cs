namespace ParqueInnovatec.Forms
{
    partial class FrmGrafoRutas
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
            this.tbOrigen = new System.Windows.Forms.TextBox();
            this.tbDestino = new System.Windows.Forms.TextBox();
            this.tbPeso = new System.Windows.Forms.TextBox();
            this.btnAgregarConexiones = new System.Windows.Forms.Button();
            this.btnRutaCorta = new System.Windows.Forms.Button();
            this.btnMostarConexioness = new System.Windows.Forms.Button();
            this.lbConexiones = new System.Windows.Forms.ListBox();
            this.lbRutas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbOrigen
            // 
            this.tbOrigen.Location = new System.Drawing.Point(108, 23);
            this.tbOrigen.Name = "tbOrigen";
            this.tbOrigen.Size = new System.Drawing.Size(183, 26);
            this.tbOrigen.TabIndex = 0;
            // 
            // tbDestino
            // 
            this.tbDestino.Location = new System.Drawing.Point(108, 62);
            this.tbDestino.Name = "tbDestino";
            this.tbDestino.Size = new System.Drawing.Size(183, 26);
            this.tbDestino.TabIndex = 1;
            // 
            // tbPeso
            // 
            this.tbPeso.Location = new System.Drawing.Point(108, 104);
            this.tbPeso.Name = "tbPeso";
            this.tbPeso.Size = new System.Drawing.Size(183, 26);
            this.tbPeso.TabIndex = 2;
            // 
            // btnAgregarConexiones
            // 
            this.btnAgregarConexiones.Location = new System.Drawing.Point(324, 15);
            this.btnAgregarConexiones.Name = "btnAgregarConexiones";
            this.btnAgregarConexiones.Size = new System.Drawing.Size(166, 37);
            this.btnAgregarConexiones.TabIndex = 3;
            this.btnAgregarConexiones.Text = "Agregar conexiones";
            this.btnAgregarConexiones.UseVisualStyleBackColor = true;
            // 
            // btnRutaCorta
            // 
            this.btnRutaCorta.Location = new System.Drawing.Point(324, 58);
            this.btnRutaCorta.Name = "btnRutaCorta";
            this.btnRutaCorta.Size = new System.Drawing.Size(166, 35);
            this.btnRutaCorta.TabIndex = 4;
            this.btnRutaCorta.Text = "Ruta mas corta";
            this.btnRutaCorta.UseVisualStyleBackColor = true;
            // 
            // btnMostarConexioness
            // 
            this.btnMostarConexioness.Location = new System.Drawing.Point(324, 99);
            this.btnMostarConexioness.Name = "btnMostarConexioness";
            this.btnMostarConexioness.Size = new System.Drawing.Size(166, 36);
            this.btnMostarConexioness.TabIndex = 5;
            this.btnMostarConexioness.Text = "Mostar conexiones";
            this.btnMostarConexioness.UseVisualStyleBackColor = true;
            // 
            // lbConexiones
            // 
            this.lbConexiones.FormattingEnabled = true;
            this.lbConexiones.ItemHeight = 20;
            this.lbConexiones.Location = new System.Drawing.Point(37, 140);
            this.lbConexiones.Name = "lbConexiones";
            this.lbConexiones.Size = new System.Drawing.Size(236, 284);
            this.lbConexiones.TabIndex = 6;
            // 
            // lbRutas
            // 
            this.lbRutas.FormattingEnabled = true;
            this.lbRutas.ItemHeight = 20;
            this.lbRutas.Location = new System.Drawing.Point(296, 140);
            this.lbRutas.Name = "lbRutas";
            this.lbRutas.Size = new System.Drawing.Size(215, 284);
            this.lbRutas.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Origen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Destino:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Distancia:";
            // 
            // FrmGrafoRutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbRutas);
            this.Controls.Add(this.lbConexiones);
            this.Controls.Add(this.btnMostarConexioness);
            this.Controls.Add(this.btnRutaCorta);
            this.Controls.Add(this.btnAgregarConexiones);
            this.Controls.Add(this.tbPeso);
            this.Controls.Add(this.tbDestino);
            this.Controls.Add(this.tbOrigen);
            this.Name = "FrmGrafoRutas";
            this.Text = "FrmGrafoRutas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbOrigen;
        private System.Windows.Forms.TextBox tbDestino;
        private System.Windows.Forms.TextBox tbPeso;
        private System.Windows.Forms.Button btnAgregarConexiones;
        private System.Windows.Forms.Button btnRutaCorta;
        private System.Windows.Forms.Button btnMostarConexioness;
        private System.Windows.Forms.ListBox lbConexiones;
        private System.Windows.Forms.ListBox lbRutas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}