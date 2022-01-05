using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeSistema___v2.src.DataBase;
using MySql.Data.MySqlClient;
using ZeSistema___v2.src.ApplicationControle;
using ZeSistema___v2.src.Login;

namespace ZeSistema___v2.src.Receitas
{
    internal class CadastrarReceitas
    {

        public CadastrarReceitas()
        {

        }

        public string CadastrarReceitasNoDB(string categoria, string descricao, string valorRecebidoText, string statusRecebimento, string formaDeRecebimento, string dataDeCadastro, string dataDeVencimento, Int64 qtdDeParcelasTotal, Int64 qtdDeParcelasPagas)
        {
            string strSQL;

            string dataFormatForDB = "-";
            string categoriaData;
            string tempDataVencimento;
            Int64 id_categoria_fk;
            double valorRecebido;

            categoriaData = dataDeCadastro;
            tempDataVencimento = dataDeVencimento;

            if (descricao != "")
            {
                if (categoria != "Selecione uma categoria")
                {
                    if(valorRecebidoText != "")
                    {
                        try
                        {
                            valorRecebido = Convert.ToDouble(valorRecebidoText);

                        }
                        catch (Exception error)
                        {
                            return "Favor informe um valor valido.";
                        }

                        if (statusRecebimento != "Selecione o status")
                        {
                            if (formaDeRecebimento != "Selecione o tipo de recebimento")
                            {
                                dataDeCadastro = $"{categoriaData[6]}{categoriaData[7]}{categoriaData[8]}{categoriaData[9]}{dataFormatForDB}{categoriaData[3]}{categoriaData[4]}{dataFormatForDB}{categoriaData[0]}{categoriaData[1]}";
                                dataDeVencimento = $"{tempDataVencimento[6]}{tempDataVencimento[7]}{tempDataVencimento[8]}{tempDataVencimento[9]}{dataFormatForDB}{tempDataVencimento[3]}{tempDataVencimento[4]}{dataFormatForDB}{tempDataVencimento[0]}{categoriaData[1]}";

                                var sb = new StringBuilder(categoria.Length);
                                foreach (var letra in categoria) if (Char.IsDigit(letra)) sb.Append(letra);
                                id_categoria_fk = Convert.ToInt32(sb.ToString());

                                strSQL = $"CALL CadastrarRecebimentos('{descricao}', {valorRecebido}, '{dataDeCadastro}', {qtdDeParcelasTotal}, {qtdDeParcelasPagas}, '{statusRecebimento}', '{dataDeVencimento}', '{formaDeRecebimento}', {LoginForm.dbUserId}, {id_categoria_fk})";

                                DBCadastrarDados dBCadastrarDados = new DBCadastrarDados();
                                dBCadastrarDados.ExQuerySQL(strSQL);

                                return "Recebimento cadastrado com sucesso.";
                            } else
                            {
                                return "Não é possível cadastrar um recebimento vazio, informa a forma de recebimento.";
                            }

                        } else
                        {
                            return "Não é possível cadastrar um recebimento vazio, informa o status do recebimento.";
                        }

                    } else
                    {
                        return "Não é possível cadastrar um recebimento vazio, informa o valor do recebimento.";
                    }

                } else
                {
                    return "Não é possível cadastrar um recebimento vazio, informa a categoria.";
                }

            } else
            {
                return "Não é possível cadastrar um recebimento vazio, informa a descrição.";
            }

        }
    }
}
