using System;

namespace UrbanDrive.Entities
{
    public class Veiculo
    {
        private string _placa;
        public int Identificador { get; set; }
        public string Modelo { get; set; }
        public decimal ValorBaseDiaria { get; set; }

        public string Placa
        {
            get { return _placa; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A placa do veículo não pode ser nula ou vazia.");
                }
                _placa = value;
            }
        }

        public Veiculo(int identificador, string placa, string modelo, decimal valorBaseDiaria)
        {
            Identificador = identificador;
            Placa = placa;
            Modelo = modelo;
            ValorBaseDiaria = valorBaseDiaria;
        }

        public virtual void ExibirInformacoes()
        {
            Console.WriteLine($"ID: {Identificador} | Modelo: {Modelo} | Placa: {Placa} | Diária: R$ {ValorBaseDiaria:F2}");
        }
    }
}