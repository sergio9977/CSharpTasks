using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundacion.Jala.AppVector
{
    public class VectorOperations : Points
    {
        public VectorOperations(int x, int y)
        {
            this.Origin = new Points
            {
                X = 0,
                Y = 0
            };
            this.X = x;
            this.Y = y;

        }
        public Points Origin { get; set; }
        public VectorOperations Add(VectorOperations vectorB)
        {
            return new VectorOperations(this.X + vectorB.X, this.Y + vectorB.Y);
        }
        public int Prop(VectorOperations vectorB)
        {
            int resultVectorA = this.X * this.Y;
            int resultVectorB = vectorB.X * vectorB.Y;
            int result = resultVectorA + resultVectorB;
            return result;
        }
        public double LengthVector()
        {
            double resultPropX = Math.Pow(this.X, 2);
            double resultPropY = Math.Pow(this.Y, 2);
            double resultAddXY = resultPropX + resultPropY;
            double resultLength = Math.Sqrt(resultAddXY);
            return resultLength;
        } 
        public override string ToString()
        {
            return $"[{this.X},{this.Y}]";
        }
    }
}
