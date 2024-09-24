# Projeto CRUD de Clientes com ASP.NET Core Razor Pages, C#, MySQL e Docker

Este projeto é um simples sistema para gerenciar clientes, um CRUD (Criar, Ler, Atualizar, Deletar), desenvolvido utilizando ASP.NET Core Razor Pages, Bootstrap e MySQL, com as tabelas sendo gerenciadas pelo Entity Framework Core e o banco de dados rodando dentro de um container Docker.

<h3>
<img src="https://img.shields.io/badge/ASP.NET_Core-512BD4?style=for-the-badge&logo=dotnet&logoColor=white"/>
<img src="https://img.shields.io/badge/EntityFrameworkCore-512BD4?style=for-the-badge&logo=dotnet&logoColor=white"/>
<img src="https://img.shields.io/badge/MySQL-4479A1?style=for-the-badge&logo=mysql&logoColor=white"/>
<img src="https://img.shields.io/badge/Docker-2496ED?style=for-the-badge&logo=docker&logoColor=white"/>
<img src="https://img.shields.io/badge/Bootstrap-563D7C?style=for-the-badge&logo=bootstrap&logoColor=white"/>
<img src="https://img.shields.io/badge/Visual_Studio_Code-007ACC?style=for-the-badge&logo=visualstudiocode&logoColor=white"/>
</h3>

</br>
<p align="center">
  <img width="800" height="400" src="/ClientesApp/Assets/form.png">
</p>

# Passos para Rodar:
clonar o Repositório:
> git clone https://github.com/diego-roberto/tdsa-asp-net.git

executar o container da base de dados:
> docker-compose up -d

acessar deretório do projeto:
> cd ClientesApp

executar update de base de dados (criar tabelas):
> dotnet ef database update

executar projeto:
> dotnet run

acessar em:
> http://localhost:7154/Clientes


## Requisitos:
>Docker instalado
>

>.NET SDK 6.0 instalado para rodar a aplicação ASP.NET Core

>VS Code (ou outra IDE de sua preferência)


# Especificações do Desafio técnico:
### você deve criar um projeto em ASP.NET WebForms (c# ou vb.net)
- Projeto criado utilizando ASP.NET (C#)
> Microsoft.EntityFrameworkCore            6.0.16      6.0.16  
> Microsoft.EntityFrameworkCore.Tools      6.0.16      6.0.16  
> MySql.Data                               9.0.0       9.0.0   
> Pomelo.EntityFrameworkCore.MySql         6.0.2       6.0.2   

### Dois ou três forms, para executar o CRUD padrão ( incluir, listar, alterar e deletar)
- Utilizei o mesmo Form com uma Table abaixo, contendo os registros já cadastrados e botões para excluir ou editar cada.

### Tabela simples de banco de dados ( SQL Server ou outro )
 - Base de Dados utiliza MySQL 8.0 containerizado em Docker

### Entidade especificada:
- CLIENTE </br>
CLI_ID  (integer) </br>
CLI_NOME (varchar) </br>
CLI_DATANASCIMENTO (date) </br>
CLI_ATIVO (bit)

<p align="center">
  <img width="600" height="300" src="/ClientesApp/Assets/table_clientes.png">
</p>
