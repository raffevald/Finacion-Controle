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
using MySql.Data.MySqlClient;
using ZeSistema___v2.src.Login;

namespace ZeSistema___v2.src.Receitas
{
    public partial class ReceitasAtualizarDadosForm : Form
    {
         public static int contDataRecebimento = 0;
        public static int contDataVencimento = 0;
        public ReceitasAtualizarDadosForm()
        {
            InitializeComponent();
            PopularComboBox();
            DBListarDados dBListarDados = new DBListarDados();
            dgvFormulario.DataSource = dBListarDados.ListarTodosOsRecebimentos();
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarReceitas atualizarReceitas = new AtualizarReceitas();
            MessageBox.Show(atualizarReceitas.AtualizarReceitasDB(tbCodigo.Text, cbCategoria.Text, tbDescricao.Text, tbValorRecebido.Text, cbStatusRecebimento.Text, cbFormaDeRecebimento.Text, Convert.ToString(dtpDataDeCadastro.Value),
                Convert.ToString(dtpDataDeVencimento.Value), tbQuantidadeDeParcelasTotal.Text, tbQuantidadeDeParcelasPagas.Text));

            DBListarDados dBListarDados = new DBListarDados();
            dgvFormulario.DataSource = dBListarDados.ListarTodosOsRecebimentos();
        }

        public void PopularComboBox()
        {
            string strSQL;
            string categoria;
            int categoriaCodigo;

            MySqlDataReader dr;

            DBListarCategorias listarCategorias = new DBListarCategorias();

            strSQL = $"SELECT Categorias.descricao_cat as 'categoria', Categorias.id_cat as 'codigo' FROM Categorias WHERE Categorias.tipo_de_categoria_cat = 'Recebimentos' AND Categorias.id_usuario_fk = {LoginForm.dbUserId};";
            listarCategorias.ListagemDB(strSQL);

            dr = listarCategorias.ListagemDB(strSQL).ExecuteReader();

            while (dr.Read())
            {
                categoria = Convert.ToString(dr["categoria"]);
                categoriaCodigo = Convert.ToInt16(dr["codigo"]);

                cbCategoria.Items.Add($"{categoriaCodigo} - {categoria}");
            }

        }

        private void dtpDataDeCadastro_ValueChanged(object sender, EventArgs e)
        {
            contDataRecebimento = contDataRecebimento + 1;
        }

        private void dtpDataDeVencimento_ValueChanged(object sender, EventArgs e)
        {
            contDataVencimento = contDataVencimento + 1;
        }
    }
}
