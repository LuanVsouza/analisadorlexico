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

        private void btnGeradorLexico_Click(object sender, EventArgs e)
        {

            //Adcionar os tokens

            string codigo;

            txbToken.Clear();

            codigo = txbCodigo.Text;

            //Converte o codigo de string para char
            char[] programa = codigo.ToCharArray();

            if(codigo != "")
            {
                Lexico lex = new Lexico(programa);

                String token = "";

                while (token != ";")
                {
                    token = lex.GetToken();
                    txbToken.Text += token.ToString() + "\n";
                }

                foreach (Simbolo item in lex.tabelaSimbolos.Simbolos)
                {
                    txbTabSimbolos.Text += "ID: " + item.Id.ToString() + " | ";
                    txbTabSimbolos.Text += "Nome: " + item.Nome.ToString() + "\n";

                    dataGridView1.DataSource = item.Nome.ToString();
                }
            }
            else
            {
                MessageBox.Show("Erro: Nenhum Código Digitado!");
            }

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
