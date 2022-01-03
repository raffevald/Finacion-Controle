using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeSistema___v2.src.Receitas
{
    internal class ReceitaCadastroDadosFormControle
    {
        public ReceitaCadastroDadosFormControle()
        {

        }

        public void MostrarReceitaCadastroDadosFormControle()
        {
            ReceitaCadastroDadosForm receitaCadastroDadosForm = new ReceitaCadastroDadosForm();
            receitaCadastroDadosForm.ShowDialog();
        }
    }
}
