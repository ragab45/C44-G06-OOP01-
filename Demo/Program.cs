using System.ComponentModel;

namespace Demo
{
    internal class Program
    {
        
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

        //private
        private int X;
        //Private Protected
        //private protected int Z;
        //Protected
        protected int Y;
        //Internal
        internal int W;
        //protected Internal
        protected internal int B;
        //Public
        public int H;

        public void SetX(int value)
        {
            X = value;
            Y = value;
            Z = value;
            W = value;
            H = value;
            B = value;
        }
        #endregion
    }
    
}
