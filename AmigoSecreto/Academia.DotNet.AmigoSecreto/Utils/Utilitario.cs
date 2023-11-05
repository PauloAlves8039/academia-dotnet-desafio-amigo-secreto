using Academia.DotNet.AmigoSecreto.Models;
using System.Text.RegularExpressions;

namespace Academia.DotNet.AmigoSecreto.Utils
{
    public static class Utilitario
    {
        public static bool ValidarNome(string nomeInformado)
        {
            if (string.IsNullOrWhiteSpace(nomeInformado))
            {
                Console.WriteLine("Nome não pode estar em branco. Por favor, insira um nome válido.");
                return false;
            }

            if (!nomeInformado.Contains(" "))
            {
                Console.WriteLine("O nome deve conter pelo menos um espaço para o sobrenome. Por favor, insira um nome completo.");
                return false;
            }

            return true;
        }

        public static bool ValidarFormatoDoEmail(string emailInformado)
        {
            if (string.IsNullOrWhiteSpace(emailInformado))
            {
                return false;
            }

            var formatoDoEmail = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";

            return Regex.IsMatch(emailInformado, formatoDoEmail);
        }
        
        public static void OrdenarAmigosPorNome(List<Amigo> amigos)
        {
            amigos.Sort((amigo1, amigo2) => amigo1.Nome.CompareTo(amigo2.Nome));
        }
    }
}
