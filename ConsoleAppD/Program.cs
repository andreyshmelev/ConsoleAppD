using System;

public class Program
{
    public static void Main(string[] args)
    {

        using (StreamReader file = new StreamReader("C:\\Users\\Brux\\Downloads\\testD\\tests\\20"))
        {
            char[] alphabeth = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            int[] usedLetterFirst = new int[alphabeth.Length];

            Array.Fill(usedLetterFirst, 0);

            var firstWord = file.ReadLine();
            var secondWord = file.ReadLine();

            char[] aaa = firstWord.ToCharArray();
            char[] bbb = secondWord.ToCharArray();

            char[] resultCharArr = new String('_', firstWord.Length).ToCharArray();

            for (int i = 0; i < firstWord.Length; i++)
            {
                var letterFirstWord = aaa[i];
                var letterSecondWord = bbb[i];

                if (letterFirstWord == letterSecondWord) // если буква равна букве
                {
                    resultCharArr[i] = 'G';
                    aaa[i] = ' ';
                    bbb[i] = ' ';
                }
            }

            for (int i = 0; i < firstWord.Length; i++)
            {
                var letterFirstWord = aaa[i];

                var indFirst = Array.IndexOf(alphabeth, letterFirstWord);

                if (indFirst >= 0)
                {
                    usedLetterFirst[indFirst]++;
                }
            }


           // Console.WriteLine(String.Join(" ", alphabeth));
            //Console.WriteLine(String.Join(" ", usedLetterFirst));


            var trimmedalpha = alphabeth;

            for (int i = 0; i < usedLetterFirst.Length; i++)
            {
                if (usedLetterFirst[i] == 0)
                {
                    trimmedalpha[i] = ' ';
                }
            }

            char charToRemove = ' ';
            trimmedalpha = trimmedalpha.Where(val => val != charToRemove).ToArray();

            int numToRemove = 0;
            usedLetterFirst = usedLetterFirst.Where(val => val != numToRemove).ToArray();


           // Console.WriteLine(String.Join(" ", trimmedalpha));
           // Console.WriteLine(String.Join(" ", usedLetterFirst));



           for (int i = 0; i < secondWord.Length; i++)
            {

                if (bbb[i] != ' ')
                {
                    var letterSecondWord = bbb[i];
                    var indSecond = Array.IndexOf(trimmedalpha, letterSecondWord);

                    if (indSecond >= 0)
                    {
                        if (usedLetterFirst[indSecond] > 0)
                        {
                            resultCharArr[i] = 'Y';
                            usedLetterFirst[indSecond]--;
                        }
                        else
                        {
                            resultCharArr[i] = '.';
                        }
                    }

                }
            }
            

  //          Console.WriteLine(String.Join(" ", trimmed));

//            Console.WriteLine(String.Join("", usedLetterFirst));

            Console.WriteLine(String.Join("", resultCharArr));
        }
    }
}