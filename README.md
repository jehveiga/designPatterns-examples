# Design Patterns em C#

Este repositório contém exemplos práticos de **Design Patterns** implementados em **C# (.NET 8)**, organizados em três categorias principais:

* **Creational Design Patterns** (Padrões Criacionais)
* **Structural Design Patterns** (Padrões Estruturais)
* **Behavioral Design Patterns** (Padrões Comportamentais)

O objetivo é servir como material de estudo e também como base de consulta para aplicar os padrões em futuros projetos.
Referência utilizada: [Refactoring Guru](https://refactoring.guru/)

---

## 📖 O que são Design Patterns?

**Design Patterns** são soluções reutilizáveis para problemas comuns que surgem durante o desenvolvimento de software.
Eles não são código pronto, mas sim **modelos de projeto** que ajudam a criar sistemas mais organizados, reutilizáveis, escaláveis e de fácil manutenção.

---

## 🏗️ Padrões Criacionais (Creational Design Patterns)

Os **padrões criacionais** lidam com a forma de **instanciar objetos**, tornando o código mais flexível e independente de implementações concretas.

* **Singleton**

  * **Problema:** Garantir que exista apenas uma instância de uma classe e fornecer um ponto global de acesso a ela.
  * **Exemplo de uso:** Configurações globais, gerenciadores de cache, conexões a banco de dados.

* **Factory Method**

  * **Problema:** Criar objetos sem expor a lógica de criação ao cliente, deixando que subclasses decidam qual classe instanciar.
  * **Exemplo de uso:** Criação de diferentes tipos de documentos, produtos, logs.

* **Abstract Factory**

  * **Problema:** Criar famílias de objetos relacionados sem acoplar o código às classes concretas.
  * **Exemplo de uso:** UI multiplataforma (Windows, Mac, Linux) com diferentes implementações de botões e checkboxes.

* **Builder**

  * **Problema:** Construir objetos complexos passo a passo, sem depender da representação final.
  * **Exemplo de uso:** Montagem de relatórios, objetos imutáveis, configurações complexas.

* **Prototype**

  * **Problema:** Criar cópias de objetos existentes sem acoplar o código às classes deles.
  * **Exemplo de uso:** Clonar objetos em memória, duplicação de configurações.

---

## 🧩 Padrões Estruturais (Structural Design Patterns)

Os **padrões estruturais** tratam da **composição de classes e objetos**, ajudando a formar estruturas maiores e flexíveis.

* **Adapter**

  * **Problema:** Permitir que interfaces incompatíveis trabalhem juntas.
  * **Exemplo de uso:** Conectar sistemas legados a novas APIs.

* **Bridge**

  * **Problema:** Separar abstração da implementação, permitindo variar ambos independentemente.
  * **Exemplo de uso:** Diferentes dispositivos de controle remoto (TV, rádio) com diferentes implementações.

* **Composite**

  * **Problema:** Tratar objetos individuais e composições de objetos de forma uniforme.
  * **Exemplo de uso:** Estruturas de árvore como sistemas de arquivos.

* **Decorator**

  * **Problema:** Adicionar responsabilidades a objetos dinamicamente sem modificar sua estrutura.
  * **Exemplo de uso:** Adicionar filtros em streams, funcionalidades extras em objetos.

* **Facade**

  * **Problema:** Fornecer uma interface simples para um subsistema complexo.
  * **Exemplo de uso:** API de inicialização de sistemas complexos.

* **Flyweight**

  * **Problema:** Reduzir o consumo de memória compartilhando objetos comuns em grande quantidade.
  * **Exemplo de uso:** Renderização de caracteres em editores de texto.

* **Proxy**

  * **Problema:** Fornecer um substituto ou marcador para controlar acesso a outro objeto.
  * **Exemplo de uso:** Lazy loading, controle de acesso, proxy remoto.

---

## 🎭 Padrões Comportamentais (Behavioral Design Patterns)

Os **padrões comportamentais** focam na **comunicação entre objetos** e na maneira como responsabilidades são distribuídas.

* **Chain of Responsibility**

  * **Problema:** Evitar acoplamento do remetente ao receptor, passando a solicitação por uma cadeia de manipuladores.
  * **Exemplo de uso:** Pipelines de validação, tratamento de requisições.

* **Command**

  * **Problema:** Encapsular uma solicitação como objeto, permitindo desfazer/redo e filas de operações.
  * **Exemplo de uso:** Operações de editor (Ctrl+Z), sistemas de fila de tarefas.

* **Interpreter**

  * **Problema:** Definir gramática e interpretador para linguagens específicas.
  * **Exemplo de uso:** Avaliação de expressões matemáticas, linguagens de script.

* **Iterator**

  * **Problema:** Percorrer coleções sem expor sua estrutura interna.
  * **Exemplo de uso:** Iterar listas, árvores, coleções personalizadas.

* **Mediator**

  * **Problema:** Reduzir dependência direta entre objetos, centralizando comunicação em um mediador.
  * **Exemplo de uso:** Chats, sistemas de controle de tráfego aéreo.

* **Memento**

  * **Problema:** Capturar e restaurar o estado interno de um objeto sem expor sua implementação.
  * **Exemplo de uso:** Funcionalidade de "desfazer" em editores.

* **Observer**

  * **Problema:** Notificar múltiplos objetos sobre mudanças no estado de outro objeto.
  * **Exemplo de uso:** Eventos em UI, listeners, notificações push.

* **State**

  * **Problema:** Permitir que um objeto altere seu comportamento quando seu estado interno muda.
  * **Exemplo de uso:** Máquinas de venda, ciclo de vida de pedidos.

* **Strategy**

  * **Problema:** Definir uma família de algoritmos e torná-los intercambiáveis.
  * **Exemplo de uso:** Algoritmos de ordenação, cálculo de frete.

* **Template Method**

  * **Problema:** Definir o esqueleto de um algoritmo deixando que subclasses implementem partes específicas.
  * **Exemplo de uso:** Processamento de arquivos, workflows padronizados.

* **Visitor**

  * **Problema:** Permitir adicionar operações em objetos sem alterar suas classes.
  * **Exemplo de uso:** Árvores de sintaxe, exportação de estruturas para diferentes formatos.

---

## 📂 Estrutura do Projeto

```
/DesignPatterns.Examples
  ├── README.md
  ├── DesignPatterns.Examples.Api
  ├── DesignPatterns.Examples.Application
  ├── DesignPatterns.Examples.Core
  ├── DesignPatterns.Examples.Infrastructure
    ├── Creational
    ├── Structural
    ├── Behavioral

```

Cada diretório contém os exemplos em **C#** de cada padrão.

---

## 🚀 Como usar este repositório

1. Clone o repositório:

   ```bash
   git clone https://github.com/jehveiga/designPatterns-examples.git
   ```

2. Abra no **Visual Studio** ou **Rider**.

3. Explore cada pasta de padrões e rode os exemplos.

---

## 📚 Referências

* [Refactoring Guru](https://refactoring.guru/design-patterns)
* *Design Patterns: Elements of Reusable Object-Oriented Software* (Gang of Four - GoF)

---
