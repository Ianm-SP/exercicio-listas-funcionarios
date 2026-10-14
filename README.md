# Exercício dos Funcionários - C#

Repositório criado para fins de estudo, contendo a resolução do exercício de **Listas** do curso de C# do professor **Nélio Alves**.

## 📌 Sobre o Exercício

O programa gerencia o cadastro de funcionários de uma empresa. O sistema permite:

1. Informar a quantidade de funcionários que serão registrados.
2. Registrar o id, o nome e o salário de cada funcionário, sem permitir id repetido.
3. Aumentar o salário de um funcionário, informando o id e a porcentagem. Se o id não existir, mostra uma mensagem e aborta a operação.
4. Exibir a listagem atualizada de todos os funcionários.

## 🛠️ Tecnologias Utilizadas

- **Linguagem:** C# (.NET)
- **Conceitos aplicados:**
  * Orientação a Objetos (Classes, Construtores)
  * Encapsulamento (`private set` no salário, alterado só pelo método `AumentarSalario`)
  * Listas (`List<T>`)
  * Estruturas de repetição e controle (`for`, `foreach`, `while`, `if`)

## 💻 Exemplo de Uso

```
Quantos funcionários serão registrados? 2

Funcionário #1:
Id: 1
Nome: Maria
Salário: 3000.00

Funcionário #2:
Id: 2
Nome: João
Salário: 2500.00

Digite o id do funcionário que terá aumento salarial: 2
Digite a porcentagem: 10

Lista atualizada de funcionários:
1, Maria, 3000.00
2, João, 2750.00
```
