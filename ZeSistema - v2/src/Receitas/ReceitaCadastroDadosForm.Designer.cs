namespace ZeSistema___v2.src.Receitas
{
    partial class ReceitaCadastroDadosForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbFormaDeRecebimento = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbQuantidadeDeParcelasPagas = new System.Windows.Forms.TextBox();
            this.tbQuantidadeDeParcelasTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDataDeVencimento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btAtualizarCategorias = new System.Windows.Forms.Button();
            this.btExcluirCategorias = new System.Windows.Forms.Button();
            this.btListarCategorias = new System.Windows.Forms.Button();
            this.cbStatusRecebimento = new System.Windows.Forms.ComboBox();
            this.lbTipoDeCategoria = new System.Windows.Forms.Label();
            this.dtpDataDeCadastro = new System.Windows.Forms.DateTimePicker();
            this.tbValorRecebido = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvFormulario = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormulario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbFormaDeRecebimento);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbCategoria);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbQuantidadeDeParcelasPagas);
            this.panel1.Controls.Add(this.tbQuantidadeDeParcelasTotal);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtpDataDeVencimento);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbDescricao);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbDescricao);
            this.panel1.Controls.Add(this.btCadastrar);
            this.panel1.Controls.Add(this.btAtualizarCategorias);
            this.panel1.Controls.Add(this.btExcluirCategorias);
            this.panel1.Controls.Add(this.btListarCategorias);
            this.panel1.Controls.Add(this.cbStatusRecebimento);
            this.panel1.Controls.Add(this.lbTipoDeCategoria);
            this.panel1.Controls.Add(this.dtpDataDeCadastro);
            this.panel1.Controls.Add(this.tbValorRecebido);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(33, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1134, 252);
            this.panel1.TabIndex = 5;
            // 
            // cbFormaDeRecebimento
            // 
            this.cbFormaDeRecebimento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFormaDeRecebimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFormaDeRecebimento.FormattingEnabled = true;
            this.cbFormaDeRecebimento.Items.AddRange(new object[] {
            "Dinheiro",
            "Cheque",
            "Crédito",
            "Débito",
            "Pix",
            "Não recebido"});
            this.cbFormaDeRecebimento.Location = new System.Drawing.Point(217, 152);
            this.cbFormaDeRecebimento.Name = "cbFormaDeRecebimento";
            this.cbFormaDeRecebimento.Size = new System.Drawing.Size(332, 28);
            this.cbFormaDeRecebimento.TabIndex = 23;
            this.cbFormaDeRecebimento.Text = "Selecione o tipo de recebimento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(133, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Categoria";
            // 
            // cbCategoria
            // 
            this.cbCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(217, 27);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(332, 28);
            this.cbCategoria.TabIndex = 21;
            this.cbCategoria.Text = "Selecione uma categoria";
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.cbCategoria_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Forma de recebimento";
            // 
            // tbQuantidadeDeParcelasPagas
            // 
            this.tbQuantidadeDeParcelasPagas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQuantidadeDeParcelasPagas.Location = new System.Drawing.Point(555, 120);
            this.tbQuantidadeDeParcelasPagas.Name = "tbQuantidadeDeParcelasPagas";
            this.tbQuantidadeDeParcelasPagas.Size = new System.Drawing.Size(332, 26);
            this.tbQuantidadeDeParcelasPagas.TabIndex = 18;
            this.tbQuantidadeDeParcelasPagas.Text = "1";
            // 
            // tbQuantidadeDeParcelasTotal
            // 
            this.tbQuantidadeDeParcelasTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQuantidadeDeParcelasTotal.Location = new System.Drawing.Point(555, 88);
            this.tbQuantidadeDeParcelasTotal.Name = "tbQuantidadeDeParcelasTotal";
            this.tbQuantidadeDeParcelasTotal.Size = new System.Drawing.Size(332, 26);
            this.tbQuantidadeDeParcelasTotal.TabIndex = 17;
            this.tbQuantidadeDeParcelasTotal.Text = "1";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(893, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Quantidade de parcelas pagas";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(893, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Quantidade de parcelas total";
            // 
            // dtpDataDeVencimento
            // 
            this.dtpDataDeVencimento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDataDeVencimento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataDeVencimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataDeVencimento.Location = new System.Drawing.Point(555, 58);
            this.dtpDataDeVencimento.Name = "dtpDataDeVencimento";
            this.dtpDataDeVencimento.Size = new System.Drawing.Size(332, 26);
            this.dtpDataDeVencimento.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(893, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Data de vencimento";
            // 
            // tbDescricao
            // 
            this.tbDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescricao.Location = new System.Drawing.Point(217, 58);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(332, 26);
            this.tbDescricao.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Valor recebido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(893, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Data do recebimento";
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescricao.Location = new System.Drawing.Point(131, 59);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(80, 20);
            this.lbDescricao.TabIndex = 0;
            this.lbDescricao.Text = "Descrição";
            // 
            // btCadastrar
            // 
            this.btCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.Location = new System.Drawing.Point(716, 148);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btCadastrar.Size = new System.Drawing.Size(171, 32);
            this.btCadastrar.TabIndex = 9;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btAtualizarCategorias
            // 
            this.btAtualizarCategorias.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btAtualizarCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtualizarCategorias.Location = new System.Drawing.Point(445, 214);
            this.btAtualizarCategorias.Name = "btAtualizarCategorias";
            this.btAtualizarCategorias.Size = new System.Drawing.Size(150, 32);
            this.btAtualizarCategorias.TabIndex = 8;
            this.btAtualizarCategorias.Text = "Atualizar categoria";
            this.btAtualizarCategorias.UseVisualStyleBackColor = true;
            // 
            // btExcluirCategorias
            // 
            this.btExcluirCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btExcluirCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluirCategorias.Location = new System.Drawing.Point(851, 214);
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
            this.btListarCategorias.Location = new System.Drawing.Point(6, 214);
            this.btListarCategorias.Name = "btListarCategorias";
            this.btListarCategorias.Size = new System.Drawing.Size(150, 32);
            this.btListarCategorias.TabIndex = 6;
            this.btListarCategorias.Text = "Listar categorias";
            this.btListarCategorias.UseVisualStyleBackColor = true;
            // 
            // cbStatusRecebimento
            // 
            this.cbStatusRecebimento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbStatusRecebimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatusRecebimento.FormattingEnabled = true;
            this.cbStatusRecebimento.Items.AddRange(new object[] {
            "Recebido",
            "Não recebido"});
            this.cbStatusRecebimento.Location = new System.Drawing.Point(217, 118);
            this.cbStatusRecebimento.Name = "cbStatusRecebimento";
            this.cbStatusRecebimento.Size = new System.Drawing.Size(332, 28);
            this.cbStatusRecebimento.TabIndex = 5;
            this.cbStatusRecebimento.Text = "Selecione o status";
            this.cbStatusRecebimento.SelectedIndexChanged += new System.EventHandler(this.cbStatusRecebimento_SelectedIndexChanged);
            // 
            // lbTipoDeCategoria
            // 
            this.lbTipoDeCategoria.AutoSize = true;
            this.lbTipoDeCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipoDeCategoria.Location = new System.Drawing.Point(55, 121);
            this.lbTipoDeCategoria.Name = "lbTipoDeCategoria";
            this.lbTipoDeCategoria.Size = new System.Drawing.Size(156, 20);
            this.lbTipoDeCategoria.TabIndex = 4;
            this.lbTipoDeCategoria.Text = "Status recebimentos";
            // 
            // dtpDataDeCadastro
            // 
            this.dtpDataDeCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDataDeCadastro.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataDeCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataDeCadastro.Location = new System.Drawing.Point(555, 26);
            this.dtpDataDeCadastro.Name = "dtpDataDeCadastro";
            this.dtpDataDeCadastro.Size = new System.Drawing.Size(332, 26);
            this.dtpDataDeCadastro.TabIndex = 3;
            // 
            // tbValorRecebido
            // 
            this.tbValorRecebido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValorRecebido.Location = new System.Drawing.Point(217, 88);
            this.tbValorRecebido.Name = "tbValorRecebido";
            this.tbValorRecebido.Size = new System.Drawing.Size(332, 26);
            this.tbValorRecebido.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvFormulario);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(33, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1134, 650);
            this.panel5.TabIndex = 9;
            // 
            // dgvFormulario
            // 
            this.dgvFormulario.AllowUserToAddRows = false;
            this.dgvFormulario.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvFormulario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvFormulario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFormulario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFormulario.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvFormulario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFormulario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvFormulario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFormulario.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvFormulario.Enabled = false;
            this.dgvFormulario.GridColor = System.Drawing.SystemColors.Window;
            this.dgvFormulario.Location = new System.Drawing.Point(0, 252);
            this.dgvFormulario.Name = "dgvFormulario";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFormulario.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFormulario.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvFormulario.Size = new System.Drawing.Size(1131, 398);
            this.dgvFormulario.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(33, 650);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1134, 26);
            this.panel4.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1167, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(29, 676);
            this.panel3.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(33, 676);
            this.panel2.TabIndex = 6;
            // 
            // ReceitaCadastroDadosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 676);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "ReceitaCadastroDadosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ReceitaCadastroDadosForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormulario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btAtualizarCategorias;
        private System.Windows.Forms.Button btExcluirCategorias;
        private System.Windows.Forms.Button btListarCategorias;
        private System.Windows.Forms.ComboBox cbStatusRecebimento;
        private System.Windows.Forms.Label lbTipoDeCategoria;
        private System.Windows.Forms.DateTimePicker dtpDataDeCadastro;
        private System.Windows.Forms.TextBox tbValorRecebido;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvFormulario;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbQuantidadeDeParcelasPagas;
        private System.Windows.Forms.TextBox tbQuantidadeDeParcelasTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDataDeVencimento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFormaDeRecebimento;
    }
}