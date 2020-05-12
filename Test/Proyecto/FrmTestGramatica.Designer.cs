namespace Proyecto
{
    partial class FrmTestGramatica
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
            this.Nombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Buscar = new System.Windows.Forms.Button();
            this.Leer = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.TxtAr = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.txtTokens = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEvaluar = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnEvaluar = new System.Windows.Forms.Button();
            this.btnGenera = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(37, 7);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(83, 13);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "Nombre Archivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 20);
            this.textBox1.TabIndex = 2;
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(240, 20);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 4;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // Leer
            // 
            this.Leer.Location = new System.Drawing.Point(321, 20);
            this.Leer.Name = "Leer";
            this.Leer.Size = new System.Drawing.Size(75, 23);
            this.Leer.TabIndex = 5;
            this.Leer.Text = "Leer";
            this.Leer.UseVisualStyleBackColor = true;
            this.Leer.Click += new System.EventHandler(this.Leer_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.TxtAr);
            this.flowLayoutPanel1.Controls.Add(this.splitter1);
            this.flowLayoutPanel1.Controls.Add(this.txtTokens);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 62);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1415, 311);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // TxtAr
            // 
            this.TxtAr.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAr.Location = new System.Drawing.Point(3, 3);
            this.TxtAr.Multiline = true;
            this.TxtAr.Name = "TxtAr";
            this.TxtAr.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtAr.Size = new System.Drawing.Size(349, 308);
            this.TxtAr.TabIndex = 7;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(358, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 308);
            this.splitter1.TabIndex = 10;
            this.splitter1.TabStop = false;
            // 
            // txtTokens
            // 
            this.txtTokens.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTokens.Location = new System.Drawing.Point(367, 3);
            this.txtTokens.Multiline = true;
            this.txtTokens.Name = "txtTokens";
            this.txtTokens.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTokens.Size = new System.Drawing.Size(1037, 308);
            this.txtTokens.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtResultado);
            this.panel1.Controls.Add(this.txtEvaluar);
            this.panel1.Location = new System.Drawing.Point(12, 379);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1415, 281);
            this.panel1.TabIndex = 9;
            // 
            // txtEvaluar
            // 
            this.txtEvaluar.Location = new System.Drawing.Point(0, 3);
            this.txtEvaluar.Multiline = true;
            this.txtEvaluar.Name = "txtEvaluar";
            this.txtEvaluar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEvaluar.Size = new System.Drawing.Size(609, 278);
            this.txtEvaluar.TabIndex = 0;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(616, 4);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultado.Size = new System.Drawing.Size(796, 267);
            this.txtResultado.TabIndex = 1;
            // 
            // btnEvaluar
            // 
            this.btnEvaluar.Location = new System.Drawing.Point(403, 19);
            this.btnEvaluar.Name = "btnEvaluar";
            this.btnEvaluar.Size = new System.Drawing.Size(75, 23);
            this.btnEvaluar.TabIndex = 10;
            this.btnEvaluar.Text = "Evaluar";
            this.btnEvaluar.UseVisualStyleBackColor = true;
            this.btnEvaluar.Click += new System.EventHandler(this.btnEvaluar_Click);
            // 
            // btnGenera
            // 
            this.btnGenera.Location = new System.Drawing.Point(485, 20);
            this.btnGenera.Name = "btnGenera";
            this.btnGenera.Size = new System.Drawing.Size(114, 23);
            this.btnGenera.TabIndex = 11;
            this.btnGenera.Text = "Generar Código";
            this.btnGenera.UseVisualStyleBackColor = true;
            this.btnGenera.Click += new System.EventHandler(this.btnGenera_Click);
            // 
            // FrmTestGramatica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 662);
            this.Controls.Add(this.btnGenera);
            this.Controls.Add(this.btnEvaluar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Leer);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nombre);
            this.Name = "FrmTestGramatica";
            this.Text = "Lector De Gramatica";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Button Leer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox TxtAr;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox txtTokens;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtEvaluar;
        private System.Windows.Forms.Button btnEvaluar;
        private System.Windows.Forms.Button btnGenera;
    }
}

