# 📘 GrpcMsg

> Projeto base que demonstra integração com gRPC em .NET, com exemplos de mensagens, Serviços e comunicação entre microserviços.

![.NET](https://img.shields.io/badge/.NET‑8.0‑blueviolet?logo=dotnet)
![CSharp](https://img.shields.io/badge/C%23‑100%25‑blue?logo=csharp)
![Status](https://img.shields.io/badge/Status‑Ativo‑success)
![License](https://img.shields.io/badge/Licença‑MIT‑blue)

---

## 📖 Visão Geral

O projeto GrpcMsg tem como objetivo:

* Demonstrar como utilizar gRPC em projetos .NET para comunicação eficiente entre serviços.
* Mostrar casos de uso práticos de mensagens, streams, contratos `.proto`, e geração de código servidor/cliente.
* Servir de base para arquiteturas de microsserviços ou integrações de backend onde o desempenho e o design de APIs importam.

Ideal para desenvolvedores que querem:

* Entender como configurar e usar gRPC em .NET
* Migrar ou construir serviços que usam RPC em vez de apenas REST
* Ter um “template” de projeto pronto para comunicação entre microsserviços

---

## 🧩 Estrutura do Projeto

```mermaid
graph TD
    A[GrpcMsg] --> B[Protos]
    A --> C[Server]
    A --> D[Client]
    A --> E[Shared]
    A --> F[Program.cs (Server)]
    A --> G[Program.cs (Client)]
```

**Descrição das pastas:**

* `Protos` → arquivos `.proto` que definem as mensagens e serviços gRPC
* `Server` → implementação do servidor gRPC que expõe os serviços
* `Client` → implementação de um cliente gRPC que consome os serviços
* `Shared` → contratos comuns, modelos e utilitários reutilizados entre servidor/cliente

---

## 🧪 Tecnologias Utilizadas

* **.NET 8** — Plataforma moderna e performática para backend
* **gRPC** — Framework RPC open‑source de alto desempenho (potencialmente via HTTP/2)
* **Protocol Buffers (.proto)** — Definições de tipos de mensagem e serviço, geração de stubs
* **C#** — Linguagem principal de implementação
* Projeto de referência para comunicação eficiente entre componentes distribuídos

---

## ⚙️ Pré‑requisitos

Antes de executar o projeto localmente, garanta que você tem:

* ✅ [Visual Studio 2022](https://visualstudio.microsoft.com/) ou [VS Code](https://code.visualstudio.com/)
* ✅ [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
* ✅ Familiaridade básica com C# e com o conceito de Serviços, Cliente/Servidor
* ✅ (Opcional) Familiaridade com Protocol Buffers e geração de código

---

## 🚀 Como Executar Localmente

1. Clone este repositório:

   ```bash
   git clone https://github.com/thiagodsantana/GrpcMsg.git
   cd GrpcMsg
   ```
2. Abra as soluções ou projetos servidor e cliente na sua IDE preferida.
3. Execute primeiro o **Server**, depois o **Client**.
4. Observe os logs de requisição/resposta no cliente e no servidor para verificar a comunicação gRPC funcionando.
5. Explore os arquivos `.proto` na pasta `Protos` para entender os contratos de serviço e mensagem.

---

## 💡 Objetivo Educacional

Este projeto serve para:

* Fornecer uma base de estudo prática sobre gRPC e comunicação eficiente entre microserviços.
* Servir como template para times que desejam adotar RPC em projetos .NET.
* Facilitar workshops internos ou treinamentos sobre arquitetura distribuída, contratos fortes e serialização eficiente.

---

## 📚 Boas Práticas e Recomendações

* Use arquivos `.proto` bem definidos para separar contratos de implementação.
* Evite transportar cargas pesadas sem necessidade — gRPC + Protocol Buffers ajudam na serialização eficiente.
* Lembre‑se de configurar corretamente **HTTP/2**, autenticação/autorização e **interceptors** (se necessário) em um cenário de produção.
* Logue e monitore chamadas gRPC, incluindo latência e erros — em runtime distribuído isso importa muito.
* Considere fallback ou compatibilidade para clientes REST se houver interoperabilidade necessária.

---

## 🤝 Contribuindo

1. Faça um *fork* deste repositório.
2. Crie uma branch:

   ```bash
   git checkout ‑b feature/nova‑funcionalidade
   ```
3. Adicione exemplos (por exemplo: streaming, bidirecional, interceptors, autenticação) ou melhorias.
4. Faça commit:

   ```bash
   git commit ‑m "Adiciona funcionalidade X ao exemplo gRPC"
   ```
5. Envie para o seu fork:

   ```bash
   git push origin feature/nova‑funcionalidade
   ```
6. Abra um Pull Request para revisão e eventual merge.

---

## 🪪 Licença

Este projeto está sob a **Licença MIT** — livre para uso, estudo e modificação.

---

## ✉️ Contato

**Autor:** [Thiago D. Santana](https://github.com/thiagodsantana)
**LinkedIn:** [linkedin.com/in/thiagodsantana](https://linkedin.com/in/thiagodsantana)
**E‑mail:** [thiago.darley@gmail.com](mailto:thiago.darley@gmail.com)
