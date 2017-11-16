using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TrabalhoBiblioteca
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            this.WindowState = WindowState.Maximized;
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            FormCadastrarLivro Cadastrar = new FormCadastrarLivro();
            Cadastrar.ShowDialog();
        }

        private void btnConsultar_Click(object sender, RoutedEventArgs e)
        {
            FormConsultar Consultar = new FormConsultar();
            Consultar.ShowDialog();
        }

        private void btnExcluir_Click(object sender, RoutedEventArgs e)
        {
            FormExcluir Excluir = new FormExcluir();
            Excluir.ShowDialog();
        }

        private void btnAlterar_Click(object sender, RoutedEventArgs e)
        {
            FormAlterar Alterar = new FormAlterar();
            Alterar.Show();
        }
    }
}
