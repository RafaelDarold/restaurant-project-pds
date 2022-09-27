﻿using System;
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
            string acesso = txtUsuario.Text;
            string senha = pwSenha.Password.ToString();

            if (acesso == "Usuario" && senha == "senha")
            {
                MessageBox.Show("Acesso feito com sucesso!");
                var form = new TelaInicial();
                form.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro no Login!", "ERRO", MessageBoxButton.OK, MessageBoxImage.Error);
                pwSenha.Clear();
                txtUsuario.Clear();
                txtUsuario.Focus();
            }
            //var form = new TelaInicial();
            //form.Show();
            //this.Close();
        }

        private void CliqueAqui_Click(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
