using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongArithmetic
{
    class BigInt
    {
        private string str;
        public int[] Digits { get; }
        public int Length { get; }
        public bool Sign { get; }

        public BigInt(string s)
        {
            str = s;
            char[] chars = s.ToCharArray();
            Digits = new int[chars.Length];
            for (int i = 0; i < chars.Length; i++)
            {
                Digits[i] = chars[chars.Length - i - 1] - '0';
            }
            Length = Digits.Length;
        }

        public BigInt(int[] a)
        {
            int n = a[a.Length - 1] == 0 ? a.Length - 1 : a.Length;
            Digits = new int[n];
            for (int i = 0; i < Digits.Length; i++)
            {
                Digits[i] = a[i];
            }
            str = ToString();
        }

        public override string ToString()
        {
            string s = null;
            for (int i = Digits.Length - 1; i >= 0; i--)
            {
                s += Digits[i];
            }
            return s;
        }





        public static BigInt operator +(BigInt a, BigInt b)
        {
            return BigIntMath.Sum(a, b);
        }

        public static bool operator >(BigInt a, BigInt b)
        {
            if (a.Length != b.Length)
            {
                return a.Length > b.Length ? true : false;
            }
            else
            {
                for (int i = a.Length - 1; i >= 0; i--)
                {
                    if (a.Digits[i] != b.Digits[i])
                    {
                        if (a.Digits[i] > b.Digits[i])
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                return false;
            }
        }

        public static bool operator <(BigInt a, BigInt b)
        {
            if (a.Length != b.Length)
            {
                return a.Length < b.Length ? true : false;
            }
            else
            {
                for (int i = a.Length - 1; i >= 0; i--)
                {
                    if (a.Digits[i] != b.Digits[i])
                    {
                        if (a.Digits[i] < b.Digits[i])
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                return false;
            }
        }

        public static bool operator ==(BigInt a, BigInt b)
        {
            if (a.Length != b.Length)
            {
                for (int i = a.Length - 1; i >= 0; i--)
                {
                    if (a.Digits[i] != b.Digits[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(BigInt a, BigInt b)
        {
            if (a.Length == b.Length)
            {
                for (int i = a.Length - 1; i >= 0; i--)
                {
                    if (a.Digits[i] != b.Digits[i])
                    {
                        return true;
                    }
                }
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool operator >=(BigInt a, BigInt b)
        {
            if (a > b || a == b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <=(BigInt a, BigInt b)
        {
            if (a < b || a == b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    static class BigIntMath
    {
        public static BigInt Sum(BigInt a, BigInt b)
        {
            int[] result;
            BigInt c;
            int al = a.Length, bl = b.Length;
            if (al == bl)
            {
                result = new int[al + 1];
                for (int i = 0; i < al; i++)
                {
                    if (result[i] + a.Digits[i] + b.Digits[i] > 9)
                    {
                        result[i] = (result[i] + a.Digits[i] + b.Digits[i]) % 10;
                        result[i + 1] += 1;
                    }
                    else
                    {
                        result[i] += a.Digits[i] + b.Digits[i];
                    }
                }
                c = new BigInt(result);
                return c;
            }
            else
            {
                int max, min;

                if (al > bl)
                {
                    max = al;
                    min = bl;
                }
                else
                {
                    max = bl;
                    min = bl;
                }
                result = new int[max];
                for (int i = 0; i < min; i++)
                {
                    if (result[i] + a.Digits[i] + b.Digits[i] > 9)
                    {
                        result[i] = (result[i] + a.Digits[i] + b.Digits[i]) % 10;
                        result[i + 1] += 1;
                    }
                }
                if (al > bl)
                {
                    for (int i = min; i < max; i++)
                    {
                        result[i] += a.Digits[i];
                    }
                }
                else
                {
                    for (int i = min; i < max; i++)
                    {
                        result[i] += b.Digits[i];
                    }
                }
                c = new BigInt(result);
            }
            return c;
        }

        public static BigInt Sub(BigInt a, BigInt b)
        {
            return null;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string a = Console.ReadLine();
            BigInt n = new BigInt(s);
            BigInt n1 = new BigInt(a);
            Console.Write(n + n1);
            Console.ReadKey();
        }
    }
}

