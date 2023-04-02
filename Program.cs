decimal valorcompra, valorpago, valortroco;

Console.WriteLine("...Troco...\n");

Console.Write("Valor da compra (R$)...:\n");
Console.ForegroundColor = ConsoleColor.Blue;
valorcompra = Convert.ToDecimal(Console.ReadLine());

Console.ResetColor();

Console.Write("Valor pago (R$)...: ");
Console.ForegroundColor = ConsoleColor.DarkGreen;
valorpago = Convert.ToDecimal(Console.ReadLine());

Console.ResetColor();

valortroco = valorpago - valorcompra;

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"\nTroco: {valortroco:c}");

Console.ResetColor();
