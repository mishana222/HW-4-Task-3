using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4_Task_3
{
    public abstract class Triangle
    {
        protected double SideA;
        protected double SideB;
        protected double CornerC;

        public virtual double GetPerimetr()
        {
            double SideC = Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideB, 2) - 2 * SideA * SideB * Math.Cos(CornerC));
            return SideA + SideB + SideC;
        }
        public virtual double GetArea()
        {
            double SideC = Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideB, 2) - 2 * SideA * SideB * Math.Cos(CornerC));
            double p = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) + (p - SideC));
        }

    }

    public class RightTriangle : Triangle
    {
        double SideC;
        public RightTriangle(double sideA, double sideB, double cornerC)
        {
            if (sideA > 0 && sideB >0)
            {
                SideA = sideA;
                SideB = sideB;
                CornerC = (cornerC / 180) * Math.PI;
                SideC = Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideB, 2) - 2 * SideA * SideB * Math.Cos(CornerC));
                SideC = Math.Round(SideC, MidpointRounding.ToEven);
            }
            else
                throw new Exception();
        }

        public override double GetPerimetr()
        {
            if (CornerC == 90)
                return 2 * SideA + SideC;
            else
               return  SideA + SideB + SideC;
        }

        public override double GetArea()
        {
            if (CornerC == 90)
                return (SideA * SideB) / 2;
            else if (SideA > SideB)
                return (SideB * SideC) / 2;
            else
                return (SideA * SideC);
                
        }
    }

    public class IsoscelesTriangle : Triangle
    {
        double SideC;

        public IsoscelesTriangle(double sideA, double sideB, double cornerC)
        {
            if (sideA > 0 && sideB > 0)
            {
                SideA = sideA;
                SideB = sideB;
                CornerC = (cornerC / 180) * Math.PI;
                SideC = Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideB, 2) - 2 * SideA * SideB * Math.Cos(CornerC));
                SideC = Math.Round(SideC, MidpointRounding.ToEven);
            }
            else
                throw new Exception();
        }

        public override double GetPerimetr()
        {
            if (SideA == SideB)
                return 2 * SideA + SideC;
            else
                return SideA + SideB + SideC;
        }

        public override double GetArea()
        {
            if (SideA == SideB)
                return Math.Abs((Math.Pow(SideA, 2) * Math.Sin(CornerC)) / 2);
            else
                return Math.Abs((Math.Pow(SideB, 2) * Math.Sin(CornerC)) / 2);
        }
    }
}
