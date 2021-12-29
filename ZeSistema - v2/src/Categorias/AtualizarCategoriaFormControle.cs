using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeSistema___v2.src.Categorias
{
    internal class AtualizarCategoriaFormControle
    {
        public AtualizarCategoriaFormControle()
        {

        }

        public void MostrarFormaAtualizarCategoria()
        {
            AtualizarCategoriaForm atualizarCategoriaForm = new AtualizarCategoriaForm();
            atualizarCategoriaForm.ShowDialog();
        }
    }
}
