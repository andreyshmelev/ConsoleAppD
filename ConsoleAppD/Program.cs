using System;
#pragma warning disable CS8604
#pragma warning disable CS8602
public class Program
{
    public static void Main(string[] args)
    {

        using (StreamReader file = new StreamReader("C:\\Users\\Brux\\Downloads\\testD\\tests\\04"))
        {
            char[] alphabeth = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            int[] usedLetterFirst  = new int[alphabeth.Length];
            int[] usedLetterSecond = new int[alphabeth.Length];

            Array.Fill(usedLetterFirst, 0);
            Array.Fill(usedLetterSecond, 0);

            var firstWord = file.ReadLine();
            var secondWord = file.ReadLine();

            char[] aaa = firstWord.ToCharArray();
            char[] bbb = secondWord.ToCharArray();


            string resultword = new String('_', firstWord.Length);



            char[] resultCharArr = resultword.ToCharArray();


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
                var letterSecondWord = bbb[i];

                var indFirst  = Array.IndexOf(alphabeth, letterFirstWord);
                var indSecond = Array.IndexOf(alphabeth, letterSecondWord);

                if (indFirst >= 0)
                {
                    usedLetterFirst[indFirst]++;
                }

                if (indSecond >= 0)
                {
                    usedLetterSecond[indSecond]++;
                }

                if (letterFirstWord == letterSecondWord) // если буква равна букве
                {
                    resultCharArr[i] = 'G';
                    //usedLetter[indd]--;
                    aaa[i] = ' ';
                    bbb[i] = ' ';
                }
            }

            for (int i = 0; i < secondWord.Length; i++)
            {

                if (bbb[i] != ' ')
                {
                    var letterSecondWord = bbb[i];
                    var indSecond = Array.IndexOf(alphabeth, letterSecondWord);

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
            



            //Console.WriteLine(String.Join("", resultCharArr));

           // Console.WriteLine(String.Join(" ", aaa));
           // Console.WriteLine(String.Join(" ", bbb));

           // Console.WriteLine(String.Join(" ", alphabeth));
            //Console.WriteLine(String.Join(" ", usedLetterFirst));
             //   Console.WriteLine(String.Join(" ", usedLetterSecond));
                Console.WriteLine(String.Join("", resultCharArr));

                //Console.WriteLine(String.Join("+", aaa));

                //Console.WriteLine(String.Join("-", bbb));


            }
    }
}