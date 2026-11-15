namespace UrbanDrive.Entities
{
    public class ConfiguradorSistema
    {
        public static string NomeSistema { get; set; } = "UrbanDrive";

        public static decimal TaxaServico { get; set; } = 0.10m;

        public static void ExibirConfiguracoes()
        {
            Console.WriteLine("\n=== Configurações do Sistema ===");
            Console.WriteLine($"Sistema: {NomeSistema}");
            Console.WriteLine($"Taxa de serviço: {TaxaServico:P}");
        }
    }
}