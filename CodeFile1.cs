using System;
using System.IO;
class Program
{
    static void StrR(StreamReader sR, double[,] a)
    {
        string st = sR.ReadToEnd();
        st = st.Replace("\r\n", " ");
        string[] stm = st.Split(' ');
        int k = 0;
        for (int i = 0; i < a.GetLength(0); i++)
            for (int j = 0; j < a.GetLength(1); j++)
                a[i, j] = Convert.ToDouble(stm[k++]);
    }
    static void StrR(StreamReader sR, char[,] a)
    {
        string st = sR.ReadToEnd();
        st = st.Replace("\r\n", " ");
        string[] stm = st.Split(' ');
        int k = 0;
        for (int i = 0; i < a.GetLength(0); i++)
            for (int j = 0; j < a.GetLength(1); j++)
                a[i, j] = Convert.ToChar(stm[k++]);
    }
    static void StrW(StreamWriter sW, double[,] a, double[,] b)
    {
        sW.WriteLine();
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                sW.Write("{0,7:0.00}", a[i, j]);
                if (j < a.GetLength(1) - 1) sW.Write(" ");
            }
            sW.WriteLine();
        }
        sW.WriteLine();
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                sW.Write("{0,7:0.000}", b[i, j]);
                if (j < a.GetLength(1) - 1) sW.Write(" ");
            }
            sW.WriteLine();
        }
        sW.WriteLine();
    }
    static void StrR(StreamReader aR, int[,] a)
    {
        string st = aR.ReadToEnd();
        st = st.Replace("\r\n", " ");
        string[] stm = st.Split(' ');
        int k = 0;
        for (int i = 0; i < a.GetLength(0); i++)
            for (int j = 0; j < a.GetLength(1); j++)
                a[i, j] = Convert.ToInt32(stm[k++]);
    }
    static void StrR(StreamReader aR, int[,] a, int [,] b)
    {
        string st = aR.ReadToEnd();
        st = st.Replace("\r\n\r\n", "\r\n");
        st = st.Replace("\r\n", " ");
        string[] stm = st.Split(' ');
                int k = 0;
        for (int i = 0; i < a.GetLength(0); i++)
            for (int j = 0; j < a.GetLength(1); j++)
                a[i, j] = Convert.ToInt32(stm[k++]);
        for (int i = 0; i < b.GetLength(0); i++)
            for (int j = 0; j < b.GetLength(1); j++)
                b[i,j]= Convert.ToInt32(stm[k++]);
    }
    static void StrW(StreamWriter aW, int[,] a, int[,] b)
    {
        aW.WriteLine();
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                aW.Write("{0,4}", a[i, j]);
                if (j < a.GetLength(1) - 1) aW.Write(" ");
            }
            aW.WriteLine();
        }
        aW.WriteLine();
        for (int i = 0; i < b.GetLength(0); i++)
        {
            for (int j = 0; j < b.GetLength(1); j++)
            {
                aW.Write("{0,4}", b[i, j]);
                if (j < b.GetLength(1) - 1) aW.Write(" ");
            }
            aW.WriteLine();
        }
        aW.WriteLine();
    }
    static void StrW(StreamWriter aW, int[,] a, int[,] b, int [,] c)
    {
        aW.WriteLine();
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                aW.Write("{0,4}", a[i, j]);
                if (j < a.GetLength(1) - 1) aW.Write(" ");
            }
            aW.WriteLine();
        }
        aW.WriteLine();
        for (int i = 0; i < b.GetLength(0); i++)
        {
            for (int j = 0; j < b.GetLength(1); j++)
            {
                aW.Write("{0,4}", b[i, j]);
                if (j < b.GetLength(1) - 1) aW.Write(" ");
            }
            aW.WriteLine();
        }
        aW.WriteLine();
        for (int i = 0; i < c.GetLength(0); i++)
        {
            for (int j = 0; j < c.GetLength(1); j++)
            {
                aW.Write("{0,4}", c[i, j]);
                if (j < c.GetLength(1) - 1) aW.Write(" ");
            }
            aW.WriteLine();
        }
        aW.WriteLine();
    }
    static void StrW(StreamWriter sW, int[,] a, int[] b, int[] c)
    {
        sW.WriteLine();
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                sW.Write("{0,4}", a[i, j]);
                if (j < a.GetLength(1) - 1) sW.Write(" ");
            }
            sW.WriteLine();
        }
        sW.WriteLine();
        for (int i = 0; i < b.Length; i++)
        {
            sW.Write("{0,4}", b[i]);
            if (i < b.Length - 1) sW.Write(" ");
        }
        sW.WriteLine();
        sW.WriteLine();
        for (int i = 0; i < c.Length; i++)
        {
            sW.Write("{0,4}", c[i]);
            if (i < c.Length - 1) sW.Write(" ");
        }
        sW.WriteLine();
        sW.WriteLine();
    }
    static void StrW(StreamWriter sW, char[,] a, char[] b, char[] c)
    {
        sW.WriteLine();
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                sW.Write("{0,4}", a[i, j]);
                if (j < a.GetLength(1) - 1) sW.Write(" ");
            }
            sW.WriteLine();
        }
        sW.WriteLine();
        for (int i = 0; i < b.Length; i++)
        {
            sW.Write("{0,4:D}",(int) b[i]);
            if (i < b.Length - 1) sW.Write(" ");
        }
        sW.WriteLine();
        sW.WriteLine();
        for (int i = 0; i < c.Length; i++)
        {
            sW.Write("{0,4:D}",(int) c[i]);
            if (i < c.Length - 1) sW.Write(" ");
        }
        sW.WriteLine();
        sW.WriteLine();
    }
    static void StrW(StreamWriter sW, int[,] a)
    {
        sW.WriteLine();
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                sW.Write("{0,4}", a[i, j]);
                if (j < a.GetLength(1) - 1) sW.Write(" ");
            }
            sW.WriteLine();
        }
        sW.WriteLine();
    }
    static void StrW(StreamWriter sW, int[,] a, int[] b, int[] c, int[] d)
    {
        sW.WriteLine();
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                sW.Write("{0,4}", a[i, j]);
                if (j < a.GetLength(1) - 1) sW.Write(" ");
            }
            sW.WriteLine();
        }
        sW.WriteLine();
        for (int i = 0; i < b.Length; i++)
        {
            sW.Write("{0,4}", b[i]);
            if (i < b.Length - 1) sW.Write(" ");
        }
        sW.WriteLine();
        for (int i = 0; i < c.Length; i++)
        {
            sW.Write("{0,4}", c[i]);
            if (i < c.Length - 1) sW.Write(" ");
        }
        sW.WriteLine();
        for (int i = 0; i < d.Length; i++)
        {
            sW.Write("{0,4}", d[i]);
            if (i < d.Length - 1) sW.Write(" ");
        }
        sW.WriteLine();
        sW.WriteLine();
    }
    static void StrW(StreamWriter sW, int[,] a, int[] b)
    {
        sW.WriteLine();
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                sW.Write("{0,4}", a[i, j]);
                if (j < a.GetLength(1) - 1) sW.Write(" ");
            }
            sW.WriteLine();
        }
        sW.WriteLine();
        for (int i = 0; i < b.Length; i++)
        {
            sW.Write("{0,4}",b[i]);
            if (i < b.Length - 1) sW.Write(" ");
        }
        sW.WriteLine();
    }
    static void StrW(StreamWriter sW, int[,] a, double[,] b)
    {
        sW.WriteLine();
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                sW.Write("{0,5}", a[i, j]);
                if (j < a.GetLength(1) - 1) sW.Write(" ");
            }
            sW.WriteLine();
        }
        sW.WriteLine();
        for (int i = 0; i < b.GetLength(0); i++)
        {
            for (int j = 0; j < b.GetLength(1); j++)
            {
                sW.Write("{0,7:0.00}",b[i, j]);
                if (i < b.Length - 1) sW.Write(" ");
            }
            sW.WriteLine();
        }
        sW.WriteLine();
    }
    static void StrW(StreamWriter sW, int[,] a, string[] b)
    {
        sW.WriteLine();
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                sW.Write("{0,5}", a[i, j]);
                if (j < a.GetLength(1) - 1) sW.Write(" ");
            }
            sW.WriteLine();
        }
        sW.WriteLine();
        for (int i = 0; i < b.GetLength(0); i++)
                sW.WriteLine("{0,7:0.00}", b[i]);
        sW.WriteLine();
    }
    static double Max(double[,] a)
    {
        double max = 0;
        for (int i = 0; i < a.GetLength(0); i++)
            for (int j = 0; j < a.GetLength(1); j++)
            {
                if (Math.Abs(a[i, j]) > Math.Abs(max)) max = a[i, j];
            }
        return max;
    }
    static int Max(int[,] a)
    {
        int max = 0;
        for (int i = 0; i < a.GetLength(0); i++)
            for (int j = 0; j < a.GetLength(1); j++)
                if (Math.Abs(a[i, j]) > max) max = a[i, j];
        return max;
    }
    static void del(double[,] a, double[,] b)
    {
        double max = Max(a);
        for (int i = 0; i < a.GetLength(0); i++)
            for (int j = 0; j < a.GetLength(1); j++)
            {
                b[i, j] = a[i, j];
                b[i, j] /= max;
            }
    }
    static void Nuli(int[,] a, int[,] b)
    {
        double max = Max(a);
        for (int i = 0; i < a.GetLength(0); i++)
            for (int j = 0; j < a.GetLength(1); j++)
            {
                if (a[i, j] == max)
                {
                    if (i != 0 || i != a.GetLength(0) - 1)
                        b[i, j] = 0;
                }
                else
                    b[i, j] = a[i, j];
            }
    }
    static void Min(char[,] a, char[] b)
    {
        for (int i = 0; i < a.GetLength(0); i++)
        {
            int min =a[i,0];
            for (int j = 0; j < a.GetLength(1); j++)
            {
                if (a[i, j] < min)
                {
                    min = a[i, j];
                }
            }
            b[i]  =Convert.ToChar(min);
        }
    }
    static void Max(char[,] a, char[] b)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            int max = a[0, j];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                if (a[i, j] > max)
                {
                    max = a[i, j];
                }
            }
            b[j] = Convert.ToChar(max);
        }
    }
    static void Izm(int[,] a, int[,] b)
    {
        int max = Max(a);
        for (int i = 0; i < a.GetLength(0); i++)
            for (int j = 0; j < a.GetLength(1); j++)
            {
                b[i, j] = a[i, j] + max;
            }
    }
    static void Shach(int[,] a)
    {
        for (int i = 0; i < a.GetLength(0); i++)
            for (int j = 0; j < a.GetLength(1); j++)
            {
                if (i % 2 != 0)
                {
                    if (j % 2 == 0)
                        a[i, j] = 0;
                    else
                        a[i, j] = 1;
                }
                else
                {
                    if (j % 2 == 0)
                        a[i, j] = 1;
                    else
                        a[i, j] = 0;
                }
            }
    }
    static void Diag(int[,] a, int[] b, int[] c)
    {
        int k = 0;
        for (int i = 0; i < a.GetLength(0); i++)
            for (int j = 0; j <= i; j++)
            {
                b[k] = a[i, j];
                k++;
            }
        k = 0;
        for (int i = 0; i < a.GetLength(0); i++)
            for (int j = a.GetLength(0) - 1 - i; j < a.GetLength(0); j++)
            {
                c[k] = a[i, j];
                k++;
            }
    }
    static void Perev(int[,] a, int[,] b)
    {
        for (int i = 0; i < a.GetLength(0); i++)
            for (int j = 0; j < a.GetLength(1); j++)
                b[j, i] = a[i, j];
    }
    static void Razdel(int[,] a, int[] b, int[] c, int[] d)
    {
        for (int i = 0; i < a.GetLength(0); i++)
        {
            int max = 0;
            for (int j = 0; j < a.GetLength(1); j++)
            {
                if (a[i, j] > max)
                    max = a[i, j];
            }
            b[i] = max;
        }
        for (int j = 0; j < a.GetLength(1); j++)
        {
            int min = a[0, j];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                if (a[i, j] < min)
                    min = a[i, j];
            }
            c[j] = min;
        }
        for (int i = 0; i < a.GetLength(0); i++)
        {
            int sr = 0;
            for (int j = 0; j < a.GetLength(1); j++)
            {
                sr += a[i, j];
            }
            d[i] = sr / a.GetLength(0);
        }
    }
    static void Stolb(int[,] a, int[,] b, int[] c)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            int min = a[0, j];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                if (a[i, j] < min)
                    min = a[i, j];
            }
            c[j] = min;
        }
        for (int j = 0; j < a.GetLength(1); j++)
            for (int i = 0; i < a.GetLength(0); i++)
                b[i, j] = a[i, j] + c[j];
    }
    static void Otric(int[,] a, int[] b)
    {
        int[] sum = new int[a.GetLength(0)];
        int[] pr = new int[a.GetLength(0)];
        for (int i = 0; i < a.GetLength(0); i++)
        {
            sum[i] = 0;
            pr[i] = 1;
            for (int j = 0; j < a.GetLength(1); j++)
            {
                if (a[i, j] > 0)
                    sum[i] += a[i, j];
                else
                    if (a[i, j] < 0)
                    pr[i] *= a[i, j];
            }
        }
        for (int i = 0; i < a.GetLength(0); i++)
            for (int j = 0; j < a.GetLength(1); j++)
            {
                if (i == j)
                {
                    if (a[i, j] < 0)
                        b[i] = sum[i];
                    else if (a[i, j] > 0)
                        b[i] = pr[i];
                }
            }
    }
    static void Obrat(int [,] a, double [,] b)
    {
        for (int i = 0; i < a.GetLength(0); i++)
            for (int j = 0; j < a.GetLength(1); j++)
                if (a[i, j] != 0)
                    b[i, j] = -1.00 / a[i, j];
    }
    static void Nuli1(int [,]a, int [,] c)
    {
        for (int i = 0; i < a.GetLength(0); i++)
            for (int j = 0; j < a.GetLength(1); j++)
            {
                c[i, j] = a[i, j];
            }
        for (int i = 0; i < a.GetLength(0); i++)
            for (int j = 0; j <= i; j++)
            {
                c[i, j] = 0;
            }
    }
    static int Pro(int [,] a)
    {
        int pro = 1;
        for (int i = 1; i < a.GetLength(0); i++)
            for (int j = a.GetLength(0)-i; j < a.GetLength(1); j++)
            {
                if (a[i, j] > 0)
                    pro *= a[i, j];
            }
        return pro;
    }
    static void Perest(int [,] a, int [,] b)
    {
        int max = a[0, 0];
        int min = 0;
        int imax = 0;
        int jmax = 0;
        int imin = 0;
        int jmin = 0;
        for (int i = 0; i < a.GetLength(0); i++)
            for (int j = 0; j < a.GetLength(1); j++)
            {
                b[i, j] = a[i, j];
                if (b[i, j] > max)
                {
                    max = b[i, j];
                    imax = i;
                    jmax = j;
                }
                if (b[i, j] < min)
                {
                    min = b[i, j];
                    imin = i;
                    jmin = j;
                }
            }
        for (int i = 0; i < a.GetLength(0); i++)
            for (int j = 0; j < a.GetLength(1); j++)
            {
                if (i == imin && j == jmin)
                    b[i, j] = max;
                if (i == imax && j == jmax)
                    b[i, j] = min;
            }
    }
    static void Otric(int [,] a, int [] b, int [] c)
    {
        int s1 = 0;
        int s2 = 0;
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
                if (a[i, j] < 0)
                    s1 += a[i, j];
            b[i] = s1;
            s1 = 0;
        }
        for (int j = 0; j < a.GetLength(1); j++)
        {
            for (int i = 0; i < a.GetLength(0); i++)
                if (a[i, j] < 0)
                    s2 += a[i, j];
            c[j] = s2;
            s2 = 0;
        }
    }
    static void Delej(double [,] a, double [,] b)
    {
        double max = Max(a);
        for (int j = 0; j < a.GetLength(1); j++)
            for (int i = 0; i < a.GetLength(0); i++)
                b[i, j] = a[i, j] / max;
    }
    static void MinSum(int [,] a, string [] s)
    {
        int min = 0;
        int sum = 0;
        for (int i = 0; i < a.GetLength(0); i++)
            for (int j = 0; j < a.GetLength(1); j++)
            {
                if (a[i, j] < min) min = a[i, j];
            }
        s[0] += min;
        for (int i = 0; i < a.GetLength(0); i++)
            for (int j = 0; j < a.GetLength(1)-i; j++)
                sum += a[i, j];
        s[1] += sum;
    }
    static void MaxSum(int[,] a, string[] s)
    {
        int max = 0;
        int sum = 0;
        for (int i = 0; i < a.GetLength(0); i++)
            for (int j = 0; j < a.GetLength(1); j++)
            {
                if (a[i, j] > max) max = a[i, j];
            }
        s[0] += max;
        for (int i = 0; i < a.GetLength(0); i++)
            for (int j = 0; j <= i; j++)
                sum += a[i, j];
        s[1] += sum;
    }
    static void MaxPr(int[,] a, int[] b, int[,] c)
    {
        int max = 0;
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                if (a[i, j] > max) max = a[i, j];
            }
            b[i] = max;
            max = 0;
        }
        for (int i = 0; i < a.GetLength(0); i++)
            for (int j = 0; j < a.GetLength(1); j++)
                c[i, j] = a[i, j] + b[i];
    }
    static void MaxMin(int [,] a, int [] b)
    {
        int max = a[0, 0];
        int min = a[0,0];
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                if (a[i, j] > max)
                    max = a[i, j];
                if (a[i, j] < min)
                    min = a[i, j];
            }
            b[i] = max + min;
            if (i != a.GetLength(0) - 1)
                max = a[i + 1, 0];
            if (i!= a.GetLength(0)-1)
            min = a[i+1, 0];
        }
    }
    static void PD(int [,] a, int [] b)
    {
        for (int i = 0; i < a.GetLength(0); i++)
            for (int j = 0; j < a.GetLength(1); j++)
                if (i == j)
                    b[i] = a[i, j];
    }
    static void MS(int [,] a, int [] b)
    {
        for (int i = 0; i < a.GetLength(0); i++)
        {
            int min = a[i, 0];
            for (int j = 0; j < a.GetLength(1); j++)
            {
                if (a[i, j] < min)
                    min = a[i, j];
            }
            b[i] = min;
        }
    }
    static void Sa(int [,] a,int [] b, int [,] c)
    {
        for (int i = 0; i < a.GetLength(0); i++)
        {
            int sr = 0;
            for (int j = 0; j < a.GetLength(1); j++)
            {
                sr += a[i, j];
            }
            sr /= a.GetLength(1);
            b[i] = sr;
            sr = 0;
        }
        for (int i = 0; i < a.GetLength(0); i++)
            for (int j = 0; j < a.GetLength(1); j++)
                c[i, j] = a[i, j] - b[i];
    }
    static void N(int [,] a, int [,] b)
    {
        for (int i = 0; i < a.GetLength(0); i++)
            for (int j = 0; j < a.GetLength(1); j++)
                b[i, j] = a[i, j];
        for (int i = 0; i < a.GetLength(0) - 1; i++)
            for (int j = i + 1; j < a.GetLength(1); j++)
                b[i, j] = 0;
        for (int i = 1; i < a.GetLength(0); i++)
            for (int j = a.GetLength(1)-i; j < a.GetLength(1); j++)
                b[i, j] = 0;
    }
    static void Zerk(int [,] a, int [,] b)
    {
        for (int i = 0; i < a.GetLength(0); i++)
            for (int j = 0; j < a.GetLength(1); j++)
                b[i, j] = a[i, j];
        int q = 0;
        for (int j = 0; j < a.GetLength(1) - 1; j++)
            for (int i =0; i <a.GetLength(0)-2; i++)
                if (i != a.GetLength(0) - j)
                {
                    q = b[i, j];
                    b[i, j] = b[a.GetLength(0)-1 - j, a.GetLength(1)-1 - i];
                    b[a.GetLength(0)-1 - j, a.GetLength(1)-1 - i] = q;
                }
    }
    static int Cep(int [,] a)
    {
        int maxg = 0;
        int maxv = 0;
        int maxd = 0;
        int max = 0;
        int k = 0;
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                if (a[i, j] == 0)
                    k++;
                if (a[i, j] != 0 || j == a.GetLength(1) - 1)
                {
                    if (k>maxg)
                    maxg = k;
                    k = 0;
                }
            }
        }
        for (int j = 0; j < a.GetLength(1); j++)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                if (a[i, j] == 0)
                    k++;
                if (a[i, j] != 0 || i==a.GetLength(0)-1)
                {
                    if (k > maxv)
                        maxv = k;
                    k = 0;
                }
            }
        }
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                if (a[i, j] == 0 && j == i)
                    k++;
                if (a[i, j] != 0 && j == i || i == a.GetLength(0) - 1)
                {
                    if (k > maxd)
                        maxd = k;
                    k = 0;
                }
            }
        }
        if (maxd >= maxv && maxd>=maxg)
            max= maxd;
        else
        if (maxv >= maxg && maxv>=maxd)
            max= maxv;
        else
        if (maxg >= maxd && maxg>=maxv)
            max= maxd;
        return max;
    }
    static void Sum(int [,] a, int [,] b, int [,] c)
    {
        for (int i = 0; i < a.GetLength(0); i++)
            for (int j = 0; j < a.GetLength(1); j++)
                c[i, j] = a[i, j] + b[i,j];
    }
    static void Spir(int [,] a)
    {        
        int k = 1;
        int l = 0;
        do
        {
            for (int j = l; j < a.GetLength(1) - l; j++)
            {
                a[l, j] = k;
                k++;
            }
            for (int i = l + 1; i < a.GetLength(0) - l; i++)
            {
                a[i, a.GetLength(1) - l-1] = k;
                k++;
            }
            for (int j = a.GetLength(1) - 2 - l; j >= l; j--)
            {
                a[a.GetLength(0) - 1 - l, j] = k;
                k++;
            }
            for (int i = a.GetLength(0) - 2 - l; i > l; i--)
            {
                a[i, l] = k;
                k++;
            }
            l++;
        } while (a[l, l] == 0);      
    }
    static void Lat(int [,] a)
    {
        for (int i = 0; i < a.GetLength(0); i++)
            for (int j = 0; j < a.GetLength(1); j++)
            {
                if (i == j)
                    a[i, j] = a.GetLength(0);
                if (i < j)
                    a[i, j] = a.GetLength(0) - Math.Abs(i - j);
                if (i > j)
                    a[i, j] = i - j;
            }
    }
    static void Main()
    {
        string pathIN = "TextIN1.txt";
        StreamReader sr1 = new StreamReader(pathIN);
        int n = 5;
        int m = 4;
        double[,] c = new double[n, m];
        double[,] b = new double[n, m];
        StrR(sr1, c);
        sr1.Close();
        del(c, b);
        string pathOUT = "textOUT.txt";
        StreamWriter sw1 = new StreamWriter(pathOUT);
        sw1.WriteLine(" Первая программа");
        StrW(sw1, c, b);
        pathIN = "TextIN2.txt";
        StreamReader sr2 = new StreamReader(pathIN);
        n = 6;
        m = 6;
        int[,] a = new int[n, m];
        int[,] d = new int[n, m];
        StrR(sr2, a);
        sr2.Close();
        Nuli(a, d);
        sw1.WriteLine(" Вторая программа");
        StrW(sw1, a, d);
        pathIN = "TextIN3.txt";
        StreamReader sr3 = new StreamReader(pathIN);
        n = 5;
        m = 7;
        char[,] e = new char[n, m];
        StrR(sr3, e);
        char[] x = new char[n];
        char[] z = new char[m];
        sr3.Close();
        Min(e, x);
        Max(e, z);
        sw1.WriteLine(" Третья программа");
        StrW(sw1, e,x,z);
        pathIN = "TextIN4.txt";
        StreamReader sr4 = new StreamReader(pathIN);
        n = 5;
        m = 7;
        a = new int[n, m];
        d = new int[n, m];
        StrR(sr4, a);
        Izm(a, d);
        sw1.WriteLine(" Четвертая программа");
        StrW(sw1, a, d);
        pathIN = "TextIN4.txt";
        StreamReader sr5 = new StreamReader(pathIN);
        n = 5;
        m = 7;
        a = new int[n, m];
        d = new int[n, m];
        StrR(sr5, a);
        sr4.Close();
        Shach(a);
        sw1.WriteLine(" Пятая программа");
        StrW(sw1, a);
        pathIN = "TextIN6.txt";
        StreamReader sr6 = new StreamReader(pathIN);
        n = 4;
        m = 10;
        a = new int[n, n];
        int[] g = new int[m];
        int [] f = new int[m];
        StrR(sr6, a);
        sr6.Close();
        Diag(a, g, f);
        sw1.WriteLine(" Шестая программа");
        StrW(sw1, a, g, f);
        pathIN = "TextIN2.txt";
        StreamReader sr7 = new StreamReader(pathIN);
        n = 5;
        m = 7;
        a = new int[m, n];
        d = new int[n, m];
        StrR(sr7, a);
        sr7.Close();
        Perev(a, d);
        sw1.WriteLine(" Седьмая программа");
        StrW(sw1, a, d);
        pathIN = "TextIN8.txt";
        StreamReader sr8 = new StreamReader(pathIN);
        n = 7;
        m = 8;
        a = new int[n, m];
        g = new int[n];
        f = new int[m];
        int[] h = new int[n];
        StrR(sr8, a);
        sr8.Close();
        Razdel(a, g, f, h);
        sw1.WriteLine(" Восьмая программа");
        StrW(sw1, a, g, f, h);
        pathIN = "TextIN8.txt";
        StreamReader sr9 = new StreamReader(pathIN);
        n = 7;
        m = 8;
        a = new int[n, m];
        d = new int[n, m];
        f = new int[m];
        StrR(sr9, a);
        sr9.Close();
        Stolb(a, d, f);
        sw1.WriteLine(" Девятая программа");
        StrW(sw1, a, d);
        pathIN = "TextIN10.txt";
        StreamReader sr10 = new StreamReader(pathIN);
        n = 6;
        a = new int[n, n];
        f = new int[n];
        StrR(sr10, a);
        sr10.Close();
        Otric(a, f);
        sw1.WriteLine(" Десятая программа");
        StrW(sw1, a, f);
        pathIN = "TextIN11.txt";
        StreamReader sr11 = new StreamReader(pathIN);
        n = 5;
        m = 7;
        a = new int[n, m];
        b = new double[n,m];
        StrR(sr11, a);
        sr11.Close();
        Obrat(a, b);
        sw1.WriteLine();
        sw1.WriteLine(" Одиннадцатая программа");
        StrW(sw1, a, b);
        pathIN = "TextIN12.txt";
        StreamReader sr12 = new StreamReader(pathIN);
        n = 6;
        a = new int[n, n];
        d = new int[n, n];
        StrR(sr12, a);
        sr12.Close();
        Nuli1(a, d);
        sw1.WriteLine(" Двенадцатая программа");
        StrW(sw1, a, d);
        pathIN = "TextIN13.txt";
        StreamReader sr13 = new StreamReader(pathIN);
        n = 4;
        a = new int[n, n];
        d = new int[n, n];
        StrR(sr13, a);
        sr13.Close();
        int pro=Pro(a);
        sw1.WriteLine(" Тринадцатая программа");
        StrW(sw1, a);
        sw1.WriteLine("\n " + pro);
        pathIN = "TextIN14.txt";
        StreamReader sr14 = new StreamReader(pathIN);
        n = 6;
        m = 7;
        a = new int[n, m];
        d = new int[n, m];
        StrR(sr14, a);
        sr14.Close();
        Perest(a, d);
        sw1.WriteLine();
        sw1.WriteLine(" Четырнадцатая программа");
        StrW(sw1, a, d);
        pathIN = "TextIN15.txt";
        StreamReader sr15 = new StreamReader(pathIN);
        n = 9;
        a = new int[n, n];
        g = new int[n];
        f = new int[n];
        StrR(sr15, a);
        sr15.Close();
        Otric(a, g,f);
        sw1.WriteLine();
        sw1.WriteLine(" Пятнадцатая программа");
        StrW(sw1, a, g,f);
        pathIN = "TextIN16.txt";
        StreamReader sr16 = new StreamReader(pathIN);
        n = 7;
        m = 6;
        c = new double[n, m];
        b = new double[n, m];
        StrR(sr16, c);
        sr16.Close();
        Delej(c, b);
        sw1.WriteLine();
        sw1.WriteLine(" Шестнадцатая программа");
        StrW(sw1, c, b);
        pathIN = "TextIN17.txt";
        StreamReader sr17 = new StreamReader(pathIN);
        n = 8;
        a = new int[n, n];
        string [] s = new string[2];
        StrR(sr17, a);
        sr17.Close();
        MinSum(a,s);
        sw1.WriteLine();
        sw1.WriteLine(" Семнадцатая программа");
        StrW(sw1, a, s);
        pathIN = "TextIN17.txt";
        StreamReader sr18 = new StreamReader(pathIN);
        n = 8;
        a = new int[n, n];
        s = new string[2];
        StrR(sr18, a);
        sr18.Close();
        MaxSum(a, s);
        sw1.WriteLine();
        sw1.WriteLine(" Восемнадцатая программа");
        StrW(sw1, a, s);
        pathIN = "TextIN8.txt";
        StreamReader sr19 = new StreamReader(pathIN);
        n = 7;
        m = 8;
        a = new int[n, m];
        d = new int[n, m];
        f = new int[n];
        StrR(sr19, a);
        sr19.Close();
        MaxPr(a, f, d);
        sw1.WriteLine();
        sw1.WriteLine(" Девятнадцатая программа");
        StrW(sw1, a, d);
        pathIN = "TextIN20.txt";
        StreamReader sr20 = new StreamReader(pathIN);
        n = 7;
        m = 6;
        a = new int[n, m];
        f = new int[n];
        StrR(sr20, a);
        sr20.Close();
        MaxMin(a, f);
        sw1.WriteLine();
        sw1.WriteLine(" Двадцатая программа");
        StrW(sw1, a, f);
        pathIN = "TextIN21.txt";
        StreamReader sr21 = new StreamReader(pathIN);
        n = 7;
        a = new int[n, n];
        f = new int[n];
        StrR(sr21, a);
        sr21.Close();
        PD(a, f);
        sw1.WriteLine();
        sw1.WriteLine(" Двадцать первая программа");
        StrW(sw1, a, f);
        pathIN = "TextIN11.txt";
        StreamReader sr22 = new StreamReader(pathIN);
        n = 5;
        m = 7;
        a = new int[n, m];
        f = new int[n];
        StrR(sr22, a);
        sr22.Close();
        MS(a, f);
        sw1.WriteLine();
        sw1.WriteLine(" Двадцать вторая программа");
        StrW(sw1, a, f);
        pathIN = "TextIN11.txt";
        StreamReader sr23 = new StreamReader(pathIN);
        n = 4;
        m = 5;
        a = new int[n, m];
        d = new int[n, m];
        f = new int[n];
        StrR(sr23, a);
        sr23.Close();
        Sa(a, f, d);
        sw1.WriteLine();
        sw1.WriteLine(" Двадцать третья программа");
        StrW(sw1, a, d);
        pathIN = "TextIN12.txt";
        StreamReader sr24 = new StreamReader(pathIN);
        n = 6;
        a = new int[n, n];
        d = new int[n, n];
        StrR(sr24, a);
        sr24.Close();
        N(a, d);
        sw1.WriteLine();
        sw1.WriteLine(" Двадцать четвертая программа");
        StrW(sw1, a, d);
        pathIN = "TextIN6.txt";
        StreamReader sr25 = new StreamReader(pathIN);
        n = 4;
        a = new int[n, n];
        d = new int[n, n];
        StrR(sr25, a);
        sr25.Close();
        Zerk(a, d);
        sw1.WriteLine();
        sw1.WriteLine(" Двадцать пятая программа");
        StrW(sw1, a, d);
        pathIN = "TextIN26.txt";
        StreamReader sr26 = new StreamReader(pathIN);
        n = 5;
        a = new int[n, n];
        StrR(sr26, a);
        sr26.Close();
        int max=Cep(a);
        sw1.WriteLine();
        sw1.WriteLine(" Двадцать шестая программа");
        StrW(sw1, a);
        sw1.WriteLine();
        sw1.WriteLine(" Максимальная длина цепочки из нулей в матрице равна " + max);
        pathIN = "TextIN27.txt";
        StreamReader sr27 = new StreamReader(pathIN);
        n = 6;
        m = 7;
        a = new int[n, m];
        d = new int[n, m];
        int [,] t = new int[n, m];
        StrR(sr27, a,d);
        sr27.Close();
        Sum(a, d, t);
        sw1.WriteLine();
        sw1.WriteLine(" Двадцать седьмая программа");
        StrW(sw1, a,d,t);
        n = 6;
        m = 7;
        a = new int[m, n];
        Spir(a);
        sw1.WriteLine();
        sw1.WriteLine(" Двадцать восьмая программа");
        StrW(sw1, a);
        n = 5;
        a = new int[n, n];
        Lat(a);
        sw1.WriteLine();
        sw1.WriteLine(" Двадцать девятая программа");
        StrW(sw1, a);
        sw1.Close();
        Console.WriteLine(" Нажмите любую клавишу для продолжения...");
        Console.ReadKey();
    }
}
