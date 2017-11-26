using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace HowToTrainTapirDoDo.TLU
{

    public struct Data
    {
        public double x,y;
        public int output;
        public Data(double d1,double d2)
        {
            x = d1;
            y = d2;
            output = 0;
        }
        public Data(double d1, double d2,int o)
        {
            x = d1;
            y = d2;
            output = o;
        }
        public static double operator*(Data d1, Data d2)
        {
            return d1.x * d2.x + d1.y * d2.y;
        }
        public static Data operator*(double d1, Data d2)
        {
            Data data=new Data(d1*d2.x,d1*d2.y);
            return data;
        }
        public static Data operator+(Data d1, Data d2)
        {
            Data data = new Data(d1.x+d2.x, d1.y+d2.y);
            return data;
        }
    }
    public class TLUmodel
    {
     
        private int n_pattern;
        private double threshold;
        private double rate;
        private int Max = 5000;
        public Data weight;
        public Queue<Data> q;
        private BackgroundWorker TLUbk;
        private TLUControl myControl;
        public bool flag = false;
        public TLUmodel(double t,double a,Data d,int m,TLUControl parent)
        {
            Max = m;
            myControl = parent;
            q = new Queue<Data>();
            threshold = t;
            rate = a;
            weight = d;
            TLUbk = new BackgroundWorker();
            TLUbk.WorkerReportsProgress = true;
            TLUbk.WorkerSupportsCancellation = true;
            TLUbk.DoWork += new DoWorkEventHandler(RunModel);

        }
        private void RunModel(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker ReceiveWorker = sender as BackgroundWorker;
            int count=0;
            int timer = 0;
            int m = 0;
            while(count!=n_pattern)
            {
                int o;
                Data tmp;    
                tmp=q.Dequeue();
                
                o = (weight * tmp >= threshold) ? 1 : 0;

                if (o == tmp.output)
                    count++;
                else
                {
                    count = 0;
                    weight = weight + (rate * (tmp.output - o)) * tmp;
                }
                q.Enqueue(tmp);
                if(timer>20)
                {
                    timer = 0;
                    Console.WriteLine(m);
                    myControl.Notification(weight.x, weight.y, threshold);
                    
                }
                if(m>=Max)
                {
                    myControl.ShowLog("Reach the max round - train fail  -w1:" + weight.x + " w2:" + weight.y + "\n");
                    break;
                }
                timer++;
                m++;
                Console.WriteLine(tmp.y+" "+tmp.x + " " + weight.x + " " + weight.y);
                System.Threading.Thread.Sleep(1);
                if (flag)
                    break;
            }

            if(m<Max)
                myControl.ShowLog("Finsih-find weight:\n ( W1: " + weight.x + " , W2: " + weight.y+" )\n");
            myControl.Notification(weight.x, weight.y,threshold);
            myControl.ReleaseBtn();
         
            
        }

        public bool Train()
        {
            if(q.Count>0)
            {
                n_pattern = q.Count;
                TLUbk.RunWorkerAsync();
                return true;
            }
            return false;
        }
        public void Reset()
        {
            q.Clear();
        }

      
    }
}
