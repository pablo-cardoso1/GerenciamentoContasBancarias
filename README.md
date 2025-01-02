
# Desafio de Projeto: Sistema Bancário com Herança e Polimorfismo

Este projeto é uma implementação simples de um sistema bancário em C#, que utiliza os conceitos de **herança**, **polimorfismo** e **encapsulamento**. O objetivo deste desafio é criar um sistema que gerencie diferentes tipos de contas bancárias (conta corrente e conta poupança), permitindo depósitos, saques e a exibição do saldo de cada conta.

## Tecnologias Utilizadas
- C# (.NET)
- Console Application

## Funcionalidades Implementadas

1. **Conta Bancária**: 
   - A classe base `ContaBancaria` representa uma conta bancária comum. Ela tem as propriedades `NumeroConta`, `Titular` e `Saldo`, além de métodos para realizar depósitos, saques e exibir o saldo atual.

2. **Conta Corrente**:
   - A classe `ContaCorrente` herda de `ContaBancaria` e sobrepõe o método `Sacar` para aplicar uma taxa de 10% sobre o valor do saque, antes de reduzir o saldo.

3. **Conta Poupança**:
   - A classe `ContaPoupanca` também herda de `ContaBancaria` e sobrepõe o método `Sacar` para permitir um número limitado de saques por mês. Após 5 saques, o sistema bloqueia o saque, garantindo que o limite seja respeitado.

4. **Validações**:
   - O sistema garante que o valor do depósito e do saque seja maior que zero.
   - Se o saldo for insuficiente para o saque, o sistema avisa o usuário.
   - Na conta poupança, um limite de saques mensais é implementado.

## Como Rodar o Projeto

Para rodar o projeto em sua máquina local:

1. Clone este repositório:
   ```bash
   git clone https://github.com/seu-usuario/sistema-bancario.git
2. Abra o projeto em seu editor de código preferido, como o Visual Studio Code ou Visual Studio.
3. Compile e execute o projeto:
    - No Visual Studio, clique em Iniciar ou pressione F5.
    - No Visual Studio Code, use o terminal integrado para rodar o seguinte comando:
    ```bash
    dotnet run

## Exemplo de Uso
A seguir está um exemplo de como o programa funcionará ao ser executado:

Para uma conta corrente:
```bash
Saldo atual: R$1000
Você depositou R$500. Seu saldo atual é R$1500.
Você sacou R$200. Seu saldo atual é R$1300.
```
Para uma conta poupança:
```bash
Saldo atual: R$2000
Você depositou R$300. Seu saldo atual é R$2300.
Você sacou R$100. Seu saldo atual é R$2200. Você já realizou 1 saque este mês.
Você sacou R$200. Seu saldo atual é R$2000. Você já realizou 2 saques este mês.
Você sacou R$300. Seu saldo atual é R$1700. Você já realizou 3 saques este mês.
Você sacou R$400. Seu saldo atual é R$1300. Você já realizou 4 saques este mês.
Você sacou R$500. Seu saldo atual é R$800. Você já realizou 5 saques este mês.
Você atingiu o limite máximo de saques no mês.
```

## Desafio e Aprendizado
Este projeto foi desenvolvido como parte de um desafio para aplicar conceitos fundamentais de Programação Orientada a Objetos (POO) em C#. Durante o desenvolvimento, foi possível praticar:

Herança: Criação de classes derivadas como ContaCorrente e ContaPoupanca a partir da classe base ContaBancaria.

Polimorfismo: Sobrecarga de métodos como Sacar, permitindo comportamentos específicos para diferentes tipos de contas.

Encapsulamento: Proteção de dados internos, garantindo a integridade e a segurança das informações bancárias.

### Contribuições
Este é um projeto pessoal, mas contribuições são bem-vindas! Caso queira adicionar novas funcionalidades ou corrigir algum problema, fique à vontade para abrir um pull request.

Autor: Pablo Cardoso









