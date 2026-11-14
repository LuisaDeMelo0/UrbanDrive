# Planejamento e Resultado - Sprint 1

## A. Identificação
* **Grupo:** UrbanDrive
* **Integrantes:** Luísa, Gustavo, Marcus, Vinicius
* **Número da sprint:** 1
* **Período:** 23/10/2026 a 31/10/2026
* **Responsável pelo acompanhamento:** Luísa de Melo

## B. Objetivo da sprint
Estabelecer a estrutura inicial do sistema em C# e implementar uma primeira versão funcional com a classe Veiculo, garantindo o encapsulamento e as validações básicas de dados.

## C. Itens selecionados do Product Backlog
| ID | Requisito ou item | Prioridade | Justificativa |
|---|---|---|---|
| RF01 | Gerenciamento de veículos | Alta | Base fundamental para representar os veículos no sistema. |

## D. Planejamento das tarefas
| ID | Tarefa | Item relacionado | Responsável | Estimativa de esforço |
|---|---|---|---|---|
| T01 | Criar estrutura do projeto C# e repositório | RF01 | Luísa | 1h |
| T02 | Implementar classe Veiculo e encapsulamento | RF01 | Luísa | 0,25h |
| T03 | Criar validações (placa nula/vazia) | RF01 | Luísa | 0,25h |
| T04 | Configurar Program.cs e testes iniciais | RF01 | Gustavo | 2h |

## E. Critérios de aceitação
* A classe `Veiculo` deve possuir identificador, placa, modelo e valor-base da diária.
* Atributos devem ser privados e acessíveis por propriedades públicas.
* Tentativas de cadastrar placas nulas ou vazias devem ser bloqueadas por validações.

## F. Entregáveis previstos
* Código-fonte da classe `Veiculo`.
* Aplicação de console demonstrando a criação de objetos e validações.

## G. Resultado da sprint
| Item ou tarefa | Situação | Evidência | Observações |
|---|---|---|---|
| T01 | Concluído | Repositório GitHub | - |
| T02 | Concluído | `Veiculo.cs` | - |
| T03 | Concluído | Validações implementadas | - |
| T04 | Concluído | `Program.cs` | Testes executados com sucesso |

## H. Retrospectiva
1. **O que funcionou bem?** A configuração inicial do repositório e a divisão básica da classe Veiculo.
2. **Quais foram as principais dificuldades?** Nenhuma dificuldade significativa. Como o escopo inicial era focado apenas na classe base e na estrutura inicial, a implementação ocorreu de forma fluida e rápida.
3. **O planejamento foi adequado ao esforço necessário?** Sim, as estimativas atenderam ao escopo da Sprint 1.
4. **O que deverá ser melhorado na próxima sprint?** Melhorar o alinhamento das tarefas da Sprint 2.
