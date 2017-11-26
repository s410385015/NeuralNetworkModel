using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HowToTrainTapirDoDo.Hopfield
{
    public partial class HopfieldControl : UserControl
    {
        public HopfieldModel hfm;
        public int inputN=3;
        public int length=100;
        public HopfieldControl()
        {
            InitializeComponent();
            DisplayUser(false);
        }

        private void HopfieldControl_Load(object sender, EventArgs e)
        {

        }

        private void TrainBtn_Click(object sender, EventArgs e)
        {
            UserInput.Clear();
            length = Input1.GetArray().Length;
            hfm = new HopfieldModel(length, inputN);

            for (int i = 1; i <= inputN;i++ )
            {
                DrawControl.DrawBox d= (DrawControl.DrawBox)this.Controls.Find("Input" + i, true)[0];

                bool[] array = d.GetArray();
                int[] n = new int[array.Length]; 
                Console.WriteLine(array.Length);
                for(int j=0;j<array.Length;j++)
                {
                    if (array[j])
                        n[j] = 1;
                    else
                        n[j] = -1;

                   
                }
                hfm.pushData(n);
            }

           
            hfm.GenerateWeight();
            DisplayUser(true);
            //int[] n4 = new int[] { 1, 1, 1, -1, 1, -1 };
            //hfm.SetInput(n4);
            
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            bool[] array = UserInput.GetArray();
            int[] n = new int[array.Length];

            for (int j = 0; j < array.Length; j++)
            {
                if (array[j])
                    n[j] = 1;
                else
                    n[j] = -1;
            }


            hfm.Recurrent(n);
            
            bool[] tmp = new bool[hfm.input.d.Length];
            for (int j = 0; j < hfm.input.d.Length; j++)
            {
                if (hfm.input.d[j] == 1)
                    tmp[j] = true;
                else
                    tmp[j] = false;
            }
            UserInput.DrawByValue(tmp);
        }

        public void DisplayUser(bool b)
        {
            if(b)
            {
                RunBtn.Show();
                UserInput.Show();
                AutoBtn.Show();
                ClearBtn.Show();
            }
            else
            {
                ClearBtn.Hide();
                RunBtn.Hide();
                UserInput.Hide();
                AutoBtn.Hide();
            }
        }

        private void AutoBtn_Click(object sender, EventArgs e)
        {

            bool[] array = UserInput.GetArray();
            int[] n = new int[array.Length];

            for (int j = 0; j < array.Length; j++)
            {
                if (array[j])
                    n[j] = 1;
                else
                    n[j] = -1;
            }


            hfm.Recurrent_Matrix(n);

            bool[] tmp = new bool[hfm.input.d.Length];
            for (int j = 0; j < hfm.input.d.Length; j++)
            {
                if (hfm.input.d[j] == 1)
                    tmp[j] = true;
                else
                    tmp[j] = false;
            }
            UserInput.DrawByValue(tmp);
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            DisplayUser(false);
            for (int i = 1; i <= inputN; i++)
            {
                DrawControl.DrawBox d = (DrawControl.DrawBox)this.Controls.Find("Input" + i, true)[0];
                d.Clear();
            }
            UserInput.Clear();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            UserInput.Clear();
        }

        
    }
}
