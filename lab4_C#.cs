                                //////////////////////////////////
                                //������������ ������ �4./////////
                                //�����������. ����������� ����.//
                                //����������������� ������.///////
                                //������� �6./////////////////////
                                //////////////////////////////////

/*
� ������ � ���������� ���������� ��� ��������� �������. ������� � ��������� �� ����� �������� ������� ����� ����������. 
�������� � � ��� ���� ������ � ���������� ���������� � ��� ����. ������� �� ����� �������� ��������� ������� ������� ����� ����������. 
������ ������ ���������������� ��� �������� (�� ���� �� � ������������) . ������� ����������������� ����� � �� ����������� �����.
� ��������� ������������������ ������ ������ �� ����������� ����� � ��������������� ������. � �������� ���������� �����
��������� ��� � �������� ��� (�� ���� ������� 2 ������� � ������� �����������). ����������� ���� � ��� ������.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sharp4
{
    public class A
    {
        public int a, b;
        public int c
        {
            get
            {
                return a - b;
            }
            set
            {
                a *= value;
                b++;
            }
        }
        public A(int x, int y)
        {
            a = x;
            b = y;
        }
    }
    public class B : A
    {
        public B(int x, int y) : base(x, y) { }
        public B(int x, int y, int z) : base(x, y)
        {
            d = z;
            arr = new int[a];
            for (int i = 0; i < a; i++)
            {
                arr[i] = c2 * i;
            }
        }
        public void printarr()
        {
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }
        private int[] arr;
        private char[] arrNew = { 'a', 'b', 'c', 'd', 'e', 'f' };
        public int this[int index1] //���������� int
        {
            get { return arr[index1]; }
            set { arr[index1] = value; }
        }
        public char this[char ch]   //���������� char
        {
            get { return arrNew[ch]; }
            set { arrNew[ch] = value; }
        }
        public int d;
        public int c2
        {
            get { return c - 2 * d; }
        }
    }
    public class C<T>
    {
        public T x;
        public static int a = 10;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "������������ ������ �4";
            int a = 10;
            B obj3 = new B(a, 2, 3);
            Console.WriteLine("�������� ���:");
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(obj3[(int)i]);
            }
            Console.WriteLine("��������� ���:");
            for (int ch = 0; ch <= 5; ch++)
            {
                Console.WriteLine(obj3[(char)ch]);
            }
            Console.WriteLine(C<int>.a);
            C<int> obj10 = new C<int>();
            C<char> obj9 = new C<char>();
            obj10.x = 25;
            obj9.x = 'Z';
            Console.WriteLine(obj10.x);
            Console.WriteLine(obj9.x);
            Console.ReadKey();
        }
    }
}