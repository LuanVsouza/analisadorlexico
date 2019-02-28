﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisadorLexico
{
    class Lexico
    {
        private char peek;
        private int i;


        private char[] codigo;

        private string[] Operadores = { "+", "-", "*", "/", ">", "<", "=", "!", "(", ")" };

        private List<Simbolo> Simbolos = new List<Simbolo>();
        private PalavraReservada palavraReservada = new PalavraReservada();
        private TabelaSimbolos tabelaSimbolos = new TabelaSimbolos();

        public Lexico(char[] p)
        {
            codigo = p;
            init();
        }

        private void init()
        {
            i = 0;
            nextChar();
        }

        private void nextChar()
        {
            if (i < codigo.Length)
            {
                peek = codigo[i];
                i++;
            }
            else
            {
                peek = codigo[codigo.Length - 1];
            }
        }

        public string GetToken()
        {
            string token = "";

            //enquanto tiver espaço ele ignora
            while (peek == ' ' || peek == '\t' || peek == '\n')
            {
                nextChar();
            }

            //Numero
            if (Char.IsDigit(peek))
            {
                int v = 0;//vai armezenar o valor do numero

                while (Char.IsDigit(peek))
                {
                    v = 10 * v + int.Parse(peek.ToString());
                    nextChar();
                };

                token = "<NUM," + v.ToString() + ">";

                return token;
            }

            //Identificador
            if (Char.IsLetter(peek) || peek == '"')
            {
                // armazena as palavras do codigo
                StringBuilder lexema = new StringBuilder();

                while (Char.IsLetterOrDigit(peek) || peek == '"')
                {
                    lexema.Append(peek);
                    nextChar();

                };

                if (palavraReservada.PalavrasReservadas.Where(x => x.ToUpper() == lexema.ToString().ToUpper()).ToList().Count > 0)
                {
                    token = "<" + lexema.ToString() + "," + lexema.ToString() + ">";
                }
                else
                {
                    token = "<ID," + tabelaSimbolos.id_simbolo(lexema.ToString()).ToString() + ">";
                }

                return token;
            }

            if (palavraReservada.PalavrasReservadas.Where(x => x.ToUpper() == peek.ToString().ToUpper()).ToList().Count > 0)
            {
                token = "<" + peek.ToString() + ">";
                nextChar();
                return token;
            }

            //Operador
            if (Operadores.Where(x => x == peek.ToString()).ToList().Count > 0)
            {
                StringBuilder lexema = new StringBuilder();

                lexema.Append(peek);

                if (peek.ToString() == "=" || peek.ToString() == "!" || peek.ToString() == ">" || peek.ToString() == "<")
                {
                    nextChar();

                    if (peek.ToString() == "=")
                    {
                        lexema.Append(peek);
                        nextChar();
                    }
                }
                else
                {
                    nextChar();
                }

                token = "<OP," + lexema.ToString() + ">";

                return token;
            }

            token = peek.ToString();

            return token;
        }
    }
}