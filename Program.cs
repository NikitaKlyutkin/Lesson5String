
using Lesson5String;
using System.ComponentModel.Design;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

Class1 class1 = new Class1();
string str = File.ReadAllText(@"\lesson5.txt");
StreamReader reader = new StreamReader(@"\menu.txt", Encoding.Default);
string menuFile = reader.ReadToEnd();
reader.Close();
Console.WriteLine(menuFile);

while (true)
{
    Console.Write("Введите операцию из меню:");
    string? menu = Console.ReadLine();
    int intValue;
    int selectmenu;
    if (int.TryParse(menu, out intValue))
    {
        selectmenu = intValue;
    }
    else
    {
        Console.WriteLine("Не верный ввод. Попробуйте снова");
        continue;
    }
    if(selectmenu == 1)
    {
        class1.MaxWordNum(str);
    }
    else if(selectmenu == 2)
    {
        class1.MaxWord(str);
    }
    else if(selectmenu == 3)
    {
        class1.ReplaceNumToWord(str);
    }
    else if(selectmenu == 4)
    {
        class1.SentenceExcQue(str);
    }
    else if (selectmenu == 5)
    {
        class1.WithOutSentence(str);
    }
    else if (selectmenu == 6)
    {
        class1.WordSameLetter(str);
    }
    else
    {
        Console.WriteLine("Такой операции не существует");
    }
    Console.WriteLine("Нажми Enter");
    Console.ReadKey();
    Console.Clear();
    Console.WriteLine(menuFile);
}