using Academia.DotNet.AmigoSecreto.Data;
using Academia.DotNet.AmigoSecreto.Models;
using Academia.DotNet.AmigoSecreto.Communications;
using Academia.DotNet.AmigoSecreto.Utils;

internal class Program
{
    private static void Main(string[] args)
    {
        Persistencia persistencia = new Persistencia();
        List<Amigo> amigos = persistencia.LerAmigosDoArquivo();

        Comunicacao comunicacao = new Comunicacao(amigos);

        bool sair = false;
        while (!sair)
        {
            Console.WriteLine("\n****** Menu Amigo Secreto ******");
            Console.WriteLine("*   1 - Cadastrar amigo        *");
            Console.WriteLine("*   2 - Listar amigos          *");
            Console.WriteLine("*   3 - Gerar amigo secreto    *");
            Console.WriteLine("*   4 - Limpar arquivos        *");
            Console.WriteLine("*   5 - Sair                   *");
            Console.WriteLine("********************************");

            Console.Write("\nOpção: ");
            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    Console.Write("Digite o nome do amigo: ");
                    string nome = Console.ReadLine();
                    
                    while (!Utilitario.ValidarNome(nome))
                    {
                        Console.WriteLine("Digite um nome válido:");
                        nome = Console.ReadLine();
                    }

                    string email;
                    bool emailValido = false;

                    do 
                    {
                        Console.Write("Digite o email do amigo: ");
                        email = Console.ReadLine();

                        if (amigos.Any(a => string.Equals(a.Email, email, StringComparison.OrdinalIgnoreCase)))
                        {
                            Console.WriteLine("Email já existe para um amigo! Não é possível adicionar o amigo.");
                            Console.WriteLine("Por favor, verifique o email ou escolha outro.");
                        }
                        else if (!Utilitario.ValidarFormatoDoEmail(email))
                        {
                            Console.WriteLine("Digite um email válido:");
                        }
                        else
                        {
                            emailValido = true;
                        }
                    }
                    while (!emailValido);

                    Amigo novoAmigo = new Amigo(nome, email);
                    comunicacao.AdicionarAmigo(novoAmigo);
                    persistencia.SalvarAmigosNoArquivo(amigos);
                    break;

                case "2":
                    Console.WriteLine("\nLista de Amigos (ordenados por nome):\n");
                    List<Amigo> listaAmigos = comunicacao.ListarAmigos();
                    Utilitario.OrdenarAmigosPorNome(listaAmigos);

                    foreach (var amigo in listaAmigos)
                    {
                        Console.WriteLine(amigo);
                    }
                    break;

                case "3":
                    List<Tuple<Amigo, Amigo>> paresAmigosSecretos = comunicacao.GerarAmigoSecreto();

                    if (paresAmigosSecretos != null)
                    {
                        Console.WriteLine("\nPares de Amigos Secretos:\n");
                        persistencia.LerParesDosAmigosSecretos();
                    }
                    break;

                case "4":
                    Console.WriteLine("\nLimpando as Listas!\n");
                    amigos.Clear();
                    persistencia.LimparConteudoDosArquivos();
                    break;

                case "5":
                    sair = true;
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}