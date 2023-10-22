using System;
namespace module7practice
{
    public class Decimal
    {
        private char[] data = new char[100];

        public Decimal(string value)
        {
            if (value.Length > 100)
                throw new ArgumentException("Значение ввода слишком велико для размещения в Decimal.");

            if (!value.All(char.IsDigit))
                throw new ArgumentException("Значение ввода содержит символы, которые не являются цифрами.");

            Array.Fill(data, '0', 0, 100 - value.Length);
            value.AsSpan().CopyTo(data.AsSpan(100 - value.Length));
        }

        public char[] Data => data;

        public static Decimal operator +(Decimal left, Decimal right) => new Decimal((Add(left.Data, right.Data));

        public static Decimal operator -(Decimal left, Decimal right) => new Decimal(Subtract(left.Data, right.Data);

        public static Decimal operator *(Decimal left, Decimal right)
        {
            throw new NotImplementedException();
        }

        public static Decimal operator /(Decimal left, Decimal right)
        {
            throw new NotImplementedException();
        }

        private static char[] Add(char[] a, char[] b)
        {
            int carry = 0;
            char[] result = new char[100];

            for (int i = 99; i >= 0; i--)
            {
                int sum = a[i] - '0' + b[i] - '0' + carry;
                result[i] = (char)((sum % 10) + '0');
                carry = sum / 10;
            }

            return result;
        }

        private static char[] Subtract(char[] a, char[] b)
        {
            int borrow = 0;
            char[] result = new char[100];

            for (int i = 99; i >= 0; i--)
            {
                int diff = a[i] - '0' - (b[i] - '0') - borrow;
                if (diff < 0)
                {
                    diff += 10;
                    borrow = 1;
                }
                else
                {
                    borrow = 0;
                }
                result[i] = (char)(diff + '0');
            }

            return result;
        }
    }
}