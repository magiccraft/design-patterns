internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Interpreter Pattern Örneği ===");

        // Örnek İfade: (10 + 5) * (20 - 15)
        // Sözdizimi Ağacı (Abstract Syntax Tree - AST) oluşturuluyor:
        IExpression num10 = new NumberExpression(10);
        IExpression num5 = new NumberExpression(5);
        IExpression addExp = new AddExpression(num10, num5); // (10 + 5) = 15

        IExpression num20 = new NumberExpression(20);
        IExpression num15 = new NumberExpression(15);
        IExpression subExp = new SubtractExpression(num20, num15); // (20 - 15) = 5

        IExpression syntaxTree = new MultiplyExpression(addExp, subExp); // 15 * 5 = 75

        Console.WriteLine("Yorumlanacak İfade Ağacı: ((10 + 5) * (20 - 15))");
        int result = syntaxTree.Interpret();
        Console.WriteLine($"İfadenin Hesaplanmış Sonucu: {result}");
    }
}
