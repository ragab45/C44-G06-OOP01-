using System.ComponentModel;
using System.Diagnostics;

namespace Demo
{
    internal class Program
    {
        void Main(string[] args)
        {
            // Uncomment the sections below to see the examples in action
            #region V-1
            //Console.WriteLine("Hello, World!");
            //Print();
            //Console.WriteLine(X);
            //PrintHello();
            #endregion
            #region V-2
            //SetX(10);
            //Console.WriteLine(X);
            //Console.WriteLine(Y);
            //Console.WriteLine(Z);
            //Console.WriteLine(W);
            //Console.WriteLine(H);
            //Console.WriteLine(B);
            #endregion
            #region V-3
            //Person person = new Person();
            //person.Id = 1;
            //person.Name = "Ahmed";
            //person

            #region V-1
            // What You Can Write Inside?
            // 1. Signature For Method
            //void Print();

            //// 2. Signature For Property
            //public int X { get; set; }

            //// 3. Default Implemented Method
            //private void PrintHello()
            //{
            //    Console.WriteLine("Say Hello");
            //}
            #endregion
            #region V-2
            // Access Modifier Allowed Inside ?

            ////private
            //private int X;
            ////Private Protected
            ////private protected int Z;
            ////Protected
            //protected int Y;
            ////Internal
            //internal int W;
            ////protected Internal
            //protected internal int B;
            ////Public
            //public int H;

            //public void SetX(int value)
            //{
            //    X = value;
            //    Y = value;
            //    Z = value;
            //    W = value;
            //    H = value;
            //    B = value;
            //}
            #endregion

            #region V-3
            //Person person = new Person();

            //person.Id = 1;
            //person.Name = "Ahmed";
            //person.Gender = Gender.Male;

            //Console.WriteLine(person.Gender);

            Grade grade = Grade.A;

            if (grade == Grade.A)
                Console.WriteLine("Excellent");
            else
                Console.WriteLine("Good Luck Next Time");

            grade = 5;
            #endregion
        }

    }
}

