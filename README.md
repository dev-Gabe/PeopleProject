# 👥 PeopleProject - Sistema de Gerenciamento de Pessoas

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET 10](https://img.shields.io/badge/.NET%2010-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Status](https://img.shields.io/badge/Status-Conclu%C3%ADdo-brightgreen?style=for-the-badge)

Um sistema de console robusto e intuitivo desenvolvido em **C#** para o gerenciamento de dados cadastrais de pessoas, utilizando o CPF como identificador único. O projeto aplica conceitos de **Arquitetura em Camadas (Layered Architecture)** para garantir organização e manutenibilidade.

---

## 🚀 Funcionalidades

O sistema oferece um menu interativo com as seguintes operações:

| Operação | Descrição |
| :--- | :--- |
| **🔍 Consultar CPF** | Busca uma pessoa no sistema através do CPF e exibe seus detalhes (Nome, Idade, Cidade). |
| **📝 Cadastrar CPF** | Registra uma nova pessoa solicitando Nome, Cidade, Idade e CPF com validações em tempo real. |
| **🗑️ Deletar CPF** | Remove o registro de uma pessoa do sistema após confirmação do usuário. |
| **🚪 Sair** | Encerra a execução do sistema com segurança. |

---

## 🛠️ Tecnologias e Arquitetura

O projeto foi construído utilizando as tecnologias mais recentes do ecossistema .NET:

- **Linguagem:** C# 13
- **Framework:** .NET 10.0
- **Estrutura de Dados:** `Dictionary<string, People>` para buscas rápidas e eficientes.
- **Arquitetura:** Organizado em camadas para separação de responsabilidades:
  - `Data`: Gerenciamento e persistência em memória dos dados.
  - `Services`: Lógica de negócio (Cadastro, Consulta, Deleção e Validações).
  - `Models`: Definição das entidades do sistema.
  - `Functions`: Utilitários de formatação e interface de console.

---

## 📋 Regras de Negócio e Validações

Para garantir a integridade dos dados, o sistema implementa:

> [!IMPORTANT]
> **Validação de CPF:** O sistema exige exatamente 11 dígitos numéricos e solicita uma confirmação visual do CPF formatado (`000.000.000-00`) antes de prosseguir.

> [!TIP]
> **Validação de Idade:** Apenas idades entre 1 e 110 anos são aceitas, prevenindo erros de digitação comuns.

---

## 💻 Como Executar

### Pré-requisitos
- [.NET 10 SDK](https://dotnet.microsoft.com/download) instalado em sua máquina.

### Passo a Passo
1. **Clone o repositório ou extraia o arquivo:**
   ```bash
   git clone https://github.com/seu-usuario/PeopleProject.git
   cd PeopleProject
   ```

2. **Restaure as dependências:**
   ```bash
   dotnet restore
   ```

3. **Execute a aplicação:**
   ```bash
   dotnet run --project PeopleProject/PeopleProject.csproj
   ```

---

## 📂 Estrutura do Projeto

```text
PeopleProject/
├── Data/           # Armazenamento de dados (Dicionário em memória)
├── Models/         # Definição da struct People
├── Services/       # Lógica de Cadastro, Consulta, Deleção e Validação
├── Functions/      # Funções auxiliares de console e formatação
└── Program.cs      # Ponto de entrada e menu principal
```

---

## 👤 Autor

Desenvolvido com foco em aprendizado de arquitetura e lógica de programação em C#.

---
*Este README foi gerado automaticamente para documentar o projeto PeopleProject.*
