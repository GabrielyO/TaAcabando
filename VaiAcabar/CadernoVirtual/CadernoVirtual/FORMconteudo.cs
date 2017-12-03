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
    public partial class FORMconteudo : Form
    {
        public FORMconteudo(string c)
        {
            txtC.Text = c;
            InitializeComponent();
        }
    }
}
