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
    public partial class DeletarCategoriaForm : Form
    {

        DBListarDados dBListarDados = new DBListarDados();
        public DeletarCategoriaForm()
        {
            InitializeComponent();
            
            dgvFormulario.DataSource = dBListarDados.ListarCategoriasList();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            DBDeletarDados dBDeletarDados = new DBDeletarDados();
            dBDeletarDados.DeletarCategoria(tbCodigo.Text);

            dgvFormulario.DataSource = dBListarDados.ListarCategoriasList();

        }
    }
}
