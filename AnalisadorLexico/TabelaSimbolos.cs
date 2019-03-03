using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisadorLexico
{
    class TabelaSimbolos
    {
        public List<Simbolo> Simbolos = new List<Simbolo>();

        public int id_simbolo(string lexema)
        {
            try
            {
                if (Simbolos.Where(x => x.Nome == lexema).ToList().Count > 0)
                {
                    return Simbolos.Where(x => x.Nome == lexema).First().Id;
                }
                else
                {
                    Simbolos.Add(new Simbolo
                    {
                        Id = Simbolos.Count + 1,
                        Nome = lexema
                    });

                    return Simbolos.Where(x => x.Nome == lexema).First().Id;
                }
            }
            catch
            {
                return -1;
            }
        }
    }
}
