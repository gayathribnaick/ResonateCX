// See https://aka.ms/new-console-template for more information

using CodeReview;


var foo = new Foo<double>(1.5d);

foo.LogToConsole("Hello world");

await foo.LogtoFileAsync("Hello world");

var result1 = Foo<double>.DoCalc(1, 2); 

Console.WriteLine(result1);

var result2 = Foo<double>.HigherOrderCalculation((x, y) => x + y, 3, 4);

Console.WriteLine(result2);
