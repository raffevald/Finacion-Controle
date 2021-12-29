namespace ZeSistema___v2.src.Categorias
{
    partial class CategoriasForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btAtualizarCategorias = new System.Windows.Forms.Button();
            this.btExcluirCategorias = new System.Windows.Forms.Button();
            this.btListarCategorias = new System.Windows.Forms.Button();
            this.cbTipoDeCategoria = new System.Windows.Forms.ComboBox();
            this.lbTipoDeCategoria = new System.Windows.Forms.Label();
            this.dtpDataDeCadastro = new System.Windows.Forms.DateTimePicker();
            this.lbDataDeCadastro = new System.Windows.Forms.Label();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvFormulario = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormulario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbDescricao);
            this.panel1.Controls.Add(this.btCadastrar);
            this.panel1.Controls.Add(this.btAtualizarCategorias);
            this.panel1.Controls.Add(this.btExcluirCategorias);
            this.panel1.Controls.Add(this.btListarCategorias);
            this.panel1.Controls.Add(this.cbTipoDeCategoria);
            this.panel1.Controls.Add(this.lbTipoDeCategoria);
            this.panel1.Controls.Add(this.dtpDataDeCadastro);
            this.panel1.Controls.Add(this.lbDataDeCadastro);
            this.panel1.Controls.Add(this.tbDescricao);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 195);
            this.panel1.TabIndex = 0;
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescricao.Location = new System.Drawing.Point(29, 27);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(80, 20);
            this.lbDescricao.TabIndex = 0;
            this.lbDescricao.Text = "Descrição";
            // 
            // btCadastrar
            // 
            this.btCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.Location = new System.Drawing.Point(1005, 91);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btCadastrar.Size = new System.Drawing.Size(150, 32);
            this.btCadastrar.TabIndex = 9;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btAtualizarCategorias
            // 
            this.btAtualizarCategorias.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btAtualizarCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtualizarCategorias.Location = new System.Drawing.Point(522, 157);
            this.btAtualizarCategorias.Name = "btAtualizarCategorias";
            this.btAtualizarCategorias.Size = new System.Drawing.Size(150, 32);
            this.btAtualizarCategorias.TabIndex = 8;
            this.btAtualizarCategorias.Text = "Atualizar categoria";
            this.btAtualizarCategorias.UseVisualStyleBackColor = true;
            this.btAtualizarCategorias.Click += new System.EventHandler(this.btAtualizarCategorias_Click);
            // 
            // btExcluirCategorias
            // 
            this.btExcluirCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btExcluirCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluirCategorias.Location = new System.Drawing.Point(1005, 157);
            this.btExcluirCategorias.Name = "btExcluirCategorias";
            this.btExcluirCategorias.Size = new System.Drawing.Size(150, 32);
            this.btExcluirCategorias.TabIndex = 7;
            this.btExcluirCategorias.Text = "Excluir categoria";
            this.btExcluirCategorias.UseVisualStyleBackColor = true;
            this.btExcluirCategorias.Click += new System.EventHandler(this.btExcluirCategorias_Click);
            // 
            // btListarCategorias
            // 
            this.btListarCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListarCategorias.Location = new System.Drawing.Point(33, 157);
            this.btListarCategorias.Name = "btListarCategorias";
            this.btListarCategorias.Size = new System.Drawing.Size(150, 32);
            this.btListarCategorias.TabIndex = 6;
            this.btListarCategorias.Text = "Listar categorias";
            this.btListarCategorias.UseVisualStyleBackColor = true;
            this.btListarCategorias.Click += new System.EventHandler(this.btListarCategorias_Click);
            // 
            // cbTipoDeCategoria
            // 
            this.cbTipoDeCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTipoDeCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoDeCategoria.FormattingEnabled = true;
            this.cbTipoDeCategoria.Items.AddRange(new object[] {
            "Recebimentos",
            "Despesas"});
            this.cbTipoDeCategoria.Location = new System.Drawing.Point(192, 57);
            this.cbTipoDeCategoria.Name = "cbTipoDeCategoria";
            this.cbTipoDeCategoria.Size = new System.Drawing.Size(963, 28);
            this.cbTipoDeCategoria.TabIndex = 5;
            this.cbTipoDeCategoria.Text = "Selecione uma categoria";
            // 
            // lbTipoDeCategoria
            // 
            this.lbTipoDeCategoria.AutoSize = true;
            this.lbTipoDeCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipoDeCategoria.Location = new System.Drawing.Point(29, 65);
            this.lbTipoDeCategoria.Name = "lbTipoDeCategoria";
            this.lbTipoDeCategoria.Size = new System.Drawing.Size(131, 20);
            this.lbTipoDeCategoria.TabIndex = 4;
            this.lbTipoDeCategoria.Text = "Tipo de categoria";
            // 
            // dtpDataDeCadastro
            // 
            this.dtpDataDeCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDataDeCadastro.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataDeCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataDeCadastro.Location = new System.Drawing.Point(823, 22);
            this.dtpDataDeCadastro.Name = "dtpDataDeCadastro";
            this.dtpDataDeCadastro.Size = new System.Drawing.Size(332, 26);
            this.dtpDataDeCadastro.TabIndex = 3;
            // 
            // lbDataDeCadastro
            // 
            this.lbDataDeCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDataDeCadastro.AutoSize = true;
            this.lbDataDeCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataDeCadastro.Location = new System.Drawing.Point(685, 27);
            this.lbDataDeCadastro.Name = "lbDataDeCadastro";
            this.lbDataDeCadastro.Size = new System.Drawing.Size(132, 20);
            this.lbDataDeCadastro.TabIndex = 2;
            this.lbDataDeCadastro.Text = "Data de cadastro";
            // 
            // tbDescricao
            // 
            this.tbDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescricao.Location = new System.Drawing.Point(124, 22);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(299, 26);
            this.tbDescricao.TabIndex = 1;
            this.tbDescricao.TextChanged += new System.EventHandler(this.tbDescricao_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 195);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(33, 550);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1155, 195);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(29, 550);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(33, 697);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1122, 48);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvFormulario);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(33, 195);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1122, 502);
            this.panel5.TabIndex = 4;
            // 
            // dgvFormulario
            // 
            this.dgvFormulario.AllowUserToAddRows = false;
            this.dgvFormulario.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvFormulario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFormulario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFormulario.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvFormulario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFormulario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFormulario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFormulario.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFormulario.Enabled = false;
            this.dgvFormulario.GridColor = System.Drawing.SystemColors.Window;
            this.dgvFormulario.Location = new System.Drawing.Point(0, 0);
            this.dgvFormulario.Name = "dgvFormulario";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFormulario.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFormulario.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvFormulario.Size = new System.Drawing.Size(1122, 502);
            this.dgvFormulario.TabIndex = 0;
            this.dgvFormulario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFormulario_CellContentClick);
            // 
            // CategoriasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 745);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CategoriasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CategoriasForm";
            this.Load += new System.EventHandler(this.CategoriasForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormulario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvFormulario;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btAtualizarCategorias;
        private System.Windows.Forms.Button btExcluirCategorias;
        private System.Windows.Forms.Button btListarCategorias;
        private System.Windows.Forms.ComboBox cbTipoDeCategoria;
        private System.Windows.Forms.Label lbTipoDeCategoria;
        private System.Windows.Forms.DateTimePicker dtpDataDeCadastro;
        private System.Windows.Forms.Label lbDataDeCadastro;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.Label lbDescricao;
    }
}