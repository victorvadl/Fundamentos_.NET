using Fundamentos.Common.Models;

// Instancia da classe pessoa
Pessoa pessoa1 = new Pessoa("Diana", 28);

// Ações da pessoa
pessoa1.Correr();
pessoa1.Apresentar();
pessoa1.Parar();
pessoa1.Apresentar();


Calculadora calc = new Calculadora();
calc.Somar(3,5);
calc.Dividir(10,2);
calc.Multiplicar(10,5);
calc.Subtrair(50,20);
calc.Potencia(2,10);
calc.Seno(35);
calc.Coseno(35);
calc.Tangente(35);
calc.RaizQuadrada(9);





List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");


Console.WriteLine("Percorrendo a lista com o FOR");
for(int contador = 0; contador < listaString.Count; contador++)
{
  Console.WriteLine(listaString[contador]);
}

Console.WriteLine("Percorrendo a lista com o FOREACH");
foreach(string valor in listaString)
{
  Console.WriteLine(valor);
}



// int[] arrayInteiros = new int[3];

// arrayInteiros[0] = 71;
// arrayInteiros[1] = 1;
// arrayInteiros[2] = 73;

// // Percorrendo o Array com FOR
// Console.WriteLine("Percorrendo o Array com o FOR");
// for(int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//   Console.WriteLine(arrayInteiros[contador]);
// }

// int[] arrayInteirosDobrado = new int[arrayInteiros.Length *2];
// Array.Copy(arrayInteiros,arrayInteirosDobrado,arrayInteiros.Length);

// Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

// // Percorrendo o Array com o FOREACH
// Console.WriteLine("Percorrendo o Array com o FOREACH");
// foreach(int valor in arrayInteiros)
// {
//   Console.WriteLine(valor);
// }



// string? opcao = "";
// string? opcaoCadastro = "";
// bool exibirMenu = true;

// while(exibirMenu)
// {
//   if (opcao == "")
//   {
//     Console.Clear();
//     Console.WriteLine("Digite a sua opção:");
//     Console.WriteLine("1 - Cadastrar cliente");
//     Console.WriteLine("2 - Buscar cliente");
//     Console.WriteLine("3 - Apagar cliente");
//     Console.WriteLine("4 - Encerrar");
//   }
  
//   opcao = Console.ReadLine();

//   switch(opcao)
//   {
//     case "1":
//       Console.Clear();
//       Console.WriteLine("Você selecionou a opção de Cadastro de cliente");
//       // Menu secundário para a opção 1
//       while (exibirMenu)
//       {
//         Console.WriteLine("Digite a sua opção:");
//         Console.WriteLine("1 - Voltar ao menu anterior");
//         Console.WriteLine("2 - Encerrar");
//         opcaoCadastro = Console.ReadLine();
//         switch (opcaoCadastro)
//         {
//           case "1":
//             // Volta para o menu anterior
//             break;
//           case "2":
//             Console.WriteLine("Encerrando o programa...");
//             exibirMenu = false;
//             //Enviroment.Exit(0);
//             break;
//           default:
//             Console.Clear();
//             Console.WriteLine("Você digitou uma opção inválida");
//             break;
//         }
//         if (opcaoCadastro =="1")
//         {
//           opcao = "";
//           break;
//         }
//       }
//       break;

//     case "2":
//       Console.Clear();
//       Console.WriteLine("Você selecionou a opção de Busca de cliente");
//       // Menu secundário para a opção 2
//       while (exibirMenu)
//       {
//         Console.WriteLine("Digite a sua opção:");
//         Console.WriteLine("1 - Voltar ao menu anterior");
//         Console.WriteLine("2 - Encerrar");
//         opcaoCadastro = Console.ReadLine();
//         switch (opcaoCadastro)
//         {
//           case "1":
//             // Volta para o menu anterior
//             break;
//           case "2":
//             Console.WriteLine("Encerrando o programa...");
//             exibirMenu = false;
//             break;
//           default:
//             Console.Clear();
//             Console.WriteLine("Você digitou uma opção inválida");
//             break;
//         }
//         if (opcaoCadastro =="1")
//         {
//           opcao = "";
//           break;
//         }
//       }
//       break;

//     case "3":
//       Console.Clear();
//       Console.WriteLine("Você selecionou a opção de Apagar cliente");
//       // Menu secundário para a opção 1
//       while (exibirMenu)
//       {
//         Console.WriteLine("Digite a sua opção:");
//         Console.WriteLine("1 - Voltar ao menu anterior");
//         Console.WriteLine("2 - Encerrar");
//         opcaoCadastro = Console.ReadLine();
//         switch (opcaoCadastro)
//         {
//           case "1":
//             // Volta para o menu anterior
//             break;
//           case "2":
//             Console.WriteLine("Encerrando o programa...");
//             exibirMenu = false;
//             break;
//           default:
//             Console.Clear();
//             Console.WriteLine("Você digitou uma opção inválida");
//             break;
//         }
//         if (opcaoCadastro =="1")
//         {
//           opcao = "";
//           break;
//         }
//       }
//       break;

//     case "4":
//       Console.Clear();
//       Console.WriteLine("Você selecionou a opção de Encerrar");
//       Console.WriteLine("Encerrando o programa...");
//       exibirMenu = false;
//       break;

//     default:
//       Console.Clear();
//       Console.WriteLine("Você digitou uma opção inválida");
//       break;
//   }
// }
// Console.WriteLine("Programa foi encerrado");




















// int numero = 10;

// for (int i = 0; i <= numero; i++)
// {
//   Console.WriteLine($"{i +1}ª Execução: {numero} x {i} = {i * numero}");
// }

// int contador = 0;

// do
// {
//   Console.WriteLine($"{contador +1}ª Execução: {numero} x {contador} = {numero *contador}");
//   contador++;
// } while (contador <= 10);



// while (contador <= 10)
// {
//   Console.WriteLine($"{contador +1}ª Execução: {numero} x {contador} = {numero *contador}");
//   contador++;
// }

// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();

// switch (letra)
// {
//   case "a":
//   case "e":
//   case "i":
//   case "o":
//   case "u":
//     Console.WriteLine("Vogal");
//     break;

//   default:
//     Console.WriteLine("Não é uma vogal");
//     break;
// }