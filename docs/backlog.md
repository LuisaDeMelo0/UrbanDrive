# Product Backlog - UrbanDrive

Lista priorizada de requisitos e funcionalidades previstas para o desenvolvimento do sistema de gestão de frota e locação/uso de veículos.

## Requisitos Funcionais

| ID | Requisito / Funcionalidade | Descrição | Prioridade | Sprint Prevista | Status |
|---|---|---|---|---|---|
| **RF01** | Gerenciamento de Veículos | Cadastro e validação básica de veículos (identificador, placa, modelo e valor-base da diária) com encapsulamento. | Alta | Sprint 1 | Concluído |
| **RF02** | Interface de Console Inicial | Menu básico em linha de comando para demonstrar a criação e validação de veículos. | Alta | Sprint 1 | Concluído |
| **RF03** | Gerenciamento de Motoristas e CNH | Cadastro de motoristas vinculados obrigatoriamente a uma CNH (relação de composição). | Alta | Sprint 2 | Em andamento |
| **RF04** | Gerenciamento de Frotas | Criação de frotas capazes de agrupar e gerenciar uma coleção de veículos (relação de agregação). | Alta | Sprint 2 | Em andamento |
| **RF05** | Configuração Global do Sistema | Componente com membros estáticos para armazenar taxas, parâmetros ou contadores compartilhados. | Média | Sprint 2 | Em andamento |
| **RF06** | Tipos Específicos de Veículos | Especialização de veículos (ex: carros de passeio, utilitários) aplicando herança e polimorfismo no cálculo de diárias. | Média | Sprint 3 | Pendente |
| **RF07** | Registro de Viagens / Locações | Associação entre motorista, veículo e período de uso, calculando valores finais com base nas regras de negócio. | Média | Sprint 3 | Pendente |
| **RF08** | Relatórios e Consultas | Exibição de resumos da frota, veículos disponíveis e histórico de operações no console. | Baixa | Sprint 4 | Pendente |

## Observações de Priorização
* **Alta:** Funcionalidades estruturais essenciais para o funcionamento base e modelagem dos relacionamentos principais de POO.
* **Média:** Regras de negócio complementares e extensões de comportamento (herança/polimorfismo).
* **Baixa:** Recursos de visualização consolidada e refinamentos finais do sistema.
