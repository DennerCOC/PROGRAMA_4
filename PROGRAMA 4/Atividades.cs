using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROGRAMA_4
{
    public partial class Atividades : Form
    {
        public Atividades()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Essas são suas novas metas de horários para suas atividades.\n As mais importantes foram priorizadas e ganharam mais tempo";
            button1.Enabled = false;

            switch (textBox20.Text)
            {
                case "1":
                int num;
                num = Convert.ToInt32(textBox30.Text);
                num = int.Parse(textBox30.Text);
                    if (num > 3)
                    {
                        num = num - 3;
                        textBox30.Text = Convert.ToString(num);
                    }
                    else
                    {
                        textBox30.Text = Convert.ToString(num);
                    }
                    break;
                case "2":
                    int num2;
                    num2 = Convert.ToInt32(textBox30.Text);
                    num2 = int.Parse(textBox30.Text);
                    if (num2 > 2)
                    {
                        num2 = num2 - 1;
                        textBox30.Text = Convert.ToString(num2);
                    }
                    else
                    {
                        textBox30.Text = Convert.ToString(num2);
                    }
                    break;
                case "3":
                    int num3;
                    num3 = Convert.ToInt32(textBox30.Text);
                    num3 = int.Parse(textBox30.Text);
                    if (num3 >= 4)
                    {
                        num3 = num3 - 1;
                        textBox30.Text = Convert.ToString(num3);
                    }
                    else
                    {
                        textBox30.Text = Convert.ToString(num3);
                    }
                    break;
                case "4":
                    int num4;
                    num4 = Convert.ToInt32(textBox30.Text);
                    num4 = int.Parse(textBox30.Text);
                    if (num4 < 3)
                    {
                        num4 = num4 +1;
                        textBox30.Text = Convert.ToString(num4);
                    }
                    else
                    {
                        textBox30.Text = Convert.ToString(num4);
                    }
                    break;
                case "5":
                    int num5;
                    num5 = Convert.ToInt32(textBox30.Text);
                    num5 = int.Parse(textBox30.Text);
                    if (num5 < 3)
                    {
                        num5 = num5 +3;
                        textBox30.Text = Convert.ToString(num5);
                    }
                    else
                    {
                        textBox30.Text = Convert.ToString(num5);
                    }
                    break;
            }

            switch (textBox19.Text)
            {
                case "1":
                    int num;
                    num = Convert.ToInt32(textBox29.Text);
                    num = int.Parse(textBox29.Text);
                    if (num > 3)
                    {
                        num = num - 3;
                        textBox29.Text = Convert.ToString(num);
                    }
                    else
                    {
                        textBox29.Text = Convert.ToString(num);
                    }
                    break;
                case "2":
                    int num2;
                    num2 = Convert.ToInt32(textBox29.Text);
                    num2 = int.Parse(textBox29.Text);
                    if (num2 > 2)
                    {
                        num2 = num2 - 1;
                        textBox29.Text = Convert.ToString(num2);
                    }
                    else
                    {
                        textBox29.Text = Convert.ToString(num2);
                    }
                    break;
                case "3":
                    int num3;
                    num3 = Convert.ToInt32(textBox29.Text);
                    num3 = int.Parse(textBox29.Text);
                    if (num3 >= 4)
                    {
                        num3 = num3 - 1;
                        textBox29.Text = Convert.ToString(num3);
                    }
                    else
                    {
                        textBox29.Text = Convert.ToString(num3);
                    }
                    break;
                case "4":
                    int num4;
                    num4 = Convert.ToInt32(textBox29.Text);
                    num4 = int.Parse(textBox29.Text);
                    if (num4 < 3)
                    {
                        num4 = num4 + 1;
                        textBox29.Text = Convert.ToString(num4);
                    }
                    else
                    {
                        textBox29.Text = Convert.ToString(num4);
                    }
                    break;
                case "5":
                    int num5;
                    num5 = Convert.ToInt32(textBox29.Text);
                    num5 = int.Parse(textBox29.Text);
                    if (num5 < 3)
                    {
                        num5 = num5 + 3;
                        textBox29.Text = Convert.ToString(num5);
                    }
                    else
                    {
                        textBox29.Text = Convert.ToString(num5);
                    }
                    break;
            }

            switch (textBox18.Text)
            {
                case "1":
                    int num;
                    num = Convert.ToInt32(textBox28.Text);
                    num = int.Parse(textBox28.Text);
                    if (num > 3)
                    {
                        num = num - 3;
                        textBox28.Text = Convert.ToString(num);
                    }
                    else
                    {
                        textBox28.Text = Convert.ToString(num);
                    }
                    break;
                case "2":
                    int num2;
                    num2 = Convert.ToInt32(textBox28.Text);
                    num2 = int.Parse(textBox28.Text);
                    if (num2 > 2)
                    {
                        num2 = num2 - 1;
                        textBox28.Text = Convert.ToString(num2);
                    }
                    else
                    {
                        textBox28.Text = Convert.ToString(num2);
                    }
                    break;
                case "3":
                    int num3;
                    num3 = Convert.ToInt32(textBox28.Text);
                    num3 = int.Parse(textBox28.Text);
                    if (num3 >= 4)
                    {
                        num3 = num3 - 1;
                        textBox28.Text = Convert.ToString(num3);
                    }
                    else
                    {
                        textBox28.Text = Convert.ToString(num3);
                    }
                    break;
                case "4":
                    int num4;
                    num4 = Convert.ToInt32(textBox28.Text);
                    num4 = int.Parse(textBox28.Text);
                    if (num4 < 3)
                    {
                        num4 = num4 + 1;
                        textBox28.Text = Convert.ToString(num4);
                    }
                    else
                    {
                        textBox28.Text = Convert.ToString(num4);
                    }
                    break;
                case "5":
                    int num5;
                    num5 = Convert.ToInt32(textBox28.Text);
                    num5 = int.Parse(textBox30.Text);
                    if (num5 < 3)
                    {
                        num5 = num5 + 3;
                        textBox28.Text = Convert.ToString(num5);
                    }
                    else
                    {
                        textBox28.Text = Convert.ToString(num5);
                    }
                    break;
            }

            switch (textBox17.Text)
            {
                case "1":
                    int num;
                    num = Convert.ToInt32(textBox27.Text);
                    num = int.Parse(textBox27.Text);
                    if (num > 3)
                    {
                        num = num - 3;
                        textBox27.Text = Convert.ToString(num);
                    }
                    else
                    {
                        textBox27.Text = Convert.ToString(num);
                    }
                    break;
                case "2":
                    int num2;
                    num2 = Convert.ToInt32(textBox27.Text);
                    num2 = int.Parse(textBox27.Text);
                    if (num2 > 2)
                    {
                        num2 = num2 - 1;
                        textBox27.Text = Convert.ToString(num2);
                    }
                    else
                    {
                        textBox27.Text = Convert.ToString(num2);
                    }
                    break;
                case "3":
                    int num3;
                    num3 = Convert.ToInt32(textBox27.Text);
                    num3 = int.Parse(textBox27.Text);
                    if (num3 >= 4)
                    {
                        num3 = num3 - 1;
                        textBox27.Text = Convert.ToString(num3);
                    }
                    else
                    {
                        textBox27.Text = Convert.ToString(num3);
                    }
                    break;
                case "4":
                    int num4;
                    num4 = Convert.ToInt32(textBox27.Text);
                    num4 = int.Parse(textBox27.Text);
                    if (num4 < 3)
                    {
                        num4 = num4 + 1;
                        textBox27.Text = Convert.ToString(num4);
                    }
                    else
                    {
                        textBox27.Text = Convert.ToString(num4);
                    }
                    break;
                case "5":
                    int num5;
                    num5 = Convert.ToInt32(textBox27.Text);
                    num5 = int.Parse(textBox27.Text);
                    if (num5 < 3)
                    {
                        num5 = num5 + 3;
                        textBox27.Text = Convert.ToString(num5);
                    }
                    else
                    {
                        textBox27.Text = Convert.ToString(num5);
                    }
                    break;
            }

            switch (textBox16.Text)
            {
                case "1":
                    int num;
                    num = Convert.ToInt32(textBox26.Text);
                    num = int.Parse(textBox26.Text);
                    if (num > 3)
                    {
                        num = num - 3;
                        textBox26.Text = Convert.ToString(num);
                    }
                    else
                    {
                        textBox26.Text = Convert.ToString(num);
                    }
                    break;
                case "2":
                    int num2;
                    num2 = Convert.ToInt32(textBox26.Text);
                    num2 = int.Parse(textBox26.Text);
                    if (num2 > 2)
                    {
                        num2 = num2 - 1;
                        textBox26.Text = Convert.ToString(num2);
                    }
                    else
                    {
                        textBox26.Text = Convert.ToString(num2);
                    }
                    break;
                case "3":
                    int num3;
                    num3 = Convert.ToInt32(textBox26.Text);
                    num3 = int.Parse(textBox26.Text);
                    if (num3 >= 4)
                    {
                        num3 = num3 - 1;
                        textBox26.Text = Convert.ToString(num3);
                    }
                    else
                    {
                        textBox26.Text = Convert.ToString(num3);
                    }
                    break;
                case "4":
                    int num4;
                    num4 = Convert.ToInt32(textBox26.Text);
                    num4 = int.Parse(textBox26.Text);
                    if (num4 < 3)
                    {
                        num4 = num4 + 1;
                        textBox26.Text = Convert.ToString(num4);
                    }
                    else
                    {
                        textBox26.Text = Convert.ToString(num4);
                    }
                    break;
                case "5":
                    int num5;
                    num5 = Convert.ToInt32(textBox26.Text);
                    num5 = int.Parse(textBox26.Text);
                    if (num5 < 3)
                    {
                        num5 = num5 + 3;
                        textBox26.Text = Convert.ToString(num5);
                    }
                    else
                    {
                        textBox26.Text = Convert.ToString(num5);
                    }
                    break;
            }
        }
    }
}
