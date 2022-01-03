using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeSistema___v2.src.Receitas
{
    internal class ReceitasFormControle
    {
        public ReceitasFormControle()
        {

        }

        public void MostrarReceitasForme()
        {
            ReceitasForm receitasForm = new ReceitasForm();
            receitasForm.ShowDialog();
        }
    }
}
