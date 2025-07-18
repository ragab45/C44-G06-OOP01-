using System.ComponentModel;

namespace Demo
{
    internal class Program
    {
        
            #region V-1
            // What You Can Write Inside?
        // 1. Signature For Method
        void Print();

        // 2. Signature For Property
        public int X { get; set; }

        // 3. Default Implemented Method
        private void PrintHello()
        {
            Console.WriteLine("Say Hello");
        }
        #endregion
    }
    
}
