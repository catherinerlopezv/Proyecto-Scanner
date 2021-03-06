// Generated by TinyPG v1.3 available at www.codeproject.com

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace TinyPG
{
    #region Scanner

    public partial class Scanner
    {
        public string Input;
        public int StartPos = 0;
        public int EndPos = 0;
        public string CurrentFile;
        public int CurrentLine;
        public int CurrentColumn;
        public int CurrentPosition;
        public List<Token> Skipped; // tokens that were skipped
        public Dictionary<TokenType, Regex> Patterns;

        private Token LookAheadToken;
        private List<TokenType> Tokens;
        private List<TokenType> SkipList; // tokens to be skipped
        private readonly TokenType FileAndLine;

        public Scanner()
        {
            Regex regex;
            Patterns = new Dictionary<TokenType, Regex>();
            Tokens = new List<TokenType>();
            LookAheadToken = null;
            Skipped = new List<Token>();

            SkipList = new List<TokenType>();
            SkipList.Add(TokenType.WHITESPACE);

            regex = new Regex(@"SETS", RegexOptions.Compiled);
            Patterns.Add(TokenType.PR_SETS, regex);
            Tokens.Add(TokenType.PR_SETS);

            regex = new Regex(@"TOKENS", RegexOptions.Compiled);
            Patterns.Add(TokenType.PR_TOKENS, regex);
            Tokens.Add(TokenType.PR_TOKENS);

            regex = new Regex(@"TOKEN", RegexOptions.Compiled);
            Patterns.Add(TokenType.PR_TOKEN, regex);
            Tokens.Add(TokenType.PR_TOKEN);

            regex = new Regex(@"ACTIONS", RegexOptions.Compiled);
            Patterns.Add(TokenType.PR_ACCIONES, regex);
            Tokens.Add(TokenType.PR_ACCIONES);

            regex = new Regex(@"RESERVADAS", RegexOptions.Compiled);
            Patterns.Add(TokenType.PR_RESERVADAS, regex);
            Tokens.Add(TokenType.PR_RESERVADAS);

            regex = new Regex(@"^\s*$", RegexOptions.Compiled);
            Patterns.Add(TokenType.EOF, regex);
            Tokens.Add(TokenType.EOF);

            regex = new Regex(@"[0-9]+", RegexOptions.Compiled);
            Patterns.Add(TokenType.NUMERO, regex);
            Tokens.Add(TokenType.NUMERO);

            regex = new Regex(@"(\S)", RegexOptions.Compiled);
            Patterns.Add(TokenType.CARACTER, regex);
            Tokens.Add(TokenType.CARACTER);

            regex = new Regex(@"(\*|\+|\?)", RegexOptions.Compiled);
            Patterns.Add(TokenType.MODIFICADOR, regex);
            Tokens.Add(TokenType.MODIFICADOR);

            regex = new Regex(@"(\')", RegexOptions.Compiled);
            Patterns.Add(TokenType.COMILLA, regex);
            Tokens.Add(TokenType.COMILLA);

            regex = new Regex(@"(\d)", RegexOptions.Compiled);
            Patterns.Add(TokenType.DIGITO, regex);
            Tokens.Add(TokenType.DIGITO);

            regex = new Regex(@"([A-Za-z_])", RegexOptions.Compiled);
            Patterns.Add(TokenType.LETRA, regex);
            Tokens.Add(TokenType.LETRA);

            regex = new Regex(@"([A-Za-z]*[E][R][R][O][R])", RegexOptions.Compiled);
            Patterns.Add(TokenType.IDERROR, regex);
            Tokens.Add(TokenType.IDERROR);

            regex = new Regex(@"(?!SETS|TOKENS|TOKEN|ACTIONS|.*?ERROR)^[A-Za-z][A-Za-z0-9]*", RegexOptions.Compiled);
            Patterns.Add(TokenType.IDENTIFICADOR, regex);
            Tokens.Add(TokenType.IDENTIFICADOR);

            regex = new Regex(@"(((?!SETS)|(?!TOKENS)|(?!TOKEN)|(?!ACTIONS))([A-Za-z][a-zA-Z0-9_]*))", RegexOptions.Compiled);
            Patterns.Add(TokenType.IDENTIFICADOR2, regex);
            Tokens.Add(TokenType.IDENTIFICADOR2);

            regex = new Regex(@"\(", RegexOptions.Compiled);
            Patterns.Add(TokenType.PABIERTO, regex);
            Tokens.Add(TokenType.PABIERTO);

            regex = new Regex(@"\)", RegexOptions.Compiled);
            Patterns.Add(TokenType.PCERRADO, regex);
            Tokens.Add(TokenType.PCERRADO);

            regex = new Regex(@"(\+)", RegexOptions.Compiled);
            Patterns.Add(TokenType.MAS, regex);
            Tokens.Add(TokenType.MAS);

            regex = new Regex(@"=", RegexOptions.Compiled);
            Patterns.Add(TokenType.IGUAL, regex);
            Tokens.Add(TokenType.IGUAL);

            regex = new Regex(@"{", RegexOptions.Compiled);
            Patterns.Add(TokenType.LLABIERTA, regex);
            Tokens.Add(TokenType.LLABIERTA);

            regex = new Regex(@"}", RegexOptions.Compiled);
            Patterns.Add(TokenType.LLCERRADA, regex);
            Tokens.Add(TokenType.LLCERRADA);

            regex = new Regex(@"..", RegexOptions.Compiled);
            Patterns.Add(TokenType.DOBLEPUNTO, regex);
            Tokens.Add(TokenType.DOBLEPUNTO);

            regex = new Regex(@"[C][H][R]", RegexOptions.Compiled);
            Patterns.Add(TokenType.CHARF, regex);
            Tokens.Add(TokenType.CHARF);

            regex = new Regex(@";", RegexOptions.Compiled);
            Patterns.Add(TokenType.PUNTOCOMA, regex);
            Tokens.Add(TokenType.PUNTOCOMA);

            regex = new Regex(@"[\n|\r|\r\n]+", RegexOptions.Compiled);
            Patterns.Add(TokenType.SALTOLINEA, regex);
            Tokens.Add(TokenType.SALTOLINEA);

            regex = new Regex(@"[\s\t]+", RegexOptions.Compiled);
            Patterns.Add(TokenType.WHITESPACE, regex);
            Tokens.Add(TokenType.WHITESPACE);


        }

        public void Init(string input)
        {
            Init(input, "");
        }

        public void Init(string input, string fileName)
        {
            this.Input = input;
            StartPos = 0;
            EndPos = 0;
            CurrentFile = fileName;
            CurrentLine = 1;
            CurrentColumn = 1;
            CurrentPosition = 0;
            LookAheadToken = null;
        }

        public Token GetToken(TokenType type)
        {
            Token t = new Token(this.StartPos, this.EndPos);
            t.Type = type;
            return t;
        }

         /// <summary>
        /// executes a lookahead of the next token
        /// and will advance the scan on the input string
        /// </summary>
        /// <returns></returns>
        public Token Scan(params TokenType[] expectedtokens)
        {
            Token tok = LookAhead(expectedtokens); // temporarely retrieve the lookahead
            LookAheadToken = null; // reset lookahead token, so scanning will continue
            StartPos = tok.EndPos;
            EndPos = tok.EndPos; // set the tokenizer to the new scan position
            CurrentLine = tok.Line + (tok.Text.Length - tok.Text.Replace("\n", "").Length);
            CurrentFile = tok.File;
            return tok;
        }

        /// <summary>
        /// returns token with longest best match
        /// </summary>
        /// <returns></returns>
        public Token LookAhead(params TokenType[] expectedtokens)
        {
            int i;
            int startpos = StartPos;
            int endpos = EndPos;
            int currentline = CurrentLine;
            string currentFile = CurrentFile;
            Token tok = null;
            List<TokenType> scantokens;


            // this prevents double scanning and matching
            // increased performance
            if (LookAheadToken != null 
                && LookAheadToken.Type != TokenType._UNDETERMINED_ 
                && LookAheadToken.Type != TokenType._NONE_) return LookAheadToken;

            // if no scantokens specified, then scan for all of them (= backward compatible)
            if (expectedtokens.Length == 0)
                scantokens = Tokens;
            else
            {
                scantokens = new List<TokenType>(expectedtokens);
                scantokens.AddRange(SkipList);
            }

            do
            {

                int len = -1;
                TokenType index = (TokenType)int.MaxValue;
                string input = Input.Substring(startpos);

                tok = new Token(startpos, endpos);

                for (i = 0; i < scantokens.Count; i++)
                {
                    Regex r = Patterns[scantokens[i]];
                    Match m = r.Match(input);
                    if (m.Success && m.Index == 0 && ((m.Length > len) || (scantokens[i] < index && m.Length == len )))
                    {
                        len = m.Length;
                        index = scantokens[i];  
                    }
                }

                if (index >= 0 && len >= 0)
                {
                    tok.EndPos = startpos + len;
                    tok.Text = Input.Substring(tok.StartPos, len);
                    tok.Type = index;
                }
                else if (tok.StartPos == tok.EndPos)
                {
                    if (tok.StartPos < Input.Length)
                        tok.Text = Input.Substring(tok.StartPos, 1);
                    else
                        tok.Text = "EOF";
                }

                // Update the line and column count for error reporting.
                tok.File = currentFile;
                tok.Line = currentline;
                if (tok.StartPos < Input.Length)
                    tok.Column = tok.StartPos - Input.LastIndexOf('\n', tok.StartPos);

                if (SkipList.Contains(tok.Type))
                {
                    startpos = tok.EndPos;
                    endpos = tok.EndPos;
                    currentline = tok.Line + (tok.Text.Length - tok.Text.Replace("\n", "").Length);
                    currentFile = tok.File;
                    Skipped.Add(tok);
                }
                else
                {
                    // only assign to non-skipped tokens
                    tok.Skipped = Skipped; // assign prior skips to this token
                    Skipped = new List<Token>(); //reset skips
                }

                // Check to see if the parsed token wants to 
                // alter the file and line number.
                if (tok.Type == FileAndLine)
                {
                    var match = Patterns[tok.Type].Match(tok.Text);
                    var fileMatch = match.Groups["File"];
                    if (fileMatch.Success)
                        currentFile = fileMatch.Value.Replace("\\\\", "\\");
                    var lineMatch = match.Groups["Line"];
                    if (lineMatch.Success)
                        currentline = int.Parse(lineMatch.Value, NumberStyles.Integer, CultureInfo.InvariantCulture);
                }
            }
            while (SkipList.Contains(tok.Type));

            LookAheadToken = tok;
            return tok;
        }
    }

    #endregion

    #region Token

    public enum TokenType
    {

            //Non terminal tokens:
            _NONE_  = 0,
            _UNDETERMINED_= 1,

            //Non terminal tokens:
            Start   = 2,
            Gramatica= 3,
            Sets    = 4,
            CuerpoSets= 5,
            ListaSets= 6,
            SetDef  = 7,
            Def     = 8,
            Tokens  = 9,
            DeclaracionTokens= 10,
            CuerpoTokens= 11,
            ListaTokens= 12,
            ListaDefToken= 13,
            DefToken= 14,
            SimpleToken= 15,
            AgrupaToken= 16,
            Acciones= 17,
            DeclaracionAcciones= 18,
            CuerpoAcciones= 19,
            FuncionReservadas= 20,
            CuerpoFunciones= 21,
            ListaAcciones= 22,
            ListaFunciones= 23,
            OtrasFunciones= 24,
            Errores = 25,
            ListaErrores= 26,

            //Terminal tokens:
            PR_SETS = 27,
            PR_TOKENS= 28,
            PR_TOKEN= 29,
            PR_ACCIONES= 30,
            PR_RESERVADAS= 31,
            EOF     = 32,
            NUMERO  = 33,
            CARACTER= 34,
            MODIFICADOR= 35,
            COMILLA = 36,
            DIGITO  = 37,
            LETRA   = 38,
            IDERROR = 39,
            IDENTIFICADOR= 40,
            IDENTIFICADOR2= 41,
            PABIERTO= 42,
            PCERRADO= 43,
            MAS     = 44,
            IGUAL   = 45,
            LLABIERTA= 46,
            LLCERRADA= 47,
            DOBLEPUNTO= 48,
            CHARF   = 49,
            PUNTOCOMA= 50,
            SALTOLINEA= 51,
            WHITESPACE= 52
    }

    public class Token
    {
        private string file;
        private int line;
        private int column;
        private int startpos;
        private int endpos;
        private string text;
        private object value;

        // contains all prior skipped symbols
        private List<Token> skipped;

        public string File { 
            get { return file; } 
            set { file = value; }
        }

        public int Line { 
            get { return line; } 
            set { line = value; }
        }

        public int Column {
            get { return column; } 
            set { column = value; }
        }

        public int StartPos { 
            get { return startpos;} 
            set { startpos = value; }
        }

        public int Length { 
            get { return endpos - startpos;} 
        }

        public int EndPos { 
            get { return endpos;} 
            set { endpos = value; }
        }

        public string Text { 
            get { return text;} 
            set { text = value; }
        }

        public List<Token> Skipped { 
            get { return skipped;} 
            set { skipped = value; }
        }
        public object Value { 
            get { return value;} 
            set { this.value = value; }
        }

        [XmlAttribute]
        public TokenType Type;

        public Token()
            : this(0, 0)
        {
        }

        public Token(int start, int end)
        {
            Type = TokenType._UNDETERMINED_;
            startpos = start;
            endpos = end;
            Text = ""; // must initialize with empty string, may cause null reference exceptions otherwise
            Value = null;
        }

        public void UpdateRange(Token token)
        {
            if (token.StartPos < startpos) startpos = token.StartPos;
            if (token.EndPos > endpos) endpos = token.EndPos;
        }

        public override string ToString()
        {
            if (Text != null)
                return Type.ToString() + " '" + Text + "'";
            else
                return Type.ToString();
        }
    }

    #endregion
}
