using Evaluator.Core;

Console.WriteLine("Hello Evaluator!");

var evaluator = new expresionEvaluator();
var infix = "1+2";
var result = expresionEvaluator.Evaluate(infix);
Console.WriteLine($"{infix} = {result}");