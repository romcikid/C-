/*Необходимо составить программу, включающую:

1.	Метод, принимающий символы двух цифр и символ операции (+ - * /), возвращает результат указанной операции над численными значениями символов.
2.	Метод, выводящий для каждого символа десятичный и шестнадцатеричный код:
•	Символы: Пробел, Точка, Запятая, Точка с запятой, Двоеточие.
•	Управляющие символы: \n, \r, \t.
•	Русские буквы: Ё,ё.

3.	Метод, выводящий для каждого символа десятичный и шестнадцатеричный код:
•	Цифры:0…9.
•	Латинские буквы: A…Z; a…z.
•	Русские буквы: А…Я; а…я.

4.	Метод преобразования произвольного текста в символьный массив.
5.	Метод преобразования символьного массива в произвольный текст.
6.	Метод для вывода массива символов.
7.	Метод для вывода кодов символов массива.
8.	Метод для определения в произвольном тексте белых пробелов и вывода кодов их символов.
9.	Метод, который определяет в произвольном тексте:
•	Количество букв.
•	Количество цифр.

10.	Метод для поиска заданного символа в строке.
11.	Метод для определения количества повторений указанного символа в строке.
12.	Метод, принимающий строку и два символа («первый» и «второй») и возвращающий строку, в которой каждый символ «первый» заменен на символ «второй».
13.	Метод, принимающий строку и символ, возвращающий строку, в которой удалены все символы, совпадающие с заданным.  
14.	Метод, принимающий строку и возвращающий строку, в которой все подряд идущие пробелы заменены на один пробел.
15.	Метод, принимающий строку и возвращающий строку, которая образована из данной чтением от конца до начала.
16.	Метод принимает слово и определяет читается ли это слово одинаково как слева направо, так и наоборот.
17.	Метод, который определяет в произвольном тексте:
•	Количество слов.
•	Количество простых предложений.
•	Количество предложений.

18.	Метод, который принимает произвольный текст и возвращает преобразованный текст, так чтобы предложения начинались с заглавной буквы, а все остальные буквы предложения становились строчными.

19.	Метод, который определяет в произвольном тексте и возвращает в виде строки:
•	Все разделители.
•	Все знаки препинания.
*/

using System;
class Program
{
    static double OP(char a, char b, char sim)
    {
        double x = char.GetNumericValue(a);
        double y = char.GetNumericValue(b);
        double z = 0;
        if (sim == '+')
            z = x + y;
        else if (sim == '-')
            z = x - y;
        else if (sim == '*')
            z = x * y;
        else if (sim == '/')
            z = x / y;
        return z;
    }
    static void Print(char a)
    {
        int codea = (int)a;
        Console.WriteLine("{0,3} {1,3:D} {2,3:X}", a, codea, codea);
    }
    static void Print(char a, char b)
    {
        for (char i = a; i <= b; i++)
        {
            int codei = (int)i;
            Console.WriteLine("{0,3} {1,3:D} {2,3:X}", i, codei, codei);
        }
    }
    static void Str(string s, out char[] c)
    {
        c = s.ToCharArray();
    }
    static string Simv(char[] c)
    {
        string s = " ";
        for (int i = 0; i < c.Length; i++)
            s += c[i];
        return s;
    }
    static void Print(char[] ch)
    {
        for (int i = 0; i < ch.Length; i++)
            Console.Write(ch[i]);
        Console.WriteLine();
    }
    static void Print(char[] ch, int g)
    {
        for (int i = 0; i < ch.Length; i++)
        {
            Console.Write((int)ch[i] + " ");
            if ((int)ch[i] == 10)
                Console.WriteLine();
        }
        Console.WriteLine();
    }
    static void Probel(char[] x)
    {
        int codei = 0;
        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] == ' ')
            {
                codei = (int)i;
                Console.WriteLine("{0,3:D} {1,3:X}",  codei, codei);
            }
        }
    }
    static int Kbukv(char[] a)
    {
        int bukv = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] != ' ' && a[i] != '0' && a[i] != '1' && a[i] != '2' && a[i] != '3' && a[i] != '4' && a[i] != '5' && a[i] != '6' && a[i] != '7' && a[i] != '8' && a[i] != '9')
                bukv++;
        }
        return bukv;
    }
    static int Kchis(char[] a)
    {
        int chis = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] != ' ' && a[i] == '0' || a[i] == '1' || a[i] == '2' || a[i] == '3' || a[i] == '4' || a[i] == '5' || a[i] == '6' || a[i] == '7' || a[i] == '8' || a[i] == '9')
                chis++;
        }
        return chis;
    }
    static int kprost(char[] a)
    {
        int prost = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == '.' || a[i] == ',' || a[i] == ';')
                prost++;
        }
        return prost;
    }
    static void Poisk(char[] x, char m)
    {
        int j = 0;
        string s = " ";
        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] != m)
                s += x[i];
            else
            if (x[i] == m)
            {
                s += " " + "ВАШ СИМВОЛ" + " ";
            }
            j++;
        }
        Console.WriteLine(s);
    }
    static int Kulich(char[] x, char m)
    {
        int k = 0;
        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] == m)
            {
                k++;
            }
        }
        return k;
    }
    static int Zaglav(char[] x, out char[] y)
    {
        int k = 0;
        y = new char[4];
        int j = 0;
        for (int i = 0; i < x.Length; i++)
        {
            if (char.IsUpper(x[i]))
            {
                k++;
                y[j] = x[i];
                j++;
            }
        }
        return k;
    }
    static void Men(string s, char a, char b)
    {
        char[] c;
        Str(s, out c);
        for (int i = 0; i < c.Length; i++)
            if (c[i] == a)
                c[i] = b;
        string e = Simv(c);
        Console.WriteLine(e);
    }
    static void Boris(string s, char h)
    {
        char[] t;
        Str(s, out t);
        int k = 0;
        for (int i = 0; i < t.Length; i++)
            if (t[i] == h)
            {
                t[i] = ' ';
                k++;
            }
        if (k == 0)
            Console.WriteLine("Представленный символ для удаления не обнаружен!");
        Print(t);
    }
    static void Eltsin(string s)
    {
        char[] t;
        Str(s, out t);
        int k = t.Length - 1;
        int m = 0;
        char j = ' ';
        for (int i = k; i != m; i--)
        {
            j = t[m];
            t[m] = t[i];
            t[i] = j;
            m++;
        }
        Print(t);
    }
    static void Probels(string s)
    {
        char[] t;
        Str(s, out t);
        int k = 0;
        string s1 ="";
        for (int i = 0; i < t.Length; i++)
        {
            if (t[i] == ' ' && t[i + 1] == ' ')
            {
                k++;
                continue;
            }
            if (k == 1)
            { 
                k=0;
                continue;
            }
            else
                s1 += t[i];
         }
        Console.WriteLine(s1);
    }
    static void Kolich(string s)
    {
        int sl = 0;
        int pr = 0;
        int predl = 0;
        char[] t;
        Str(s, out t);
        for (int i=0; i<t.Length; i++)
        {
            if (t[i] == ' ')
                sl++;
            else if (t[i] == ',')
                pr++;
            else if (t[i] == '.')
                predl++;
        }
        Console.WriteLine("Количество слов в тексте равно " + sl);
        Console.WriteLine("Количество простых предложений в тексте равно " + pr);
        Console.WriteLine("Количество преложений в тексте равно " + predl);
    }
    static void Aposh(string s)
    {
        char[] t;
        Str(s, out t);
        string s1 = "";
        for (int i = t.Length - 1; i >= 0; i--)
            s1 += t[i];
        if (s == s1)
            Console.WriteLine("Введенное вами слово является палиндромом!");
        else
            Console.WriteLine("Введенное вами слово не является палиндромом!");
    }
    static void Bolsh(string s)
    {
        char[] t;
        Str(s, out t);
        for (int i = 0; i < t.Length; i++)
        {
            if (t[i] == '.' && i > 0 && (i+1) < t.Length)
            {
                t[i + 1] = char.ToUpper(t[i + 1]);
                i++;
            }
            else if (t[i] != '.')
                t[i] = char.ToLower(t[i]);
        }
        Print(t);
    }
    static void Simvols(string s)
    {
        char[] t;
        Str(s, out t);
        string s1 = "";
        string s2 = "";
        for (int i=0; i<t.Length; i++)
        {
            if (t[i] == '\n' || t[i] == '\r' || t[i] == '\t' || t[i] == ' ')
                s1 += t[i];
            else if (t[i] == ',' || t[i] == '.' || t[i] == ';' || t[i] == ':')
                s2 += t[i];
        }
        Console.WriteLine(@"Строка с разделителями: " + s1);
        Console.WriteLine("Строка со знаками препинания: " + s2);
    }
    static void Main()
    {
        string s = @"   s45g,  df:\n = yam.  Nи8т\tм Пт Чdb; <>ум5ы).   :Ядиь,  vf3ь:9м( + Dj6бx2b  7;  [] Ймд. Sfw 22z.";
        Console.WriteLine("\n Исходная строка: "+ s);
        //1-я программа;
        Console.WriteLine("\n Первый метод ");
        Console.Write("Введите первое число: ");
        char a = Convert.ToChar(Console.ReadLine());
        Console.Write(" Введите второе число: ");
        char b = Convert.ToChar(Console.ReadLine());
        Console.Write(" Введите символ операции: ");
        char sim = Convert.ToChar(Console.ReadLine());
        Console.Write("\n Результат выполнения операции: ");
        double d = OP(a, b, sim);
        Console.WriteLine($"  {a}{sim}{b}={d:0.000}");
        //2-я программа;
        Console.WriteLine("\n Второй метод ");
        char h = ' ';
        char h1 = '.';
        char h2 = ',';
        char h3 = ';';
        char h4 = ':';
        char h5 = '\n';
        char h6 = '\r';
        char h7 = '\t';
        char h8 = 'Ё';
        char h9 = 'ё';
        Console.WriteLine("\n");
        Print(h);
        Print(h1);
        Print(h2);
        Print(h3);
        Print(h4);
        Print(h5);
        Print(h6);
        Print(h7);
        Print(h8);
        Print(h9);
        //3-я программа;
        Console.WriteLine("\n Третий метод ");
        Console.WriteLine();
        char p = '0';
        char l = '9';
        char p1 = 'A';
        char l1 = 'Z';
        char p2 = 'a';
        char l2 = 'z';
        char p3 = 'А';
        char l3 = 'Я';
        char p4 = 'а';
        char l4 = 'я';
        Print(p, l);
        Console.WriteLine();
        Print(p1, l1);
        Console.WriteLine();
        Print(p2, l2);
        Console.WriteLine();
        Print(p3, l3);
        Console.WriteLine();
        Print(p4, l4);
        //4-я программа;
        char[] c;
        Str(s, out c);
        //5-я программа;
        string e = Simv(c);
        //6-я программа;
        Console.WriteLine("\n Шестой метод ");
        char[] ch;
        Str(s, out ch);
        Print(ch);
        //7-я программа;
        Console.WriteLine("\n Седьмой метод ");
        Print(ch, 1);
        //8-я программа;
        Console.WriteLine("\n Восьмой метод ");
        Probel(ch);
        //9-я программа;
        Console.WriteLine("\n Девятый метод ");
        int kbukv = Kbukv(ch);
        Console.WriteLine(" Количество букв в предложении = " + kbukv);
        int kchis = Kchis(ch);
        Console.WriteLine(" Количество чисел в предложении = " + kchis);
        //10-я программа;
        Console.WriteLine("\n Десятый метод ");
        Console.Write("\n Задайте символ: ");
        char j = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("\n");
        Poisk(ch, j);
        //11-я программа;
        Console.WriteLine("\n Одиннадцатый метод ");
        int k = Kulich(ch, j);
        Console.WriteLine(" Количество повторенний указанного символа в строке: " + k);
        //12-я программа;
        Console.WriteLine("\n Двенадцатый метод ");
        Console.Write("Задайте первый символ : ");
        char q = Convert.ToChar(Console.ReadLine());
        Console.Write("Задайте второй символ : ");
        char zx = Convert.ToChar(Console.ReadLine());
        Men(s, q, zx);
        //13-я программа;
        Console.WriteLine("\n Тринадцатый метод ");
        Console.Write("Введите символ для удаления: ");
        char m = Convert.ToChar(Console.ReadLine());
        Console.WriteLine();
        Boris(s, m);
        //14-я программа;
        Console.WriteLine("\n Четырнадцатый метод ");
        Probels(s);
        //15-я программа;
        Console.WriteLine("\n Пятнадцатый метод ");
        Eltsin(s);
        //16-я программа;
        Console.WriteLine("\n Шестнадцатый метод ");
        Console.Write("Введите ваше слово: ");
        string u = Convert.ToString(Console.ReadLine());
        Aposh(u);
        //17-я программа;
        Console.WriteLine("\n Семнадцатый метод ");
        Kolich(s);
        //18-я программа;
        Console.WriteLine("\n Восемнадцатый метод ");
        Bolsh(s);
        //19-я программа;
        Console.WriteLine("\n Девятнадцатый метод ");
        Simvols(s);
        Console.ReadKey();
    }
}
