using System.Collections;

List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

IEnumerable query =
 from num in numbers
 where num > 5 && num < 10 //numbers greater than 5 and less than 10
 select num;

foreach (int Result in query)
{
    Console.WriteLine(Result);
}

Console.WriteLine();

IEnumerable query2 =
 from num in numbers
 where num%2!=0 //odd numbers
 orderby num descending //descending order
 select num;

foreach (int Result in query2)
{
    Console.WriteLine(Result);
}
