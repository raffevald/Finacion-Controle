using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZeSistema___v2.src.Login;
using ZeSistema___v2.src.Categorias;
using ZeSistema___v2.src.Receitas;

namespace ZeSistema___v2.src
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginFormControle loginFormControle = new LoginFormControle();
            this.Hide();
            loginFormControle.MostrarLoginForm();
        }

        private void btCategorias_Click(object sender, EventArgs e)
        {
            CategoriasFormControle categoriasFormControle = new CategoriasFormControle();
            categoriasFormControle.MostrarCategoriaForm();
        }

        private void btReceitas_Click(object sender, EventArgs e)
        {
            ReceitasFormControle receitasFormControle = new ReceitasFormControle();
            receitasFormControle.MostrarReceitasForme();
        }
    }
}
