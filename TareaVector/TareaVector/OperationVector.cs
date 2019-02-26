using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaVector
{
    public sealed class OperationVector
    {
        private static OperationVector instance = null;
        private int[] sumTotalVector;
        public int SizeVector;
        private OperationVector()
        {
            instance = null;
            SizeVector = 0;
        }
        public static OperationVector Instance
        {
            get
            {
                if (instance == null)
                {
                    if (instance == null)
                    {
                        instance = new OperationVector();
                    }                   
                }
                return instance;
            }
        }
        public int[] TransformArray(string data)
        {
            string[] res = data.Split(',');
            int[] vecInit = new int[SizeVector];
            int cont = 0;
            foreach (string item in res)
            {
                vecInit[cont] = Int32.Parse(item);
                cont++;
            }
            return vecInit;
        }
        public int[] SumArray(int[]dataVector)
        {
            int[] result = new int[SizeVector];
            for (int i = 0; i < SizeVector; i++)
            {
                sumTotalVector[i] += dataVector[i];
            }
            return sumTotalVector;
        }
        public void printVector()
        {
            for (int i = 0; i < SizeVector; i++)
            {
                Console.WriteLine(sumTotalVector[i]);
            }
        }
        public void VectorMoreLarge(string[] args)
        {
            foreach (var item in args)
            {
                string[] res = item.Split(',');
                if(SizeVector < res.Length)
                {
                    SizeVector = res.Length;
                }
            }
            sumTotalVector = new int[SizeVector];
        }

    }
}
