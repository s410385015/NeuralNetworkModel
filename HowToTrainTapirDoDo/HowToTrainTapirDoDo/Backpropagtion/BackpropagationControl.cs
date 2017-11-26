using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HowToTrainTapirDoDo.Backpropagtion
{
    public partial class BackpropagationControl : UserControl
    {
        private int dataN = 0;
        private List<UserInput> myList;
        private OutputType outputtype;
        public BackpropagationModel bm;
        public bool locked = false;
        private int t = 0;
        public BackpropagationControl()
        {
            InitializeComponent();
            myList=new List<UserInput>();
            outputtype = new OutputType();
            ShowBox.locked = true;
            HorListInit();
            OutputLabel.Text="";
            UserBox.Linked = true;
            UserBox.locked = true;
            UserBox.Func = Recongize;
        }
        public void HorListInit()
        {
            HorList.View = View.Tile;
            HorList.Alignment = ListViewAlignment.Left;
            HorList.OwnerDraw = true;
            HorList.DrawItem += HorList_DrawItem;
            HorList.TileSize = new Size(HorList.ClientSize.Width/10, HorList.ClientSize.Height-5);
            for (int i = 0; i < 10; i++)
                HorList.Items.Add(i.ToString());
           
        }
        private void BackpropagationControl_Load(object sender, EventArgs e)
        {

        }

        private void TrainBtn_Click(object sender, EventArgs e)
        {

            if (locked)
                return;
            timer1.Start();
            bm = new BackpropagationModel(81, 9, 4,this);

            for (int i = 0; i < myList.Count;i++ )
                bm.q.Enqueue(myList[i]);

           /*
            double[] d1 = new double[2] { 1, 0 };
            double[] d2 = new double[2] { 0,1 };
            UserInput u1 = new UserInput(d1, d2);
            bm.q.Enqueue(u1);


            double[] d3 = new double[2] { 1, 1 };
            double[] d4 = new double[2] { 1, 0 };
            UserInput u2 = new UserInput(d3, d4);
            bm.q.Enqueue(u2);
            
            */ 
            //Console.WriteLine(bm.Sign(0.5));
            bm.train();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            InputBox.Clear();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            int n;
            try
            {
                n = HorList.SelectedIndices[0];
            }
            catch { return; }
         

            dataN++;
            DataList.Items.Add("Input-" + dataN + "(" + n + ")");
            Console.WriteLine(String.Join(",", outputtype.getOutput(n)));

            /*
            double[] d=new double[10];
            for (int i=0; i < 10; i++)
                d[i] = 0;
            d[n] = 1;
            */
            UserInput u = new UserInput(BoolToDouble(InputBox.GetArray()), outputtype.getOutput(n));
            myList.Add(u);
            InputBox.Clear();
        }

        public double[] BoolToDouble(bool[] b)
        {
            double[] d = new double[b.Length];

            for(int i=0;i<b.Length;i++)
            {
                if (b[i])
                    d[i] = 1;
                else
                    d[i] = 0;
            }

            return d;
        }


        public bool[] DoubleToBool(double[] d)
        {
            bool[] b = new bool[d.Length];

            for (int i = 0; i < d.Length; i++)
            {
                if (d[i].Equals(1))
                    b[i] = true;
                else
                    b[i] = false;
            }

            return b;
        }

      
       


        private void HorList_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            Color textColor = Color.White;
            if ((e.State & ListViewItemStates.Selected) != 0)
            {
                e.Graphics.FillRectangle(SystemBrushes.Highlight, e.Bounds);
                textColor = SystemColors.HighlightText;
            }
            else
            {
                Color color = Color.FromArgb(27, 32, 41);
                SolidBrush brush = new SolidBrush(color);   
                e.Graphics.FillRectangle(brush, e.Bounds);
            }
            e.Graphics.DrawRectangle(Pens.DarkGray, e.Bounds);

            TextRenderer.DrawText(e.Graphics, e.Item.Text, HorList.Font, e.Bounds,
                                  textColor, Color.Empty,
                                  TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            int n;
            try{
                n=DataList.SelectedIndex;
                myList.RemoveAt(n);
                DataList.Items.RemoveAt(n);
                ShowBox.Clear();
            }
            catch { return; }
            
            
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
             DataList.Items.Clear();
             myList.Clear();
             OutputLabel.Text = "Input";
             UserBox.Clear();
             ShowBox.Clear();
             InputBox.Clear();
        }

        private void DataList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(myList.Count + "" + DataList.SelectedIndex);
            try
            {
                UserInput u = myList[DataList.SelectedIndex];
                ShowBox.DrawByValue(DoubleToBool(u.input.array));
            }
            catch { return; }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }

        private void drawBox1_Load(object sender, EventArgs e)
        {

        }

        
        public void Notification()
        {
            this.Invoke(new MethodInvoker(delegate() {
                timer1.Stop();
                OutputLabel.Text = "Done";
                UserBox.locked = false;
                locked = false;
            }));
        }

     
        public void Recongize()
        {
            this.Invoke(new MethodInvoker(delegate() {

                Data data = new Data(BoolToDouble(UserBox.GetArray()));
                double [] d=bm.Recongize(data);
                //Console.WriteLine("----");
                //bm.Debug(d);

                /*
                double n = 0;
                int m=-1;
                for(int i=0;i<10;i++)
                {
                    if (d[i] > n)
                    {
                        n = d[i];
                        m = i;
                    }
                }
                

                if(n>=(1-bm.minError*2))
                    OutputLabel.Text = m.ToString();
                */
                
                for(int i=0;i<d.Length;i++)
                {
                    if (d[i] <= bm.minError*2)
                        d[i] = 0;
                    if (d[i] >= (1 - bm.minError*2))
                        d[i] = 1;
                }

               // bm.Debug(d);

                for(int i=0;i<10;i++)
                {
                    bool flag=true;
                    for(int j=0;j<d.Length;j++){
                        if(!d[j].Equals(outputtype.getOutput(i)[j]))
                        {
                            flag=false;
                            break;
                        }
                    
                    }
                    if (flag)
                    {
                        OutputLabel.Text = i.ToString();
                        return;
                    }
                    
                }
                 
            }));
        }

        private void ClnBtn_Click(object sender, EventArgs e)
        {
            UserBox.Clear();
            OutputLabel.Text = "Input";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            String str = "Training";
            for (int i = 0; i < t; i++)
                str += ".";

            t = (t + 1) % 5;

            this.Invoke(new MethodInvoker(delegate()
            {
                OutputLabel.Text = str;
            }));
        }

    }
}
