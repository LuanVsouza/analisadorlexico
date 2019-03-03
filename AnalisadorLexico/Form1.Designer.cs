namespace AnalisadorLexico
{
    partial class frmAnalisadorLexico
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbCodigo = new System.Windows.Forms.RichTextBox();
            this.btnGeradorLexico = new System.Windows.Forms.Button();
            this.btnCarregarCodigo = new System.Windows.Forms.Button();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.lbToken = new System.Windows.Forms.Label();
            this.txbToken = new System.Windows.Forms.RichTextBox();
            this.openArqCod = new System.Windows.Forms.OpenFileDialog();
            this.lbTabSimbolos = new System.Windows.Forms.Label();
            this.txbTabSimbolos = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txbCodigo
            // 
            this.txbCodigo.Location = new System.Drawing.Point(8, 41);
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.Size = new System.Drawing.Size(351, 313);
            this.txbCodigo.TabIndex = 0;
            this.txbCodigo.Text = "";
            // 
            // btnGeradorLexico
            // 
            this.btnGeradorLexico.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGeradorLexico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeradorLexico.Location = new System.Drawing.Point(388, 182);
            this.btnGeradorLexico.Name = "btnGeradorLexico";
            this.btnGeradorLexico.Size = new System.Drawing.Size(143, 54);
            this.btnGeradorLexico.TabIndex = 1;
            this.btnGeradorLexico.Text = "GERAR TOKENS";
            this.btnGeradorLexico.UseVisualStyleBackColor = false;
            this.btnGeradorLexico.Click += new System.EventHandler(this.btnGeradorLexico_Click);
            // 
            // btnCarregarCodigo
            // 
            this.btnCarregarCodigo.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCarregarCodigo.Location = new System.Drawing.Point(109, 370);
            this.btnCarregarCodigo.Name = "btnCarregarCodigo";
            this.btnCarregarCodigo.Size = new System.Drawing.Size(149, 35);
            this.btnCarregarCodigo.TabIndex = 2;
            this.btnCarregarCodigo.Text = "Carregar Codigo";
            this.btnCarregarCodigo.UseVisualStyleBackColor = false;
            this.btnCarregarCodigo.Click += new System.EventHandler(this.btnCarregarCodigo_Click);
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo.Location = new System.Drawing.Point(6, 16);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(153, 20);
            this.lbCodigo.TabIndex = 3;
            this.lbCodigo.Text = "Digite seu código:";
            // 
            // lbToken
            // 
            this.lbToken.AutoSize = true;
            this.lbToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToken.Location = new System.Drawing.Point(554, 20);
            this.lbToken.Name = "lbToken";
            this.lbToken.Size = new System.Drawing.Size(146, 20);
            this.lbToken.TabIndex = 4;
            this.lbToken.Text = "Tokens Gerados:";
            // 
            // txbToken
            // 
            this.txbToken.Location = new System.Drawing.Point(558, 44);
            this.txbToken.Name = "txbToken";
            this.txbToken.Size = new System.Drawing.Size(168, 361);
            this.txbToken.TabIndex = 5;
            this.txbToken.Text = "";
            // 
            // openArqCod
            // 
            this.openArqCod.FileName = "openArqCod";
            // 
            // lbTabSimbolos
            // 
            this.lbTabSimbolos.AutoSize = true;
            this.lbTabSimbolos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTabSimbolos.Location = new System.Drawing.Point(740, 20);
            this.lbTabSimbolos.Name = "lbTabSimbolos";
            this.lbTabSimbolos.Size = new System.Drawing.Size(171, 20);
            this.lbTabSimbolos.TabIndex = 7;
            this.lbTabSimbolos.Text = "Tabela de Simbolos:";
            // 
            // txbTabSimbolos
            // 
            this.txbTabSimbolos.Location = new System.Drawing.Point(743, 44);
            this.txbTabSimbolos.Name = "txbTabSimbolos";
            this.txbTabSimbolos.Size = new System.Drawing.Size(168, 361);
            this.txbTabSimbolos.TabIndex = 8;
            this.txbTabSimbolos.Text = "";
            // 
            // frmAnalisadorLexico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(923, 416);
            this.Controls.Add(this.txbTabSimbolos);
            this.Controls.Add(this.lbTabSimbolos);
            this.Controls.Add(this.txbToken);
            this.Controls.Add(this.lbToken);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.btnCarregarCodigo);
            this.Controls.Add(this.btnGeradorLexico);
            this.Controls.Add(this.txbCodigo);
            this.MaximizeBox = false;
            this.Name = "frmAnalisadorLexico";
            this.Text = "Analisador Léxico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txbCodigo;
        private System.Windows.Forms.Button btnGeradorLexico;
        private System.Windows.Forms.Button btnCarregarCodigo;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Label lbToken;
        private System.Windows.Forms.RichTextBox txbToken;
        private System.Windows.Forms.OpenFileDialog openArqCod;
        private System.Windows.Forms.Label lbTabSimbolos;
        private System.Windows.Forms.RichTextBox txbTabSimbolos;
    }
}

