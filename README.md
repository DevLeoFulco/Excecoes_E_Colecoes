# Manipulação de Exceções, Pilhas, Filas e Dicionários em C#

Este repositório apresenta códigos em C# que ilustram a manipulação de exceções, o uso de pilhas, filas e dicionários. Abaixo, discutiremos brevemente cada conceito e forneceremos exemplos práticos do código disponível.

## Exceções

As exceções são eventos imprevistos durante a execução do programa que podem interromper o fluxo normal. A classe `Excecao` neste código demonstra o tratamento de exceções por meio de uma pilha de chamadas de métodos.

```csharp
public void Metodo1()
{
    try
    {
        Metodo2();
    }
    catch (Exception)
    {
        Console.WriteLine("Exceção foi Tratada!");
    }
}

public void Metodo2()
{
    Metodo3();
}

public void Metodo3()
{
    Metodo4();
}

public void Metodo4()
{
    throw new Exception("Ocorreu uma Exceção!");
}
```

Neste exemplo, `Metodo4` lança uma exceção, e a pilha de chamadas de métodos mostra como a exceção é tratada nos métodos superiores.

## Dicionários

Dicionários em C# são estruturas de dados que armazenam pares chave-valor. O código utiliza a classe `Dictionary<string, string>` para representar candidatos.

```csharp
Dictionary<string, string> candidatos = new Dictionary<string, string>();

candidatos.Add("Nome:", "Leandresson");
candidatos.Add("Nome2:", "Yasmim");
candidatos.Add("Nome3:", "Ingrid");

foreach (var item in candidatos)
{
    Console.WriteLine($"Chave {item.Key} tem o valor: {item.Value}");
}

candidatos.Remove("Nome:");

foreach (var item in candidatos)
{
    Console.WriteLine($"Chave {item.Key} tem o valor: {item.Value}");
}
```

Este trecho destaca a adição, remoção e iteração sobre elementos em um dicionário.

## Pilhas

Uma pilha é uma coleção de elementos organizados em que o último elemento adicionado é o primeiro a ser removido. O código utiliza a classe `Stack<int>` para manipular uma pilha de números inteiros.

```csharp
Stack<int> pilha = new Stack<int>();

pilha.Push(12);
pilha.Push(10);
pilha.Push(8);
pilha.Push(6);

Console.WriteLine($"O elemento removido foi: {pilha.Pop()}");

pilha.Push(38);

foreach (int item in pilha)
{
    Console.WriteLine(item);
}
```

Esse exemplo demonstra como adicionar, remover elementos e iterar sobre uma pilha.

## Filas

Filas são estruturas de dados que seguem a ordem de chegada, onde o primeiro elemento adicionado é o primeiro a ser removido. O código utiliza a classe `Queue<int>` para manipular uma fila de números inteiros.

```csharp
Queue<int> fila = new Queue<int>();

fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);
fila.Enqueue(10);
fila.Enqueue(12);
fila.Enqueue(14);

Console.WriteLine($"O elemento removido foi: {fila.Dequeue()}");

fila.Enqueue(16);

foreach (int item in fila)
{
    Console.WriteLine(item);
}
```

Neste exemplo, é mostrado como adicionar, remover elementos e iterar sobre uma fila.

## Observações Importantes

- Personalize o código de acordo com os requisitos específicos do seu projeto.
  
- As manipulações de exceções, pilhas, filas e dicionários podem ser adaptadas e expandidas conforme necessário.

- Mantenha código limpo e legível, seguindo boas práticas de programação.

Este código serve como guia inicial para esses conceitos em C#. Sinta-se à vontade para adaptar e contribuir para este repositório!
