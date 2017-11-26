using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace HowToTrainTapirDoDo.Backpropagtion
{
    public struct Data
    {
        public double[] array;

        public Data(double[] d)
        {
            array = new double[d.Length];
            d.CopyTo(array,0);
        }

        public static double operator *(Data d1, Data d2)
        {
            double data=0;
            for (int i = 0; i < d1.array.Length; i++)
                data += (d1.array[i] * d2.array[i]);

            return data;
        }
    }
    

    public struct UserInput
    {
        public Data input;
        public Data output;

        public UserInput(double[] d1,double[] d2)
        {
            input = new Data(d1);
            output = new Data(d2);
        }
    }
   

    public class BackpropagationModel
    {
        private double threshold;
        private double rate;
        private int inputN;
        private int hideN;
        private int outputN;
        public double minError = 0.1;
        private Data[] weightItoH;
        private Data[] weightHtoO;
        private BackgroundWorker bpBW;
        public Queue<UserInput> q;
        private BackpropagationControl myControl;
        private int MAXtime = 1000;
        //一層的BP

        public BackpropagationModel(int i,int h,int o,BackpropagationControl parent)
        {
            threshold = 0.0001;
            rate = 1;

            inputN = i;
            hideN = h;
            outputN = o;
            q = new Queue<UserInput>();


            myControl = parent;
            bpBW = new BackgroundWorker();
            bpBW.WorkerReportsProgress = true;
            bpBW.WorkerSupportsCancellation = true;
            bpBW.DoWork += new DoWorkEventHandler(Learning);
        }

        public void GenerateWeight()
        {
            Random r = new Random(); 
            weightItoH = new Data[hideN];
            weightHtoO = new Data[outputN];

            //double[] d = new double[inputN+1];
            //for (int j = 0; j < d.Length - 1; j++)
                //d[j] = r.NextDouble();
            
            //d[inputN]=0.5;
            for (int j = 0; j < weightItoH.Length; j++)
            {
                double[] d = new double[inputN + 1];
                for (int i = 0; i < d.Length - 1; i++)
                    d[i] = r.NextDouble();
                d[inputN] = 0.5;
                weightItoH[j] = new Data(d);
            }


            //d = new double[hideN+1];
            //for (int j = 0; j < d.Length; j++)
               // d[j] = 0.5;
            for (int j = 0; j < weightHtoO.Length; j++)
            {
                double[] d = new double[hideN+1];
                for (int i = 0; i < d.Length - 1; i++)
                     d[j] = r.NextDouble();
                d[hideN] = 0.5;
                weightHtoO[j] = new Data(d);
            }
        }

        public double Sign(double d)
        {
            return 1/(1+Math.Pow(Math.E,-d));
        }

        public bool RunModel()
        {
           //Console.WriteLine("---------------");
            UserInput u= q.Dequeue();

            double[] d1=new double[hideN];
            double[] d2 = new double[outputN];
            
            //計算hidden layer 的output
            for (int i = 0; i < hideN; i++)
                d1[i] = Sign(u.input * weightItoH[i]+1*weightItoH[i].array[inputN]);
            Data hide_out = new Data(d1);

            //計算output layer 的output
            for (int i = 0; i < outputN; i++)
                d2[i] = Sign(hide_out * weightHtoO[i]+1*weightHtoO[i].array[hideN]);
            Data real_out = new Data(d2);


            double[] e1 = new double[outputN];
            double[] e2 = new double[hideN];

            //計算output layer的誤差
            for (int i = 0; i < outputN; i++)
                e1[i] = (real_out.array[i] - u.output.array[i]) * real_out.array[i] * (1 - real_out.array[i]);
           
           
            //計算hidden layer的誤差
            for (int i = 0; i < hideN; i++)
                e2[i] = hide_out.array[i] * (1 - hide_out.array[i]) * activation(i, e1);
            

            //update ouput layer to hidden layer的權重
            for(int i=0;i<outputN;i++)
                for (int j = 0; j < hideN; j++)
                    weightHtoO[i].array[j] = weightHtoO[i].array[j] - (rate * e1[i] * hide_out.array[j]);
            
            for(int i=0;i<outputN;i++)
                weightHtoO[i].array[hideN] = weightHtoO[i].array[hideN] - (rate * e1[i]);
           

               

            //update hidden layer to input layer的權重
            for (int i = 0; i < hideN; i++)
                for (int j = 0; j < inputN; j++)
                    weightItoH[i].array[j] = weightItoH[i].array[j] - (rate * e2[i] * u.input.array[j]);

            for (int i = 0; i < hideN; i++)
                weightItoH[i].array[inputN] = weightItoH[i].array[inputN] - (rate * e2[i]);

            q.Enqueue(u);



           

            
            //Debug(e1);

            //Debug(u.output.array);
            //Debug(d2);
            //Debug(weightHtoO[0].array);
            //Debug(weightHtoO[1].array);

            for (int i = 0; i < outputN; i++)
            {
                if (Math.Abs(real_out.array[i]-u.output.array[i]) > minError)
                    return false;
            }
       
            return true;
        }
        public void Debug(double[] d)
        {
            Console.WriteLine(String.Join(",", d));
        }

        private void Learning(object sender, DoWorkEventArgs e)
        {
            int c = 0;
            int index = 0;
           
            GenerateWeight();
          
            while(c!=q.Count)
            {
                if (RunModel())
                    c++;
                else
                    c = 0;
                index++;
                if (index == MAXtime)
                    break;
                Console.WriteLine(index);
            }

            Console.WriteLine("Finish");
            myControl.Notification();
           // for (int i = 0; i < weightItoH.Length; i++)
               // Console.WriteLine(String.Join(",", weightItoH[i].array));
            
            //for(int i=0;i<weightHtoO.Length;i++)
                //Console.WriteLine(String.Join(",",weightHtoO[i].array));
        }
        public double[] Recongize(Data user)
        {
            double[] d1 = new double[hideN+1];
            double[] d2 = new double[outputN];

            //計算hidden layer 的output
            for (int i = 0; i < hideN; i++)
                d1[i] = Sign(user * weightItoH[i] + 1 * weightItoH[i].array[inputN]);
            Data hide_out = new Data(d1);

            //計算output layer 的output
            for (int i = 0; i < outputN; i++)
                d2[i] = Sign(hide_out * weightHtoO[i] + 1 * weightHtoO[i].array[hideN]);
            Data real_out = new Data(d2);


            return d2;
        }
        public double activation(int n,double[] e)
        {
            double d = 0;
            for (int i = 0; i < outputN; i++)
                d += e[i] * weightHtoO[i].array[n];
            return d;
        }

        public void train()
        {
            bpBW.RunWorkerAsync();
        }

    }
}
