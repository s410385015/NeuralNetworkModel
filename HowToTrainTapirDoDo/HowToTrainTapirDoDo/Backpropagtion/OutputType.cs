using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowToTrainTapirDoDo.Backpropagtion
{
    public class OutputType
    {
        public double[,] Output;

        public OutputType()
        {
            Output = new double[10, 4]
            {
                {0,0,0,0},
                {0,0,0,1},
                {0,0,1,0},
                {0,0,1,1},
                {0,1,0,0},
                {0,1,0,1},
                {0,1,1,0},
                {0,1,1,1},
                {1,0,0,0},
                {1,0,0,1}
            };
        }

        public double[] getOutput(int n)
        {
            double[] d = new double[4];
            for (int i = 0; i < d.Length; i++)
                d[i] = Output[n, i];
            return d;
        }
    }
}
