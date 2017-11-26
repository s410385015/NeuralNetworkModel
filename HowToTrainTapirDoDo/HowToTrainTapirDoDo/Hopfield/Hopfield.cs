using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowToTrainTapirDoDo.Hopfield
{
    public struct Weight
    {
        public int[,] w;
        public int p;
        public Weight(int n)
        {
            p = n;
            w = new int[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    w[i, j] = 0;
        }


        public static Data operator*(Weight w1,Data d1)
        {
            int[] d=new int[d1.d.Length];
            for (int i = 0; i < d.Length; i++)
                d[i] = 0;
            for (int i = 0; i < w1.p; i++)
                 for (int j = 0; j < w1.p; j++)
                     d[i] += (w1.w[i, j] * d1.d[j]);

            Data data = new Data(d);
            return data;
        }
        public void Show()
        {
            for (int i = 0; i < p; i++)
            {
                for (int j = 0; j < p; j++)
                    Console.Write(w[i, j] + " ");
                Console.WriteLine("");
            }
        }

    }
    
    public struct Data
    {
        public int[] d;
        public Data(int[] d)
        {
            this.d=new int[d.Length];
            d.CopyTo(this.d, 0);
        }
        public void Show()
        {
            Console.WriteLine(String.Join(" ", d));
        }
        
        
    }
    public class HopfieldModel
    {
        public Weight weight;
        public Data[] data;
        public Data input;
        public int index = 0;
        //pattern number
        private int p;
        //MAX Input Set
        private int MAX;
        private bool b = false;
        private int pixel_index=0;
        public HopfieldModel(int n,int m)
        {
            p=n;
            weight=new Weight(n);
            MAX = m;
            data=new Data[m];
        }

        public bool pushData(int[] d)
        {
            if (index == MAX)
                return false;

            data[index] = new Data(d);
          
            index++;
            return true;
        }
        public void GenerateWeight()
        {
            for(int k=0;k<index;k++)
            {
                for(int i=0;i<p;i++)
                {
                    for(int j=0;j<p;j++)
                    {
                        if (i == j)
                            weight.w[i, j] = 0;
                        else
                            weight.w[i, j] += (data[k].d[i]) * (data[k].d[j]);
                       
                        
                    }
                }
            }
          
            //weight.Show();
        }
        public void SetInput(int[] d)
        {
            b = true;
            input = new Data(d);
        }
        public bool Recurrent(int[] d)
        {
            SetInput(d);
            Data old = new Data(d);
            for (int k = 0; k < p / 10; k++)
            {
                pixel_index = (pixel_index + 1) % p;
                int tmp = 0;
                for (int i = 0; i < p; i++)
                {
                    if (pixel_index != i)
                    {
                        tmp += input.d[i] * weight.w[pixel_index, i];
                    }
                }
                if (tmp > 0)
                    input.d[pixel_index] = 1;
                else if (tmp < 0)
                    input.d[pixel_index] = -1;
            }
            if (Enumerable.SequenceEqual(old.d, input.d))
                return false;
            return true;
        }
        public bool Recurrent_Matrix(int[] d)
        {
            SetInput(d);
            if (b)
            {
                Data tmp = weight * input;
            
                for (int i = 0; i < tmp.d.Length; i++)
                {
                    if (tmp.d[i] > 0)
                        tmp.d[i] = 1;
                    else if (tmp.d[i] < 0)
                        tmp.d[i] = -1;
                    else
                        tmp.d[i] = input.d[i];

                }


                input.Show();

                if (Enumerable.SequenceEqual(tmp.d,input.d))
                    return false;

                input = new Data(tmp.d);
                return true;
                
            }
            return false;
        }
    }
}
