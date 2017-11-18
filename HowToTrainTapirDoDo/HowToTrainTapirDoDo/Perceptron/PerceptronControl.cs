using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HowToTrainTapirDoDo.Perceptron
{
    public partial class PerceptronControl : UserControl
    {
        public int MAX = 5;
        
        public bool locked = false;
        private PerceptronModel pm;
        public PerceptronControl()
        {
            InitializeComponent();
            
            UserOutput.locked = true;
            UserInput.Linked = true;
            DisplayUser(false);
            UserInput.Func = FillUserOuput;
        }

        private void TrainBtn_Click(object sender, EventArgs e)
        {
            if (locked)
                return;

            double a;
            double t;
            try
            {
                a = Convert.ToDouble(Tb1.Text);
                t = Convert.ToDouble(Tb2.Text);
               
            }
            catch
            {
                ErrorAnimator.ShowSync(error);
                return;
            }

            error.Hide();
            locked = true;
            pm = new PerceptronModel(t, a, Input1.GetArray().Length, output1.GetArray().Length,this);


            for(int i=1;i<=MAX;i++)
            {

                double[] tmpIN = new double[Input1.GetArray().Length];
                double[] tmpOUT = new double[output1.GetArray().Length];
                bool[] tmp;

                DrawControl.DrawBox d1=(DrawControl.DrawBox)this.Controls.Find("Input"+i,true)[0];
                DrawControl.DrawBox d2 = (DrawControl.DrawBox)this.Controls.Find("output" + i, true)[0];
                d1.locked = true;
                d2.locked = true;

               Log.AppendText("Pattern " + i + " \n");
               tmp=d1.GetArray();
               for (int j = 0; j < tmp.Length; j++)
               {
                   tmpIN[j] = (tmp[j]) ? 1 : 0;
               }
        
               tmp = d2.GetArray();
      
               for (int j = 0; j < tmp.Length; j++)
               {
                   tmpOUT[j] = (tmp[j]) ? 1 : -1;
               }

               Log.AppendText("("+String.Join(",", tmpIN) + ")\n(" + String.Join(",", tmpOUT) + ")\n\n");
         
               Data d = new Data(tmpIN, tmpOUT);
               pm.q.Enqueue(d);
            }

            pm.GenerateWeight();
            pm.Train();
        }


        public void LogShow(String str)
        {
            this.Invoke(new MethodInvoker(delegate() { Log.AppendText(str); }));
         
        }


        //通知training結束
        public void Notification()
        {
            this.Invoke(new MethodInvoker(delegate() {
                locked = false;
                for (int i = 1; i <= MAX; i++)
                {
                    DrawControl.DrawBox d1 = (DrawControl.DrawBox)this.Controls.Find("Input" + i, true)[0];
                    DrawControl.DrawBox d2 = (DrawControl.DrawBox)this.Controls.Find("output" + i, true)[0];
                    d1.locked = false;
                    d2.locked=false;
                }

                DisplayUser(true);
            }));
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= MAX; i++)
            {
                DrawControl.DrawBox d1 = (DrawControl.DrawBox)this.Controls.Find("Input" + i, true)[0];
                DrawControl.DrawBox d2 = (DrawControl.DrawBox)this.Controls.Find("output" + i, true)[0];
                d1.Clear();
                d2.Clear();
            }
            DisplayUser(false);
        }
       
        public void FillUserOuput()
        {
            this.Invoke(new MethodInvoker(delegate()
            {
               
                Double[] d = new Double[UserInput.GetArray().Length];
                Boolean[] b = new Boolean[UserOutput.GetArray().Length];
                for (int i = 0; i < d.Length; i++)
                {
                    if (UserInput.GetArray()[i])
                        d[i] = 1;
                    else
                        d[i] = 0;
                }
            
                for (int i = 0; i < pm.weight.Length; i++)
                {
                    if (d * pm.weight[i] >= pm.threshold)
                        b[i] = true;
                    else
                        b[i] = false;
                }
           
                UserOutput.DrawByValue(b);
             
            }));
        }

        public void DisplayUser(bool b)
        {
            if(b)
            {
                label4.Show();
                label6.Show();
                UserInput.Show();
                UserOutput.Show();
                UserInput.Clear();
                UserOutput.Clear();

            }
            else
            {
                label4.Hide();
                label6.Hide();
                error.Hide();
                UserInput.Clear();
                UserOutput.Clear();
                UserInput.Hide();
                UserOutput.Hide();
            }
        }
    }
}
