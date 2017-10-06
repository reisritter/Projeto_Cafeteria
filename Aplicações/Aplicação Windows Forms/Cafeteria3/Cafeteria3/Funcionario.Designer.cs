namespace Cafeteria3
{
    partial class frmFuncionario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btmSair = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dtgFuncionario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.ForeColor = System.Drawing.Color.Gray;
            this.txtPesquisa.Location = new System.Drawing.Point(13, 39);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(152, 20);
            this.txtPesquisa.TabIndex = 7;
            // 
            // btmSair
            // 
            this.btmSair.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btmSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btmSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btmSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmSair.Location = new System.Drawing.Point(590, 431);
            this.btmSair.Name = "btmSair";
            this.btmSair.Size = new System.Drawing.Size(43, 43);
            this.btmSair.TabIndex = 13;
            this.btmSair.Text = "<|---";
            this.btmSair.UseVisualStyleBackColor = true;
            this.btmSair.Click += new System.EventHandler(this.btmSair_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(586, 27);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(47, 43);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Visible = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Location = new System.Drawing.Point(537, 27);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(43, 43);
            this.btnAdicionar.TabIndex = 9;
            this.btnAdicionar.Text = "+";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnPesquisar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnPesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Location = new System.Drawing.Point(183, 32);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(73, 38);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.Text = "Pesquisar Nome";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dtgFuncionario
            // 
            this.dtgFuncionario.AllowUserToAddRows = false;
            this.dtgFuncionario.AllowUserToDeleteRows = false;
            this.dtgFuncionario.AllowUserToResizeColumns = false;
            this.dtgFuncionario.AllowUserToResizeRows = false;
            this.dtgFuncionario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgFuncionario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgFuncionario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dtgFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgFuncionario.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgFuncionario.Location = new System.Drawing.Point(13, 110);
            this.dtgFuncionario.MultiSelect = false;
            this.dtgFuncionario.Name = "dtgFuncionario";
            this.dtgFuncionario.ReadOnly = true;
            this.dtgFuncionario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtgFuncionario.ShowCellErrors = false;
            this.dtgFuncionario.ShowCellToolTips = false;
            this.dtgFuncionario.ShowEditingIcon = false;
            this.dtgFuncionario.ShowRowErrors = false;
            this.dtgFuncionario.Size = new System.Drawing.Size(620, 304);
            this.dtgFuncionario.TabIndex = 12;
            this.dtgFuncionario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgFuncionario_CellClick);
            this.dtgFuncionario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgFuncionario_CellContentClick);
            this.dtgFuncionario.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgFuncionario_CellContentDoubleClick);
            this.dtgFuncionario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgFuncionario_CellClick);
            this.dtgFuncionario.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgFuncionario_CellEnter);
            this.dtgFuncionario.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgFuncionario_CellMouseClick);
            this.dtgFuncionario.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgFuncionario_CellMouseDoubleClick);
            // 
            // frmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 491);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.btmSair);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.dtgFuncionario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmFuncionario";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Funcionário";
            this.Load += new System.EventHandler(this.frmFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btmSair;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnPesquisar;
        public System.Windows.Forms.DataGridView dtgFuncionario;
    }
}