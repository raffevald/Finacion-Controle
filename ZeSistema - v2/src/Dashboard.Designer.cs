namespace ZeSistema___v2.src
{
    partial class Dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btFexa2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btGastos = new System.Windows.Forms.Button();
            this.btReceitas = new System.Windows.Forms.Button();
            this.btCriarUsuario = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.btCategorias = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btFexa2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1113, 30);
            this.panel1.TabIndex = 0;
            // 
            // btFexa2
            // 
            this.btFexa2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btFexa2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFexa2.ForeColor = System.Drawing.Color.Red;
            this.btFexa2.Location = new System.Drawing.Point(1077, 0);
            this.btFexa2.Name = "btFexa2";
            this.btFexa2.Size = new System.Drawing.Size(36, 28);
            this.btFexa2.TabIndex = 0;
            this.btFexa2.Text = "X";
            this.btFexa2.UseVisualStyleBackColor = true;
            this.btFexa2.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btCategorias);
            this.panel2.Controls.Add(this.btGastos);
            this.panel2.Controls.Add(this.btReceitas);
            this.panel2.Controls.Add(this.btCriarUsuario);
            this.panel2.Controls.Add(this.btSair);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(182, 626);
            this.panel2.TabIndex = 1;
            // 
            // btGastos
            // 
            this.btGastos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGastos.Location = new System.Drawing.Point(0, 202);
            this.btGastos.Name = "btGastos";
            this.btGastos.Size = new System.Drawing.Size(182, 36);
            this.btGastos.TabIndex = 9;
            this.btGastos.Text = "Gastos";
            this.btGastos.UseVisualStyleBackColor = true;
            // 
            // btReceitas
            // 
            this.btReceitas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btReceitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReceitas.Location = new System.Drawing.Point(0, 148);
            this.btReceitas.Name = "btReceitas";
            this.btReceitas.Size = new System.Drawing.Size(182, 36);
            this.btReceitas.TabIndex = 8;
            this.btReceitas.Text = "Receitas";
            this.btReceitas.UseVisualStyleBackColor = true;
            // 
            // btCriarUsuario
            // 
            this.btCriarUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btCriarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCriarUsuario.Location = new System.Drawing.Point(0, 360);
            this.btCriarUsuario.Name = "btCriarUsuario";
            this.btCriarUsuario.Size = new System.Drawing.Size(182, 36);
            this.btCriarUsuario.TabIndex = 7;
            this.btCriarUsuario.Text = "Cadastrar usuarios";
            this.btCriarUsuario.UseVisualStyleBackColor = true;
            // 
            // btSair
            // 
            this.btSair.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Location = new System.Drawing.Point(0, 590);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(182, 36);
            this.btSair.TabIndex = 6;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btCategorias
            // 
            this.btCategorias.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCategorias.Location = new System.Drawing.Point(0, 89);
            this.btCategorias.Name = "btCategorias";
            this.btCategorias.Size = new System.Drawing.Size(182, 36);
            this.btCategorias.TabIndex = 10;
            this.btCategorias.Text = "Categorias";
            this.btCategorias.UseVisualStyleBackColor = true;
            this.btCategorias.Click += new System.EventHandler(this.btCategorias_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 656);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btCriarUsuario;
        private System.Windows.Forms.Button btGastos;
        private System.Windows.Forms.Button btReceitas;
        private System.Windows.Forms.Button btFexa2;
        private System.Windows.Forms.Button btCategorias;
    }
}