namespace Academia.DotNet.AmigoSecreto.Models
{
    public class Amigo
    {
        private string nome;
        private string email;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public Amigo(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Email: {Email}";
        }

        public override bool Equals(object obj)
        {
            if (obj is null || ReferenceEquals(this, obj))
            {
                return false;
            }

            if (obj is Amigo amigo)
            {
                return Email.Equals(amigo.Email, StringComparison.OrdinalIgnoreCase);
            }

            return false;
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode(StringComparison.OrdinalIgnoreCase);
        }
    }
}
