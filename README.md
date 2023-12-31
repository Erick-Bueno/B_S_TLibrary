# B_S_TLibrary
 biblioteca: https://www.nuget.org/packages/B_S_TLibrary/
# Árvore de Busca Binária (Versão 1.1)

Esta é a Versão 1.1 da Biblioteca de Árvore de Busca Binária em C# desenvolvida por Erick Bueno.

## Descrição

Esta biblioteca NuGet permite criar, manipular e realizar operações de busca em árvores de busca binária em C#. Você pode usar essa biblioteca para armazenar e buscar valores eficientemente em uma árvore binária.

## Funcionalidades

- Inserir valores na árvore de busca binária.
- Realizar buscas na árvore para encontrar um valor específico.


## Exemplo de Uso

Aqui está um exemplo simples de como usar esta biblioteca:

```csharp
using System;
using B_S_TLibrary;

class Program
{
    static void Main()
    {
        BinarySearchTree<int> tree = new BinarySearchTree<int>(1);
        tree.Insert(10);
        tree.Insert(5);
        tree.Insert(15);

       int searchValue = 1;
       if(arvore.find(searchValue) == null)
       {
            Console.WriteLine($"Valor {searchValue} não foi encontrado");
            return;
       }
       Console.WriteLine($"Valor {searchValue} foi encontrado");
    }
}
