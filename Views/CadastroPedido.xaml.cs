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
    /// Lógica interna para CadastroPedido.xaml
    /// </summary>
    public partial class CadastroPedido : Window
    {
        public CadastroPedido()
        {
            InitializeComponent();
        }

        private void voltarBT_Click(object sender, RoutedEventArgs e)
        {
            var form = new TelaInicial();
            form.Show();
            this.Close();
        }
    }
}
