namespace ProofOfConcept
{
    internal class Program
    {
        static List<Chamado> chamados = new List<Chamado>();
        static int proximoId = 1;

        static void Main(string[] args)
        {
            // Resto do código permanece inalterado




            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("\n\t--- MENU DE CHAMADOS ---\n");
                Console.WriteLine("  1 - Criar Chamado");
                Console.WriteLine("  2 - Listar Chamados");
                Console.WriteLine("  3 - Atualizar Chamado");
                Console.WriteLine("  4 - Remover Chamado");
                Console.WriteLine("\n  0 - Sair\n");
                Console.Write("  Opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1: CriarChamado(); break;
                    case 2: ListarChamados(); break;
                    case 3: AtualizarChamado(); break;
                    case 4: RemoverChamado(); break;
                    case 0: Console.WriteLine("\nPrograma encerrado"); break;
                    default: Console.WriteLine("\nOpção inválida! Tente novamente"); break;
                }

                if (opcao != 0) Console.ReadKey();
            } while (opcao != 0);
        }

        static void CriarChamado()
        {
            Console.Clear();
            Console.WriteLine("\n\t--- ABERTURA DE CHAMADO ---\n");
            Console.Write("ID Categoria: ");
            int idCategoria = int.Parse(Console.ReadLine());

            Console.Write("ID Problema: ");
            int idProblema = int.Parse(Console.ReadLine());

            Console.Write("ID Usuário Abertura: ");
            int idUsuario = int.Parse(Console.ReadLine());

            Console.Write("ID Status: ");
            int idStatus = int.Parse(Console.ReadLine());

            Console.Write("Prioridade (0 a 10): ");
            double prioridade = double.Parse(Console.ReadLine());

            chamados.Add(new Chamado
            {
                Id = proximoId++,
                IdCategoria = idCategoria,
                IdProblema = idProblema,
                IdUsuarioAbertura = idUsuario,
                IdStatus = idStatus,
                Prioridade = prioridade,
                DataAbertura = DateTime.Now
            });

            Console.WriteLine("\nChamado criado com sucesso!");
        }

        static void ListarChamados()
        {
            Console.Clear();
            Console.WriteLine("\n\t--- CHAMADOS CADASTRADOS ---\n");
            foreach (var c in chamados)
            {
                Console.WriteLine($"ID: {c.Id} | Usuário: {c.IdUsuarioAbertura} " +
                    $"| Categoria: {c.IdCategoria} | Status: {c.IdStatus} " +
                    $"| Prioridade: {c.Prioridade} | Abertura: {c.DataAbertura}");
            }
        }

        static void AtualizarChamado()
        {
            Console.Clear();
            Console.WriteLine("\n\t--- ATUALIZAÇÃO DE CHAMADO ---\n");
            Console.Write("Digite o ID do chamado a atualizar: ");
            int id = int.Parse(Console.ReadLine());

            var chamado = chamados.Find(c => c.Id == id);
            if (chamado != null)
            {
                Console.Write("Novo ID Categoria: ");
                chamado.IdCategoria = int.Parse(Console.ReadLine());

                Console.Write("Novo ID Problema: ");
                chamado.IdProblema = int.Parse(Console.ReadLine());

                Console.Write("Novo ID Status: ");
                chamado.IdStatus = int.Parse(Console.ReadLine());

                Console.Write("Nova Prioridade: ");
                chamado.Prioridade = double.Parse(Console.ReadLine());

                Console.WriteLine("\nChamado atualizado!");
            }
            else
            {
                Console.WriteLine("\nChamado não encontrado.");
            }
        }

        static void RemoverChamado()
        {
            Console.Clear();
            Console.WriteLine("\n\t--- EXCLUSÃO DE CHAMADO ---\n");
            Console.Write("Digite o ID do chamado a remover: ");
            int id = int.Parse(Console.ReadLine());

            var chamado = chamados.Find(c => c.Id == id);
            if (chamado != null)
            {
                chamados.Remove(chamado);
                Console.WriteLine("\nChamado removido!");
            }
            else
            {
                Console.WriteLine("\nChamado não encontrado.");
            }
        }

    }
}


