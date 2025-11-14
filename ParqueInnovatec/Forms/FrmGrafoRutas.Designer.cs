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
            this.btnMostarConexiones = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbOrigen
            // 
            this.tbOrigen.Location = new System.Drawing.Point(108, 20);
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
            // btnMostarConexiones
            // 
            this.btnMostarConexiones.Location = new System.Drawing.Point(324, 99);
            this.btnMostarConexiones.Name = "btnMostarConexiones";
            this.btnMostarConexiones.Size = new System.Drawing.Size(166, 36);
            this.btnMostarConexiones.TabIndex = 5;
            this.btnMostarConexiones.Text = "Mostar conexiones";
            this.btnMostarConexiones.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(37, 140);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(236, 284);
            this.listBox1.TabIndex = 6;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(296, 140);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(215, 284);
            this.listBox2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "label3";
            // 
            // FrmGrafoRutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnMostarConexiones);
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
        private System.Windows.Forms.Button btnMostarConexiones;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}