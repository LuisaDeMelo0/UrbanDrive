# Planejamento e Resultado - Sprint 2

## A. Identificação
* **Grupo:** UrbanDrive
* **Integrantes:** Luísa, Gustavo, Marcus, Vinicius
* **Número da sprint:** 2
* **Período:** 01/11/2026 a 14/11/2026
* **Responsável pelo acompanhamento:** Luísa de Melo

## B. Objetivo da sprint
Ampliar o modelo orientado a objetos para representar relacionamentos entre classes (composição e agregação) e implementar o uso de membros estáticos para configurações compartilhadas do sistema.

## C. Itens selecionados do Product Backlog
| ID | Requisito ou item | Prioridade | Justificativa |
|---|---|---|---|
| RF03 | Gerenciamento de Motoristas e CNH | Alta | Implementar relação de composição entre motorista e documento de habilitação. |
| RF04 | Gerenciamento de Frotas | Alta | Implementar relação de agregação para agrupar e gerenciar coleções de veículos. |
| RF05 | Configuração Global do Sistema | Média | Utilizar membros estáticos para centralizar parâmetros compartilhados. |

## D. Planejamento das tarefas
| ID | Tarefa | Item relacionado | Responsável | Estimativa de esforço |
|---|---|---|---|---|
| T05 | Implementar classes `Motorista` e `CNH` (Composição) | RF03 | Vinícius | 2h |
| T06 | Implementar classe `Frota` (Agregação com veículos) | RF04 | Marcus | 2h |
| T07 | Criar classe `ConfiguradorSistema` (Membros estáticos) | RF05 | Marcus | 1h |
| T08 | Atualizar `Program.cs` com testes dos novos relacionamentos | RF03, RF04, RF05 | Luisa | 1h |
| T09 | Atualizar diagrama de classes na pasta de documentação | RF03, RF04, RF05 | Gustavo | 1h |

## E. Critérios de aceitação
* A `CNH` deve ser criada e gerenciada internamente pelo `Motorista`, não existindo de forma independente (composição).
* A `Frota` deve permitir adicionar, listar e gerenciar uma coleção de objetos `Veiculo` já existentes (agregação).
* O `ConfiguradorSistema` deve armazenar e fornecer informações compartilhadas por meio de atributos e métodos estáticos (`static`).
* O console (`Program.cs`) deve demonstrar o funcionamento integrado dessas novas classes.
* O sistema deve impedir a utilização de dados inválidos nos cenários de validação implementados.

## F. Entregáveis previstos
* Código-fonte das classes `Motorista.cs`, `CNH.cs`, `Frota.cs` e `ConfiguradorSistema.cs`.
* Atualização do arquivo `Program.cs` com os cenários de teste da Sprint 2.
* Diagrama de classes atualizado contemplando os novos relacionamentos.
* Registros dos testes de funcionamento e validação das classes.

## G. Resultado da sprint
| Item ou tarefa | Situação | Evidência | Observações |
|---|---|---|---|
| T05 | Concluída | `Motorista.cs` e `CNH.cs` | Composição implementada e validações testadas. |
| T06 | Concluída | `Frota.cs` | Agregação implementada, com adição e listagem de veículos. |
| T07 | Concluída | `ConfiguradorSistema.cs` | Propriedades e método estáticos implementados e testados. |
| T08 | Concluída | `Program.cs` | Demonstração integrada das classes e testes de validação realizados. |
| T09 | Pendente | Diagrama de classes | Atualização e registro do diagrama ainda necessários |

Testes realizados
Teste                                        Resultado
---
Criação de motorista com nome vazio          Aprovado
Criação de CNH com número vazio              Aprovado
Criação de CNH com categoria vazia           Aprovado
Adição de veículo nulo à frota               Aprovado
Exibição dos veículos cadastrados na frota   Aprovado
Exibição das configurações estáticas         Aprovado
Exibição dos dados do motorista e da CNH     Aprovado


## H. Retrospectiva
1. **O que funcionou bem?**  
    A implementação das classes e a integração entre elas funcionaram corretamente. Os testes realizados ajudaram a verificar os relacionamentos entre os objetos e as validações de dados.

2. **Quais foram as principais dificuldades?**  
    A principal dificuldade foi compreender e aplicar corretamente os conceitos de composição, agregação e membros estáticos, além de integrar as novas funcionalidades ao programa principal.

3. **O planejamento foi adequado ao esforço necessário?**       
    O planejamento permitiu organizar as atividades e desenvolver as funcionalidades previstas. Durante a implementação, foram necessários testes adicionais para verificar o comportamento das classes.

4. **O que deverá ser melhorado na próxima sprint?**        
    Melhorar a organização das tarefas, registrar as evidências durante o desenvolvimento e manter a documentação e o diagrama de classes atualizados junto com o código-fonte.
