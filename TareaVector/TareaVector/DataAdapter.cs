using Fundacion.Jala.AppVector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaVector
{
    public sealed class DataAdapter
    {
        private static DataAdapter instance = null;
        public VectorOperations VectorA { get; private set; }
        public VectorOperations VectorB { get; private set; }
        public const string SizeVectorMessage = "the size of the vector is incorrect, it must be x1, y1 x2, y2";
        public const string InvalidNumberMessage = "the vector data is not numbers";

        private DataAdapter()
        {
            instance = null;
        }
        public static DataAdapter Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataAdapter();                  
                }
                return instance;
            }
        }
        public int[] ValidateData(string data)
        {
            string[] res = data.Split(',');
            int[] vecInit = new int[2];
            int cont = 0;
            foreach (string item in res)
            {
                if (!int.TryParse(item, out var valueParsed))
                {
                    throw new ArgumentException(InvalidNumberMessage);
                }
                vecInit[cont] = valueParsed;
                cont++;
            }
            return vecInit;
        }
        public void ValidateInput(string[] args)
        {
            if (args.Length == 2)
            {
                int[] argumentsA = ValidateData(args[0]);
                int[] argumentsB = ValidateData(args[1]);
                this.VectorA = new VectorOperations(argumentsA[0], argumentsA[1]);
                this.VectorB = new VectorOperations(argumentsB[0], argumentsB[1]);
            }
            else
            {
                throw new ArgumentException(SizeVectorMessage);
            }
        }
    }
}
