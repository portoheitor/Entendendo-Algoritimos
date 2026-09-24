# 📘 Entendendo Algoritmos

> Implementações, testes e anotações práticas baseadas no livro **"Entendendo Algoritmos: Um Guia Ilustrado para Programadores e Outros Curiosos"**, de Aditya Y. Bhargava — construídas do zero em C#, com foco em preparação para entrevistas técnicas.

![C#](https://img.shields.io/badge/C%23-.NET%2010-512BD4?logo=csharp&logoColor=white)
![xUnit](https://img.shields.io/badge/Tests-xUnit-5C2D91?logo=nunit&logoColor=white)
![Status](https://img.shields.io/badge/Status-Em%20andamento-yellow)

## 🎯 Sobre este repositório

Estou estudando estruturas de dados e algoritmos do zero, capítulo a capítulo, com um objetivo bem claro: **desenvolver raciocínio lógico e me preparar para entrevistas técnicas**, documentando o processo pra transformar em conteúdo (vídeos) sobre minha jornada de aprendizado em programação.

Cada capítulo do livro vira um projeto isolado, com:

- 🧠 **Implementação do algoritmo** em C# idiomático (não pseudocódigo)
- ✅ **Testes unitários** cobrindo casos de borda (xUnit, padrão Arrange-Act-Assert)
- 🐳 Ambiente 100% reprodutível via **Dev Container**

## 📚 Progresso pelo livro

| # | Capítulo | Algoritmos | Status |
|---|----------|-----------|--------|
| 1 | Introdução a Algoritmos | Busca Binária (iterativa e recursiva) | ✅ Concluído |
| 2 | Ordenação por Seleção | Selection Sort, Arrays vs Listas Encadeadas | ✅ Concluído |
| 3 | Recursão | Fatorial, Fibonacci, pilha de chamadas | ✅ Concluído |
| 4 | Quicksort | Particionamento (esquema de Lomuto), dividir para conquistar | ✅ Concluído |
| 5 | Tabelas Hash | Funções hash, colisões | 🔜 Em andamento |
| 6 | Busca em Largura (BFS) | Grafos, caminho mínimo | ⬜ Planejado |
| 7 | Algoritmo de Dijkstra | Grafos com peso | ⬜ Planejado |
| 8 | Algoritmos Gulosos | Problema da mochila, NP-completude | ⬜ Planejado |
| 9 | Programação Dinâmica | Subsequência comum, mochila, memoization | ⬜ Planejado |
| 10 | K-Vizinhos Mais Próximos | Introdução a Machine Learning | ⬜ Planejado |
| 11 | Próximos Passos | Árvores, MapReduce, filtros de Bloom | ⬜ Planejado |

## 🗂️ Estrutura do repositório

```
Entendendo-Algoritimos/
├── Cap01_BuscaBinaria/                 # Busca Binária (iterativa e recursiva)
│   └── BinarySearch.cs
├── Cap01_BuscaBinaria.Tests/
│   ├── BinarySearchTests.cs
│   ├── BinarySearchRecursiveTests.cs
│   ├── BinarySearchTheoryTests.cs
│   └── BinarySearchRecursiveTheoryTests.cs
├── Cap02_OrdenacaoSelecao/             # Selection Sort
│   └── SelectionSort.cs
├── Cap02_OrdenacaoSelecao.Tests/
│   └── Cap02_OrdenacaoSelecaoTheoryTests.cs
├── Cap03_Recursao/                     # Fatorial e Fibonacci
│   └── Recursao.cs
├── Cap03_Recursao.Tests/
│   └── RecursaoTests.cs
├── Cap04_Quicksort/                    # Quicksort (particionamento de Lomuto)
│   └── Quicksort.cs
├── Cap04_Quicksort.Tests/
│   └── QuickSortTestes.cs
├── .devcontainer/                      # Ambiente de desenvolvimento isolado (Docker, .NET 10)
│   ├── devcontainer.json
│   └── Dockerfile
└── AlgoritmosInterview.sln
```

Cada capítulo novo segue exatamente esse padrão: `CapXX_NomeDoTema/` + `CapXX_NomeDoTema.Tests/`.

## 🚀 Como rodar

Este projeto usa **Dev Containers**, então todo o ambiente (SDK, ferramentas) já vem pronto — não precisa instalar .NET na sua máquina.

**Pré-requisitos:** Docker Desktop + VS Code com a extensão [Dev Containers](https://marketplace.visualstudio.com/items?itemName=ms-vscode-remote.remote-containers).

```bash
# Clone o repositório
git clone https://github.com/portoheitor/Entendendo-Algoritimos.git
cd Entendendo-Algoritimos

# Abra no VS Code
code .
```

No VS Code: `Ctrl+Shift+P` → **Dev Containers: Reopen in Container**.

### Rodando os testes

```bash
dotnet test
```

## 🧠 Metodologia de estudo

Cada capítulo segue o mesmo processo:

1. **Entender o conceito** — o que o livro explica, sem pular pra prática antes de fixar o "porquê"
2. **Implementar sozinho** — a lógica é sempre escrita à mão, sem código pronto, pra desenvolver raciocínio real
3. **Cobrir com testes** — pensando nos casos de borda que entrevistadores testam de verdade, incluindo validação de exceções (fail-fast) quando a entrada foge do domínio do problema
4. **Revisar complexidade** — Big O de tempo e espaço, e variações que costumam aparecer em entrevista técnica
5. **Depurar com o debugger** — usar breakpoints e inspeção de variáveis para visualizar a execução de algoritmos recursivos na prática
6. **Documentar** — anotações que depois viram roteiro de vídeo

## 📎 Recursos

- 📖 Livro base: *Entendendo Algoritmos*, Aditya Y. Bhargava (Novatec)
- 🎥 Conteúdo em vídeo sobre essa jornada: *em breve*

## 📄 Licença

Este repositório contém código autoral de estudo e prática. O conteúdo teórico é baseado no livro citado, sem reprodução de texto original — apenas implementações próprias inspiradas nos conceitos apresentados.

---

*Repositório mantido por [Heitor Porto](https://github.com/portoheitor) como parte da jornada de aprendizado em desenvolvimento de software.*
