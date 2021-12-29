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
using ZeSistema___v2.src.DataBase;

namespace ZeSistema___v2.src.Categorias
{
    public partial class CategoriasForm : Form
    {
        public CategoriasForm()
        {
            InitializeComponent();

            DBListarDados dBListarDados = new DBListarDados();
            dgvFormulario.DataSource = dBListarDados.ListarCategoriasList();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            if (tbDescricao.Text != "")
            {
                int id_user_fk;
                string categoriaDescricao;
                string categoriaData;
                string dataCategoria;
                string strSQL;
                string dataFormatForDB = "-";
                string tipoDeCategoria;

                LoginForm login = new LoginForm();
                id_user_fk = LoginForm.dbUserId;

                categoriaDescricao = tbDescricao.Text;
                categoriaData = Convert.ToString(dtpDataDeCadastro.Value);
                dataCategoria = $"{categoriaData[6]}{categoriaData[7]}{categoriaData[8]}{categoriaData[9]}{dataFormatForDB}{categoriaData[3]}{categoriaData[4]}{dataFormatForDB}{categoriaData[0]}{categoriaData[1]}";
                tipoDeCategoria = cbTipoDeCategoria.Text;

                strSQL = $"INSERT INTO Categorias(descricao_cat, data_de_insercao_cat, id_usuario_fk, tipo_de_categoria_cat) VALUES ('{categoriaDescricao}', '{dataCategoria}', {id_user_fk}, '{tipoDeCategoria}');";

                DBCadastrarDados cadastrarCategoriasReceitas = new DBCadastrarDados();
                cadastrarCategoriasReceitas.ExQuerySQL(strSQL);

                tbDescricao.Text = "";
                strSQL = "";

                DBListarDados dBListarDados = new DBListarDados();
                dgvFormulario.DataSource = dBListarDados.ListarCategoriasList();

            }
            else
            {
                MessageBox.Show("Não é possivel cadastrar categoria com descrição vasia.");
            }
        }

        public void dgvFormulario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void btListarCategorias_Click(object sender, EventArgs e)
        {
            ListarCategoriaFormControle listarCategoriaFormControle = new ListarCategoriaFormControle();
            listarCategoriaFormControle.MostrarFormListarCategorias();

            DBListarDados dBListarDados = new DBListarDados();
            dgvFormulario.DataSource = dBListarDados.ListarCategoriasList();
        }

        private void btAtualizarCategorias_Click(object sender, EventArgs e)
        {
            AtualizarCategoriaFormControle atualizarCategoriaFormControle = new AtualizarCategoriaFormControle();
            atualizarCategoriaFormControle.MostrarFormaAtualizarCategoria();
        }

        private void btExcluirCategorias_Click(object sender, EventArgs e)
        {
            DeletarCategoriaFormControle deletarCategoriaFormControle = new DeletarCategoriaFormControle();
            deletarCategoriaFormControle.MostrarFormDeletarCategoria();
        }

        private void CategoriasForm_Load(object sender, EventArgs e)
        {

        }
    }
}
