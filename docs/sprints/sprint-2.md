# Planejamento e Resultado - Sprint 2

## A. Identificação
* **Grupo:** UrbanDrive
* **Integrantes:** Luísa, Gustavo, Marcus, Vinicius
* **Número da sprint:** 2
* **Período:** 31/11/2026 a 14/11/2026
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
| T05 | Implementar classes `Motorista` e `CNH` (Composição) | RF03 | [A definir] | 2h |
| T06 | Implementar classe `Frota` (Agregação com veículos) | RF04 | [A definir] | 2h |
| T07 | Criar classe `ConfiguradorSistema` (Membros estáticos) | RF05 | [A definir] | 1h |
| T08 | Atualizar `Program.cs` com testes dos novos relacionamentos | RF03, RF04, RF05 | [A definir] | 1h |
| T09 | Atualizar diagrama de classes na pasta de documentação | RF03, RF04, RF05 | [A definir] | 1h |

## E. Critérios de aceitação
* A `CNH` deve ser criada e gerenciada internamente pelo `Motorista`, não existindo de forma independente (composição).
* A `Frota` deve permitir adicionar, listar e gerenciar uma coleção de objetos `Veiculo` já existentes (agregação).
* O `ConfiguradorSistema` deve armazenar e fornecer informações compartilhadas por meio de atributos e métodos estáticos (`static`).
* O console (`Program.cs`) deve demonstrar o funcionamento integrado dessas novas classes.

## F. Entregáveis previstos
* Código-fonte das classes `Motorista.cs`, `CNH.cs`, `Frota.cs` e `ConfiguradorSistema.cs`.
* Atualização do arquivo `Program.cs` com os cenários de teste da Sprint 2.
* Diagrama de classes atualizado contemplando os novos relacionamentos.

## G. Resultado da sprint
| Item ou tarefa | Situação | Evidência | Observações |
|---|---|---|---|
| T05 | Em andamento | `Motorista.cs` e `CNH.cs` | Aguardando conclusão da implementação |
| T06 | Em andamento | `Frota.cs` | Aguardando conclusão da implementação |
| T07 | Em andamento | `ConfiguradorSistema.cs` | Aguardando conclusão da implementação |
| T08 | Pendente | `Program.cs` | - |
| T09 | Pendente | Diagrama de classes | - |

## H. Retrospectiva
1. **O que funcionou bem?** *[A Preencher]*
2. **Quais foram as principais dificuldades?** *[A Preencher]*
3. **O planejamento foi adequado ao esforço necessário?** *[A Preencher]*
4. **O que deverá ser melhorado na próxima sprint?** *[A Preencher]*
