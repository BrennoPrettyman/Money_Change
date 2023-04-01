namespace Money_Change;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Console.WriteLine("Digite o Preço: ");
        Console.Write("R$ ");
        decimal compra = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine("Digite o Preço que irá pagar: ");
        Console.Write("R$ ");
        decimal venda = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine();

        decimal Troco = compra - venda;

        Console.WriteLine("Seu troco irá ser: ");
        Console.WriteLine($"R$: {Troco}");


    }
}
