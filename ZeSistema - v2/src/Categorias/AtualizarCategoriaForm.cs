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
    public partial class AtualizarCategoriaForm : Form
    {
        public AtualizarCategoriaForm()
        {
            InitializeComponent();
            DBListarDados dBListarDados = new DBListarDados();
            dgvFormulario.DataSource = dBListarDados.ListarCategoriasList();
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            DBAtualizarDados dBAtualizarDados = new DBAtualizarDados();
            dBAtualizarDados.AtualizarDadosCategoria(tbCodigo.Text, tbDescricao.Text, cbTipoDeCategoria.Text, dtpDataDeAtualizacao.Value);

            DBListarDados dBListarDados = new DBListarDados();
            dgvFormulario.DataSource = dBListarDados.ListarCategoriasList();
        }
    }
}
