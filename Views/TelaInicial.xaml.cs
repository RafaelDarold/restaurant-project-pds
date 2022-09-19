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
using System.Windows.Shapes;

namespace restaurant_project.Views
{
    /// <summary>
    /// Lógica interna para TelaInicial.xaml
    /// </summary>
    public partial class TelaInicial : Window
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void pedido_Click(object sender, RoutedEventArgs e)
        {
            var form = new Pedido();
            form.Show();
            this.Close();
        }

        private void Funcionários_Click(object sender, RoutedEventArgs e)
        {
            var form = new CadastroFuncionario();
            form.Show();
            this.Close();
        }
    }
}
