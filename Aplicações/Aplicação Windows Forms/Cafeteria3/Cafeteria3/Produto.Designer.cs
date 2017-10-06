namespace Cafeteria3
{
    partial class frmProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgProduto = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btmSair = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgProduto
            // 
            this.dtgProduto.AllowUserToAddRows = false;
            this.dtgProduto.AllowUserToDeleteRows = false;
            this.dtgProduto.AllowUserToResizeColumns = false;
            this.dtgProduto.AllowUserToResizeRows = false;
            this.dtgProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgProduto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProduto.Location = new System.Drawing.Point(12, 91);
            this.dtgProduto.MultiSelect = false;
            this.dtgProduto.Name = "dtgProduto";
            this.dtgProduto.ReadOnly = true;
            this.dtgProduto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtgProduto.Size = new System.Drawing.Size(555, 304);
            this.dtgProduto.TabIndex = 5;
            this.dtgProduto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProduto_CellClick);
            this.dtgProduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProduto_CellContentClick);
            this.dtgProduto.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProduto_CellContentDoubleClick);
            this.dtgProduto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProduto_CellDoubleClick);
            this.dtgProduto.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProduto_CellEnter);
            this.dtgProduto.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgProduto_CellMouseClick);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnPesquisar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnPesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Location = new System.Drawing.Point(181, 31);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(73, 38);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "Pesquisar Nome";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Image = global::Cafeteria3.Properties.Resources.asdasd;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.Location = new System.Drawing.Point(520, 26);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(47, 43);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btmSair
            // 
            this.btmSair.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btmSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btmSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btmSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmSair.Location = new System.Drawing.Point(524, 418);
            this.btmSair.Name = "btmSair";
            this.btmSair.Size = new System.Drawing.Size(43, 43);
            this.btmSair.TabIndex = 6;
            this.btmSair.Text = "<|---";
            this.btmSair.UseVisualStyleBackColor = true;
            this.btmSair.Click += new System.EventHandler(this.btmSair_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesquisa.ForeColor = System.Drawing.Color.Black;
            this.txtPesquisa.Location = new System.Drawing.Point(12, 38);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(152, 20);
            this.txtPesquisa.TabIndex = 0;
            this.txtPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPesquisa_KeyDown);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdicionar.Location = new System.Drawing.Point(468, 26);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(46, 43);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "+";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 477);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.btmSair);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.dtgProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmProduto";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Produto";
            this.Load += new System.EventHandler(this.frmProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btmSair;
        private System.Windows.Forms.TextBox txtPesquisa;
        public System.Windows.Forms.DataGridView dtgProduto;
    }
}