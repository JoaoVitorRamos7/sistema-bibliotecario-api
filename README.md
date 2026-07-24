# 📚 Sistema Bibliotecário API

API REST desenvolvida com **C#**, **ASP.NET Core** e **Entity Framework Core** para gerenciamento de uma biblioteca.

O projeto foi criado com o objetivo de praticar conceitos utilizados no desenvolvimento Back-end, como arquitetura em camadas, persistência de dados, relacionamentos entre entidades e boas práticas de programação, simulando um cenário próximo ao encontrado em aplicações comerciais.

---

# 🚀 Tecnologias

Este projeto foi desenvolvido utilizando:

- C#
- .NET 8
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- Swagger / OpenAPI
- Git
- GitHub

---

# 📖 Sobre o projeto

A API permite gerenciar os principais recursos de uma biblioteca por meio de uma arquitetura organizada e desacoplada.

Durante o desenvolvimento foram aplicados conceitos fundamentais do ecossistema .NET, como:

- Arquitetura em Camadas
- Repository Pattern
- Injeção de Dependência (Dependency Injection)
- Entity Framework Core
- Migrations
- DTOs
- Relacionamentos entre entidades
- Persistência de Dados
- Boas práticas de desenvolvimento

O objetivo é construir uma API escalável, organizada e de fácil manutenção, seguindo padrões utilizados no mercado.

---

# ✨ Funcionalidades

Atualmente a API possui suporte para:

- Cadastro de Autores
- Cadastro de Livros
- Cadastro de Usuários
- Cadastro de Empréstimos
- CRUD completo das entidades
- Relacionamentos entre entidades
- Persistência em banco de dados SQL Server
- Documentação automática com Swagger

---

# 🏗 Arquitetura

O projeto segue uma arquitetura em camadas para facilitar a organização do código e a separação de responsabilidades.

```
Controllers
        │
        ▼
Repositories
        │
        ▼
Entity Framework Core
        │
        ▼
SQL Server
```

Estrutura de pastas:

```
BibliotecaAPI/
│
├── Controllers/
├── Data/
├── DTOs/
├── Interfaces/
├── Models/
├── Repositories/
├── Migrations/
├── Program.cs
└── appsettings.json
```

---

# 🗄 Modelo de Dados

O sistema possui as seguintes entidades:

- Autor
- Livro
- Usuário
- Empréstimo

Relacionamentos:

```
Autor (1)
    │
    └──────< Livro (N)

Usuário (1)
    │
    └──────< Empréstimo (N)

Livro (1)
    │
    └──────< Empréstimo (N)
```

---

# 📷 Preview

## Swagger

Em breve

---

# 🚀 Como executar

Clone o repositório

```bash
git clone https://github.com/SEU-USUARIO/sistema-bibliotecario-api.git
```

Entre na pasta

```bash
cd sistema-bibliotecario-api
```

Restaure os pacotes

```bash
dotnet restore
```

Configure a Connection String no arquivo:

```
appsettings.json
```

Execute as migrations

```bash
dotnet ef database update
```

Inicie a aplicação

```bash
dotnet run
```

A documentação estará disponível em:

```
https://localhost:xxxx/swagger
```

---

# 📚 Conceitos aplicados

Durante o desenvolvimento deste projeto foram praticados conceitos como:

- Programação Orientada a Objetos
- Princípios SOLID
- Repository Pattern
- Dependency Injection
- Entity Framework Core
- Migrations
- Relacionamentos 1:N
- LINQ
- DTOs
- API REST
- CRUD
- Swagger
- Tratamento de erros
- Organização em camadas

---

# 📌 Próximas melhorias

- [ ] Autenticação com JWT
- [ ] Autorização por perfis
- [ ] Paginação
- [ ] Filtros de pesquisa
- [ ] Upload de imagens para livros
- [ ] Testes Unitários
- [ ] Docker
- [ ] Deploy em nuvem
- [ ] Logs da aplicação
- [ ] Cache para consultas

---

# 👨‍💻 Autor

**João Vitor Ramos**

GitHub:
https://github.com/JoaoVitorRamos7

LinkedIn:
https://www.linkedin.com/in/joao-vitor-ramos-de-almeida/

Email:
joaovitorramosdealmeida55@gmail.com

---

# 📄 Licença

Este projeto foi desenvolvido para fins de estudo, aprendizado e composição de portfólio.