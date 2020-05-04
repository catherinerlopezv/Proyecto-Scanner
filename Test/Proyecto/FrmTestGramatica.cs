using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using TinyPG;

namespace Proyecto
{
    public partial class FrmTestGramatica : Form
    {
        public FrmTestGramatica()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            if(buscar.ShowDialog()==DialogResult.OK)
            {
                textBox1.Text = buscar.FileName;
                String Leer = File.ReadAllText(textBox1.Text);
                TxtAr.Text = Leer;
            }
        }

        private void Leer_Click(object sender, EventArgs e)
        {

            String Leer = TxtAr.Text;
            txtTokens.Text = "Comenzando la lectura  \n\r\n";

            Scanner scanner = new Scanner();
            Parser parser = new Parser(scanner);

            //TextHighlighter highlighter = new TextHighlighter(rtBox, scanner, parser);

            ParseTree tree = parser.Parse(Leer);

            //object result = tree.Eval(null);
            //textBox2.Text = textBox2.Text + result.ToString();

            if (tree.Errors.Count > 0)
            {
                foreach (ParseError error in tree.Errors)
                {
                    txtTokens.Text = txtTokens.Text + "Línea: " + error.Line + " Columna: " + error.Column + " Mensaje " + error.Message + "\n\r\n";
                }
                txtTokens.Text = txtTokens.Text + "\nLectura con Errores"; 
            }
            else
            {
                txtTokens.Text = txtTokens.Text + "\nLectura completada   \n\r\n";
                ExprTree expresion = new ExprTree();
                expresion.GeneraArbolExpr(tree);
                txtTokens.Text = txtTokens.Text + expresion.TokensExpr.ToString();
                txtTokens.Text = txtTokens.Text + "\n\r\n Recorrido  \n\r\n";
                txtTokens.Text = txtTokens.Text + expresion.InFijo();
                txtTokens.Text = txtTokens.Text + "\n\r\n Recorrido  \n\r\n";
                txtTokens.Text = txtTokens.Text + expresion.Dotify();
                List<string[]> rows = expresion.TablaFirsLastNullable();
                dgv_fln.Rows.Clear();
                foreach (string[] row in rows)
                {
                    dgv_fln.Rows.Add(row);
                }
                List<string[]> rowsFollow = expresion.TablaFollow();
                dgv_follow.Rows.Clear();
                foreach (string[] row in rowsFollow)
                {
                    dgv_follow.Rows.Add(row);
                }
                string graphVizString = tree.Dotify();
                GraficaArbol.Image = Graphviz.RenderImage(graphVizString, "jpg");

            }

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //TextBoxWriter writer = new TextBoxWriter(textBox2);
            //Console.SetOut(writer);
        }

        private void GraficaArbol_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
