using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowToTrainTapirDoDo.TLU
{
    //XY 以0.5為最小單位
    //(1,1)在畫面顯示實際上是(0.5,0.5)

    public class XYGraph
    {
        //實際pixel長度
        public int Width;
        public int Height;
        //換算成XY座標的格數
        public int w;
        public int h;
        public int pixel;
        public Point Center;
        public int[] Map;
        public int negative;
        public int positive;
        public Point last;
        public XYGraph()
        {
            
        }
        public XYGraph(int W,int H,int P)
        {
            last.X = last.Y = -1;
            negative = 0;
            positive = 0;
            Width = W;
            Height = H;
            pixel = P;
            w = Width / pixel + 1;
            h = Height / pixel + 1;
            Center.X = W / 2;
            Center.Y = H / 2;
            Map = new int[w * h];

            for (int i = 0; i < Map.Length; i++) Map[i] = -1;
        }

        //回傳panel點p在座標軸上代表的(X,Y)
        public Point ConvertToXY(Point p)
        {
            Point xy = new Point((Int16)Math.Round((p.X - Center.X) / (double)pixel), (Int16)Math.Round((Center.Y - p.Y) / (double)pixel));
            return xy;
        }

        //回傳陣第n位列代表的(X,Y);
        public Point ConvertToXY(int n)
        {
            Point xy = ConvertToPanel(n);
            xy = ConvertToXY(xy);
            return xy;
        }
        //回傳panel點p實際在陣列中存的位置
        public int ConvertToArray(Point p)
        {
            Point xy = new Point((Int16)Math.Round((p.X - Center.X) / (double)pixel), (Int16)Math.Round((Center.Y - p.Y) / (double)pixel));
            return xy.X + w / 2 + (xy.Y + h / 2) * w;
        }

        //回傳點panel點p實際在(X,Y)上的位置
        public Point ConvertToPanel(Point p)
        {
            Point xy = new Point((Int16)Math.Round((p.X - Center.X) / (double)pixel), (Int16)Math.Round((Center.Y - p.Y) / (double)pixel));
            xy = new Point(Center.X + (xy.X * pixel) , Center.Y - (xy.Y * pixel));
            return xy;
        }

        //回傳陣列第n位實際在panel上的位置
        public Point ConvertToPanel(int n)
        {
            int x=n%w;
            int y=n/w;
            Point xy = new Point(x * pixel, Height - y * pixel);
            return xy;
        }

        public void Reset()
        {
            for (int i = 0; i < Map.Length; i++) Map[i] = -1;
        }
    }
}
