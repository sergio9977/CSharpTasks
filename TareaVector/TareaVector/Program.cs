using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaVector
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] datas = args;
            //string[] a = { "1,2", "2,1"};
            var operation = DataAdapter.Instance;
            operation.ValidateInput(datas);
            var vectorA = operation.VectorA;
            var vectorB = operation.VectorB;
            var resultSum = vectorA.Add(vectorB);
            Console.WriteLine(resultSum.ToString());
            Console.WriteLine(resultSum);
            var lengthVec = resultSum.LengthVector();
            Console.WriteLine(lengthVec.ToString());
            var resultProp = vectorA.Prop(vectorB);
            Console.WriteLine(resultProp.ToString());
            Console.ReadKey();
        }
    }
}
