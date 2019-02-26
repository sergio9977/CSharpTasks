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
            var operation = OperationVector.Instance;
            operation.VectorMoreLarge(datas);
            foreach (var data in datas)
            {
                int[] vec = operation.TransformArray(data);
                int[] result = operation.SumArray(vec);
            }
            operation.printVector();
        }
    }
}
