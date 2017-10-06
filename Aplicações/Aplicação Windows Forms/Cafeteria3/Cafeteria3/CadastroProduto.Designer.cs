namespace Cafeteria3
{
    partial class frmCadastroProduto
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.grpbDados = new System.Windows.Forms.GroupBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.rdbMateria = new System.Windows.Forms.RadioButton();
            this.rdbProduzido = new System.Windows.Forms.RadioButton();
            this.rdbPronto = new System.Windows.Forms.RadioButton();
            this.btmSair = new System.Windows.Forms.Button();
            this.grpbDados.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Location = new System.Drawing.Point(78, 30);
            this.txtNome.MaxLength = 30;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(230, 20);
            this.txtNome.TabIndex = 0;
            // 
            // txtPreco
            // 
            this.txtPreco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPreco.Location = new System.Drawing.Point(78, 69);
            this.txtPreco.MaxLength = 12;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(85, 20);
            this.txtPreco.TabIndex = 1;
            this.txtPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPreco.TextChanged += new System.EventHandler(this.txtPreco_TextChanged);
            this.txtPreco.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPreco_KeyDown);
            this.txtPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPreco_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Preço:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Location = new System.Drawing.Point(13, 312);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(71, 53);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Categoria";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(78, 107);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(126, 21);
            this.cmbCategoria.TabIndex = 2;
            // 
            // grpbDados
            // 
            this.grpbDados.Controls.Add(this.lblCategoria);
            this.grpbDados.Controls.Add(this.lblPreco);
            this.grpbDados.Controls.Add(this.lblNome);
            this.grpbDados.Controls.Add(this.cmbCategoria);
            this.grpbDados.Controls.Add(this.label1);
            this.grpbDados.Controls.Add(this.label4);
            this.grpbDados.Controls.Add(this.txtNome);
            this.grpbDados.Controls.Add(this.label2);
            this.grpbDados.Controls.Add(this.txtPreco);
            this.grpbDados.Location = new System.Drawing.Point(12, 12);
            this.grpbDados.Name = "grpbDados";
            this.grpbDados.Size = new System.Drawing.Size(367, 146);
            this.grpbDados.TabIndex = 0;
            this.grpbDados.TabStop = false;
            this.grpbDados.Text = "Dados";
            this.grpbDados.Enter += new System.EventHandler(this.grpbDados_Enter);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.SystemColors.Control;
            this.lblCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.Red;
            this.lblCategoria.Location = new System.Drawing.Point(210, 111);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(12, 12);
            this.lblCategoria.TabIndex = 11;
            this.lblCategoria.Text = "X";
            this.lblCategoria.Visible = false;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.BackColor = System.Drawing.SystemColors.Control;
            this.lblPreco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.ForeColor = System.Drawing.Color.Red;
            this.lblPreco.Location = new System.Drawing.Point(169, 71);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(12, 12);
            this.lblPreco.TabIndex = 10;
            this.lblPreco.Text = "X";
            this.lblPreco.Visible = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.SystemColors.Control;
            this.lblNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Red;
            this.lblNome.Location = new System.Drawing.Point(314, 33);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(12, 12);
            this.lblNome.TabIndex = 9;
            this.lblNome.Text = "X";
            this.lblNome.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTipo);
            this.groupBox1.Controls.Add(this.rdbMateria);
            this.groupBox1.Controls.Add(this.rdbProduzido);
            this.groupBox1.Controls.Add(this.rdbPronto);
            this.groupBox1.Location = new System.Drawing.Point(12, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 124);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.SystemColors.Control;
            this.lblTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.Red;
            this.lblTipo.Location = new System.Drawing.Point(280, 55);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(12, 12);
            this.lblTipo.TabIndex = 14;
            this.lblTipo.Text = "X";
            this.lblTipo.Visible = false;
            // 
            // rdbMateria
            // 
            this.rdbMateria.AutoSize = true;
            this.rdbMateria.Location = new System.Drawing.Point(22, 87);
            this.rdbMateria.Name = "rdbMateria";
            this.rdbMateria.Size = new System.Drawing.Size(145, 17);
            this.rdbMateria.TabIndex = 5;
            this.rdbMateria.TabStop = true;
            this.rdbMateria.Text = "Matéria Prima - Fornecido";
            this.rdbMateria.UseVisualStyleBackColor = true;
            this.rdbMateria.CheckedChanged += new System.EventHandler(this.rdbMateria_CheckedChanged);
            // 
            // rdbProduzido
            // 
            this.rdbProduzido.AutoSize = true;
            this.rdbProduzido.Location = new System.Drawing.Point(22, 52);
            this.rdbProduzido.Name = "rdbProduzido";
            this.rdbProduzido.Size = new System.Drawing.Size(160, 17);
            this.rdbProduzido.TabIndex = 4;
            this.rdbProduzido.TabStop = true;
            this.rdbProduzido.Text = "Produto Produzido - Vendido";
            this.rdbProduzido.UseVisualStyleBackColor = true;
            this.rdbProduzido.CheckedChanged += new System.EventHandler(this.rdbProduzido_CheckedChanged);
            // 
            // rdbPronto
            // 
            this.rdbPronto.AutoSize = true;
            this.rdbPronto.Location = new System.Drawing.Point(22, 20);
            this.rdbPronto.Name = "rdbPronto";
            this.rdbPronto.Size = new System.Drawing.Size(200, 17);
            this.rdbPronto.TabIndex = 3;
            this.rdbPronto.TabStop = true;
            this.rdbPronto.Text = "Produto Pronto - Vendido e fornecido";
            this.rdbPronto.UseVisualStyleBackColor = true;
            this.rdbPronto.CheckedChanged += new System.EventHandler(this.rdbPronto_CheckedChanged);
            // 
            // btmSair
            // 
            this.btmSair.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btmSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btmSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btmSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmSair.Location = new System.Drawing.Point(308, 312);
            this.btmSair.Name = "btmSair";
            this.btmSair.Size = new System.Drawing.Size(71, 53);
            this.btmSair.TabIndex = 7;
            this.btmSair.Text = "Sair";
            this.btmSair.UseVisualStyleBackColor = true;
            this.btmSair.Click += new System.EventHandler(this.btmSair_Click);
            // 
            // frmCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 381);
            this.Controls.Add(this.btmSair);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpbDados);
            this.Controls.Add(this.btnCadastrar);
            this.Name = "frmCadastroProduto";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Produto";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCadastroProduto_FormClosed);
            this.Load += new System.EventHandler(this.frmCadastroProduto_Load);
            this.grpbDados.ResumeLayout(false);
            this.grpbDados.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.GroupBox grpbDados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbMateria;
        private System.Windows.Forms.RadioButton rdbProduzido;
        private System.Windows.Forms.RadioButton rdbPronto;
        private System.Windows.Forms.Button btmSair;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTipo;
    }
}

