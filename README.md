# GrpcMsg - Cliente e Servidor

Solução de cliente e servidor gRPC desenvolvido em C#. O servidor disponibiliza dois serviços gRPC: um serviço de saudação e um serviço para envio de dados do usuário. O cliente se conecta ao servidor e realiza chamadas gRPC para esses serviços.

## Requisitos

Antes de executar este projeto, você precisa garantir que os seguintes requisitos estejam atendidos:

- .NET 6 ou superior instalado.

## Estrutura do Projeto

O projeto é composto por duas partes principais:

1. **Servidor gRPC**: Um servidor que implementa dois serviços gRPC:
   - **Greeter Service**: Serviço que envia uma saudação simples.
   - **Usuario Service**: Serviço que envia informações de um usuário (nome, e-mail, endereço).
   
2. **Cliente gRPC**: Um cliente que faz chamadas para o servidor gRPC e recebe as respostas.

## Como Executar

### 1. Executando o Servidor gRPC

1. **Clone este repositório** ou copie o código para o seu ambiente de desenvolvimento.
2. Abra um terminal no diretório onde o código do servidor está localizado e execute os seguintes comandos:

   - Restaure as dependências do servidor:
     ```bash
     dotnet restore
     ```

   - Compile e execute o servidor:
     ```bash
     dotnet run
     ```

   - O servidor gRPC estará rodando em `https://localhost:7044`.

   - Você deve ver a mensagem:
     ```
     Servidor gRPC em execução.
     ```

### 2. Executando o Cliente gRPC

1. **Clone este repositório** ou copie o código do cliente para o seu ambiente de desenvolvimento.
2. Abra um terminal no diretório onde o código do cliente está localizado e execute os seguintes comandos:

   - Restaure as dependências do cliente:
     ```bash
     dotnet restore
     ```

   - Compile e execute o cliente:
     ```bash
     dotnet run
     ```

   - O cliente fará chamadas para o servidor gRPC e exibirá as respostas.
