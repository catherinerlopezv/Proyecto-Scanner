using System;
                                using System.Collections.Generic;
                                using System.Text;
                                using System.Xml.Serialization;
                                using System.Text.RegularExpressions; 
                                namespace Codigo {
public class Pattern
                {
                    public string Nombre { get; set; }
                    public string Numero { get; set; }
                    public string Patron { get; set; }
                }
public class Evaluador {
                   public List<Pattern> ListaTokens { get; set; }
                   public List<Pattern> ListaAcciones { get; set; }
                   public List<Pattern> ListaErrores { get; set; }

                   public Evaluador() {
                      ListaTokens = new List<Pattern>();
                      ListaAcciones = new List<Pattern>();
                      ListaErrores = new List<Pattern>();
                      Pattern patron;
patron = new Pattern();
patron.Nombre = "";
patron.Numero = "1";
patron.Patron = @"[0-9][0-9]*";
ListaTokens.Add(patron);
patron = new Pattern();
patron.Nombre = "";
patron.Numero = "4";
patron.Patron = @"[\=]";
ListaTokens.Add(patron);
patron = new Pattern();
patron.Nombre = "";
patron.Numero = "5";
patron.Patron = @"[\<][\>]";
ListaTokens.Add(patron);
patron = new Pattern();
patron.Nombre = "";
patron.Numero = "6";
patron.Patron = @"[\<]";
ListaTokens.Add(patron);
patron = new Pattern();
patron.Nombre = "";
patron.Numero = "7";
patron.Patron = @"[\>]";
ListaTokens.Add(patron);
patron = new Pattern();
patron.Nombre = "";
patron.Numero = "8";
patron.Patron = @"[\>][\=]";
ListaTokens.Add(patron);
patron = new Pattern();
patron.Nombre = "";
patron.Numero = "9";
patron.Patron = @"[\<][\=]";
ListaTokens.Add(patron);
patron = new Pattern();
patron.Nombre = "";
patron.Numero = "10";
patron.Patron = @"[\+]";
ListaTokens.Add(patron);
patron = new Pattern();
patron.Nombre = "";
patron.Numero = "11";
patron.Patron = @"[\-]";
ListaTokens.Add(patron);
patron = new Pattern();
patron.Nombre = "";
patron.Numero = "12";
patron.Patron = @"[O][R]";
ListaTokens.Add(patron);
patron = new Pattern();
patron.Nombre = "";
patron.Numero = "13";
patron.Patron = @"[\*]";
ListaTokens.Add(patron);
patron = new Pattern();
patron.Nombre = "";
patron.Numero = "14";
patron.Patron = @"[A][N][D]";
ListaTokens.Add(patron);
patron = new Pattern();
patron.Nombre = "";
patron.Numero = "15";
patron.Patron = @"[M][O][D]";
ListaTokens.Add(patron);
patron = new Pattern();
patron.Nombre = "";
patron.Numero = "16";
patron.Patron = @"[D][I][V]";
ListaTokens.Add(patron);
patron = new Pattern();
patron.Nombre = "";
patron.Numero = "17";
patron.Patron = @"[N][O][T]";
ListaTokens.Add(patron);
patron = new Pattern();
patron.Nombre = "";
patron.Numero = "40";
patron.Patron = @"[\(][\*]";
ListaTokens.Add(patron);
patron = new Pattern();
patron.Nombre = "";
patron.Numero = "41";
patron.Patron = @"[\*][\)]";
ListaTokens.Add(patron);
patron = new Pattern();
patron.Nombre = "";
patron.Numero = "42";
patron.Patron = @"[\;]";
ListaTokens.Add(patron);
patron = new Pattern();
patron.Nombre = "";
patron.Numero = "43";
patron.Patron = @"[\.]";
ListaTokens.Add(patron);
patron = new Pattern();
patron.Nombre = "";
patron.Numero = "44";
patron.Patron = @"[\{]";
ListaTokens.Add(patron);
patron = new Pattern();
patron.Nombre = "";
patron.Numero = "45";
patron.Patron = @"[\}]";
ListaTokens.Add(patron);
patron = new Pattern();
patron.Nombre = "";
patron.Numero = "46";
patron.Patron = @"[\(]";
ListaTokens.Add(patron);
patron = new Pattern();
patron.Nombre = "";
patron.Numero = "47";
patron.Patron = @"[\)]";
ListaTokens.Add(patron);
patron = new Pattern();
patron.Nombre = "";
patron.Numero = "48";
patron.Patron = @"[\[]";
ListaTokens.Add(patron);
patron = new Pattern();
patron.Nombre = "";
patron.Numero = "49";
patron.Patron = @"[\]]";
ListaTokens.Add(patron);
patron = new Pattern();
patron.Nombre = "";
patron.Numero = "50";
patron.Patron = @"[\.][\.]";
ListaTokens.Add(patron);
patron = new Pattern();
patron.Nombre = "";
patron.Numero = "51";
patron.Patron = @"[\:]";
ListaTokens.Add(patron);
patron = new Pattern();
patron.Nombre = "";
patron.Numero = "52";
patron.Patron = @"[\,]";
ListaTokens.Add(patron);
patron = new Pattern();
patron.Nombre = "";
patron.Numero = "53";
patron.Patron = @"[\:][\=]";
ListaTokens.Add(patron);
patron = new Pattern();
patron.Nombre = "";
patron.Numero = "3";
patron.Patron = @"[A-Z][a-z][_]([A-Z][a-z][_]|[0-9])*";
ListaTokens.Add(patron);
patron = new Pattern();
patron.Nombre = "";
patron.Numero = "18";
patron.Patron = @"[P][R][O][G][R][A][M]";
ListaAcciones.Add(patron);
patron = new Pattern();
patron.Nombre = "";
patron.Numero = "19";
patron.Patron = @"[I][N][C][L][U][D][E]";
ListaAcciones.Add(patron);
patron = new Pattern();
patron.Nombre = "";
patron.Numero = "20";
patron.Patron = @"[C][O][N][S][T]";
ListaAcciones.Add(patron);
patron = new Pattern();
patron.Nombre = "";
patron.Numero = "21";
patron.Patron = @"[T][Y][P][E]";
ListaAcciones.Add(patron);
patron = new Pattern();
patron.Nombre = "";
patron.Numero = "22";
patron.Patron = @"[V][A][R]";
ListaAcciones.Add(patron);
patron = new Pattern();
patron.Nombre = "";
patron.Numero = "23";
patron.Patron = @"[R][E][C][O][R][D]";
ListaAcciones.Add(patron);
patron = new Pattern();
patron.Nombre = "";
patron.Numero = "24";
patron.Patron = @"[A][R][R][A][Y]";
ListaAcciones.Add(patron);
patron = new Pattern();
patron.Nombre = "";
patron.Numero = "25";
patron.Patron = @"[O][F]";
ListaAcciones.Add(patron);
patron = new Pattern();
patron.Nombre = "";
patron.Numero = "26";
patron.Patron = @"[P][R][O][C][E][D][U][R][E]";
ListaAcciones.Add(patron);
patron = new Pattern();
patron.Nombre = "";
patron.Numero = "27";
patron.Patron = @"[F][U][N][C][T][I][O][N]";
ListaAcciones.Add(patron);
patron = new Pattern();
patron.Nombre = "";
patron.Numero = "28";
patron.Patron = @"[I][F]";
ListaAcciones.Add(patron);
patron = new Pattern();
patron.Nombre = "";
patron.Numero = "29";
patron.Patron = @"[T][H][E][N]";
ListaAcciones.Add(patron);
patron = new Pattern();
patron.Nombre = "";
patron.Numero = "30";
patron.Patron = @"[E][L][S][E]";
ListaAcciones.Add(patron);
patron = new Pattern();
patron.Nombre = "";
patron.Numero = "31";
patron.Patron = @"[F][O][R]";
ListaAcciones.Add(patron);
patron = new Pattern();
patron.Nombre = "";
patron.Numero = "32";
patron.Patron = @"[T][O]";
ListaAcciones.Add(patron);
patron = new Pattern();
patron.Nombre = "";
patron.Numero = "33";
patron.Patron = @"[W][H][I][L][E]";
ListaAcciones.Add(patron);
patron = new Pattern();
patron.Nombre = "";
patron.Numero = "34";
patron.Patron = @"[D][O]";
ListaAcciones.Add(patron);
patron = new Pattern();
patron.Nombre = "";
patron.Numero = "35";
patron.Patron = @"[E][X][I][T]";
ListaAcciones.Add(patron);
patron = new Pattern();
patron.Nombre = "";
patron.Numero = "36";
patron.Patron = @"[E][N][D]";
ListaAcciones.Add(patron);
patron = new Pattern();
patron.Nombre = "";
patron.Numero = "37";
patron.Patron = @"[C][A][S][E]";
ListaAcciones.Add(patron);
patron = new Pattern();
patron.Nombre = "";
patron.Numero = "38";
patron.Patron = @"[B][R][E][A][K]";
ListaAcciones.Add(patron);
patron = new Pattern();
patron.Nombre = "";
patron.Numero = "39";
patron.Patron = @"[D][O][W][N][T][O]";
ListaAcciones.Add(patron);
       } // constructor Evaluador 
 public string Evaluar (string input) {
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
                             } // Evaluar 
       } // Evaluador 

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


        public static void WriteToConsole(string message = "")
        {
            if (message.Length > 0)
            {
                Console.WriteLine(message);
            }
        }


        const string _readPrompt = "console> ";
        public static string ReadFromConsole(string promptMessage = "")
        {
            // Show a prompt, and get input:
            Console.Write(_readPrompt + promptMessage);
            return Console.ReadLine();
        }
                    

} // Program
} // namespace

