# 🧪 Projeto de Testes Automatizados - OrangeHRM

Este projeto foi desenvolvido como parte de uma atividade acadêmica para demonstrar o uso de **testes automatizados com Playwright e NUnit** em C#. Utilizamos o site demo do OrangeHRM para simular testes de sistema e incluímos também testes unitários para lógica de negócios.

## 📌 Tecnologias Utilizadas

- [.NET 8](https://dotnet.microsoft.com/en-us/download)
- [NUnit](https://nunit.org/)
- [Microsoft Playwright para .NET](https://playwright.dev/dotnet/)
- [Playwright Test Generator CLI](https://playwright.dev/dotnet/docs/cli)
- C#
- Git + GitHub

---

## 🚀 Como Rodar o Projeto

### 🔧 Pré-requisitos

Antes de tudo, certifique-se de que você possui:

- [.NET SDK 8.0 ou superior](https://dotnet.microsoft.com/download)
- Git instalado
- Um editor como [Visual Studio 2022+](https://visualstudio.microsoft.com/) ou [Rider](https://www.jetbrains.com/rider/)

### 📥 Clonando o Repositório

```bash
git clone https://github.com/seu-usuario/seu-repositorio.git
cd seu-repositorio
```

📦 Instalando Dependências

```bash
dotnet restore
```
🧪 Instalando o Playwright
```bash
# Instale os navegadores e recursos do Playwright
playwright install
```
⚠️ Se não tiver o CLI do Playwright:

```bash
dotnet tool install --global Microsoft.Playwright.CLI
```
🧷 Estrutura do Projeto
```bash
📁 OrangeHRM
├── 📁 Pages                 # Page Object Models (Login, Dashboard)
├── 📁 Utils                 # Classes utilitárias (ConversorDeData, ValidadorDeSenha)
├── 📁 Tests
│   ├── 📁 System            # Testes funcionais com Playwright
│   └── 📁 Unit              # Testes unitários com NUnit
├── 📄 OrangeHRM.csproj
└── README.md
```
🎯 Funcionalidades Implementadas
✅ Testes Funcionais (com Playwright)
Acesso à página de login do OrangeHRM

Preenchimento de credenciais válidas

Verificação de redirecionamento para o Dashboard após login

Verificação da visibilidade de elementos no dashboard (ex: "Time at Work", "Quick Launch")

✅ Testes Unitários
ConversorDeData: converte datas para formatos específicos

ValidadorDeSenha: valida critérios de senha forte (mínimo de 8 caracteres, número, maiúscula, minúscula, símbolo)

▶️ Executando os Testes
Testes Unitários
```bash
dotnet test --filter TestCategory=Unit
```
Ou simplesmente:

```bash
dotnet test
```
Testes de Sistema (Playwright)
Certifique-se que os navegadores do Playwright estão instalados:

```bash
playwright install
```
Depois execute normalmente:

```bash
dotnet test
```
Os testes de sistema abrirão o navegador Chrome (modo não-headless por padrão) e executarão ações reais no site.
