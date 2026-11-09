# UrbanDrive

Aplicação de console em C# para demonstrar a classe `Veiculo` na Sprint 1.

## Executar

É necessário ter o SDK do .NET 10 instalado. Na raiz do repositório, execute:

```powershell
dotnet run --project .\src\UrbanDrive.Models\UrbanDrive.csproj
```

O menu permite mostrar o veículo atual, criar outro veículo ou alterar sua placa. Para testar manualmente a validação, escolha `2` ou `3` e digite uma placa válida, pressione Enter sem digitar nada, ou digite apenas espaços. Após uma tentativa inválida, escolha `1` para confirmar que o veículo anterior continua disponível. Digite `0` para sair.

O valor `null` não pode ser digitado no console; para testar esse caso, é necessário passá-lo diretamente em código ou em um teste automatizado.

O comando `dotnet run` sem `--project` na raiz não encontra o projeto, pois o arquivo `.csproj` está em `src/UrbanDrive.Models`.
