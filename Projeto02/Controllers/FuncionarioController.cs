using Projeto02.Entities;
using Projeto02.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto02.Controllers
{
    public class FuncionarioController
    {
        public void CadastrarFuncionario()
        {
            var funcionario = new Funcionario();
            funcionario.Setor = new Setor();
            funcionario.Dependentes = new List<Dependentes>();

            Console.WriteLine("\n --- CADASTRO DO FUNCIONARIO --- \n");

            funcionario.IdFuncionario = Guid.NewGuid();

            Console.Write("Nome do funcionario...........: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("CPF do funcionario............: ");
            funcionario.Cpf = Console.ReadLine();

            Console.Write("Matricula do funcionario......: ");
            funcionario.Matricula = Console.ReadLine();

            Console.Write("Data admissão do funcionario..: ");
            funcionario.DataAdmissao = DateTime.Parse(Console.ReadLine());

            funcionario.Setor.IdSetor = Guid.NewGuid();

            Console.Write("Nome do setor.................: ");
            funcionario.Setor.Nome = Console.ReadLine();

            Console.Write("Descrição do setor............: ");
            funcionario.Setor.Descricao = Console.ReadLine();

            Console.Write("Quantidade de dependentes.....: ");
            var numDependentes = int.Parse(Console.ReadLine());

            for (int i = 0; i < numDependentes; i++)
            {
                var dependente = new Dependentes();

                dependente.IdDependente = Guid.NewGuid();

                Console.Write($"\nEntre com {i + 1}° dependente.....:\n ");

                Console.Write("Nome do dependente...............: ");
                dependente.Nome = Console.ReadLine();

                Console.Write("Data nascimento do dependente....: ");
                dependente.DataNascimento = DateTime.Parse(Console.ReadLine());

                funcionario.Dependentes.Add(dependente);
            }

            var funcionarioRepository = new FuncionarioRepository();
            funcionarioRepository.ExportarJSON(funcionario);

            Console.WriteLine("\nArquivo JSON gerado com sucesso!");
        }
    }
}
