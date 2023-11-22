<h1 align="center">:gift: Academia .NET - Desafio Amigo Secreto</h1>

<p align="center">
  <a href="https://learn.microsoft.com/pt-br/dotnet/"><img alt="DotNet 6" src="https://img.shields.io/badge/.NET-5C2D91?logo=.net&logoColor=white&style=for-the-badge" /></a>
  <a href="https://learn.microsoft.com/pt-br/dotnet/csharp/programming-guide/"><img alt="C#" src="https://img.shields.io/badge/C%23-239120?logo=c-sharp&logoColor=white&style=for-the-badge" /></a>
</p>

## :computer: Projeto

Repositório com solução de desafio para gerenciar listas relacionadas a realização de um amigo secreto, este projeto tem como propósito criar a formarção dos pares do amigo secreto. O desafio foi proposto durante a Academia DotNet ministrada pela `Universidade Franciscana - UFN`.

## :camera: Screenshot

<p align="center"> <img src="https://github.com/PauloAlves8039/academia-dotnet-desafio-amigo-secreto/blob/master/AmigoSecreto/Academia.DotNet.AmigoSecreto/Resources/images/screenshot.PNG" /></p>

## :page_facing_up: Desafio

[Descrição do Desafio](https://github.com/ricardosma/academia_DotNet_5/blob/main/anotacoesAlexandre/aulas.md)

## :scroll: Funcionalidades

Essa aplicação permite ao usuário:

- Cadastrar `Nome` e `Email` dos amigos que vão participar do `Amigo Secreto`.
- Visualizar duas listas: `amigos cadastrados` e `pares dos amigos`.
- Gerar o sorteio aleatório dos pares dos amigos.
- Limpar as listas dos amigos cadastrados e dos pares de amigos.

## :white_check_mark: Decisões Técnicas

1. Os arquivos `amigos.csv` e `secretos.csv` estão salvos no projeto na pasta padrão `bin\Debug\net6.0`, optei em manter essa estrutura para futuras implementações caso seja necessário.

2. Procurei manter a divisão dos nomes e emails usando `;` confome instruções na descrição do enunciado. 

3. Fiz a criação de pastas visando uma organização na estrutura do projeto, decidi seguir essas nomeclaturas de acordo com o que foi apresentado pelo professor em aula. As pastas representam as definições de cada uma das classes utilizadas:

- <b>Communications</b>: nesta pasta é armazenada a classe `Comunicacao` que possui métodos responsáveis pela regra de negócio da aplicação.
- <b>Models</b>: essa pasta é responsável por armazenar a classe de modelo `Amigo`, o objetivo é representar a entidade Amigo.
- <b>Data</b>: essa pasta é responsável por definir a classe que atua com a persistência de dados, foi criada a classe `Persistencia` com esse propósito.
- <b>Utils</b>: esta pasta contem a classe `Utilitario`, o seu objetivo é definir métodos auxiliares para as validações das propriedades e outras funcionalidades.

## ✔️ Recursos Utilizados

- ``.NET 6.0``
- ``Console Application``
- ``C#``

## :floppy_disk: Clonar Repositório

```bash
git clone https://github.com/PauloAlves8039/academia-dotnet-desafio-amigo-secreto.git
```

## :boy: Author


<a href="https://github.com/PauloAlves8039"><img src="https://avatars.githubusercontent.com/u/57012714?v=4" width=70></a>
[Paulo Alves](https://github.com/PauloAlves8039)
