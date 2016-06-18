using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace theDay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            for (int i = 1900; i <= 2015; i++)
            {
              //  ComboBoxItem item = new ComboBoxItem();
                // item.Content = i;
                comYear.Items.Add(i);
            }




            WebBrowser b = new WebBrowser();
            b.Navigate("https://www.youtube.com/watch?v=k_3H_GMA3Rs");


        

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try { 
            int year = int.Parse(comYear.Text);
            int month =  int.Parse(comMonth.Text);
            int theday = int.Parse(combDay.Text);

            DateTime dt = new DateTime(year, month, theday);




            switch (dt.DayOfWeek.ToString())
            {
                case "Friday": la.Text = "الجمعه "; break;
                case "Sunday": la.Text = "الاحد "; break;
                case "Monday": la.Text = "الاثنين "; break;
                case "Tuesday": la.Text = "الثلاثاء "; break;
                case "Wednesday": la.Text = "الاربعاء "; break;
                case "Thursday": la.Text = "الخميس "; break;
                case "Saturday": la.Text = "السبت "; break;



                default: la.Text = " العطل من البرنامج نفسة";
                    break;
            }
          


            }
            catch
            {
                MessageBox.Show("دخل تاريخ صحيح لو سمحت ");
            }
          






           // MessageBox.Show(dt.DayOfWeek.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();


        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            this.Opacity = 100;

        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }



        int flag ;
        int valueX ;
        int valueY ;

private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
             flag = 1;
             valueX = e.X;
             valueY = e.Y;


        }

        


        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag == 1)
            {
                this.SetDesktopLocation(MousePosition.X - valueX, MousePosition.Y - valueY);

            }
        }

        


        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            flag = 0;
        }

        private void label4_Click(object sender, EventArgs e)
        {        
            Process.Start("https://www.facebook.com/mo1994");


        }

       


    
    }
}
