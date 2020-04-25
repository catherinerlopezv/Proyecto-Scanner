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
            this.rtBox = new System.Windows.Forms.RichTextBox();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
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
            this.flowLayoutPanel1.Controls.Add(this.rtBox);
            this.flowLayoutPanel1.Controls.Add(this.splitter2);
            this.flowLayoutPanel1.Controls.Add(this.textBox2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 62);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1239, 443);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // TxtAr
            // 
            this.TxtAr.Location = new System.Drawing.Point(3, 3);
            this.TxtAr.Multiline = true;
            this.TxtAr.Name = "TxtAr";
            this.TxtAr.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtAr.Size = new System.Drawing.Size(349, 440);
            this.TxtAr.TabIndex = 7;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(358, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 440);
            this.splitter1.TabIndex = 10;
            this.splitter1.TabStop = false;
            // 
            // rtBox
            // 
            this.rtBox.Location = new System.Drawing.Point(367, 3);
            this.rtBox.Name = "rtBox";
            this.rtBox.Size = new System.Drawing.Size(416, 440);
            this.rtBox.TabIndex = 9;
            this.rtBox.Text = "";
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(789, 3);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 440);
            this.splitter2.TabIndex = 11;
            this.splitter2.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(798, 3);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(435, 440);
            this.textBox2.TabIndex = 8;
            // 
            // FrmTestGramatica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 511);
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
        private System.Windows.Forms.RichTextBox rtBox;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.TextBox textBox2;
    }
}

