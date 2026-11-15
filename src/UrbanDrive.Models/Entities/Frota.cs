
using System;
using System.Collections.Generic;

namespace UrbanDrive.Entities
{
    public class Frota
    {
        private readonly List<Veiculo> _veiculos = new List<Veiculo>();

        public IReadOnlyCollection<Veiculo> Veiculos
        {
            get { return _veiculos.AsReadOnly(); }
        }

        public void AdicionarVeiculo(Veiculo veiculo)
        {
            if (veiculo == null)
            {
                throw new ArgumentNullException(nameof(veiculo),
                    "O veículo não pode ser nulo.");
            }

            _veiculos.Add(veiculo);
        }

        public void ExibirVeiculos()
        {
            if (_veiculos.Count == 0)
            {
                Console.WriteLine("A frota não possui veículos cadastrados.");
                return;
            }

            Console.WriteLine("\n=== Veículos da Frota ===");

            foreach (Veiculo veiculo in _veiculos)
            {
                veiculo.ExibirInformacoes();
            }
        }
    }
}
