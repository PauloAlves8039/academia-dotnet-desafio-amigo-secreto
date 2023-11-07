<h1 align="center">Academia DotNet - Desafio Amigo Secreto</h1>

## :computer: Projeto

Repositório com desafio em C# para gerenciar lista de amigos secretos, este projeto tem com propósito realizar o cadastro, exibição da lista de amigos e formar os pares do amigo secreto. O desafio foi proposto durante a Academia DotNet ministrada pela `Universidade Franciscana - UFN`.

## :page_facing_up: Desafio

[Descrição do Desafio](https://github.com/ricardosma/academia_DotNet_5/blob/main/anotacoesAlexandre/aulas.md)

## :white_check_mark: Decisões Técnicas

Fiz a criação de pastas visando uma organização na estrutura do projeto, cada pasta represeta a definição de cada uma das classes utilizadas:

- <b>Communications</b>: nesta pasta é armazenada a classe `Comunicacao` que possui métodos responsáveis pela regra de negócio da aplicação.
- <b>Models</b>: essa pasta é responsável por armazenar as classes de modelo, nela foi criada a classe `Amigo`.
- <b>Data</b>: essa pasta é responsável por armazenar as classes que atuam com persistência de dados, foi criada a classe `Persistencia` para manipular os dados.
- <b>Files</b>: essa pasta armazena os arquivos `amigos.csv` que define a lista dos amigos e `secretos.csv` que geram os pares de amigos secretos.
- <b>Utils</b>: esta pasta contem a classe `Utilitario`, o seu objetivo é definir métodos auxiliares para as validações das propriedades.

## ✔️ Recursos Utilizados

- ``.NET 6.0``
- ``C#``

## :floppy_disk: Clonar Repositório

```git clone https://github.com/PauloAlves8039/academia-dotnet-exercicio-padel.git```

## Author
:boy: [Paulo Alves](https://github.com/PauloAlves8039)
