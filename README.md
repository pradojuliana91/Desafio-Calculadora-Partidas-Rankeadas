# Calculadora de Saldo de Vitórias e Nível de Jogador

Este projeto em C# calcula o saldo de vitórias de um jogador com base nas vitórias e derrotas informadas pelo usuário. O programa também determina o nível do jogador de acordo com a quantidade de vitórias, seguindo uma hierarquia de níveis.

## Funcionalidades

- Solicita ao usuário a quantidade de **vitórias** e **derrotas**.
- Calcula o **saldo de vitórias** (vitórias - derrotas).
- Determina o **nível do jogador** com base nas vitórias:
  - **Ferro**: menos de 10 vitórias.
  - **Bronze**: entre 11 e 20 vitórias.
  - **Prata**: entre 21 e 50 vitórias.
  - **Ouro**: entre 51 e 80 vitórias.
  - **Diamante**: entre 81 e 90 vitórias.
  - **Lendário**: entre 91 e 100 vitórias.
  - **Imortal**: mais de 101 vitórias.
- Exibe uma mensagem final com o saldo de vitórias e o nível do jogador.

# Estrutura do Código

- `CalcularSaldoVitorias(int vitorias, int derrotas)`: Calcula o saldo de vitórias subtraindo derrotas das vitórias.
- `DeterminaNivel(int vitorias)`: Determina o nível do jogador com base no número de vitórias.
- `ExibeMensagem(int saldoVitorias, string nivel)`: Exibe a mensagem final com o saldo e o nível do jogador.

## Tecnologias Utilizadas

- Linguagem de Programação: **C#**
- Plataforma: **.NET Core**

## Pré-requisitos

- [SDK do .NET] instalado.
- IDE que suporte C#, como o Visual Studio.
