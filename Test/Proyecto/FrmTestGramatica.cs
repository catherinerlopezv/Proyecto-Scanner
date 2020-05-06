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
using System.Text.RegularExpressions;
using System.Threading;

namespace Proyecto
{
    public partial class FrmTestGramatica : Form
    {

        public Scanner scanner;
        public Parser parser;
        public ParseTree tree;
        public TablaPatterns patterns;


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
            scanner = new Scanner();
            parser = new Parser(scanner);
            tree = parser.Parse(Leer);

            
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

                
            }

            patterns = new TablaPatterns();
            patterns.GeneraTabla(tree);

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

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            
            txtTokens.Text = txtTokens.Text + patterns.ImprimeTabla();

            foreach (Pattern pt in patterns.ListaAcciones)
            {
                Regex rgx = new Regex(pt.Patron,
                                RegexOptions.Compiled | RegexOptions.IgnoreCase);
                foreach (Match mt in rgx.Matches(txtEvaluar.Text))
                {
                    txtResultado.Text += "\r\n " + mt.Value + " = " + pt.Numero;
                }
            }

            foreach (Pattern pt in patterns.ListaTokens)
            {
                Regex rgx = new Regex(pt.Patron,
                                RegexOptions.Compiled);
                foreach (Match mt in rgx.Matches(txtEvaluar.Text))
                {
                    txtResultado.Text += "\r\n " + mt.Value + " = " + pt.Numero;
                }
            }
        }

        private void btnGenera_Click(object sender, EventArgs e)
        {
            StringBuilder codigo = new StringBuilder();
            codigo.AppendLine(@"using System;
                                using System.Collections.Generic;
                                using System.Text;
                                using System.Xml.Serialization;
                                using System.Text.RegularExpressions; 
                                namespace Codigo {");
            codigo.AppendLine(@"public class Pattern
                {
                    public string Nombre { get; set; }
                    public string Numero { get; set; }
                    public string Patron { get; set; }
                }");

            codigo.AppendLine(@"public class Evaluador {
                   public List<Pattern> ListaTokens { get; set; }
                   public List<Pattern> ListaAcciones { get; set; }
                   public List<Pattern> ListaErrores { get; set; }

                   public Evaluador() {
                      ListaTokens = new List<Pattern>();
                      ListaAcciones = new List<Pattern>();
                      ListaErrores = new List<Pattern>();
                      Pattern patron;");
                   
                   foreach(Pattern pt in patterns.ListaTokens) {
                        codigo.AppendLine("patron = new Pattern();");
                        codigo.Append("patron.Nombre = \"");
                        codigo.Append(pt.Nombre);
                        codigo.AppendLine("\";");
                        codigo.Append("patron.Numero = \"");
                        codigo.Append(pt.Numero);
                        codigo.AppendLine("\";");
                        codigo.Append("patron.Patron = @\"");
                        codigo.Append(pt.Patron);
                        codigo.AppendLine("\";");
                        codigo.AppendLine("ListaTokens.Add(patron);");
                    }

                    foreach (Pattern pt in patterns.ListaAcciones)
                    {
                        codigo.AppendLine("patron = new Pattern();");
                        codigo.Append("patron.Nombre = \"");
                        codigo.Append(pt.Nombre);
                        codigo.AppendLine("\";");
                        codigo.Append("patron.Numero = \"");
                        codigo.Append(pt.Numero);
                        codigo.AppendLine("\";");
                        codigo.Append("patron.Patron = @\"");
                        codigo.Append(pt.Patron);
                        codigo.AppendLine("\";");
                        codigo.AppendLine("ListaAcciones.Add(patron);");
                    }

                    //foreach (Pattern pt in patterns.ListaErrores)
                    //{
                    //    codigo.Append("patron.Nombre = \"");
                    //    codigo.Append(pt.Nombre);
                    //    codigo.AppendLine("\";");
                    //    codigo.Append("patron.Numero = \"");
                    //    codigo.Append(pt.Numero);
                    //    codigo.AppendLine("\";");
                    //    codigo.Append("patron.Patron = \"");
                    //    codigo.Append(pt.Patron);
                    //    codigo.AppendLine("\";");
                    //    codigo.AppendLine("ListaErrores.Add(patron);");
                    //}

            codigo.AppendLine(@"       } // constructor Evaluador ");
            codigo.AppendLine(@" public string Evaluar (string input) {
                                 StringBuilder salida = new StringBuilder();
                                foreach (Pattern pt in ListaAcciones)
                                {
                                    Regex rgx = new Regex(pt.Patron,
                                    RegexOptions.Compiled | RegexOptions.IgnoreCase);
                                    foreach (Match mt in rgx.Matches(input))
                                    {
                                        salida.AppendLine(mt.Value + ' ' + '=' + ' ' + pt.Numero  + ' '  + ' ');
                                    }
                                 }

                                foreach (Pattern pt in ListaTokens)
                                {
                                    Regex rgx = new Regex(pt.Patron,
                                                    RegexOptions.Compiled);
                                    foreach (Match mt in rgx.Matches(input))
                                    {
                                        salida.AppendLine(mt.Value + ' ' + '=' + ' ' + pt.Numero  + ' '  + ' ');
                                    }
                                }
                                return salida.ToString();
                             } // Evaluar ");
            codigo.AppendLine("       } // Evaluador ");
                codigo.AppendLine(@"
                    class Program {
                       static void Main(string[] args) {
                        Console.Title = typeof(Program).Name;
                        // We will add some set-up stuff here later...

                        Run();
                       } // static Main

                        static void Run()
    {
        while (true)
        {  
            var consoleInput = ReadFromConsole();
            if (string.IsNullOrWhiteSpace(consoleInput)) continue;
  
            try
            {
                // Execute the command:
                string result = Execute(consoleInput);
      
                // Write out the result:
                WriteToConsole(result);
            }
            catch (Exception ex)
            {
                // OOPS! Something went wrong - Write out the problem:
                WriteToConsole(ex.Message);
            }
        }
    }


    static string Execute(string command)
    {
        Evaluador evalu = new Evaluador();
        return evalu.Evaluar(command);
        
    }


        public static void WriteToConsole(string message = """")
        {
            if (message.Length > 0)
            {
                Console.WriteLine(message);
            }
        }


        const string _readPrompt = ""console> "";
        public static string ReadFromConsole(string promptMessage = """")
        {
            // Show a prompt, and get input:
            Console.Write(_readPrompt + promptMessage);
            return Console.ReadLine();
        }
                    ");
                   
                codigo.AppendLine("");
            codigo.AppendLine("} // Program");
            codigo.AppendLine("} // namespace");

            // genera el archivo
            string path = @"C:\Users\desa\Documents\Evaluador\";
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(path + "evaluador.cs"))
            {
                file.WriteLine(codigo.ToString());
            }
            txtTokens.Text = txtTokens.Text + "\nCodigo ha sido generado   \n\r\n";

            int milliseconds = 3000;
            Thread.Sleep(milliseconds);

            // genera el exe
            string strCmdText;
            strCmdText = "-out:" + path + "evaludador.exe " +  path + "evaluador.cs";
            System.Diagnostics.Process.Start(@"C:\Windows\Microsoft.NET\Framework64\v4.0.30319\csc.exe", strCmdText);

            //Thread.Sleep(milliseconds);

            //// ejecuta el archivo
            //System.Diagnostics.Process.Start(path + "evaluador.exe");
        }
    }
}
