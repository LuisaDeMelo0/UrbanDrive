using System;

namespace UrbanDrive.Entities
{
    public class Motorista
    {
        private string _nome = string.Empty;

        public int Identificador { get; set; }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O nome do motorista não pode ser nulo ou vazio.");
                }

                _nome = value;
            }
        }

        public CNH CNH { get; }

        public Motorista(
            int identificador,
            string nome,
            string numeroCNH,
            string categoriaCNH,
            DateOnly validadeCNH)
        {
            Identificador = identificador;
            Nome = nome;
            CNH = new CNH(numeroCNH, categoriaCNH, validadeCNH);
        }
    }
}
