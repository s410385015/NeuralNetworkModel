using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace HowToTrainTapirDoDo.Perceptron
{
    public struct Data
    {
        public double[] input;
        public double[] output;

        public Data(double[] d1, double[] d2)
        {
            input = new double[d1.Length];
            output = new double[d2.Length];
            d1.CopyTo(input,0);
            d2.CopyTo(output, 0);
        }
        public Data(double[] d1,int d2)
        {
            input = new double[d1.Length];
            d1.CopyTo(input, 0);
            output = new double[d2];
        }
        public static double operator *(Data d1, Data d2)
        {
            double tmp = 0;
            for(int i=0;i<d1.input.Length;i++)
                tmp+=d1.input[i]*d2.input[i];
            return tmp;
        }
        public static Data operator *(double d1, Data d2)
        {
            Data data = new Data(d2.input,d2.output);
            for (int i = 0; i < data.input.Length; i++)
                data.input[i] *= d1;
            return data;
        }


        public static double operator *(double[] d1, Data d2)
        {
            double data=0;
            for (int i = 0; i < d1.Length; i++)
                data += d1[i] * d2.input[i];
            return data;
        }
        public static Data operator +(Data d1, Data d2)
        {
            Data data =  new Data(d1.input,d1.output);
            for (int i = 0; i < data.input.Length; i++)
                data.input[i] += d2.input[i];
            return data;
        }
       

        public static bool operator ==(double[]d1,Data d2)
        {
            for (int i = 0; i < d1.Length;i++ )
            {
                if (!d1[i].Equals(d2.output[i]))
                    return false;
            }
            return true;
        }
        public static bool operator !=(double[] d1, Data d2)
        {
            for (int i = 0; i < d1.Length; i++)
            {
                if (!d1[i].Equals(d2.output[i]))
                    return true;
            }
            return false;
        }
        public void Show()
        {
            Console.WriteLine(String.Join(",", input));
        }
       
    }
    class PerceptronModel
    {
        public double threshold;
        public double rate;
        private int patternN;
        private int outN;
        private BackgroundWorker PerceptronBW;
        public Queue<Data> q;
        public Data[] weight;
        private PerceptronControl myControl;
        public PerceptronModel(double t,double a,int p,int o,PerceptronControl parent)
        {
            threshold = t;
            rate = a;
            patternN = p;
            outN = o;
            myControl = parent;

            q = new Queue<Data>();

            PerceptronBW = new BackgroundWorker();
            PerceptronBW.WorkerReportsProgress = true;
            PerceptronBW.WorkerSupportsCancellation = true;
            PerceptronBW.DoWork += new DoWorkEventHandler(RunModel);
        }
        private void RunModel(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker ReceiveWorker = sender as BackgroundWorker;
            int round = 0;
            int c = 0;
            while(round!=q.Count)
            {
                Data tmp;
                double[] expect = new double[outN];
                tmp = q.Dequeue();
             
                for(int i=0;i<outN;i++)
                    expect[i] = (weight[i] * tmp >= threshold) ? 1 : -1;
               
                if (expect == tmp)
                    round++;
                else
                {
                    for (int i = 0; i < outN; i++)
                        weight[i] = weight[i] + ((rate * (tmp.output[i] - expect[i])) * tmp);


                   
                    round = 0;

                 
                }

                q.Enqueue(tmp);

                c++;

                if (c > 5000)
                    break;
                
            }
            

            if(c>5000)
                myControl.LogShow("Training fail\n(");
            else
                myControl.LogShow("Training time : "+c+"\n(");
            myControl.LogShow("Weight:\n(");
            for (int i = 0; i < outN; i++)
                myControl.LogShow(String.Join(",",weight[i].input)+"\n");

            myControl.LogShow(")\n");
            myControl.Notification();
        }

        public void GenerateWeight()
        {
           
            weight = new Data[outN];
            double[] tmp=new double[patternN];
           
            for(int i=0;i<patternN;i++)
                tmp[i]=1;
            
            for (int i = 0; i < outN; i++)
                    weight[i] = new Data(tmp,patternN);
          
          
        }

        public void Train()
        {
            PerceptronBW.RunWorkerAsync();
        }
    }
}
