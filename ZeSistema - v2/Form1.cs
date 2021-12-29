using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZeSistema___v2.src.Login;

namespace ZeSistema___v2
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
            LoginFormControle loginFormControle = new LoginFormControle();
            this.Hide();
            loginFormControle.MostrarLoginForm();
        }

        private void Loading_Load(object sender, EventArgs e)
        {

        }
    }
}
