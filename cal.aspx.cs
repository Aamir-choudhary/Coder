using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace calculator_cheack
{
    public partial class cal : System.Web.UI.Page
    {
        ArrayList num = new ArrayList();
        string sum = string.Empty;
        double temp = 0;
        string add = string.Empty;
        string cheack = string.Empty;
        int[] arr_op = { 37, 42, 43, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, };
        List<char> list = new List<char>();
        int n = 0;
        int last = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Btn_0_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0") { Result.Text = Btn_0.Text; }
            else { Result.Text += Btn_0.Text; }
        }

        protected void Btn_1_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0") { Result.Text = Btn_1.Text; }
            else { Result.Text += Btn_1.Text; }
        }

        protected void Btn_2_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0") { Result.Text = Btn_2.Text; }
            else { Result.Text += Btn_2.Text; }
        }

        protected void Btn_3_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0") { Result.Text = Btn_3.Text; }
            else { Result.Text += Btn_3.Text; }
        }

        protected void Btn_4_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0") { Result.Text = Btn_4.Text; }
            else { Result.Text += Btn_4.Text; }
        }

        protected void Btn_5_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0") { Result.Text = Btn_5.Text; }
            else { Result.Text += Btn_5.Text; }
        }

        protected void Btn_6_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0") { Result.Text = Btn_6.Text; }
            else { Result.Text += Btn_6.Text; }
        }

        protected void Btn_7_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0") { Result.Text = Btn_7.Text; }
            else { Result.Text += Btn_7.Text; }
        }

        protected void Btn_8_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0") { Result.Text = Btn_8.Text; }
            else { Result.Text += Btn_8.Text; }
        }

        protected void Btn_9_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0") { Result.Text = Btn_9.Text; }
            else { Result.Text += Btn_9.Text; }
        }

        protected void Btn_plus_Click(object sender, EventArgs e)
        {
            cheack = Result.Text;
            int op = cheack[cheack.Length - 1];
            if (op == 42 || op == 43 || op == 45 || op == 47 || op == 37)
            {
                add = cheack.Remove(cheack.Length - 1);
                Result.Text = add;
                add = string.Empty;
            }
            cheack = string.Empty;
            if (Result.Text == "0") { Result.Text = "0"; }
            else { Result.Text += Btn_plus.Text; }
        }

        protected void Btn_minus_Click(object sender, EventArgs e)
        {
            cheack = Result.Text;
            int op = cheack[cheack.Length - 1];
            if (op == 42 || op == 43 || op == 45 || op == 47 || op == 37)
            {
                add = cheack.Remove(cheack.Length - 1);
                Result.Text = add;
                add = string.Empty;
            }
            cheack = string.Empty;
            if (Result.Text == "0") { Result.Text = "0"; }
            else { Result.Text += Btn_minus.Text; }
        }

        protected void Btn_multiply_Click(object sender, EventArgs e)
        {
            cheack = Result.Text;
            int op = cheack[cheack.Length - 1];
            if (op == 42 || op == 43 || op == 45 || op == 47 || op == 37)
            {
                add = cheack.Remove(cheack.Length - 1);
                Result.Text = add;
                add = string.Empty;
            }
            cheack = string.Empty;
            if (Result.Text == "0") { Result.Text = "0"; }
            else { Result.Text += Btn_multiply.Text; }
        }

        protected void Btn_dvd_Click(object sender, EventArgs e)
        {
             cheack = Result.Text;
            int op = cheack[cheack.Length - 1];
            if (op == 42 || op == 43 || op == 45 || op == 47 || op == 37)
            {
                add = cheack.Remove(cheack.Length - 1);
                Result.Text = add;
                add = string.Empty;
            }
            cheack = string.Empty;
            if (Result.Text == "0") { Result.Text = "0"; }
            else { Result.Text += Btn_dvd.Text; }

        }
        protected void Btn_percentage_Click(object sender, EventArgs e)
        {
            cheack = Result.Text;
            int op = cheack[cheack.Length - 1];
            if (op == 42 || op == 43 || op == 45 || op == 47 || op == 37)
            {
                add = cheack.Remove(cheack.Length - 1);
                Result.Text = add;
                add = string.Empty;
            }
            cheack = string.Empty;
            if (Result.Text == "0") { Result.Text = "0"; }
            else { Result.Text += Btn_percentage.Text; }
        }
        protected void Btn_dot_Click(object sender, EventArgs e)
        {
            cheack = Result.Text;
            int op = cheack[cheack.Length - 1];
            if (op == 42 || op == 43 || op == 45 || op == 47) { Result.Text = cheack + "0"; }
            if (cheack[cheack.Length - 1] == 46) { return; }
            string cal = Result.Text;
            for (int i = 0; i < cal.Length; i++)
            {
                if (cal[i] == 43)
                {
                    num.Add(sum);
                    sum = string.Empty;
                    num.Add(cal[i]);
                    list.Add(cal[i]);
                }
                else if (cal[i] == 45)
                {
                    num.Add(sum);
                    sum = string.Empty;
                    num.Add(cal[i]);
                    list.Add(cal[i]);
                }
                else if (cal[i] == 42)
                {
                    num.Add(sum);
                    sum = string.Empty;
                    num.Add(cal[i]);
                    list.Add(cal[i]);
                }
                else if (cal[i] == 47)
                {
                    num.Add(sum);
                    sum = string.Empty;
                    num.Add(cal[i]);
                    list.Add(cal[i]);
                }
                else if (cal[i] == 37)
                {
                    num.Add(sum);
                    sum = string.Empty;
                    num.Add(cal[i]);
                    list.Add(cal[i]);
                }
                else
                {

                    sum += cal[i].ToString();
                }

            }
            num.Add(sum);
            if(num.Count == 1)
            {
                cal = num[0].ToString();
                for(int i = 0; i < cal.Length; i++)
                {
                    if (cal[i] == 46) { return; }
                }
            }
            else
            {
                for (int i = 0; i < num.Count; i++)
                {
                    for (int j = n; j < list.Count; j++)
                    {
                        op = list[j];
                        if (op == 42 || op == 43 || op == 45 || op == 47 || op == 37)
                        {
                            last = i;
                        }
                        if (j == j)
                        {
                            n = j;
                            break;
                        }
                    }
                }
                Console.WriteLine(num[last - 1]);
                cal = num[last].ToString();
                for (int i = 0; i < cal.Length; i++)
                {
                    if (cal[i] == 46)
                    {
                        return;
                    }
                }
            }
            
            cheack = string.Empty;
            Result.Text += Btn_dot.Text;
        }
        protected void Btn_clear_Click(object sender, EventArgs e)
        {
            Result.Text = "0";

        }
        protected void Btn_del_Click(object sender, EventArgs e)
        {
            cheack = Result.Text;
            if(Result.Text == "0") { return; }
            if (cheack.Length >= 0)
            {
                cheack = cheack.Remove(cheack.Length - 1);
                if(cheack.Length == 0) { cheack = "0"; }
            }

            Result.Text = cheack;
            cheack = string.Empty;
        }
 
        protected void equal_Click(object sender, EventArgs e)
        {
            string Test = Result.Text;
            int inc = 0;
            for (int i = 0; i < Test.Length; i++)
            {
                for (int j = 0 ; j < arr_op.Length; j++)
                {
                   // if (j == 44) { j++; }

                    if (Test[i] == arr_op[j]) { inc++; }
                }
                if (i < Test.Length - 1) { add += Test[i]; }
            }
            if (Test[Test.Length - 1] == 42 || Test[Test.Length - 1] == 43 || Test[Test.Length - 1] == 45 || Test[Test.Length - 1] == 47 || Test[Test.Length - 1] == 37)
            { Result.Text = add; add = string.Empty; }
            if (inc == Test.Length)
            {
                string cal = Result.Text;
                for (int i = 0; i < cal.Length; i++)
                {
                    if (cal[i] == 43)
                    {
                        num.Add(sum);
                        sum = string.Empty;
                        num.Add(cal[i]);
                    }
                    else if (cal[i] == 45)
                    {
                        num.Add(sum);
                        sum = string.Empty;
                        num.Add(cal[i]);
                    }
                    else if (cal[i] == 42)
                    {
                        num.Add(sum);
                        sum = string.Empty;
                        num.Add(cal[i]);
                    }
                    else if (cal[i] == 47)
                    {
                        num.Add(sum);
                        sum = string.Empty;
                        num.Add(cal[i]);
                    }
                    else if (cal[i] == 37)
                    {
                        num.Add(sum);
                        sum = string.Empty;
                        num.Add(cal[i]);
                    }
                    else
                    {

                        sum += cal[i].ToString();
                    }

                }
                num.Add(sum);
               

            multi_div_per:
                for (int i = 0; i < num.Count; i++)
                {

                    if ((num[i]).ToString() == "*")//'*'
                    {
                        temp = (Convert.ToDouble(num[i - 1].ToString())) * (Convert.ToDouble(num[i + 1].ToString()));
                        num.RemoveAt(i + 1);
                        num.RemoveAt(i);
                        num[i - 1] = temp;
                        temp = 0;
                    }
                    else if ((num[i]).ToString() == "/")//'/'
                    {
                        temp = (Convert.ToDouble(num[i - 1].ToString())) / (Convert.ToDouble(num[i + 1].ToString()));
                        num.RemoveAt(i + 1);
                        num.RemoveAt(i);
                        num[i - 1] = temp;
                        temp = 0;
                    }
                    else if ((num[i]).ToString() == "%")//'%'
                    {
                        temp = (Convert.ToDouble(num[i - 1].ToString())) * (Convert.ToDouble(num[i + 1].ToString()) / 100d );
                        num.RemoveAt(i + 1);
                        num.RemoveAt(i);
                        num[i - 1] = temp;
                        temp = 0;
                    }
                    //if (i == 1) { break; }
                }
                for (int i = 0; i < num.Count; i++)
                {
                    if ((num[i]).ToString() == "*" || (num[i]).ToString() == "/" || (num[i]).ToString() == "%")
                    {
                        goto multi_div_per;
                    }
                }

            plus_minus:
                //-----------addition and minus ----------
                for (int i = 0; i < num.Count; i++)
                {
                    if ((num[i]).ToString() == "+")//'*'
                    {
                        temp = (Convert.ToDouble(num[i - 1].ToString())) + (Convert.ToDouble(num[i + 1].ToString()));
                        num.RemoveAt(i + 1);
                        num.RemoveAt(i);
                        num[i - 1] = temp;
                        temp = 0;
                    }
                    else if ((num[i]).ToString() == "-")//'/'
                    {
                        temp = (Convert.ToDouble(num[i - 1].ToString())) - (Convert.ToDouble(num[i + 1].ToString()));
                        num.RemoveAt(i + 1);
                        num.RemoveAt(i);
                        num[i - 1] = temp;
                        temp = 0;
                    }
                    if (i == 1) { break; }
                }
                for (int i = 0; i < num.Count; i++)
                {
                    if (num[i].ToString() == "+" || (num[i]).ToString() == "-") { goto plus_minus; }
                }
                Result.Text = num[0].ToString();
            }
            else { Result.Text = "Wrong Input"; }
        }
    }
}