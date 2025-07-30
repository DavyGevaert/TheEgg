// See https://aka.ms/new-console-template for more information
using TheEgg.Model;

Console.WriteLine("Hello, World!");

bool isPositive(int value)
{
    return value > 0;
}

var data = new List<int> {1, 0, -1, 2, -3, 4, 3, -5 };

var predicate = new Predicate<int>(isPositive);
var positives = data.FindAll(predicate);

var output = string.Join(",", positives);

Console.WriteLine(output);

var chicken1 = new Chicken();
var egg = chicken1.Lay();
var childChicken = egg.Hatch();
