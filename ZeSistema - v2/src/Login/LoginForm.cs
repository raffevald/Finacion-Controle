using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZeSistema___v2.src.ApplicationControle;
using MySql.Data.MySqlClient;

namespace ZeSistema___v2.src.Login
{
    public partial class LoginForm : Form
    {

        public static string DBhost { get; set; }
        public static string DBport { get; set; }
        public static string DBuser { get; set; }
        public static string DBpassword { get; set; }
        public static string DBName { get; set; }


        public static int dbUserId { get; set; }
        public static string dbUserName { get; set; }

        public LoginForm()
        {
            InitializeComponent();
            ObterDataBaseADress();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {

            String Usuario;
            String Senha;
            string strSQL;

            String dbUser = "";
            String dbSenha = "";

            MySqlDataReader dr;

            Usuario = tbUsuario.Text;
            Senha = tbSenha.Text;

            if (Usuario != "" && Senha != "")
            {

                strSQL = $"SELECT usuarios.nome_de_usuario_usua as 'username', usuarios.senha_usua as 'autentificacao',  usuarios.id_usua as 'codigo', usuarios.nome_usua as 'nome'  FROM usuarios WHERE usuarios.nome_de_usuario_usua = '{Usuario}'";

                DBValidarUsuario validarUser = new DBValidarUsuario();

                validarUser.ListagemDB(strSQL);

                dr = validarUser.ListagemDB(strSQL).ExecuteReader();

                while (dr.Read())
                {
                    dbSenha = Convert.ToString(dr["autentificacao"]);
                    dbUser = Convert.ToString(dr["username"]);
                    dbUserId = Convert.ToInt16(dr["codigo"]);
                    dbUserName = Convert.ToString(dr["nome"]);
                }

                if ((dbUser == Usuario) && (dbSenha == Senha))
                {
                    DashboardControle dashboardControle = new DashboardControle();
                    this.Hide();
                    dashboardControle.MostrarDashboard();
                }
                else
                {
                    MessageBox.Show("Usuario ou senha incorreto.");
                }
            }
            else
            {
                MessageBox.Show("Usuario ou senha não pode ser em branco.");
            }

        }

        public void ObterDataBaseADress()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\ZeSistema\src\DataBase\dataBaseAdress.txt");
            DBhost = lines[0];
            DBport = lines[1];
            DBuser = lines[2];
            DBpassword = lines[3];
            DBName = lines[4];
        }
    }
}
