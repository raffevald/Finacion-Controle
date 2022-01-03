using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZeSistema___v2.src.Categorias;

namespace ZeSistema___v2.src.Receitas
{
    public partial class ReceitasForm : Form
    {
        public ReceitasForm()
        {
            InitializeComponent();
        }

        private void btCategorias_Click(object sender, EventArgs e)
        {
            CategoriasFormControle categoriasFormControle = new CategoriasFormControle();
            categoriasFormControle.MostrarCategoriaForm();
        }

        private void btReceitas_Click(object sender, EventArgs e)
        {
            ReceitaCadastroDadosFormControle receitaCadastroDadosFormControle = new ReceitaCadastroDadosFormControle();
            receitaCadastroDadosFormControle.MostrarReceitaCadastroDadosFormControle();
        }
    }
}
