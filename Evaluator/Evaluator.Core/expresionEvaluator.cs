namespace Evaluator.Core;

using System.Globalization;

public class ExpresionEvaluator
{
    public static double Evaluate(string infix)
    {
        var infixElements = Elements(infix);
        var postfixElements = InfixToPostfix(infixElements);
        return Calculate(postfixElements);
    }

    private static List<string> Elements(string infix)
    {
        var elements = new List<string>();
        var currentNumber = string.Empty;

        for (int i = 0; i < infix.Length; i++)
        {
            var item = infix[i];
            if (char.IsDigit(item) || item == '.')
            {
                currentNumber += item;
            }
            else if (IsOperator(item))
            {
                if (!string.IsNullOrEmpty(currentNumber))
                {
                    elements.Add(currentNumber);
                    currentNumber = string.Empty;
                }
                elements.Add(item.ToString());
            }
        }
        if (!string.IsNullOrEmpty(currentNumber))
        {
            elements.Add(currentNumber);
        }
        return elements;
    }

    private static List<string> InfixToPostfix(List<string> infixElements)
    {
        var stack = new Stack<string>();
        var postfix = new List<string>();

        foreach (var item in infixElements)
        {
            if (IsOperator(item))
            {
                if (item == ")")
                {
                    while (stack.Count > 0 && stack.Peek() != "(")
                    {
                        postfix.Add(stack.Pop());
                    }
                    if (stack.Count > 0) stack.Pop();
                }
                else
                {
                    while (stack.Count > 0 && PriorityStack(stack.Peek()[0]) >= PriorityInfix(item[0]))
                    {
                        if (stack.Peek() == "(") break;
                        postfix.Add(stack.Pop());
                    }
                    stack.Push(item);
                }
            }
            else
            {
                postfix.Add(item);
            }
        }
        while (stack.Count > 0)
        {
            postfix.Add(stack.Pop());
        }

        return postfix;
    }

    private static bool IsOperator(string item) => item.Length == 1 && IsOperator(item[0]);

    private static bool IsOperator(char item) => item is '^' or '/' or '*' or '%' or '+' or '-' or '(' or ')';

    private static int PriorityInfix(char op) => op switch
    {
        '+' or '-' => 1,
        '/' or '*' or '%' => 2,
        '^' => 4,
        '(' => 5,
        _ => 0
    };

    private static int PriorityStack(char op) => op switch
    {
        '+' or '-' => 1,
        '/' or '*' or '%' => 3,
        '^' => 3,
        '(' => 0,
        _ => 0
    };

    private static double Calculate(List<string> postfixElements)
    {
        var stack = new Stack<double>();
        foreach (var item in postfixElements)
        {
            if (IsOperator(item))
            {
                var op2 = stack.Pop();
                var op1 = stack.Pop();
                stack.Push(Calculate(op1, item[0], op2));
            }
            else
            {
                stack.Push(Convert.ToDouble(item, CultureInfo.InvariantCulture));
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