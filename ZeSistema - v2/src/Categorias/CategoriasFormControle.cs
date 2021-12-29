using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeSistema___v2.src.Categorias
{
    internal class CategoriasFormControle
    {
        public CategoriasFormControle()
        {

        }

        public void MostrarCategoriaForm()
        {
            CategoriasForm categoriasForm = new CategoriasForm();
            categoriasForm.ShowDialog();
        }
    }
}
