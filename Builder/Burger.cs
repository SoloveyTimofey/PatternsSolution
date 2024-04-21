using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Burger
    {
        public string Name;
        public Bun Bun;
        public List<Vegetable> Vegetables;
        public List<Cutlet> Cutlets;
        public List<Souce> Souces;
        public List<Cheese> Cheeses;

        public Burger()
        {
            Vegetables = new List<Vegetable>();
            Cutlets = new List<Cutlet>();
            Souces = new List<Souce>();
            Cheeses = new List<Cheese>();
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Your ").Append(Name).AppendLine(" has:");
            stringBuilder.AppendLine("Bun type: "+Bun.Type);
            if (Vegetables.Count()>0)
            {
                stringBuilder.Append($"{Vegetables.Count()} vegetables: ");
                for (int i = 0; i < Vegetables.Count(); i++)
                {
                    if (i+1==Vegetables.Count())
                    {
                        stringBuilder.AppendLine(Vegetables[i].Type.ToString());
                    }
                    else
                    {
                        stringBuilder.Append(Vegetables[i].Type.ToString() + ", ");
                    }                    
                }
            }
            if (Cutlets.Count() > 0)
            {
                stringBuilder.Append($"{Cutlets.Count()} cutlets: ");
                for (int i = 0; i < Cutlets.Count(); i++)
                {
                    if (i + 1 == Cutlets.Count())
                    {
                        stringBuilder.AppendLine(Cutlets[i].Type.ToString());
                    }
                    else
                    {
                        stringBuilder.Append(Cutlets[i].Type.ToString() + ", ");
                    }
                }
            }
            if (Souces.Count() > 0)
            {
                stringBuilder.Append($"{Souces.Count()} souces: ");
                for (int i = 0; i < Souces.Count(); i++)
                {
                    if (i + 1 == Souces.Count())
                    {
                        stringBuilder.AppendLine(Souces[i].Type.ToString());
                    }
                    else
                    {
                        stringBuilder.Append(Souces[i].Type.ToString() + ", ");
                    }
                }
            }
            if (Cheeses.Count() > 0)
            {
                stringBuilder.Append($"{Cheeses.Count()} cheeses: ");
                for (int i = 0; i < Cheeses.Count(); i++)
                {
                    if (i + 1 == Cheeses.Count())
                    {
                        stringBuilder.AppendLine(Cheeses[i].Type.ToString());
                    }
                    else
                    {
                        stringBuilder.Append(Cheeses[i].Type.ToString() + ", ");
                    }
                }
            }

            return stringBuilder.ToString();
        }
    }
}
