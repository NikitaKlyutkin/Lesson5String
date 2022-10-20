using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5String
{
    internal class Class1
    {
        public void MaxWordNum(string str)
        {
            string [] textsplit = str.Split('\n', ' ', '.');
            int Max = 0;
            int Index = 0;
            for (int slovo = 0; slovo < textsplit.Length; slovo++)
            {
                int currmax = 0;
                for (int simvol = 0; simvol < textsplit[slovo].Length; simvol++)
                {
                    if (char.IsNumber(textsplit[slovo][simvol])) // Где i это слово k смвол 
                    {
                        currmax++;
                    }
                }
                if (currmax > Max)
                {
                    Max = currmax;
                    Index = slovo;
                }
            }
            Console.WriteLine("Наибольше цифр в слове " + textsplit[Index]);
        }
        public void MaxWord(string str)
        {
            string[] textsplit = str.Split('\n', ' ', '.');
            string maxlength = "";
            for (int i = 0; i < textsplit.Length; i++)
                if (maxlength.Length < textsplit[i].Length)
                    maxlength = textsplit[i];

            int count = 0;
            foreach (string x in textsplit)
            {
                if (x == maxlength)
                    ++count;
            }
            Console.WriteLine("Самое длинное слово: {0}\nСколько раз было: {1}", maxlength, count);
        }
        public void ReplaceNumToWord(string str)
        {
            Console.WriteLine("Замена цифр на слова : ");
            string[] arr = { " ноль ", " один ", " два ", " три ", " четыре ", " пять ", " шесть ", " семь ", " восемь ", " девять " };
            string lines = str;
            for (int i = 0; i < 10; i++)
                lines = lines.Replace(i.ToString(), arr[i]); // От 0 до 10 (i) следовательно i= 0 берем из массива 0 элемент 
            Console.WriteLine(lines);
        }
        public void WithOutSentence(string str)
        {
            string[] sentences = str.Split('.', '\n');
            Console.WriteLine("Предложение которые не содержат запятые:");
            foreach (string sentence in sentences)
            {
                if (!sentence.Contains(','))
                Console.WriteLine(sentence.Trim());
            }
        }
        public void WordSameLetter(string str)
        {
            Console.WriteLine("Слова которые начинаются и заканчиваются на одну и ту же букву:");
            var words = str.Split(' ', ',', '!', '?', '.', '-', '\n');
            foreach (var word in words)
            {
                if (word.Length > 1 && word[0] == word[word.Length - 1])
                {
                    Console.WriteLine(word);
                }
            }
        }

        public void SentenceExcQue(string str)
        {
            string[] textsplit2 = str.Split('.', '\n');
            Console.WriteLine("Сначала вопросительные, потом предложения:");
            foreach (string stri in textsplit2)
            {
                if (stri.Contains('?') == true)
                {
                    Console.WriteLine(stri.Trim());
                }
            }
            foreach (string stri in textsplit2)
            {
                if (stri.Contains('!') == true)
                {
                    Console.WriteLine(stri.Trim());
                }
            }
        }
    }
}
