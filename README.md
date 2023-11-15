<h1 align="center">Academia .NET - Desafio Amigo Secreto</h1>

## :computer: Projeto

Repositório com projeto `Console Application` usando a linguagem `C#` para gerenciar lista de amigos secretos, este projeto tem com propósito realizar o cadastro, exibição da lista de amigos e formar os pares do amigo secreto. O desafio foi proposto durante a Academia .NET ministrada pela `Universidade Franciscana - UFN`.

## :page_facing_up: Desafio

[Descrição do Desafio](https://github.com/ricardosma/academia_DotNet_5/blob/main/anotacoesAlexandre/aulas.md)

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
- ``C#``

## :floppy_disk: Clonar Repositório

```git clone https://github.com/PauloAlves8039/academia-dotnet-desafio-amigo-secreto.git```

## :camera: Screenshot

<p align="center"> <img src="https://github.com/PauloAlves8039/academia-dotnet-desafio-amigo-secreto/blob/master/AmigoSecreto/Academia.DotNet.AmigoSecreto/assets/images/screenshot.PNG" /></p>


## Author
:boy: [Paulo Alves](https://github.com/PauloAlves8039)
