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
using ZeSistema___v2.src.ApplicationControle;
using ZeSistema___v2.src.Login;

namespace ZeSistema___v2.src.Receitas
{
    public partial class ReceitaCadastroDadosForm : Form
    {
        DBListarDados dBListarDados = new DBListarDados();
        public ReceitaCadastroDadosForm()
        {
            InitializeComponent();
            PopularComboBox();
            dgvFormulario.DataSource = dBListarDados.ListarTodosOsRecebimentos();
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void cbStatusRecebimento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStatusRecebimento.Text == "Não recebido")
            {
                cbFormaDeRecebimento.Text = "Não recebido";
            }
        }

        private void btExcluirCategorias_Click(object sender, EventArgs e)
        {


        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarReceitas cadastrarReceitas = new CadastrarReceitas();
            MessageBox.Show(cadastrarReceitas.CadastrarReceitasNoDB(cbCategoria.Text, tbDescricao.Text, tbValorRecebido.Text, cbStatusRecebimento.Text, cbFormaDeRecebimento.Text, Convert.ToString(dtpDataDeCadastro.Value),
                Convert.ToString(dtpDataDeVencimento.Value), Convert.ToInt32(tbQuantidadeDeParcelasTotal.Text), Convert.ToInt32(tbQuantidadeDeParcelasPagas.Text)));

            DBListarDados dBListarDados = new DBListarDados();
            dgvFormulario.DataSource = dBListarDados.ListarTodosOsRecebimentos();
        }

        private void btAtualizarCategorias_Click(object sender, EventArgs e)
        {
            ReceitasAtualizarDadosFormControler receitasAtualizarDadosFormControler = new ReceitasAtualizarDadosFormControler();
            receitasAtualizarDadosFormControler.MostrarFormAtualizarReceitas();
        }
    }
}
