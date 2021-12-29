using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeSistema___v2.src.Categorias
{
    internal class DeletarCategoriaFormControle
    {
        public DeletarCategoriaFormControle()
        {

        }

        public void MostrarFormDeletarCategoria()
        {
            DeletarCategoriaForm deletarCategoriaForm = new DeletarCategoriaForm();
            deletarCategoriaForm.ShowDialog();
        }
    }
}
