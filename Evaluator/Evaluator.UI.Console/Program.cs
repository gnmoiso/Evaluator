using Evaluator.Core;

Console.WriteLine("Hello Evaluator!");

var evaluator = new expresionEvaluator();
var infix1 = "4*5/(4+6)";
var result1 = expresionEvaluator.Evaluate(infix1);
Console.WriteLine($"{infix1} = {result1}");

var infix2 = "4*(5+6-(8/2^3)-7)-1";
var result2 = expresionEvaluator.Evaluate(infix2);
Console.WriteLine($"{infix2} = {result2}");

var infix3 = "7^(1/2)";
var result3 = expresionEvaluator.Evaluate(infix3);
Console.WriteLine($"{infix3} = {result3}");