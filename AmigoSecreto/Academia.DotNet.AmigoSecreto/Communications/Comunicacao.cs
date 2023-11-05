using Academia.DotNet.AmigoSecreto.Data;
using Academia.DotNet.AmigoSecreto.Models;
using Academia.DotNet.AmigoSecreto.Utils;

namespace Academia.DotNet.AmigoSecreto.Communications
{
    public class Comunicacao
    {
        private List<Amigo> listaDeAmigos;

        public Comunicacao(List<Amigo> amigos)
        {
            listaDeAmigos = amigos;
        }

        public void AdicionarAmigo(Amigo amigo)
        {
            listaDeAmigos.Add(amigo);
            Utilitario.OrdenarAmigosPorNome(listaDeAmigos);
            Console.WriteLine("Amigo adicionado com sucesso!");
        }

        public List<Amigo> ListarAmigos()
        {
            return listaDeAmigos;
        }

        public List<Tuple<Amigo, Amigo>> GerarAmigoSecreto()
        {
            if (listaDeAmigos.Count < 2)
            {
                Console.WriteLine("Não há amigos suficientes para gerar amigos secretos.");
                return new List<Tuple<Amigo, Amigo>>();
            }
            else 
            {
                List<Amigo> amigosEmbaralhados = listaDeAmigos.ToList();
                Random random = new Random();

                List<Tuple<Amigo, Amigo>> paresAmigosSecretos = new List<Tuple<Amigo, Amigo>>();

                while (amigosEmbaralhados.Count > 0)
                {
                    Amigo amigo = amigosEmbaralhados[0];
                    amigosEmbaralhados.RemoveAt(0);

                    int indiceAmigoSecreto = random.Next(0, amigosEmbaralhados.Count);
                    Amigo amigoSecreto = amigosEmbaralhados[indiceAmigoSecreto];
                    amigosEmbaralhados.RemoveAt(indiceAmigoSecreto);

                    paresAmigosSecretos.Add(new Tuple<Amigo, Amigo>(amigo, amigoSecreto));
                }

                Persistencia persistencia = new Persistencia();
                persistencia.SalvarParesAmigosSecretos(paresAmigosSecretos);

                return paresAmigosSecretos;
            }
            
        }
    }
}
