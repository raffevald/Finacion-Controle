using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZeSistema___v2.src.DataBase;

namespace ZeSistema___v2.src.Categorias
{
    public partial class ListarCategoriasForm : Form
    {
        public ListarCategoriasForm()
        {
            InitializeComponent();
            DBListarDados dBListarDados = new DBListarDados();
            dgvFormulario.DataSource = dBListarDados.ListarCategoriasList();
        }

        private void btListar_Click(object sender, EventArgs e)
        {
            DBListarDados dBListarDados = new DBListarDados();
            dgvFormulario.DataSource = dBListarDados.ListarCategoriasPorTipo(cbTipoDeListagem.Text);
        }
    }
}
