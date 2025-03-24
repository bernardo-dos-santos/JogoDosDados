# Jogo Dos Dados
![](https://i.imgur.com/uCL3Yce.gif)
O jogo dos dados é uma corrida entre o jogador e o computador e seu objetivo é chegar até a casa 30 antes do adversário

## Detalhes

**Números Aleatórios** - No jogo, é escolhido a cada turno um número aleatório entre 1 e 6, simulando uma rolagem de dados

**Exibição de Progresso** - É exibido o progresso do jogador e do computador a cada turno

**Bônus** - Nas casas 5, 10, 15 e 20 há um bônus de aumento de 3 casas, assim deixando o jogo mais empolgantes

**Ônus** - Assim como temos o bônus, o ônus está presente nas casas 9, 14, 19 e 21, diminuindo 2 casas

## Requisitos 

.NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto

## Como Jogar 

1. Clone o Repositório
```
git clone https://github.com/bernardo-dos-santos/JogoDosDados
```
2. Navegue até a pasta raiz da solução
```
cd JogoDosDados
```
3. Restaure as dependências
```
dotnet restore
```
4. Navegue até a pasta do projeto
```
cd JogoDosDados.ConsoleApp
```
5. Execute o projeto
```
dotnet run
```