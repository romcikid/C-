/*Необходимо написать программу, включающую:

1.  Метод Main() создать строковый массив:
           один       два     три
            четыре   пять
            шесть     семь   восемь   девять  

2.  Метод для вывода строкового ступенчатого массива.
             один      два         три
          четыре   пять
            шесть   семь   восемь  девять

3.  Метод для нахождения элемента строкового ступенчатого массива с наибольшим количеством символов.
                  Im = 1         Jm = 0

4.  Метод для преобразования строкового ступенчатого массива в строку с заданием символа-разделителя между элементами массива в строке.
один,  два,  три,  четыре,  пять,  шесть,  семь, восемь,  девять (обращение к методу с ‘,’)
один;  два;  три;  четыре;  пять;  шесть;  семь; восемь;  девять (обращение к методу с ‘;’)

5.  Метод для преобразования строки в одномерный строковой массив с указанием символа разделителя между подстроками, которые станут элементами строкового массива. Метод для вывода одномерного массива.
     (обращение к методу с ‘,’ затем вывод)                                      (обращение к методу с ‘;’ затем вывод)
       один                                                                                                                  один        
       два          два
       три  три
       четыре       четыре
       пять пять
       шесть        шесть
       семь семь
       восемь       восемь
       девять   девять

6.  Метод для преобразования одномерного строкового массива в строку с заданием символа-разделителя между элементами массива в строке.
один,  два,  три,  четыре,  пять,  шесть,  семь, восемь,  девять (обращение к методу с ‘,’)
один;  два;  три;  четыре;  пять;  шесть;  семь; восемь;  девять (обращение к методу с ‘;’)
*/

using System;
class Program
{
    static void print(string [] [] c)
    {
        for (int i = 0; i < c.Length; i++)
        {
            for (int j = 0; j < c[i].Length; j++)
                Console.Write($"{c[i][j],8}");
            Console.WriteLine();
        }
    }
    static void print(string [] c)
    {
        for (int i = 0; i < c.Length; i++)
                Console.WriteLine(c[i]);
    }

    static int Bolsh(string [] [] c, int h)
    {
        int m = 0;
        int im = 0;
        int jm = 0;
        for (int i = 0; i < c.Length; i++)
        {
            for (int j = 0; j < c[i].Length; j++)
            {
                if (c[i][j].Length > m)
                {
                    m = c[i][j].Length;
                    im = i;
                    jm = j;
                }
            }
         }
        if (h == 0)
            return im;
        else
            return jm;
    }
    static string Stroki(string[][] c, string h)
    {
        string s = "";
        for (int i = 0; i < c.Length; i++)
        {
            for (int j = 0; j < c[i].Length; j++)
            {
                if (i == c.Length - 1 && j == c[i].Length - 1)
                {
                    s = s + c[i][j];
                }
                else
                {
                    s = s + c[i][j] + h;
                }
            }
        }
        return s;
    }
    static void Pre(string s,out string [] j, char h)
    {
        j = s.Split(h);
    }
    static string Straka(string [] o, string g)
    {
        string s = string.Join(g, o);
        return s;
    }
    static void Main()
    {
        const int n = 3;
        string[][] Cifr = new string[n][]
        {
            new string[] {"один", "два", "три"},
            new string[] {"четыре", "пять"},
            new string[] {"шесть", "семь", "восемь", "девять"},
        };
        print(Cifr);
        int im = Bolsh(Cifr,0);
        int jm = Bolsh(Cifr, 1);
        Console.WriteLine("\n Наибольший элемент находится в {0} строке и в  {1} столбце", im,jm);
        string s = Stroki(Cifr, ", ");
        string s1 = Stroki(Cifr, "; ");
        Console.WriteLine("\n Символ-разделитель между элементами равен ','");
        Console.WriteLine(s);
        Console.WriteLine("\n Символ-разделитель между элементами равен ';'");
        Console.WriteLine(s1);
        string[] o ;
        Pre(s,out o,',');
        string[] p;
        Pre(s, out p, ',');
        Console.WriteLine("\n Одномерный строковый массив без ',' : ");
        print(o);
        Console.WriteLine("\n Одномерный строковый массив без ';' : ");
        print(p);
        s = string.Empty;
        s1 = string.Empty;
        s = Straka(o, ", ");
        s1 = Straka(o, "; ");
        Console.WriteLine("\n Символ-разделитель между элементами равен ',' "+"\n"+s);
        Console.WriteLine("\n Символ-разделитель между элементами равен ';' " + "\n" + s1);
        Console.ReadKey();
    }
}
