using System;
using System.Windows;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HowToTrainTapirDoDo.TLU;
namespace HowToTrainTapirDoDo
{
    public partial class Form1 : Form
    {
        public TLUControl tlu;

        public Form1()
        {
            InitializeComponent();
            TabIndexChange(1);
            //tluControl1.Hide();
            //perceptronControl11.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            if (Menu.Width == 253)
            {
                Menu.Visible = false;
                Menu.Width = 56;
                MenuAnimator.ShowSync(Menu);
                Logo.Hide();
            }
            else
            {
                Menu.Visible = false;
                Menu.Width = 253;
                MenuAnimator.ShowSync(Menu);
                LogoAminator.ShowSync(Logo);
            }
        }


        protected override void OnPaint(PaintEventArgs e)
        {


        }

        private void perceptronControl11_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Menu_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        public void TabIndexChange(int i)
        {
            switch(i)
            {
                case 1:
                    tluControl1.Show();
                    perceptronControl11.Hide();
                    break;
                case 2:
                    tluControl1.Hide();
                    perceptronControl11.Show();
                    break;
                case 3:
                    tluControl1.Hide();
                    perceptronControl11.Hide();
                    break;
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            TabIndexChange(1);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            TabIndexChange(2);
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            TabIndexChange(3);
        }


    }
        

      
    
      
    
}
