using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeSistema___v2.src.Receitas
{
    internal class ReceitasAtualizarDadosFormControler
    {
        public ReceitasAtualizarDadosFormControler()
        {

        }

        public void MostrarFormAtualizarReceitas()
        {
            ReceitasAtualizarDadosForm receitasAtualizarDadosForm = new ReceitasAtualizarDadosForm();
            receitasAtualizarDadosForm.ShowDialog();
        }
    }
}
