using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeSistema___v2.src.Receitas
{
    internal class AtualizarReceitas
    {
        public AtualizarReceitas()
        {

        }

        public string AtualizarReceitasDB(string codigoText, string categoria, string descricao, string valorRecebidoText, string statusRecebimento, string formaDeRecebimento, string dataDeCadastro, string dataDeVencimento, string qtdDeParcelasTotalText, string qtdDeParcelasPagasText)
        {
            Int64 qtdDeParcelasTotal;
            Int64 qtdDeParcelasPagas;
            Int64 codigo;
            string srtSQL;

            if(codigoText != "")
            {
                try
                {
                    codigo = Convert.ToInt64(codigoText);

                    //dataDeCadastro & dataDeVencimento
                    if (categoria != "Selecione uma categoria" & (descricao == "" & valorRecebidoText == "" & statusRecebimento == "Selecione o status" & formaDeRecebimento == "Selecione o tipo de recebimento" & qtdDeParcelasTotalText == "1" & qtdDeParcelasPagasText == "1"))
                    {
                        srtSQL = categoria;
                    } else
                    {
                        srtSQL = "Nada";
                    }

                    return srtSQL;

                } catch (Exception)
                {
                    return "Favor informe um código valido.";
                }

            }
            else
            {
                return "Favor informe um código.";
            }

        }
    }
}
