namespace Evaluator.Core;

public class expresionEvaluator
{
    public static double Evaluate(string infix)
    {
        var postfix = InfixToPostfix(infix);

        return Calculate(postfix);
    }

    private static object InfixToPostfix(string infix)
    {
        var stack = new Stack<char>();
        var postfix = string.Empty;
        foreach (var item in postfix)
        {
            if (IsOperator(item))
            {
                if (stack.Count > 0)
                {

                }
                else
                {
                    stack.Push(item);
                }
            }
            else
            {
                postfix += item;
            }
        }
        return postfix;
    }

    private static bool IsOperator(char item) => item is '^' or '/' or '*' or '%' or '+' or '-' or '(' or ')';

    private static int PriorityInfix(char op) => op switch
    {
        '+' or '-' => 1,
        '/' or '*' or '%' => 2,
        '^' => 4,
        '(' => 5,
        _ => throw new Exception("Invalid expresion"),
    };

    private static int PriorityStack(char op) => op switch
    {
        '+' or '-' => 1,
        '/' or '*' or '%' => 3,
        '^' => 3,
        '(' => 0,
        _ => throw new Exception("Invalid expresion"),
    };

    private static double Calculate(object postfix)
    {
        throw new NotImplementedException();
    }
}