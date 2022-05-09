using System;

public class Program
{
    public static void Main(string[] args)
    {

        using (StreamReader file = new StreamReader("C:\\Users\\Brux\\Downloads\\testD\\tests\\01"))
        {

            var firstWord = file.ReadLine();
            var secondWord = file.ReadLine();

            string resultword = new String('_', firstWord.Length); 

            Console.WriteLine(firstWord);
            Console.WriteLine(secondWord);

            char[] resultCharArr = resultword.ToCharArray();


            for (int i = 0; i < firstWord.Length; i++)
            {
                if (firstWord.ElementAt(i) == secondWord.ElementAt(i))
                {
                    resultCharArr[i] = firstWord.ElementAt(i);
                    Console.WriteLine("a");

                }
                else {

                    Console.WriteLine("z");
                    resultword.Append((char)'z');
                }
            }


            Console.WriteLine(String.Join("", resultCharArr));

            /*for (var j = 0; j < 0; j++)
            {

                var qqq = Console.ReadLine();
                var count = int.Parse(qqq);

                var input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                {
                    var tasks = input.Split(" ");
                    var collection = new int[tasks.Length];
                    var indexes = new int[tasks.Length];

                    for (var i = 0; i < tasks.Length; i++)
                    {
                        int.TryParse(tasks[i], out collection[i]);
                        indexes[i] = i;
                    }

                    Array.Sort(collection, indexes);

                    Array.Reverse(collection);
                    Array.Reverse(indexes);

                    var niceCollection = new int[collection.Length];
                    var newCollection = new int[collection.Length];
                    var maxvalue = collection[0];

                    int nice = 1;

                    for (int i = 0; i < collection.Length; i++)
                    {
                        if (collection[i] < maxvalue - 1)
                        {
                            nice++;
                            maxvalue = collection[i];
                        }
                        niceCollection[i] = nice;
                    }

                    for (int i = 0; i < collection.Length; i++)
                    {
                        newCollection[indexes[i]] = niceCollection[i];

                    }
                    Console.WriteLine(String.Join(" ", newCollection));
                }
            }*/
        }
    }
}
