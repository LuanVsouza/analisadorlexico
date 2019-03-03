using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisadorLexico
{
    class PalavraReservada
    {
        public String[] PalavrasReservadas = {
            "Int",
            "String",
            "double",
            "float",
            "if",
            "else",
            "while",
            "for",
            "end"
        };

        public PalavraReservada() { }
    }
}