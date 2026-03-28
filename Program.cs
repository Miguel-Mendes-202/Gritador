Console.WriteLine("Digite o Que quiser e se tornara um grito! ");

String textoDoUsuario = Console.ReadLine()!;

String MensagemDeTexto = $" {textoDoUsuario}!".ToUpper();

Console.WriteLine(MensagemDeTexto);