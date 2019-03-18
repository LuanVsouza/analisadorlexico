using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnalisadorLexico;

namespace AnalisadorLexico
{
    public partial class frmAnalisadorLexico : Form
    {
        public frmAnalisadorLexico()
        {
            InitializeComponent();
        }

        private Simbolo simbolo = new Simbolo();
        private TabelaSimbolos tabelaSimbolos = new TabelaSimbolos();

        string codigo;

        char[] programa;

        private void btnGeradorLexico_Click(object sender, EventArgs e)
        {
            codigo = txbCodigo.Text;

            String token = "";

            //Converte o codigo de string para char
            programa = codigo.ToCharArray();

            if(codigo != "")
            {
                Lexico lex = new Lexico(programa);

                while (token != ";")
                {
                    //Adcionar os tokens
                    token = lex.GetToken();

                    if ((token == "<Palavra reservada>") || (token == "<Palavra reservada>") || (token == "<RELOP>") || (token == ";") || (token == ("<STRING>")))
                    {
                        if(token != ";")
                        {
                            txbToken.Text += token.ToString() + "\n";
                            token = "";
                        }  
                    }
                    else
                    {
                        txbToken.Text += "<ID, " + tabelaSimbolos.add_simbolo(token) + ">" + "\n";
                        token = "";
                    }      
                }

                txbTabSimbolos.Clear();

                foreach (Simbolo item in tabelaSimbolos.Simbolos)
                {
                    txbTabSimbolos.Text += "ID: " + item.Id.ToString() + " | ";
                    txbTabSimbolos.Text += "Nome: " + item.Nome.ToString() + "\n";
                }
            }
            else
            {
                MessageBox.Show("Erro: Nenhum Código Digitado!");
            }

            txbCodigo.Clear();
        }

        //Carregar o Arquivo com o codigo
        private void btnCarregarCodigo_Click(object sender, EventArgs e)
        {

            openArqCod.Multiselect = false;
            openArqCod.Title = "Selecionar Arquivo";
            openArqCod.InitialDirectory = @"C:\";
            openArqCod.Filter = "Imagens (*.TXT)|*.TXT";
            openArqCod.CheckFileExists = true;
            openArqCod.CheckPathExists = true;
            openArqCod.FilterIndex = 1;

            DialogResult arq = openArqCod.ShowDialog();


            //Se o arquivo Selecionado for OK coloca no TxbCodigo
            if(arq.ToString() == "OK")
            {
                txbCodigo.Text = System.IO.File.ReadAllText(openArqCod.FileName);
            }
        }
    }
}
