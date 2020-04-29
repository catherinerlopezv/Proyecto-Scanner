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
            rtBox.Text = Leer;
            textBox2.Text = "Comenzando la lectura  \n\r\n";

            Scanner scanner = new Scanner();
            Parser parser = new Parser(scanner);

            TextHighlighter highlighter = new TextHighlighter(rtBox, scanner, parser);

            ParseTree tree = parser.Parse(Leer);

            //object result = tree.Eval(null);
            //textBox2.Text = textBox2.Text + result.ToString();

            if (tree.Errors.Count > 0)
            {
                foreach (ParseError error in tree.Errors)
                {
                    textBox2.Text = textBox2.Text + "Línea: " + error.Line + " Columna: " + error.Column + " Mensaje " + error.Message + "\n\r\n";
                }
                textBox2.Text = textBox2.Text + "\nLectura con Errores"; 
            }
            else
            {
                textBox2.Text = textBox2.Text + "\nLectura completada";
                textBox2.Text = textBox2.Text + tree.PrintTree();
                string graphVizString = tree.Dotify();
                //textBox2.Text = textBox2.Text + graphVizString;
                //graphVizString = @"digraph G {
                //                        rankdir = BT;
                //                        node[
                //                          fontname = ""Bitstream Vera Sans""
                //                          fontsize = 10
                //                          shape = ""record""
                //                        ]
                //                        edge[
                //                          fontname = ""Bitstream Vera Sans""
                //                          fontsize = 8
                //                          arrowhead = ""empty""
                //                        ]
                //                        A->B
                //                        C->B
                //                        { rank = same}
                //                    }";
                GraficaArbol.Image = Graphviz.RenderImage(graphVizString, "jpg");

            }

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TextBoxWriter writer = new TextBoxWriter(textBox2);
            Console.SetOut(writer);
        }

        private void GraficaArbol_Click(object sender, EventArgs e)
        {

        }
    }
}
