﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomConversions
{
    struct Square
    {
        public int Length { get; set; }

        public Square(int l) : this()
        {
            Length = l;
        }

        public void Draw()
        {
            for (int i = 0; i < Length; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static explicit operator Square(Rectangle r)
        {
            Square s = new Square();
            s.Length = r.Height;
            return s;
        }
        public static explicit operator Square(int i)
        {
            return (new Square(i));
        }
        public static explicit operator int(Square s)
        {
            return s.Length;
        }

        public override string ToString()
        {
            return string.Format("[Length: {0}]", Length);
        }

    }
}
