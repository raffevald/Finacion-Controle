using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using ZeSistema___v2.src.DataBase;
//using MySql.Data.MySqlClient;
using ZeSistema___v2.src.Login;

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
            string srtSQL = "";
            string srtSQLData;
            string dataRecebimento;
            string dataVencimento;

            if (codigoText != "")
            {
                try
                {

                    
                    codigo = Convert.ToInt64(codigoText);

                    //    MySqlDataReader dr;
                    //    DBListarCategorias listarCategorias = new DBListarCategorias();

                    //   srtSQLData = $"SELECT Recebimentos.data_de_recebimento_receb AS 'DataDoRecebimento', Recebimentos.data_vencimento_receb AS 'DataDeVencimento' FROM Recebimentos WHERE Recebimentos.id_receb = {codigo} AND Recebimentos.id_usuario_fk = {LoginForm.dbUserId};";
                    //    listarCategorias.ListagemDB(srtSQLData);
                    //    dr = listarCategorias.ListagemDB(srtSQLData).ExecuteReader();

                    //    while (dr.Read())
                    //    {
                    //        dataRecebimento = Convert.ToString(dr["DataDoRecebimento"]);
                    //        dataVencimento = Convert.ToString(dr["DataDeVencimento"]);
                    //    }

                    Int64 id_categoria_fk;
                    var sb = new StringBuilder(categoria.Length);
                    foreach (var letra in categoria) if (Char.IsDigit(letra)) sb.Append(letra);
                    id_categoria_fk = Convert.ToInt32(sb.ToString());


                    if (categoria != "Selecione uma categoria" & descricao == "" & valorRecebidoText == "" & statusRecebimento == "Selecione o status" & formaDeRecebimento == "Selecione o tipo de recebimento" & qtdDeParcelasTotalText == "1" & qtdDeParcelasPagasText == "1" & ReceitasAtualizarDadosForm.contDataRecebimento == 0 & ReceitasAtualizarDadosForm.contDataVencimento == 0 )
                    {
                        srtSQL = $"UPDATE Recebimentos SET Recebimentos.id_categoria_fk = {id_categoria_fk} WHERE Recebimentos.id_receb = {codigo} AND Recebimentos.id_usuario_fk = {LoginForm.dbUserId};";
                    } 

                    if (descricao != "" & categoria != "Selecione uma categoria" & valorRecebidoText == "" & statusRecebimento == "Selecione o status" & formaDeRecebimento == "Selecione o tipo de recebimento" & qtdDeParcelasTotalText == "1" & qtdDeParcelasPagasText == "1" & ReceitasAtualizarDadosForm.contDataRecebimento == 0 & ReceitasAtualizarDadosForm.contDataVencimento == 0)
                    {
                        srtSQL = $"UPDATE Recebimentos SET Recebimentos.descricao_receb = '{descricao}', Recebimentos.id_categoria_fk = {id_categoria_fk} WHERE Recebimentos.id_receb = {codigo} AND Recebimentos.id_usuario_fk = {LoginForm.dbUserId};";
                    }

                    if (descricao != "" & categoria != "Selecione uma categoria" & valorRecebidoText != "" & statusRecebimento == "Selecione o status" & formaDeRecebimento == "Selecione o tipo de recebimento" & qtdDeParcelasTotalText == "1" & qtdDeParcelasPagasText == "1" & ReceitasAtualizarDadosForm.contDataRecebimento == 0 & ReceitasAtualizarDadosForm.contDataVencimento == 0)
                    {
                        double valorTemp;

                        try
                        {
                            valorTemp = Convert.ToDouble(valorRecebidoText);

                            srtSQL = $"UPDATE Recebimentos SET Recebimentos.valor_receb = {valorTemp}, Recebimentos.descricao_receb = '{descricao}', Recebimentos.id_categoria_fk = {id_categoria_fk} WHERE Recebimentos.id_receb = {codigo} AND Recebimentos.id_usuario_fk = {LoginForm.dbUserId};";
                        } catch (Exception)
                        {
                            return "Favor informe um valor valido.";
                        }
                    }

                    if (descricao != "" & categoria != "Selecione uma categoria" & valorRecebidoText != "" &  statusRecebimento != "Selecione o status" & formaDeRecebimento == "Selecione o tipo de recebimento" & qtdDeParcelasTotalText == "1" & qtdDeParcelasPagasText == "1" & ReceitasAtualizarDadosForm.contDataRecebimento == 0 & ReceitasAtualizarDadosForm.contDataVencimento == 0)
                    {
                        try
                        {
                            double valorTemp;
                            valorTemp = Convert.ToDouble(valorRecebidoText);

                            srtSQL = $"UPDATE Recebimentos SET Recebimentos.status_recebimentos_receb = '{statusRecebimento}', Recebimentos.valor_receb = {valorTemp}, Recebimentos.descricao_receb = '{descricao}', Recebimentos.id_categoria_fk = {id_categoria_fk} WHERE Recebimentos.id_receb = {codigo} AND Recebimentos.id_usuario_fk = {LoginForm.dbUserId};";
                        }
                        catch (Exception)
                        {
                            return "Favor informe um valor valido.";
                        }
                    }

                    if (descricao != "" & categoria != "Selecione uma categoria" & valorRecebidoText != "" & statusRecebimento != "Selecione o status" & formaDeRecebimento != "Selecione o tipo de recebimento" & qtdDeParcelasTotalText == "1" & qtdDeParcelasPagasText == "1" & ReceitasAtualizarDadosForm.contDataRecebimento == 0 & ReceitasAtualizarDadosForm.contDataVencimento == 0)
                    {
                        try
                        {
                            double valorTemp;
                            valorTemp = Convert.ToDouble(valorRecebidoText);

                            srtSQL = $"UPDATE Recebimentos SET Recebimentos.forma_de_recebimento_receb = '{formaDeRecebimento}', Recebimentos.status_recebimentos_receb = '{statusRecebimento}', Recebimentos.valor_receb = {valorTemp}, Recebimentos.descricao_receb = '{descricao}', Recebimentos.id_categoria_fk = {id_categoria_fk} WHERE Recebimentos.id_receb = {codigo} AND Recebimentos.id_usuario_fk = {LoginForm.dbUserId};";
                        }
                        catch (Exception)
                        {
                            return "Favor informe um valor valido.";
                        }
                    }

                    if (descricao != "" & categoria != "Selecione uma categoria" & valorRecebidoText != "" & statusRecebimento != "Selecione o status" & formaDeRecebimento != "Selecione o tipo de recebimento" & qtdDeParcelasTotalText != "" & qtdDeParcelasPagasText == "1" & ReceitasAtualizarDadosForm.contDataRecebimento == 0 & ReceitasAtualizarDadosForm.contDataVencimento == 0)
                    {
                        double valorTemp;
                        Int64 qtdTotalParcTemp = 0;

                        try
                        {
                            valorTemp = Convert.ToDouble(valorRecebidoText);

                            try
                            {
                                qtdTotalParcTemp = Convert.ToInt64(qtdDeParcelasTotalText);
                            }
                            catch (Exception)
                            {
                                return "Favor informe quantidade de parcelas validas.";
                            }
                        }
                        catch (Exception)
                        {
                            return "Favor informe um valor valido.";
                        }


                        if (qtdTotalParcTemp > 1)
                        {
                              srtSQL = $"UPDATE Recebimentos SET Recebimentos.quantidade_de_parcelas_total_receb = {qtdTotalParcTemp}, Recebimentos.forma_de_recebimento_receb = '{formaDeRecebimento}', Recebimentos.status_recebimentos_receb = '{statusRecebimento}', Recebimentos.valor_receb = {valorTemp}, Recebimentos.descricao_receb = '{descricao}', Recebimentos.id_categoria_fk = {id_categoria_fk} WHERE Recebimentos.id_receb = {codigo} AND Recebimentos.id_usuario_fk = {LoginForm.dbUserId};";
                        }
                        else
                        {
                            return "Numero minimo de parcelas totais é 1.";
                        }

                    }

                    if (descricao != "" & categoria != "Selecione uma categoria" & valorRecebidoText != "" & statusRecebimento != "Selecione o status" & formaDeRecebimento != "Selecione o tipo de recebimento" & qtdDeParcelasTotalText != "" & qtdDeParcelasPagasText != "" & ReceitasAtualizarDadosForm.contDataRecebimento == 0 & ReceitasAtualizarDadosForm.contDataVencimento == 0)
                    {
                        double valorTemp;
                        Int64 qtdTotalParcTemp = 0;
                        Int64 qtdTotalParcPagasTemp = 0;

                        try
                        {
                            valorTemp = Convert.ToDouble(valorRecebidoText);

                            try
                            {
                                qtdTotalParcTemp = Convert.ToInt64(qtdDeParcelasTotalText);
                            }
                            catch (Exception)
                            {
                                return "Favor informe quantidade de parcelas validas.";
                            }
                        }
                        catch (Exception)
                        {
                            return "Favor informe um valor valido.";
                        }

                        try
                        {
                            qtdTotalParcPagasTemp = Convert.ToInt64(qtdDeParcelasPagasText);
                        }
                        catch (Exception)
                        {
                            return "Favor informe quantidade de parcelas validas.";
                        }

                        if (qtdTotalParcTemp > 1)
                        {
                            if(qtdTotalParcPagasTemp >= 0)
                            {
                                srtSQL = $"UPDATE Recebimentos SET  Recebimentos.quantidade_de_parcelas_pagas_receb = {qtdTotalParcPagasTemp}, Recebimentos.quantidade_de_parcelas_total_receb = {qtdTotalParcTemp}, Recebimentos.forma_de_recebimento_receb = '{formaDeRecebimento}', Recebimentos.status_recebimentos_receb = '{statusRecebimento}', Recebimentos.valor_receb = {valorTemp}, Recebimentos.descricao_receb = '{descricao}', Recebimentos.id_categoria_fk = {id_categoria_fk} WHERE Recebimentos.id_receb = {codigo} AND Recebimentos.id_usuario_fk = {LoginForm.dbUserId};";
                            }
                            else
                            {
                                return "Valor informado invalido.";
                            }
                        }
                        else
                        {
                            return "Numero minimo de parcelas totais é 1.";
                        }
                    }









                    if (descricao != "" & (categoria == "Selecione uma categoria" || categoria != "") & valorRecebidoText == "" & statusRecebimento == "Selecione o status" & formaDeRecebimento == "Selecione o tipo de recebimento" & qtdDeParcelasTotalText == "1" & qtdDeParcelasPagasText == "1" & ReceitasAtualizarDadosForm.contDataRecebimento == 0 & ReceitasAtualizarDadosForm.contDataVencimento == 0)
                    {
                        srtSQL = $"UPDATE Recebimentos SET Recebimentos.descricao_receb = '{descricao}' WHERE Recebimentos.id_receb = {codigo} AND Recebimentos.id_usuario_fk = {LoginForm.dbUserId};";

                    }



                    DBCadastrarDados dBCadastrarDados = new DBCadastrarDados();
                    dBCadastrarDados.ExQuerySQL(srtSQL);





                    return "Recebimento atualizado com sucesso.";

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
