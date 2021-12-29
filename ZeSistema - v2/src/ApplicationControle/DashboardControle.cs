using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeSistema___v2.src;
using ZeSistema___v2.src.Login;

namespace ZeSistema___v2.src.ApplicationControle
{
    internal class DashboardControle
    {
        public DashboardControle()
        {

        }

        public void MostrarDashboard()
        {
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
        }
    }
}
