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
    /// Lógica interna para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Label_SourceUpdated(object sender, DataTransferEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Entrar();
        }

        private void CliqueAqui_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                pwSenha.Focus();
            }
        }

        private void pwSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Entrar();
            }
        }

        private void Entrar()
        {
            //string acesso = txtUsuario.Text;
            //string senha = pwSenha.Password.ToString();

            //if (acesso.ToUpper() == "USUARIO" && senha.ToUpper() == "SENHA")
            //{
            //    MessageBox.Show("Acesso feito com sucesso!");
            //    var form = new TelaInicial();
            //    form.Show();
            //    this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Erro no Login!", "ERRO", MessageBoxButton.OK, MessageBoxImage.Error);
            //    pwSenha.Clear();
            //    txtUsuario.Clear();
            //    txtUsuario.Focus();
            //}
            var form = new TelaInicial();
            form.Show();
            this.Close();
        }

        private void LoginWindow_Activated(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }
    }
}
