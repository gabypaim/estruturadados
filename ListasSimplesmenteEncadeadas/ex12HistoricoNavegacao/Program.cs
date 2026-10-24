using Fsg.EstruturaDados;

HistoricoNavegacao historico = new HistoricoNavegacao();

historico.Visitar(1);
historico.Visitar(2);
historico.Visitar(3);

Console.WriteLine($"Voltar: {historico.Voltar()}");

historico.Visitar(4);

Console.WriteLine($"Voltar: {historico.Voltar()}");
Console.WriteLine($"Voltar: {historico.Voltar()}");
Console.WriteLine($"Voltar: {historico.Voltar()}");

Console.WriteLine($"Página atual: {historico.PaginaAtual()}");

//Inserir no início e remover do início são operações O(1),
//porque não precisamos percorrer a lista para encontrar a posição. Basta atualizar as referências dos nós.

//A estrutura de dados construída é uma pilha (Stack), que funciona pelo princípio LIFO,
//ou seja, o último elemento que entra é o primeiro que sai.
