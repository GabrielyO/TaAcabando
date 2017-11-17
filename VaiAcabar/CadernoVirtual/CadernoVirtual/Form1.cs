using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadernoVirtual
{
    public partial class paginaInicial : Form
    {
        public paginaInicial()
        {
            InitializeComponent();
        }

        private void BTNcadastrar_Click(object sender, EventArgs e)
        {
            PANELcadastrar.Visible = true;
            PANELentrar.Visible = false;
        }

        private void BTNpaginaprincipal_Click(object sender, EventArgs e)
        {
            PANELcadastrar.Visible = false;
            PANELentrar.Visible = false;
        }

        private void BTNentrar_Click(object sender, EventArgs e)
        {
            PANELentrar.Visible = true;
            PANELcadastrar.Visible = false;
        }
    }
}
