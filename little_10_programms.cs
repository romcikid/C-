using System;
using System.Collections.Generic;
using System.IO;
namespace Tasks
{
    class Spisok
    {
        List<object> sp = new List<object>();
        List<object> sp1 = new List<object>();
        List<object> sp2 = new List<object>();
        List<string> stroki1 = new List<string>();
        List<string> stroki2 = new List<string>();
        List<string> stroki3 = new List<string>();
        public void ReadINT(StreamReader sR)
        {
            string st = sR.ReadToEnd();
            st = st.Replace("\r\n", " ");
            string[] stm = st.Split(' ');
            sp.Clear();
            int k = 0;
            for (int i = 0; i < stm.Length; i++)
                sp.Add(Convert.ToInt32(stm[k++]));
        }
        public void ReadDouble(StreamReader sR)
        {
            string st = sR.ReadToEnd();
            st = st.Replace("\r\n", " ");
            string[] stm = st.Split(' ');
            sp.Clear();
            int k = 0;
            for (int i = 0; i < stm.Length; i++)
                sp.Add(Convert.ToDouble(stm[k++]));
        }
        public void ReadChar(StreamReader sR)
        {
            string st = sR.ReadToEnd();
            st = st.Replace("\r\n", " ");
            string[] stm = st.Split(' ');
            sp.Clear();
            int k = 0;
            for (int i = 0; i < stm.Length; i++)
                sp.Add(Convert.ToChar(stm[k++]));
        }
        public void ReadStr(StreamReader sR)
        {
            stroki1.Clear();
            string st = sR.ReadToEnd();
            st = st.Replace("\r\n", "\n");
            string[] stm = st.Split('\n');
            int k = 0;
            for (int i = 0; i < stm.Length; i++)
                stroki1.Add(stm[k++]);
        }
        public void ReadStr1(StreamReader sR)
        {
            string st = sR.ReadToEnd();
            st = st.Replace("\r\n\r\n", "\r\n");
            string[] stm = st.Split('\n');
            stroki1.Clear();
            stroki2.Clear();
            int k = 0;
            Console.Write(" Количество строк в первой коллекции: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
                stroki1.Add(stm[k++]);
            for (int i = 0; i < stm.Length - n; i++)
                stroki2.Add(stm[k++]);
        }
        public void StrW(StreamWriter sw)
        {
            sw.WriteLine();
            for (int i = 0; i < sp.Count; i++)
            {
                sw.Write("{0,3}", sp[i]);
                if (i < sp.Count) sw.Write(" ");
            }
            sw.WriteLine();
        }
        public StreamWriter SW { get; set; }
        public void StrW(List<object> s)
        {
            SW.WriteLine();
            for (int i = 0; i < s.Count; i++)
                SW.Write("{0,3}", s[i]);
            SW.WriteLine();
        }
        public void StrW(List<string> stroki1, List<string> stroki2)
        {
            SW.WriteLine();
            SW.WriteLine(" До:");
            SW.WriteLine();
            SW.WriteLine(" Первый список:");
            SW.WriteLine();
            foreach (string s in stroki1)
                SW.WriteLine(" " + s);
            SW.WriteLine();
            SW.WriteLine(" Второй список:");
            SW.WriteLine();
            foreach (string s in stroki2)
                SW.WriteLine(" " + s);
            SW.WriteLine();
        }
        public void StrW(List<string> stroki3)
        {
         SW.WriteLine();
            foreach (string s in stroki3)
                SW.WriteLine(" " + s);
        }
        public void Z1()
        {
            foreach (var s in sp)
            {
                if (Convert.ToInt32(s) % 2 == 0)
                    sp1.Add(s);
                else
                    sp2.Add(s);
            }
            StrW(sp1);
            StrW(sp2);
        }
        public void Z2()
        {
            sp.Clear();
            sp1.Clear();
            int k = 0;
            Console.Write(" Введите значнеие n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Введите значнеие a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Введите значнеие b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Random r = new Random((int)DateTime.Now.Ticks);
            for (int i = 0; i < n; i++)
                sp.Add(r.Next(a, b));
            StrW(sp);
            foreach (var s in sp)
                if (Convert.ToInt32(s) % 10 == 0)
                {
                    k++;
                    sp1.Add(s);
                }
            StrW(sp1);
            SW.WriteLine();
            SW.WriteLine(" Количество элементов, кончающихся на 0, равно " + k);
        }
        public void Z3()
        {
            sp1.Clear();
            for (int i = 0; i < sp.Count; i++)
                if (Convert.ToChar(sp[i]) != '0' && Convert.ToChar(sp[i]) != '1' && Convert.ToChar(sp[i]) != '2' && Convert.ToChar(sp[i]) != '3' && Convert.ToChar(sp[i]) != '4' && Convert.ToChar(sp[i]) != '5' && Convert.ToChar(sp[i]) != '6' && Convert.ToChar(sp[i]) != '7' && Convert.ToChar(sp[i]) != '8' && Convert.ToChar(sp[i]) != '9')
                    sp1.Add(sp[i]);
            SW.WriteLine();
            SW.WriteLine(" До:");
            StrW(sp);
            SW.WriteLine();
            SW.WriteLine(" После:");
            StrW(sp1);
        }
        public void Z4()
        {
            SW.WriteLine();
            stroki2.Clear();
            foreach (string s in stroki1)
            { 
                int l = s.Length;
                if (s[0] == s[l - 1])
                    stroki2.Add(s);
                SW.WriteLine(" " + s);
            }
            SW.WriteLine();
            foreach (string s in stroki2)
                SW.WriteLine(" " + s);
        }
        public void Z5()
        {
            stroki2.Clear();
            string s1 = "";
            SW.WriteLine();
            foreach (string s in stroki1)
            {
                char[] c = s.ToCharArray();
                for (int j = 0; j < c.Length; j++)
                    if (c[j] != ' ')
                        s1 += c[j];
                stroki2.Add(s1);
                s1 = "";
            }
            SW.WriteLine(" До:");
            SW.WriteLine();
            foreach (string s in stroki1)
                SW.WriteLine(" " + s);
            SW.WriteLine();
            SW.WriteLine(" После:");
            SW.WriteLine();
            foreach (string s in stroki2)
                SW.WriteLine(" "+s);
        }
        public void Z6()
        {
            sp1.Clear();
            int k = 0;
            for (int i = 0; i < sp.Count; i++)
            {
                if (Convert.ToChar(sp[i]) == 'A' || Convert.ToChar(sp[i]) == 'a' || Convert.ToChar(sp[i]) == 'E' || Convert.ToChar(sp[i]) == 'e' || Convert.ToChar(sp[i]) == 'I' || Convert.ToChar(sp[i]) == 'i' || Convert.ToChar(sp[i]) == 'O' || Convert.ToChar(sp[i]) == 'o' || Convert.ToChar(sp[i]) == 'U' || Convert.ToChar(sp[i]) == 'u' || Convert.ToChar(sp[i]) == 'Y' || Convert.ToChar(sp[i]) == 'y')
                {
                    sp1.Add(sp[i]);
                    k++;
                }
            }
            StrW(sp);
            StrW(sp1);
            SW.WriteLine();
            SW.WriteLine(" Количество гласных англ. букв: {0}", k);
        }
        public void Z7()
        {
            StrW(stroki1, stroki2);
            foreach (string s in stroki1)
                stroki3.Add(s);
            foreach (string s in stroki2)
                stroki3.Add(s);
            SW.WriteLine();
            SW.WriteLine(" После:");
            StrW(stroki3);
        }
        public void Z8()
        {
            stroki3.Clear();
            int k = 0;
            StrW(stroki1, stroki2);
            foreach (string s in stroki1)
            {
                stroki3.Add(s);
                for (int i=k; i<stroki2.Count; i++)
                {
                    stroki3.Add(stroki2[i]);
                    k++;
                    break;
                }
            }
            SW.WriteLine();
            SW.WriteLine(" После:");
            StrW(stroki3);
        }
        public void Z9()
        {
            stroki3.Clear();
            StrW(stroki1, stroki2);
            foreach (string s in stroki1)
            {
                char[] c = s.ToCharArray();
                if (Char.IsUpper(c[0]))
                    stroki3.Add(s);
            }
            foreach (string s in stroki2)
            {
                char[] c = s.ToCharArray();
                if (Char.IsUpper(c[0]))
                    stroki3.Add(s);
            }
             foreach (string s in stroki1)
            {
                char[] c = s.ToCharArray();
                if (!Char.IsUpper(c[0]))
                    stroki3.Add(s);
            }
            foreach (string s in stroki2)
            {
                char[] c = s.ToCharArray();
                if (!Char.IsUpper(c[0]))
                    stroki3.Add(s);
            }
            SW.WriteLine();
            SW.WriteLine(" После:");
            StrW(stroki3);
        }
        public void Z10()
        {
            stroki3.Clear();
            StrW(stroki1, stroki2);
            foreach (string s in stroki1)
            {
                if (s[s.Length - 2] == '.')
                    stroki3.Add(s);
            }
            foreach (string s in stroki2)
            {
                if (s[s.Length - 2] == '.')
                    stroki3.Add(s);
            }
            foreach (string s in stroki1)
            {
                if (s[s.Length - 2] != '.')
                    stroki3.Add(s);
            }
            foreach (string s in stroki2)
            {
                if (s[s.Length-2]!='.')
                    stroki3.Add(s);
            }
            SW.WriteLine();
            SW.WriteLine(" После:");
            StrW(stroki3);
        }
    }
    class Program
    {
        static void Main()
        {
            Spisok s = new Spisok();
            string pathInt = "InputInt.txt";
            StreamReader sr1 = new StreamReader(pathInt);
            s.ReadINT(sr1);
            sr1.Close();
            string pathOUT = "testOUT.txt";
            StreamWriter sw = new StreamWriter(pathOUT);
            sw.WriteLine(" Программа 1");
            s.StrW(sw);
            s.SW = sw;
            s.Z1();
            sw.WriteLine();
            sw.WriteLine(" Программа 2");
            s.Z2();
            pathInt = "InputChar.txt";
            StreamReader sr3 = new StreamReader(pathInt);
            s.ReadChar(sr3);
            sr3.Close();
            sw.WriteLine();
            sw.WriteLine(" Программа 3 ");
            s.Z3();
            pathInt = "InputStroki.txt";
            StreamReader sr4 = new StreamReader(pathInt);
            s.ReadStr(sr4);
            sr4.Close();
            sw.WriteLine();
            sw.WriteLine(" Программа 4 ");
            s.Z4();
             pathInt = "InputStroki.txt";
             StreamReader sr5 = new StreamReader(pathInt);
             s.ReadStr(sr5);
             sr5.Close();
             sw.WriteLine();
             sw.WriteLine(" Программа 5 ");
             s.Z5();
            pathInt = "InputChar.txt";
            StreamReader sr6 = new StreamReader(pathInt);
            s.ReadChar(sr6);
            sr6.Close();
            sw.WriteLine();
            sw.WriteLine(" Программа 6 ");
            s.Z6();
            pathInt = "InputStroki1.txt";
            StreamReader sr7 = new StreamReader(pathInt);
            s.ReadStr1(sr7);
            sr7.Close();
            sw.WriteLine();
            sw.WriteLine(" Программа 7 ");
            s.Z7();
            sw.WriteLine();
            sw.WriteLine(" Программа 8 ");
            s.Z8();
            sw.WriteLine();
            sw.WriteLine(" Программа 9 ");
            s.Z9();
            sw.WriteLine();
            sw.WriteLine(" Программа 10 ");
            s.Z10();
            sw.Close();
            Console.WriteLine(" Нажмите любую клвашу для продолжения...");
            Console.ReadKey();
        }
    }
}
