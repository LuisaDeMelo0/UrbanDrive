using System;

namespace UrbanDrive.Entities
{
    public class CNH
    {
        public string Numero { get; }
        public string Categoria { get; }
        public DateOnly DataValidade { get; }

        internal CNH(string numero, string categoria, DateOnly dataValidade)
        {
            if (string.IsNullOrWhiteSpace(numero))
            {
                throw new ArgumentException("O número da CNH não pode ser nulo ou vazio.");
            }

            if (string.IsNullOrWhiteSpace(categoria))
            {
                throw new ArgumentException("A categoria da CNH não pode ser nula ou vazia.");
            }

            Numero = numero;
            Categoria = categoria;
            DataValidade = dataValidade;
        }
    }
}
