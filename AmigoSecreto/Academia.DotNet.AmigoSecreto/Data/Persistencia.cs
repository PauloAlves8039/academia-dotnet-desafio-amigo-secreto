using Academia.DotNet.AmigoSecreto.Models;
using System.Reflection;

namespace Academia.DotNet.AmigoSecreto.Data
{
    public class Persistencia
    {
        private string caminhoDoArquivoAmigos => Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "amigos.csv");
        private string caminhoDoArquivoSecretos => Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "secretos.csv");

        public List<Amigo> LerAmigosDoArquivo()
        {
            List<Amigo> listaDeAmigos = new List<Amigo>();

            if (File.Exists(caminhoDoArquivoAmigos))
            {
                using (StreamReader streamReader = new StreamReader(caminhoDoArquivoAmigos))
                {
                    while (!streamReader.EndOfStream)
                    {
                        string linha = streamReader.ReadLine();
                        string[] dados = linha.Split(';');
                        listaDeAmigos.Add(new Amigo(dados[0], dados[1]));
                    }
                }
            }

            return listaDeAmigos;
        }

        public void SalvarAmigosNoArquivo(List<Amigo> listaDeAmigos)
        {
            if (!Directory.Exists(Path.GetDirectoryName(caminhoDoArquivoAmigos)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(caminhoDoArquivoAmigos));
            }

            using (StreamWriter writer = new StreamWriter(caminhoDoArquivoAmigos))
            {
                foreach (var amigo in listaDeAmigos)
                {
                    writer.WriteLine($"{amigo.Nome};{amigo.Email}");
                }
            }

            Console.WriteLine("O amigo foi adicionado no arquivo: amigos");
        }

        public List<Tuple<Amigo, Amigo>> LerParesAmigosSecretos()
        {
            List<Tuple<Amigo, Amigo>> paresAmigosSecretos = new List<Tuple<Amigo, Amigo>>();

            if (File.Exists(caminhoDoArquivoSecretos))
            {
                using (StreamReader streamReader = new StreamReader(caminhoDoArquivoSecretos))
                {
                    while (!streamReader.EndOfStream)
                    {
                        string linha = streamReader.ReadLine();
                        string[] dados = linha.Split(';');
                        Amigo amigo1 = new Amigo(dados[0], "");
                        Amigo amigo2 = new Amigo(dados[1], "");
                        paresAmigosSecretos.Add(new Tuple<Amigo, Amigo>(amigo1, amigo2));
                    }
                }
            }

            return paresAmigosSecretos;
        }

        public void SalvarParesAmigosSecretos(List<Tuple<Amigo, Amigo>> paresAmigosSecretos)
        {
            if (!Directory.Exists(Path.GetDirectoryName(caminhoDoArquivoSecretos)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(caminhoDoArquivoSecretos));
            }

            using (StreamWriter streamWriter = new StreamWriter(caminhoDoArquivoSecretos))
            {
                foreach (var par in paresAmigosSecretos)
                {
                    string linha = $"{par.Item1.Nome};{par.Item1.Email};{par.Item2.Nome};{par.Item2.Email}";
                    streamWriter.WriteLine(linha);
                }
            }

            Console.WriteLine("Os amigos secretos foram adicionados no arquivo: segredos");
        }
    }
}
