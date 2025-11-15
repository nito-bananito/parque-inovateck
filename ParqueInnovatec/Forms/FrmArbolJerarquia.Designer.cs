namespace ParqueInnovatec.Forms
{
    partial class FrmArbolJerarquia
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
            this.tvJerarquia = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.tbArbolP = new System.Windows.Forms.TextBox();
            this.btnRecorrer = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnContar = new System.Windows.Forms.Button();
            this.tbArbolH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEstadoArbol = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tvJerarquia
            // 
            this.tvJerarquia.Location = new System.Drawing.Point(12, 134);
            this.tvJerarquia.Name = "tvJerarquia";
            this.tvJerarquia.Size = new System.Drawing.Size(510, 304);
            this.tvJerarquia.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingresar arbol:";
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(345, 14);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 35);
            this.btnInsertar.TabIndex = 2;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            // 
            // tbArbolP
            // 
            this.tbArbolP.Location = new System.Drawing.Point(170, 14);
            this.tbArbolP.Name = "tbArbolP";
            this.tbArbolP.Size = new System.Drawing.Size(156, 26);
            this.tbArbolP.TabIndex = 3;
            // 
            // btnRecorrer
            // 
            this.btnRecorrer.Location = new System.Drawing.Point(345, 60);
            this.btnRecorrer.Name = "btnRecorrer";
            this.btnRecorrer.Size = new System.Drawing.Size(75, 35);
            this.btnRecorrer.TabIndex = 4;
            this.btnRecorrer.Text = "Recorrer";
            this.btnRecorrer.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(447, 14);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 35);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnContar
            // 
            this.btnContar.Location = new System.Drawing.Point(447, 60);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(75, 35);
            this.btnContar.TabIndex = 6;
            this.btnContar.Text = "Contar";
            this.btnContar.UseVisualStyleBackColor = true;
            // 
            // tbArbolH
            // 
            this.tbArbolH.Location = new System.Drawing.Point(170, 61);
            this.tbArbolH.Name = "tbArbolH";
            this.tbArbolH.Size = new System.Drawing.Size(156, 26);
            this.tbArbolH.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ingresar rama:";
            // 
            // lblEstadoArbol
            // 
            this.lblEstadoArbol.AutoSize = true;
            this.lblEstadoArbol.Location = new System.Drawing.Point(166, 100);
            this.lblEstadoArbol.Name = "lblEstadoArbol";
            this.lblEstadoArbol.Size = new System.Drawing.Size(124, 20);
            this.lblEstadoArbol.TabIndex = 9;
            this.lblEstadoArbol.Text = "Estado del arbol";
            // 
            // FrmArbolJerarquia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 450);
            this.Controls.Add(this.lblEstadoArbol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbArbolH);
            this.Controls.Add(this.btnContar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnRecorrer);
            this.Controls.Add(this.tbArbolP);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tvJerarquia);
            this.Name = "FrmArbolJerarquia";
            this.Text = "FrmArbolJerarquia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvJerarquia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox tbArbolP;
        private System.Windows.Forms.Button btnRecorrer;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.TextBox tbArbolH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEstadoArbol;
    }
}