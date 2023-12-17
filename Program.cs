using Exceções_e_Coleções.Model;
using Propriedades__Métodos_e_Construtores.Model;
using System.Globalization; 


Dictionary<string,string> candidatos = new Dictionary<string, string>();

candidatos.Add("Nome:", "Leandresson");
candidatos.Add("Nome2:", "Yasmim");
candidatos.Add("Nome3:", "Ingrid");

 foreach(var item in candidatos){
     Console.WriteLine($"Chave {item.Key} tem o valor: {item.Value}");
 }

 candidatos.Remove("Nome:");

 foreach(var item in candidatos){
     Console.WriteLine($"Chave {item.Key} tem o valor: {item.Value}");
 }

// candidatos["Nome4:"]= "Leandresson - Foi adicionado";
// foreach(var item in candidatos)
// {
//     Console.WriteLine($"Chave {item.Key} e valor {item.Value}");
// }


// string chaves = "Nome2:";
// Console.WriteLine($"Verificação da existencia da chave {chaves}");

// if (candidatos.ContainsKey(chaves)){
//     Console.WriteLine($"Essa chave ja existe {chaves}");
// }else{
//     Console.WriteLine($"A chave não existe. Voce pode criar a chave {chaves}");
// }



















// Stack<int> pilha = new Stack<int>();

// pilha.Push(12);
// pilha.Push(10);
// pilha.Push(8);
// pilha.Push(6);



// foreach(int item in pilha){
//     Console.WriteLine(item);

// }

// Console.WriteLine($"O elemento removido foi: {pilha.Pop()}");

// foreach(int item in pilha){
//     Console.WriteLine(item);

// }

// pilha.Push(38);

// foreach(int item in pilha){
//     Console.WriteLine(item);

// }
























// Queue<int> fila = new Queue<int>();

// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);
// fila.Enqueue(10);
// fila.Enqueue(12);
// fila.Enqueue(14);

// foreach(int item in fila){
//     Console.WriteLine(item);
// }

// Console.WriteLine($"O elemento removido foi: {fila.Dequeue()}");

// foreach(int item in fila){
//     Console.WriteLine(item);
// }
// fila.Enqueue(16);
// foreach(int item in fila){
//     Console.WriteLine(item);
// }






















//new Excecao().Metodo1();












// try{

//     string[] linhas = File.ReadAllLines("Arquivos/arquivoleitura.txt");

//     foreach(string linha in linhas){
//     Console.WriteLine(linha);
// }
// //Abaixo estão as excessões que são mais comuns de serem lançadas.
// }catch(FileNotFoundException ex){
//     Console.WriteLine($"Ocorreu uma excessão. Arquivo não encontrado {ex.Message}");
// }catch (DirectoryNotFoundException ex){
//     Console.WriteLine($"Ocorreu uma excessão. Diretorio não encontrado {ex.Message}");
// }catch(Exception ex){
//     Console.WriteLine($"Ocorreu uma excessão genérica. {ex.Message}");
// }finally{//Independente de dar certo ou errado, o Finally vai ser executado.
//     Console.WriteLine($"Recomendamos reiniciar sua aplicação novamente");
// }