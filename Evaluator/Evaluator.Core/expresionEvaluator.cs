namespace Evaluator.Core;

public class ExpresionEvaluator
{
    public static double Evaluate(string infix)
    {
        var postfix = InfixToPostfix(infix);
        var listNew = new List<string>(); // this is for numbers with more than one digit

        return Calculate(postfix);
    }

    private static string InfixToPostfix(string infix)
    {
        var stack = new Stack<char>();
        var postfix = string.Empty;
        foreach (var item in infix)
        {
            if (IsOperator(item))
            {
                if (item == ')')
                {
                    do
                    {
                        postfix += stack.Pop();
                    } while (stack.Peek() != '(');
                    stack.Pop();
                }
                else
                {
                    if (stack.Count > 0)
                    {
                        if (PriorityInfix(item) > PriorityStack(stack.Peek()))
                        {
                            stack.Push(item);
                        }
                        else
                        {
                            postfix += stack.Pop();
                            stack.Push(item);
                        }
                    }
                    else
                    {
                        stack.Push(item);
                    }
                }
            }
            else
            {
                postfix += item;
            }
        }
        while (stack.Count > 0)
        {
            postfix += stack.Pop();
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

    private static double Calculate(string postfix)
    {
        var stack = new Stack<double>();
        foreach (char item in postfix)
        {
            if (IsOperator(item))
            {
                var op2 = stack.Pop();
                var op1 = stack.Pop();
                stack.Push(Calculate(op1, item, op2));
            }
            else
            {
                stack.Push(Convert.ToDouble(item.ToString()));
            }
        }
        return stack.Peek();
    }

    private static double Calculate(double op1, char item, double op2) => item switch
    {
        '*' => op1 * op2,
        '/' => op1 / op2,
        '+' => op1 + op2,
        '-' => op1 - op2,
        '^' => Math.Pow(op1, op2),
        _ => throw new Exception("Invalid expresion"),
    };
}