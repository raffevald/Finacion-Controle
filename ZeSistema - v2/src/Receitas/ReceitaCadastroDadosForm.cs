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
            string strSQL;

            string categoria;
            string descricao;
            double valorRecebido;
            string statusRecebimento;
            string formaDeRecebimento;
            string dataDeCadastro;
            string dataDeVencimento;
            Int64 qtdDeParcelasTotal;
            Int64 qtdDeParcelasPagas;

            string dataFormatForDB = "-";
            string categoriaData;
            string tempDataVencimento;
            Int64 id_categoria_fk;

            categoria = cbCategoria.Text;
            descricao = tbDescricao.Text;
            valorRecebido = Convert.ToDouble(tbValorRecebido.Text);
            statusRecebimento = cbStatusRecebimento.Text;
            formaDeRecebimento = cbFormaDeRecebimento.Text;

            categoriaData = Convert.ToString(dtpDataDeCadastro.Value);
            dataDeCadastro = $"{categoriaData[6]}{categoriaData[7]}{categoriaData[8]}{categoriaData[9]}{dataFormatForDB}{categoriaData[3]}{categoriaData[4]}{dataFormatForDB}{categoriaData[0]}{categoriaData[1]}";

            tempDataVencimento = Convert.ToString(dtpDataDeVencimento.Value);
            dataDeVencimento = $"{tempDataVencimento[6]}{tempDataVencimento[7]}{tempDataVencimento[8]}{tempDataVencimento[9]}{dataFormatForDB}{tempDataVencimento[3]}{tempDataVencimento[4]}{dataFormatForDB}{tempDataVencimento[0]}{categoriaData[1]}";

            qtdDeParcelasTotal = Convert.ToInt32(tbQuantidadeDeParcelasTotal.Text);
            qtdDeParcelasPagas = Convert.ToInt32(tbQuantidadeDeParcelasPagas.Text);

            
            var sb = new StringBuilder(categoria.Length);
            foreach (var letra in categoria) if (Char.IsDigit(letra)) sb.Append(letra);
            id_categoria_fk = Convert.ToInt32(sb.ToString());

            strSQL = $"CALL CadastrarRecebimentos('{descricao}', {valorRecebido}, '{dataDeCadastro}', {qtdDeParcelasTotal}, {qtdDeParcelasPagas}, '{statusRecebimento}', '{dataDeVencimento}', '{formaDeRecebimento}', {LoginForm.dbUserId}, {id_categoria_fk});";

            DBCadastrarDados cadastrarCategoriasReceitas = new DBCadastrarDados();
            cadastrarCategoriasReceitas.ExQuerySQL(strSQL);

            tbDescricao.Text = "";
            strSQL = "";

            DBListarDados dBListarDados = new DBListarDados();
            dgvFormulario.DataSource = dBListarDados.ListarTodosOsRecebimentos();


        }
    }
}
