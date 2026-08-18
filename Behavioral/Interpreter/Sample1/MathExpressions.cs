// Abstract Expression Interface
public interface IExpression
{
    int Interpret();
}

// Terminal Expression (Sonlandırıcı İfade - Doğrudan sayısal değeri tutar)
public class NumberExpression : IExpression
{
    private readonly int _number;

    public NumberExpression(int number)
    {
        _number = number;
    }

    public int Interpret() => _number;
}

// Non-Terminal Expression 1: Toplama İfadesi
public class AddExpression : IExpression
{
    private readonly IExpression _left;
    private readonly IExpression _right;

    public AddExpression(IExpression left, IExpression right)
    {
        _left = left;
        _right = right;
    }

    public int Interpret()
    {
        return _left.Interpret() + _right.Interpret();
    }
}

// Non-Terminal Expression 2: Çıkarma İfadesi
public class SubtractExpression : IExpression
{
    private readonly IExpression _left;
    private readonly IExpression _right;

    public SubtractExpression(IExpression left, IExpression right)
    {
        _left = left;
        _right = right;
    }

    public int Interpret()
    {
        return _left.Interpret() - _right.Interpret();
    }
}

// Non-Terminal Expression 3: Çarpma İfadesi
public class MultiplyExpression : IExpression
{
    private readonly IExpression _left;
    private readonly IExpression _right;

    public MultiplyExpression(IExpression left, IExpression right)
    {
        _left = left;
        _right = right;
    }

    public int Interpret()
    {
        return _left.Interpret() * _right.Interpret();
    }
}
