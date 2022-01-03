namespace ZeSistema___v2.src.Receitas
{
    partial class ReceitasForm
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
            this.btReceitas = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btCategorias = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btReceitas
            // 
            this.btReceitas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btReceitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReceitas.Location = new System.Drawing.Point(0, 99);
            this.btReceitas.Name = "btReceitas";
            this.btReceitas.Size = new System.Drawing.Size(182, 36);
            this.btReceitas.TabIndex = 8;
            this.btReceitas.Text = "Receitas";
            this.btReceitas.UseVisualStyleBackColor = true;
            this.btReceitas.Click += new System.EventHandler(this.btReceitas_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btCategorias);
            this.panel2.Controls.Add(this.btReceitas);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(182, 666);
            this.panel2.TabIndex = 3;
            // 
            // btCategorias
            // 
            this.btCategorias.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCategorias.Location = new System.Drawing.Point(0, 57);
            this.btCategorias.Name = "btCategorias";
            this.btCategorias.Size = new System.Drawing.Size(182, 36);
            this.btCategorias.TabIndex = 10;
            this.btCategorias.Text = "Categorias";
            this.btCategorias.UseVisualStyleBackColor = true;
            this.btCategorias.Click += new System.EventHandler(this.btCategorias_Click);
            // 
            // ReceitasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 666);
            this.Controls.Add(this.panel2);
            this.Name = "ReceitasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ReceitasForm";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btReceitas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btCategorias;
    }
}