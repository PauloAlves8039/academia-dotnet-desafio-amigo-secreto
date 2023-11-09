<h1 align="center">Academia DotNet - Desafio Amigo Secreto</h1>

## :computer: Projeto

Repositório com desafio em C# para gerenciar lista de amigos secretos, este projeto tem com propósito realizar o cadastro, exibição da lista de amigos e formar os pares do amigo secreto. O desafio foi proposto durante a Academia DotNet ministrada pela `Universidade Franciscana - UFN`.

## :page_facing_up: Desafio

[Descrição do Desafio](https://github.com/ricardosma/academia_DotNet_5/blob/main/anotacoesAlexandre/aulas.md)

## :white_check_mark: Decisões Técnicas

1. Os arquivos estão salvos no projeto nas pastas `Data/Files/amigos.csv` e `Data/Files/secretos.csv`, mesmo que eles sejam excluídos ao executar o projeto e realizar o cadastro e geração da lista de amigos secretos eles seram salvos nessas pastas.

2. Procurei manter a divisão dos nomes e emails usando `;` confome instruções na descrição do enunciado. 

3. Fiz a criação de pastas visando uma organização na estrutura do projeto, cada pasta representa a definição de cada uma das classes utilizadas:

- <b>Communications</b>: nesta pasta é armazenada a classe `Comunicacao` que possui métodos responsáveis pela regra de negócio da aplicação.
- <b>Models</b>: essa pasta é responsável por armazenar a classe de modelo `Amigo`, o objetivo é representar a entidade Amigo.
- <b>Data</b>: essa pasta é responsável por armazenar a classe que atua com a persistência de dados, foi criada a classe `Persistencia` com esse propósito.
- <b>Data/Files</b>: essas pastas armazenam os arquivos `amigos.csv` que definem a lista dos amigos e `secretos.csv` que geram os pares de amigos secretos.
- <b>Utils</b>: esta pasta contem a classe `Utilitario`, o seu objetivo é definir métodos auxiliares para as validações das propriedades.

## ✔️ Recursos Utilizados

- ``.NET 6.0``
- ``C#``

## :floppy_disk: Clonar Repositório

```git clone https://github.com/PauloAlves8039/academia-dotnet-desafio-amigo-secreto.git```

## Author
:boy: [Paulo Alves](https://github.com/PauloAlves8039)
