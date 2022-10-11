using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_project.Models
{
    public class CadastroFuncionario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Funcao { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public float Salario { get; set; }
        public string Ctps { get; set; }
        public byte Foto { get; set; }
        public string Telefone { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string Sexo { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int NumeroEndereco { get; set; }
        public string ComplementoEndereco { get; set; }
}
}
