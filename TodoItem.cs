using System;

public class TodoItem
{
    // Id : chave exclusiva em um banco de dados relacional 
    public long Id { get; set; }
    public string Name { get; set; }
    public bool IsComplete { get; set; }
}

// Model : é um conjunto de classes que representam os dados gerenciados pelo aplicativo.
// As classes de Model podem ir em qualquer lugar no projeto, mas a Models pasta é usada pela Convenção.

