using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnsafeCode
{
    struct Point
    {
        public int x;
        public int y;
        public override string ToString()
        {
            return string.Format("({0}, {1})", x, y);
        }
    }
    class PointRef
    {
        public int x;
        public int y;
        public override string ToString()
        {
            return string.Format("({0}, {1})", x, y);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Calling method with unsafe code ****");
            int i = 10, j = 20;
            Console.WriteLine("Safe swap:");
            Console.WriteLine("Before swap: i = {0}, j = {1}", i, j);
            SafeSwap(ref i, ref j);
            Console.WriteLine("After swap: i = {0}, j = {1}", i, j);
            Console.WriteLine();

            Console.WriteLine("Unsafe swap:");
            Console.WriteLine("Before swap: i = {0}, j = {1}", i, j);
            unsafe { UnsafeSwap(&i, &j); }
            Console.WriteLine("After swap: i = {0}, j = {1}", i, j);
            Console.WriteLine();

            unsafe
            {
                int myInt = 10;
                SquareIntPointer(&myInt);
                Console.WriteLine("myInt: {0}", myInt);
                PrintValueAndAddres();
            }

            UsePointerToPoint();
            UseAndPinPoint();
            UseSizeOfOperator();

            Console.ReadLine();
        }

        unsafe static void UseSizeOfOperator()
        {
            Console.WriteLine("short: {0}", sizeof(short));
            Console.WriteLine("int: {0}", sizeof(int));
            Console.WriteLine("long: {0}", sizeof(long));
            Console.WriteLine("Point: {0}", sizeof(Point));
            Console.WriteLine();
        }

        unsafe static void UseAndPinPoint()
        {
            PointRef p = new PointRef { x = 5, y = 10 };
            fixed(int* ptr = &p.x)
            {
                // some code
            }
            Console.WriteLine("Point p: {0}", p);
            Console.WriteLine();
        }

        unsafe static void UsePointerToPoint()
        {
            Point point;
            Point* p = &point;
            p->x = 100;
            p->y = 200;
            Console.WriteLine(p->ToString());

            Point point2;
            Point* p2 = &point2;
            (*p2).x = 200;
            (*p2).y = 100;
            Console.WriteLine((*p2).ToString());
            Console.WriteLine();
        }
        unsafe static void UnsafeStackAlloc()
        {
            char* c = stackalloc char[256];
            for (int i = 0; i < 256; i++)
                c[i] = (char)i;
        }
        unsafe static void UnsafeSwap(int* i, int* j)
        {
            int tmp = *i;
            *i = *j;
            *j = tmp;
        }
        static void SafeSwap(ref int i, ref int j)
        {
            int tmp = i;
            i = j;
            j = tmp;
        }
        unsafe static void PrintValueAndAddres()
        {
            int myInt;
            int* ptrToInt = &myInt;
            *ptrToInt = 123;
            Console.WriteLine("ptrToInt: {0:X}", (int)ptrToInt);
            Console.WriteLine("*ptrToInt: {0}", *ptrToInt);
            Console.WriteLine("myInt: {0}", myInt);
            Console.WriteLine("Addres of myInt: {0:X}", (int)&ptrToInt);
            Console.WriteLine();
        }
        unsafe static void SquareIntPointer(int* myIntPointer)
        {
            *myIntPointer *= *myIntPointer;
        }
    }
}
