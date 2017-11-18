using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HowToTrainTapirDoDo.TLU;
namespace HowToTrainTapirDoDo
{
    public partial class TLUControl : UserControl
    {
        public XYGraph XYgraph;
        public TLUmodel tlu;
        public bool locked=false;
        public TLUControl()
        {
            InitializeComponent();
            XYgraph = new XYGraph(XY_Panel.Width, XY_Panel.Height, 10);
            tlu = new TLUmodel(1.5, 1, new Data(80, -100),5000,this);
            error.Hide();
            XY_Line_Panel.Hide();
        }

        private void TLUControl1_Load(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true); 
            this.UpdateStyles();
        }

        private void XY_Panel_Paint(object sender, PaintEventArgs e)
        {
            //Color color = Color.White;
            Color color = Color.FromArgb(0, 159, 247);
            Pen pen = new Pen(color, 0.5f);
            Graphics g = e.Graphics;

            //10 pixel per unit
            //0.5 per unit
            //2 unit per line
            //從中心繪製橫線
            for (int i = 1; i <= XYgraph.h / 4; i++)
            {
                g.DrawLine(pen, 0, XYgraph.Center.Y + XYgraph.pixel * 2 * i, XYgraph.Width, XYgraph.Center.Y + XYgraph.pixel * 2 * i);
                g.DrawLine(pen, 0, XYgraph.Center.Y - XYgraph.pixel * 2 * i, XYgraph.Width, XYgraph.Center.Y - XYgraph.pixel * 2 * i);
            }

            //從中心繪製縱線
            for (int i = 1; i <= XYgraph.w / 4; i++)
            {
                g.DrawLine(pen, XYgraph.Center.X + XYgraph.pixel * 2 * i, 0, XYgraph.Center.X + XYgraph.pixel * 2 * i, XYgraph.Height);
                g.DrawLine(pen, XYgraph.Center.X - XYgraph.pixel * 2 * i, 0, XYgraph.Center.X - XYgraph.pixel * 2 * i, XYgraph.Height);
            }


            //繪製中央十字
            color = Color.FromArgb(0, 98, 214);
            pen = new Pen(color, 5);
            g.DrawLine(pen, XYgraph.Center.X, 0, XYgraph.Center.X, XYgraph.Height);
            g.DrawLine(pen, 0, XYgraph.Center.Y, XYgraph.Width, XYgraph.Center.Y);

            pen.Dispose();
            g.Dispose();
        }


        

        public void RedrawPoint()
        {
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            Graphics g = XY_Point_Panel.CreateGraphics();


            for (int i = 0; i < XYgraph.Map.Length; i++)
            {

                if (XYgraph.Map[i] != -1)
                {
                    Point tmp = XYgraph.ConvertToPanel(i);

                    if (XYgraph.Map[i] == 1)
                        g.FillEllipse(redBrush, tmp.X - (XYgraph.pixel / 2), tmp.Y - (XYgraph.pixel / 2), XYgraph.pixel, XYgraph.pixel);
                    else
                        g.FillEllipse(yellowBrush, tmp.X - (XYgraph.pixel / 2), tmp.Y - (XYgraph.pixel) / 2, XYgraph.pixel, XYgraph.pixel);
                }
            }
            redBrush.Dispose();
            yellowBrush.Dispose();
        }


        private void XY_Point_Panel_MouseMove(object sender, MouseEventArgs e)
        {
            Point p = XY_Point_Panel.PointToClient(Cursor.Position);
            if (XYgraph.Map[XYgraph.ConvertToArray(p)] != -1)
            {
                if (XYgraph.last != p)
                {
                    Point tmp = XYgraph.ConvertToXY(p);
                    XY_Tip.SetToolTip(XY_Point_Panel, (tmp.X * 0.5) + "," + (tmp.Y * 0.5) + " value = " + XYgraph.Map[XYgraph.ConvertToArray(p)]);
                    XYgraph.last = p;
                }
            }
            else
            {
                
                XY_Tip.SetToolTip(XY_Panel, "");
            }
        }

        private void XY_Point_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (locked)
                return;
            Point p = XY_Point_Panel.PointToClient(Cursor.Position);
            Graphics g = XY_Point_Panel.CreateGraphics();
            SolidBrush brush;


            int value = -1;
            if (e.Button == MouseButtons.Left)
            {
                value = 1;
                brush = new SolidBrush(Color.Red);
            }
            else
            {
                value = 0;
                brush = new SolidBrush(Color.Yellow);
            }


            if (XYgraph.Map[XYgraph.ConvertToArray(p)] == value)
            {
                XY_Point_Panel.Refresh();
                XYgraph.Map[XYgraph.ConvertToArray(p)] = -1;
                RedrawPoint();

            }
            else
            {
                Point tmp = XYgraph.ConvertToPanel(p);
                //繪製的起點為左上角,因為要減到1/2的pixel
                g.FillEllipse(brush, tmp.X - XYgraph.pixel / 2, tmp.Y - XYgraph.pixel / 2, XYgraph.pixel, XYgraph.pixel);
                Console.WriteLine((tmp.X - XYgraph.pixel / 2) + " " + (tmp.Y - XYgraph.pixel / 2));
                XYgraph.Map[XYgraph.ConvertToArray(p)] = value;


            }

            brush.Dispose();
            g.Dispose();
        }


        

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            if (!locked)
            {
                XY_Point_Panel.Refresh();
                tlu.Reset();
                XYgraph.Reset();
                Log.Clear();
            }
        }

        private void TrainBtn_Click(object sender, EventArgs e)
        {
            if (locked)
                return;
            error.Hide();
            double a, t, w1, w2;
            int m;
            try
            {
                a = Convert.ToDouble(Tb1.Text);
                t = Convert.ToDouble(Tb2.Text);
                w1 = Convert.ToDouble(Tb3.Text);
                w2 = Convert.ToDouble(Tb4.Text);
                m = Convert.ToInt16(Tb5.Text);
            }
            catch
            {

                ErrorAnimator.ShowSync(error);
                return;
            }

            error.Hide();
            ShowLog("Create TLU model with\n");
            ShowLog("Max traing round:"+m);
            ShowLog("\nLearning Rate:"+a);
            ShowLog("\nThreshold:"+t);
            ShowLog("\nw1:"+w1);
            ShowLog("\nw2:" + w2);
            ShowLog("\nTraining Data:\n");
            tlu = new TLUmodel(t, a, new Data(w1, w2),m,this);

            for(int i=0;i<XYgraph.Map.Length;i++)
            {
                if(XYgraph.Map[i]!=-1)
                {
                    Point p = XYgraph.ConvertToXY(i);
                    Console.WriteLine(p.X + " " + p.Y + " v=" + XYgraph.Map[i]);
                    Data tmp = new Data(p.X*0.5, p.Y*0.5, XYgraph.Map[i]);
                    tlu.q.Enqueue(tmp);

                    ShowLog("( "+(p.X * 0.5) + " , " + (p.Y * 0.5) + " ) value=" + XYgraph.Map[i]+"\n");
                }
            }
            tlu.Train();
        }

    
        private void Tb3_MouseClick(object sender, MouseEventArgs e)
        {
            error.Hide();
        }

        public void Notification(double a,double b,double t)
        {
            this.Invoke(new MethodInvoker(delegate()
            {
                try{
                    XY_Point_Panel.Refresh();
                    RedrawPoint();
                    //Color color = Color.FromArgb(0, 159, 247);
                    Pen pen = new Pen(Color.White, 3f);
                    Graphics g = XY_Point_Panel.CreateGraphics();
                 
                
                    double x1, x2, y1, y2;
                    if (!a.Equals(0))
                    {
                        y1 = XYgraph.h / 4 + 1;
                        y2 = -y1;
                        x1 = (t - b * y1) / a;
                        x2 = (t - b * y2) / a;
                       
                    }
                    else
                    {
                        x1 = XYgraph.w / 4 + 1;
                        x2 = -x1;
                        y1 = (t - a * x1) / b;
                        y2 = (t - a * x2) / b;
                       
                    }
                    g.DrawLine(pen, (float)(XYgraph.Center.X + x1 * XYgraph.pixel * 2),
                                    (float)(XYgraph.Center.Y - y1 * XYgraph.pixel * 2),
                                    (float)(XYgraph.Center.X + x2 * XYgraph.pixel * 2),
                                    (float)(XYgraph.Center.Y - y2 * XYgraph.pixel * 2));

                    pen.Dispose();
                    g.Dispose();
                }
                catch
                {

                }
           }));

        }

       public void ShowLog(string s)
       {
           this.Invoke(new MethodInvoker(delegate() { Log.AppendText(s); }));
       }

       protected override void OnPaint(PaintEventArgs e)
       {

           base.OnPaint(e);
           Graphics g = e.Graphics;
         
           Bitmap b = new Bitmap(this.Width, this.Height);
           Graphics dc = Graphics.FromImage((System.Drawing.Image)b);

       

           g.DrawImage(b, 0, 0);
           dc.Dispose();
       }
        
    }
}
