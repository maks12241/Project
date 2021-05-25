using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public static double BYN = 0;
        public static double USD = 0;
        public static double EUR = 0;
        public static double valueshopcheck = 0;
        public static int valueshopdrink = 0;
        public static int valueshophungry = 0;
        public static double valueshopeags = 0;
        public static double valueshopcheese = 0;

        public static double min = 0;
        public static double hours = 0;
        public static double day = 0;
        public static double month = 0;
        public static double year = 0;

        Progress p = new Progress();
        public static int Health = 0;
        public static int Drink = 0;
        public static int Hungry = 0;
        public static int Study = 0;
        public static int Work = 0;

        public void checkboxvisible()
        {
            Answer_1.Checked = false;
            Answer_2.Checked = false;
            Answer_3.Checked = false;
            Answer_4.Checked = false;
            Answer_5.Checked = false;
        }

        public void Time_15()
        {
            min += 15;
            if (min == 60)
            { min = 0; hours += 1; }

            if (hours >= 24)
            { hours = 0; day += 1; }

            if (day >= 28)
            { day = 1; month += 1; }

            if (month >= 12)
            { month = 1; year += 1; }
        }

        public void Time_2()
        {
            hours += 2;

            if (hours >= 24)
            { hours = 0; day += 1; }

            if (day >= 28)
            { day = 1; month += 1; }

            if (month >= 12)
            { month = 1; year += 1; }
        }

        public void function_socr1()
        {
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button11.Enabled = false;
            button10.Enabled = false;
            button9.Enabled = false;
            button8.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button24.Enabled = false;
            button25.Enabled = false;
            button26.Enabled = false;
            button27.Enabled = false;
            button21.Enabled = false;
            button28.Enabled = true;
        }
        public void function_socr2()
        {
            Question.Visible = true;
            Variant_1.Visible = true;
            Variant_2.Visible = true;
            Variant_3.Visible = true;
            Variant_4.Visible = true;
            Variant_5.Visible = true;

            Answer_1.Visible = true;
            Answer_2.Visible = true;
            Answer_3.Visible = true;
            Answer_4.Visible = true;
            Answer_5.Visible = true;

            groupBox_Test1.Visible = false;
            groupBox_Test2.Visible = false;
            groupBox_Test3.Visible = false;
        }

        public void function_socr3()
        {
            groupBox_Test1.Visible = true;
            groupBox_Test2.Visible = true;
            groupBox_Test3.Visible = true;

            Question.Visible = false;
            Variant_1.Visible = false;
            Variant_2.Visible = false;
            Variant_3.Visible = false;
            Variant_4.Visible = false;
            Variant_5.Visible = false;

            Answer_1.Visible = false;
            Answer_2.Visible = false;
            Answer_3.Visible = false;
            Answer_4.Visible = false;
            Answer_5.Visible = false;
        }

        public void function_socr4()
        {
            button21.Enabled = true;
            button16.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;   
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button28.Enabled = false;
        }

        public void function_socr5()
        {
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button21.Enabled = true;
            button24.Enabled = false;
            button25.Enabled = false;
            button26.Enabled = false;
            button27.Enabled = false;
            button28.Enabled = false;
        }

        public void Time_24()
        {
             day += 1; 
            if (day >= 28)
            { day = 1; month += 1; }

            if (month >= 12)
            { month = 1; year += 1; }
        }

        //Поля
        private Button currentButton;
        private Random random;
        private int tempIndex;
        

        //Конструктор
        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }

        //Методы
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            tabControl1.SelectedTab = tabPage1;
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            tabControl1.SelectedTab = tabPage3;
        }

        private void btnStudy_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            tabControl1.SelectedTab = tabPage4;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            p = MethodsForProgress.DeSerialize();
            min = p.minutes;
            hours = p.hours;
            day = p.day;
            month = p.month;
            year = p.year;
            valueshopcheck = 0;
            valueshopdrink = 0;
            valueshophungry = 0;
            BYN = p.money;
            USD = 100;
            EUR = 100;
            Study = p.prBar_Study;
            Hungry = p.prBar_Hungry;
            Health = p.prBar_Health;
            Drink = p.prBar_Drink;
            Work = 0;
            function_socr1();
            ToolTip t = new ToolTip();
            t.SetToolTip(button4, "Время работы 6ч, 30р");
            t.SetToolTip(button5, "Время работы 8ч, 45р");
            t.SetToolTip(button6, "Время работы 4ч, 20р");
            t.SetToolTip(button7, "Время работы 14ч, 90р");
            t.SetToolTip(button11, "Время работы 8ч, 35р");
            t.SetToolTip(button10, "Время работы 10ч, 50р");
            t.SetToolTip(button9, "Время работы 8ч, 45р");
            t.SetToolTip(button8, "Время работы 12ч, 80р");
            t.SetToolTip(button14, "Время работы 2дн 2ч, 70USD");
            t.SetToolTip(button15, "Время работы 2дн 2ч, 65EUR");
            t.SetToolTip(button13, "Время работы 4дн 4ч, 150USD");
            t.SetToolTip(button12, "Время работы 4дн 4ч, 400BYN");
            t.SetToolTip(pictureBox2, "Поспать");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            tabControl1.SelectedTab = tabPage7;
        }

        private void Other_Timer_Tick(object sender, EventArgs e)
        {
            label15.Text = BYN.ToString("0.0");
            label16.Text = USD.ToString("0.0");
            label17.Text = EUR.ToString("0.0");
            Value.Text = valueshopcheck.ToString("0.0");
            Water.Text = valueshopdrink.ToString("0");
            Eat.Text = valueshophungry.ToString("0");
            WannaEat.Value = Hungry;
            WannaDrink.Value = Drink;
            WannaHealth.Value = Health;
            WannaStudy.Value = Study;
            progressBar5.Value = Work;
        }

        private void Time_min15_Tick(object sender, EventArgs e)
        {
            DataTime.Text = hours.ToString("0") + ':' + min.ToString("0") + " " + " " + day.ToString("0") + 'д' + " " + month.ToString("0") + 'м' + " " + year.ToString("0") + 'г';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Time_15();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
        }


        private void Hungry_Timer_Tick(object sender, EventArgs e)
        {
            if (Hungry >= 100)
            {
                Hungry = 100;
            }
            else
            if (Hungry <= 0)
                {
                Hungry = 0;
                Health_Timer.Enabled = false;
                Hungry_Timer.Enabled = false;
                Drink_Timer.Enabled = false;
                Study_Timer.Enabled = false;
                min = 0;
                hours = 0;
                day = 1;
                month = 3;
                year = 2021;
                valueshophungry = 0;
                valueshopdrink = 0;
                valueshopcheck = 0;
                BYN = 500.7;
                USD = 100;
                EUR = 100;
                Hungry = 50;
                Drink = 50;
                Health = 50;
                Study = 50;
                Work = 0;
                MessageBox.Show("Вы умерли от голода =( ");
                function_socr1();
                Health_Timer.Enabled = true;
                Hungry_Timer.Enabled = true;
                Drink_Timer.Enabled = true;
                Study_Timer.Enabled = true;
            }
        }

        private void Drink_Timer_Tick(object sender, EventArgs e)
        {
            if (Drink >= 100)
            {
                Drink = 100;
            }
            else
            if (Drink <= 0)
            {
                Drink = 0;
                Health_Timer.Enabled = false;
                Hungry_Timer.Enabled = false;
                Drink_Timer.Enabled = false;
                Study_Timer.Enabled = false;
                min = 0;
                hours = 0;
                day = 1;
                month = 3;
                year = 2021;
                valueshophungry = 0;
                valueshopdrink = 0;
                valueshopcheck = 0;
                BYN = 500.7;
                USD = 100;
                EUR = 100;
                Hungry = 50;
                Drink = 50;
                Work = 0;
                Health = 50;
                Study = 50;
                MessageBox.Show("Вы умерли от обезвоживания =( ");
                function_socr1();
                Health_Timer.Enabled = true;
                Hungry_Timer.Enabled = true;
                Drink_Timer.Enabled = true;
                Study_Timer.Enabled = true;
            }
        }

        private void Health_Timer_Tick(object sender, EventArgs e)
        {
            if (Health >= 100)
            {
                Health = 100;
            }
            else
            if (Health <= 0)
            {
                Health = 0;
                Health_Timer.Enabled = false;
                Hungry_Timer.Enabled = false;
                Drink_Timer.Enabled = false;
                Study_Timer.Enabled = false;
                min = 0;
                hours = 0;
                day = 1;
                month = 3;
                year = 2021;
                valueshophungry = 0;
                valueshopdrink = 0;
                valueshopcheck = 0;
                BYN = 500.7;
                USD = 100;
                EUR = 100;
                Work = 0;
                Hungry = 50;
                Drink = 50;
                Health = 50;
                Study = 50;
                MessageBox.Show("Вы умерли от болезни =( ");
                function_socr1();
                Health_Timer.Enabled = true;
                Hungry_Timer.Enabled = true;
                Drink_Timer.Enabled = true;
                Study_Timer.Enabled = true;
            }
        }

        private void Study_Timer_Tick(object sender, EventArgs e)
        {
            if (Study >= 100)
            {
                Study = 100;
            }
            else
            if (Study <= 0)
            {
                Study = 0;
                Health_Timer.Enabled = false;
                Hungry_Timer.Enabled = false;
                Drink_Timer.Enabled = false;
                Study_Timer.Enabled = false;
                min = 0;
                hours = 0;
                day = 1;
                month = 3;
                year = 2021;
                valueshophungry = 0;
                valueshopdrink = 0;
                valueshopcheck = 0;
                BYN = 500.7;
                USD = 100;
                EUR = 100;
                Hungry = 50;
                Drink = 50;
                Health = 50;
                Study = 50;
                Work = 0;
                MessageBox.Show("Вы не сдали учебу =( ");
                function_socr1();
                Health_Timer.Enabled = true;
                Hungry_Timer.Enabled = true;
                Drink_Timer.Enabled = true;
                Study_Timer.Enabled = true;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Time_2();
            Work += 34;
            Health -= 6;
            Drink -= random.Next(1,3);
            Hungry -= random.Next(1, 3);
            Study -= random.Next(3, 7);
            if (Work >= 100)
            {
                Work = 0;
                button16.Enabled = false;
                button21.Enabled = false;
                button28.Enabled = true;
                BYN += 30;
                MessageBox.Show("Вы закончили работу и получили 30р");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Time_2();
            Work += 25;
            Health -= 6;
            Drink -= random.Next(1, 3);
            Hungry -= random.Next(1, 3);
            Study -= random.Next(3, 7);
            if (Work >= 100)
            {
                Work = 0;
                button17.Enabled = false;
                button21.Enabled = false;
                button28.Enabled = true;
                BYN += 45;
                MessageBox.Show("Вы закончили работу и получили 45р");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Time_2();
            Work += 50;
            Health -= 6;
            Drink -= random.Next(1, 3);
            Hungry -= random.Next(1, 3);
            Study -= random.Next(3, 7);
            if (Work >= 100)
            {
                Work = 0;
                button18.Enabled = false;
                button21.Enabled = false;
                button28.Enabled = true;
                BYN += 20;
                MessageBox.Show("Вы закончили работу и получили 20р");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Time_2();
            Work += 15;
            Health -= 6;
            Drink -= random.Next(1, 3);
            Hungry -= random.Next(1, 3);
            Study -= random.Next(3, 7);
            if (Work >= 100)
            {
                Work = 0;
                button19.Enabled = false;
                button21.Enabled = false;
                button28.Enabled = true;
                BYN += 90;
                MessageBox.Show("Вы закончили работу и получили 90р");
            }
        }
  
        private void button4_Click(object sender, EventArgs e)
        {
            function_socr5();
            button16.Enabled = true;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
        }

        private void Work_Timer_Tick(object sender, EventArgs e)
        {
            if (Work>100)
            {
                Work = 100;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Work = 0;
            function_socr1();
            button16.Enabled = false;
            button28.Enabled = true;
            MessageBox.Show("Вы закончили работу досрочно");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            function_socr5();
            button16.Enabled = false;
            button17.Enabled = true;
            button18.Enabled = false;
            button19.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            function_socr5();
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = true;
            button19.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            function_socr5();
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Time_2(); Time_2(); Time_2(); Time_2();
            Health -= 24;
            Drink -= random.Next(7, 12);
            Hungry -= random.Next(7, 12);
            Study -= random.Next(3, 7);
            BYN += 35;
            MessageBox.Show("Вы закончили работу и получили 35р");
            button21.Enabled = false;
            function_socr1();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Time_2(); Time_2(); Time_2(); Time_2(); Time_2();
            Health -= 32;
            Drink -= random.Next(8, 14);
            Hungry -= random.Next(8, 14);
            Study -= random.Next(3, 7);
            BYN += 50;
            MessageBox.Show("Вы закончили работу и получили 50р");
            button21.Enabled = false;
            function_socr1();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Time_2(); Time_2(); Time_2(); Time_2();
            Health -= 38;
            Drink -= random.Next(8, 14);
            Hungry -= random.Next(8, 14);
            Study -= random.Next(3, 7);
            BYN += 45;
            MessageBox.Show("Вы закончили работу и получили 45р");
            button21.Enabled = false;
            function_socr1();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Time_2(); Time_2(); Time_2(); Time_2(); Time_2(); Time_2();
            Health -= 38;
            Drink -= random.Next(8, 14);
            Hungry -= random.Next(8, 14);
            Study -= random.Next(3, 7);
            BYN += 80;
            MessageBox.Show("Вы закончили работу и получили 80р");
            button21.Enabled = false;
            function_socr1();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            function_socr4();
            button24.Enabled = false;
            button25.Enabled = false;
            button26.Enabled = false;
            button27.Enabled = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            function_socr4();
            button24.Enabled = false;
            button25.Enabled = false;
            button26.Enabled = true;
            button27.Enabled = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            function_socr4();
            button24.Enabled = false;
            button25.Enabled = true;
            button26.Enabled = false;
            button27.Enabled = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            function_socr4();
            button24.Enabled = true;
            button25.Enabled = false;
            button26.Enabled = false;
            button27.Enabled = false;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Time_2();
            Work += 2;
            Health -= 6;
            Drink -= random.Next(1, 3);
            Hungry -= random.Next(1, 3);
            if (Work >= 100)
            {
                Work = 0;
                button27.Enabled = false;
                button21.Enabled = false;
                button28.Enabled = true;
                USD += 70;
                MessageBox.Show("Вы закончили работу и получили 70USD");
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Time_2();
            Work += 2;
            Health -= 6;
            Drink -= random.Next(1, 3);
            Hungry -= random.Next(1, 3);
            Study -= random.Next(3, 7);
            if (Work >= 100)
            {
                Work = 0;
                button26.Enabled = false;
                button21.Enabled = false;
                button28.Enabled = true;
                EUR += 65;
                MessageBox.Show("Вы закончили работу и получили 65EUR");
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Time_2();
            Work += 1;
            Health -= 6;
            Drink -= random.Next(1, 3);
            Hungry -= random.Next(1, 3);
            Study -= random.Next(3, 7);
            if (Work >= 100)
            {
                Work = 0;
                button25.Enabled = false;
                button21.Enabled = false;
                button28.Enabled = true;
                USD += 150;
                MessageBox.Show("Вы закончили работу и получили 150USD");
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Time_2();
            Work += 1;
            Health -= 6;
            Drink -= random.Next(1, 3);
            Hungry -= random.Next(1, 3);
            Study -= random.Next(3, 7);
            if (Work >= 100)
            {
                Work = 0;
                button24.Enabled = false;
                button21.Enabled = false;
                button28.Enabled = true;
                BYN += 400;
                MessageBox.Show("Вы закончили работу и получили 400BYN");
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product.Text = listBox2.Text;
            if (listBox2.SelectedIndex == 0)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\Admin\\Desktop\\12\\image\\Еда_КФС\\Baits.png");
                valueshopcheck = 4.2;
                valueshopdrink = 0;
                valueshophungry = 30;
            }
            else if (listBox2.SelectedIndex == 1)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\Admin\\Desktop\\12\\image\\Еда_КФС\\Баскет_S.png");
                valueshopcheck = 7.1;
                valueshopdrink = 0;
                valueshophungry = 50;
            }
            else if (listBox2.SelectedIndex == 2)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\Admin\\Desktop\\12\\image\\Еда_КФС\\Боксмастер.png");
                valueshopcheck = 6.3;
                valueshopdrink = 0;
                valueshophungry = 35;
            }
            else if (listBox2.SelectedIndex == 3)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\Admin\\Desktop\\12\\image\\Еда_КФС\\Лонгер_Чиз.png");
                valueshopcheck = 2.2;
                valueshopdrink = 0;
                valueshophungry = 10;
            }
            else if (listBox2.SelectedIndex == 4)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\Admin\\Desktop\\12\\image\\Еда_КФС\\Пати_Баскет.png");
                valueshopdrink = 0;
                valueshophungry = 60;
                valueshopcheck = 9.4;
            }
            else if (listBox2.SelectedIndex == 5)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\Admin\\Desktop\\12\\image\\Еда_КФС\\Стрипсы.png");
                valueshopcheck = 6.3;
                valueshopdrink = 0;
                valueshophungry = 35;
            }
            else if (listBox2.SelectedIndex == 6)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\Admin\\Desktop\\12\\image\\Еда_КФС\\Чизбургер.png");
                valueshopcheck = 3.4;
                valueshopdrink = 0;
                valueshophungry = 20;
            }
            else if (listBox2.SelectedIndex == 7)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\Admin\\Desktop\\12\\image\\Еда_КФС\\Шефбургер.png");
                valueshopcheck = 3.5;
                valueshopdrink = 0;
                valueshophungry = 20;
            }
        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product.Text = listBox5.Text;
            if (listBox5.SelectedIndex == 0)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\Admin\\Desktop\\12\\image\\Еда_КФС\\7up.png");
                valueshopcheck = 2.5;
                valueshopdrink = 30;
                valueshophungry = 0;
            }
            else if (listBox5.SelectedIndex == 1)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\Admin\\Desktop\\12\\image\\Еда_КФС\\Pepsi.png");
                valueshopcheck = 2.6;
                valueshopdrink = 30;
                valueshophungry = 0;
            }
            else if (listBox5.SelectedIndex == 2)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\Admin\\Desktop\\12\\image\\Еда_КФС\\Коктейль.png");
                valueshopcheck = 3.2;
                valueshopdrink = 40;
                valueshophungry = 0;
            }
            else if (listBox5.SelectedIndex == 3)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\Admin\\Desktop\\12\\image\\Еда_КФС\\Чай_Липтон.png");
                valueshopcheck = 2.1;
                valueshopdrink = 25;
                valueshophungry = 0;
            }
        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product.Text = listBox6.Text;
            if (listBox6.SelectedIndex == 0)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\Admin\\Desktop\\12\\image\\Еда_Мак\\Биг_Тейсти.png");
                valueshopcheck = 5.5;
                valueshopdrink = 0;
                valueshophungry = 40;
            }
            else if (listBox6.SelectedIndex == 1)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\Admin\\Desktop\\12\\image\\Еда_Мак\\Донат.png");
                valueshopcheck = 2;
                valueshopdrink = 0;
                valueshophungry = 10;
            }
            else if (listBox6.SelectedIndex == 2)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\Admin\\Desktop\\12\\image\\Еда_Мак\\Картофель_Фри.png");
                valueshopcheck = 2.7;
                valueshopdrink = 0;
                valueshophungry = 15;
            }
            else if (listBox6.SelectedIndex == 3)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\Admin\\Desktop\\12\\image\\Еда_Мак\\МакТост_с_сыром.png");
                valueshopcheck = 2.5;
                valueshopdrink = 0;
                valueshophungry = 15;
            }
            else if (listBox6.SelectedIndex == 4)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\Admin\\Desktop\\12\\image\\Еда_Мак\\Мороженное.png");
                valueshopcheck = 3.7;
                valueshopdrink = 0;
                valueshophungry = 20;
            }
            else if (listBox6.SelectedIndex == 5)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\Admin\\Desktop\\12\\image\\Еда_Мак\\Пирожок.png");
                valueshopcheck = 2;
                valueshopdrink = 0;
                valueshophungry = 13;
            }
            else if (listBox6.SelectedIndex == 6)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\Admin\\Desktop\\12\\image\\Еда_Мак\\Филе-о-Фиш.png");
                valueshopcheck = 4.5;
                valueshopdrink = 0;
                valueshophungry = 25;
            }
            else if (listBox6.SelectedIndex == 7)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\Admin\\Desktop\\12\\image\\Еда_Мак\\Цезарь_Ролл.png");
                valueshopcheck = 4;
                valueshopdrink = 0;
                valueshophungry = 30;
            }
        }

        private void listBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product.Text = listBox7.Text;
            if (listBox7.SelectedIndex == 0)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\Admin\\Desktop\\12\\image\\Еда_Мак\\Кока-Кола.png");
                valueshopcheck = 2.5;
                valueshopdrink = 30;
                valueshophungry = 0;
            }
            else if (listBox7.SelectedIndex == 1)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\Admin\\Desktop\\12\\image\\Еда_Мак\\Коктейль.png");
                valueshopcheck = 3.5;
                valueshopdrink = 45;
                valueshophungry = 0;
            }
            else if (listBox7.SelectedIndex == 2)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\Admin\\Desktop\\12\\image\\Еда_Мак\\Кофе.png");
                valueshopcheck = 3;
                valueshopdrink = 35;
                valueshophungry = 0;
            }
            else if (listBox7.SelectedIndex == 3)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\Admin\\Desktop\\12\\image\\Еда_Мак\\Чай.png");
                valueshopcheck = 2.3;
                valueshopdrink = 29;
                valueshophungry = 0;
            }
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
             Health += 25;
             Time_2();
             Drink -= random.Next(8, 15);
             Hungry -= random.Next(8, 15);
        }

        private void listBox5_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if ((BYN > valueshopcheck)&&(radioButton1.Checked==true))
            {
                BYN = BYN - valueshopcheck;
                Hungry = Hungry + valueshophungry;
                Drink = Drink + valueshopdrink;
                MessageBox.Show(" Вы купили продукт и употребили его! "); 
            }
            else if (radioButton1.Checked == false)
            {
                MessageBox.Show(" Сначала выберите действие: 'Употребить' ");
            }
        }

        private void listBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if ((BYN > valueshopcheck) && (radioButton1.Checked == true))
            {
                BYN = BYN - valueshopcheck;
                Hungry = Hungry + valueshophungry;
                Drink = Drink + valueshopdrink;
                MessageBox.Show(" Вы купили продукт и употребили его! ");
            }
            else if (radioButton1.Checked == false)
            {
                MessageBox.Show(" Сначала выберите действие: 'Употребить' ");
            }
        }

        private void listBox6_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if ((BYN > valueshopcheck) && (radioButton1.Checked == true))
            {
                BYN = BYN - valueshopcheck;
                Hungry = Hungry + valueshophungry;
                Drink = Drink + valueshopdrink;
                MessageBox.Show(" Вы купили продукт и употребили его! ");
            }
            else if (radioButton1.Checked == false)
            {
                MessageBox.Show(" Сначала выберите действие: 'Употребить' ");
            }
        }

        private void listBox7_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if ((BYN > valueshopcheck) && (radioButton1.Checked == true))
            {
                BYN = BYN - valueshopcheck;
                Hungry = Hungry + valueshophungry;
                Drink = Drink + valueshopdrink;
                MessageBox.Show(" Вы купили продукт и употребили его! ");
            }
            else if  (radioButton1.Checked == false)
            {
                MessageBox.Show(" Сначала выберите действие: 'Употребить' ");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            vopr1.Visible = true;
            function_socr2();
            Question.Text = "Для чего предназначен метод clear(...) коллекции List<T>?";
            Question.Location = new Point(50, 50);
            Variant_1.Text = "1. Для удаления списка;";
            Variant_1.Location = new Point(70, 100);
            Variant_2.Text = "2. Для удаления всех элементов из списка;";
            Variant_2.Location = new Point(70, 150);
            Variant_3.Text = "3. Для удаления первого элемента из списка;";
            Variant_3.Location = new Point(70, 200);
            Variant_4.Text = "4. Для удаления последнего элемента из списка;";
            Variant_4.Location = new Point(70, 250);
            Variant_5.Text = "5. Нет верного ответа.";
            Variant_5.Location = new Point(70, 300);
            Answer_1.Location = new Point(55, 108) ;
            Answer_2.Location = new Point(55, 158);
            Answer_3.Location = new Point(55, 208);
            Answer_4.Location = new Point(55, 258);
            Answer_5.Location = new Point(55, 308);
            vopr1.Location = new Point(70, 358);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if(Answer_2.Checked==true)
            {
                MessageBox.Show("Вы ответили правильно! ");
                vopr1.Visible = false;
                vopr1.Location = new Point(500, 358);
                vopr2.Visible = true;
                vopr2.Location = new Point(70, 358);
                checkboxvisible();
                Question.Text = "Что такое Java Core?";
                Variant_1.Text = "1. Коллекция Java;";
                Variant_2.Text = "2. Фундаментальные основы языка Java;";
                Variant_3.Text = "3. Фреймворк для desktop;";
                Variant_4.Text = "4. Версия JVM;";
                Variant_5.Text = "5. Нет верного ответа.";
            } else { MessageBox.Show("Вы ответили неправильно! "); checkboxvisible(); }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (Answer_2.Checked == true)
            {
                MessageBox.Show("Вы ответили правильно! ");
                vopr2.Visible = false;
                vopr2.Location = new Point(500, 358);
                vopr31.Visible = true;
                vopr31.Location = new Point(70, 358);
                checkboxvisible();
                Question.Text = "Какие встроенные панели компоновки существуют с JavaFX?";
                Variant_1.Text = "1. BorderPane;";
                Variant_2.Text = "2. VBox;";
                Variant_3.Text = "3. HBox;";
                Variant_4.Text = "4. GridBox;";
                Variant_5.Text = "5. Все ответы верны.";
            }
            else { MessageBox.Show("Вы ответили неправильно! "); checkboxvisible(); }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if ((Answer_1.Checked == true)&& (Answer_2.Checked == true) && (Answer_3.Checked == true))
            {
                MessageBox.Show("Вы ответили правильно! ");
                vopr31.Visible = false;
                vopr31.Location = new Point(500, 358);
                vopr4.Visible = true;
                vopr4.Location = new Point(70, 358);
                checkboxvisible();
                Question.Text = "Какие типы данных Java предназначены для хранения вещественных чисел?";
                Variant_1.Text = "1. float;";
                Variant_2.Text = "2. int;";
                Variant_3.Text = "3. double;";
                Variant_4.Text = "4. char;";
                Variant_5.Text = "5. bool.";
            }
            else { MessageBox.Show("Вы ответили неправильно! "); checkboxvisible(); }
        }

        private void vopr4_Click(object sender, EventArgs e)
        {
            if ((Answer_1.Checked == true) && (Answer_3.Checked == true))
            {
                MessageBox.Show("Вы ответили правильно! ");
                vopr4.Visible = false;
                vopr4.Location = new Point(500, 358);
                vopr5.Visible = true;
                vopr5.Location = new Point(70, 358);
                checkboxvisible();
                Question.Text = "Какие из перечисленных принципов не относятся к основным принципам ООП?";
                Variant_1.Text = "1. Логирование;";
                Variant_2.Text = "2. Наследование;";
                Variant_3.Text = "3. Изоморфизм;";
                Variant_4.Text = "4. Инкапсуляция;";
                Variant_5.Text = "5. Полиморфизм.";
               
            }
            else { MessageBox.Show("Вы ответили неправильно! "); checkboxvisible(); }
        }

        private void vopr5_Click(object sender, EventArgs e)
        {
            if ((Answer_1.Checked == true) && (Answer_3.Checked == true))
            {
                MessageBox.Show("Вы ответили правильно! ");
                MessageBox.Show("Вы успешно прошли тест на знание Java ");
                Study += 15;
                vopr5.Visible = false;
                vopr5.Location = new Point(500, 358);
                checkboxvisible();
                function_socr3();
            }
            else { MessageBox.Show("Вы ответили неправильно! "); checkboxvisible(); }
        }

        private void test2_Click(object sender, EventArgs e)
        {
            vopr6.Visible = true;
            function_socr2();
            Question.Text = "Для чего используется оператор NEW?";
            Question.Location = new Point(50, 50);
            Variant_1.Text = "1. Для создания новой переменной;";
            Variant_1.Location = new Point(70, 100);
            Variant_2.Text = "2. Для объявления нового класса;";
            Variant_2.Location = new Point(70, 150);
            Variant_3.Text = "3. Для создания экземпляра класса;";
            Variant_3.Location = new Point(70, 200);
            Variant_4.Text = "4. Это антагонист оператора OLD;";
            Variant_4.Location = new Point(70, 250);
            Variant_5.Text = "5. Нет верного ответа.";
            Variant_5.Location = new Point(70, 300);
            Answer_1.Location = new Point(55, 108);
            Answer_2.Location = new Point(55, 158);
            Answer_3.Location = new Point(55, 208);
            Answer_4.Location = new Point(55, 258);
            Answer_5.Location = new Point(55, 308);
            vopr6.Location = new Point(70, 358);
        }

        private void vopr6_Click(object sender, EventArgs e)
        {
            if (Answer_3.Checked == true)
            {
                MessageBox.Show("Вы ответили правильно! ");
                vopr6.Visible = false;
                vopr6.Location = new Point(500, 358);
                vopr7.Visible = true;
                vopr7.Location = new Point(70, 358);
                checkboxvisible();
                Question.Text = "Что такое класс в Java?";
                Variant_1.Text = "1. Уровень сложности программы. Все операторы делятся на классы в зависимости от сложности их использования;";
                Variant_2.Text = "2. Базовый элемент объектно-ориентирован­ного программирования в языке Java;";
                Variant_3.Text = "3. Просто одно из возможных названий переменной;";
                Variant_4.Text = "4. Такое понятие есть только в C++, в Java такого понятия нет;";
                Variant_5.Text = "5. Нет верного ответа.";
            }
            else { MessageBox.Show("Вы ответили неправильно! "); checkboxvisible(); }
        }

        private void vopr7_Click(object sender, EventArgs e)
        {
            if (Answer_2.Checked == true)
            {
                MessageBox.Show("Вы ответили правильно! ");
                vopr7.Visible = false;
                vopr7.Location = new Point(500, 358);
                vopr8.Visible = true;
                vopr8.Location = new Point(70, 358);
                checkboxvisible();
                Question.Text = "Как объявить класс в коде?";
                Variant_1.Text = "1. class MyClass {};";
                Variant_2.Text = "2. new class MyClass {};";
                Variant_3.Text = "3. select * from class MyClass {};";
                Variant_4.Text = "4. MyClass extends class {};";
                Variant_5.Text = "5. Нет верного ответа.";
            }
            else { MessageBox.Show("Вы ответили неправильно! "); checkboxvisible(); }
        }

        private void vopr8_Click(object sender, EventArgs e)
        {
            if (Answer_1.Checked == true)
            {
                MessageBox.Show("Вы ответили правильно! ");
                vopr8.Visible = false;
                vopr8.Location = new Point(500, 358);
                vopr9.Visible = true;
                vopr9.Location = new Point(70, 358);
                checkboxvisible();
                Question.Text = "Что означает ключевое слово extends?";
                Variant_1.Text = "1. Что данный класс наследуется от другого;";
                Variant_2.Text = "2. Что это дополнительный модуль класса, который расширяет его свойства;";
                Variant_3.Text = "3. Что два класса делают одно и то же;";
                Variant_4.Text = "4. Что это самый большой класс в программе;";
                Variant_5.Text = "5. Нет верного ответа.";
            }
            else { MessageBox.Show("Вы ответили неправильно! "); checkboxvisible(); }
        }

        private void vopr9_Click(object sender, EventArgs e)
        {
            if (Answer_1.Checked == true)
            {
                MessageBox.Show("Вы ответили правильно! ");
                vopr9.Visible = false;
                vopr9.Location = new Point(500, 358);
                vopr10.Visible = true;
                vopr10.Location = new Point(70, 358);
                checkboxvisible();
                Question.Text = "Что означает перегрузка метода в Java (overload)?";
                Variant_1.Text = "1. Изменение поведения метода класса относительно родительского;";
                Variant_2.Text = "2. Изменение поведения метода класса относительно дочернего;";
                Variant_3.Text = "3. Несколько разных классов с одинаковым методом;";
                Variant_4.Text = "4. Несколько методов с одинаковым названием, но разным набором параметров;";
                Variant_5.Text = "5. Нет верного ответа.";
            }
            else { MessageBox.Show("Вы ответили неправильно! "); checkboxvisible(); }
        }

        private void vopr10_Click(object sender, EventArgs e)
        {
            if (Answer_4.Checked == true)
            {
                MessageBox.Show("Вы ответили правильно! ");
                MessageBox.Show("Вы успешно прошли тест на знание Java!!! ");
                Study += 25;
                vopr10.Visible = false;
                vopr10.Location = new Point(500, 358);
                checkboxvisible();
                function_socr3();
            }
            else { MessageBox.Show("Вы ответили неправильно! "); checkboxvisible(); }
        }

        private void test3_Click(object sender, EventArgs e)
        {
            vopr11.Visible = true;
            function_socr2();
            Question.Text = "Что делает try-catch?";
            Question.Location = new Point(50, 50);
            Variant_1.Text = "1. Работает с базой данных;";
            Variant_1.Location = new Point(70, 100);
            Variant_2.Text = "2. Работает с файлами;";
            Variant_2.Location = new Point(70, 150);
            Variant_3.Text = "3. Работает с классами;";
            Variant_3.Location = new Point(70, 200);
            Variant_4.Text = "4. Работает с исключениями;";
            Variant_4.Location = new Point(70, 250);
            Variant_5.Text = "5. Нет верного ответа.";
            Variant_5.Location = new Point(70, 300);
            Answer_1.Location = new Point(55, 108);
            Answer_2.Location = new Point(55, 158);
            Answer_3.Location = new Point(55, 208);
            Answer_4.Location = new Point(55, 258);
            Answer_5.Location = new Point(55, 308);
            vopr11.Location = new Point(70, 358);
        }

        private void vopr11_Click(object sender, EventArgs e)
        {
            if (Answer_4.Checked == true)
            {
                MessageBox.Show("Вы ответили правильно! ");
                vopr11.Visible = false;
                vopr11.Location = new Point(500, 358);
                vopr12.Visible = true;
                vopr12.Location = new Point(70, 358);
                checkboxvisible();
                Question.Text = "Где верно происходит вывод данных в консоль?";
                Variant_1.Text = "1. print('Hi');";
                Variant_2.Text = "2. сonsole.log('Hi');";
                Variant_3.Text = "3. Console.write('Hi');";
                Variant_4.Text = "4. Console.WriteLine('Hi');";
                Variant_5.Text = "5. Нет верного ответа.";
            }
            else { MessageBox.Show("Вы ответили неправильно! "); checkboxvisible(); }
        }

        private void vopr12_Click(object sender, EventArgs e)
        {
            if (Answer_5.Checked == true)
            {
                MessageBox.Show("Вы ответили правильно! ");
                vopr12.Visible = false;
                vopr12.Location = new Point(500, 358);
                vopr13.Visible = true;
                vopr13.Location = new Point(70, 358);
                checkboxvisible();
                Question.Text = "В чем отличие между break и continue?";
                Variant_1.Text = "1. Нет отличий;";
                Variant_2.Text = "2. Continue работает только в циклах, break дополнительно в методах;";
                Variant_3.Text = "3. Continue пропускает итерацию, break выходит из цикла;";
                Variant_4.Text = "4. Break используется в Switch case, а continue в циклах;";
                Variant_5.Text = "5. Continue используется в Switch case, а break в циклах.";
            }
            else { MessageBox.Show("Вы ответили неправильно! "); checkboxvisible(); }
        }

        private void vopr13_Click(object sender, EventArgs e)
        {
            if (Answer_3.Checked == true)
            {
                MessageBox.Show("Вы ответили правильно! ");
                vopr13.Visible = false;
                vopr13.Location = new Point(500, 358);
                vopr14.Visible = true;
                vopr14.Location = new Point(70, 358);
                checkboxvisible();
                Question.Text = "Какие циклы существуют в языке C#?";
                Variant_1.Text = "1. for, while, do while;";
                Variant_2.Text = "2. for;";
                Variant_3.Text = "3. for, while, foreach;";
                Variant_4.Text = "4. for, while;";
                Variant_5.Text = "5. for, while, do while, foreach.";
            }
            else { MessageBox.Show("Вы ответили неправильно! "); checkboxvisible(); }
        }

        private void vopr14_Click(object sender, EventArgs e)
        {
            if (Answer_5.Checked == true)
            {
                MessageBox.Show("Вы ответили правильно! ");
                vopr14.Visible = false;
                vopr14.Location = new Point(500, 358);
                vopr15.Visible = true;
                vopr15.Location = new Point(70, 358);
                checkboxvisible();
                Question.Text = "Какие типы переменных существуют?";
                Variant_1.Text = "1. Все перечисленные;";
                Variant_2.Text = "2. int, char, bool, float, double;";
                Variant_3.Text = "3. int, char, bool, float, double, uint, short;";
                Variant_4.Text = "4. Ни один из них;";
                Variant_5.Text = "5. int, char, bool, string.";
            }
            else { MessageBox.Show("Вы ответили неправильно! "); checkboxvisible(); }
        }

        private void vopr15_Click(object sender, EventArgs e)
        {
            if (Answer_1.Checked == true)
            {
                MessageBox.Show("Вы ответили правильно! ");
                MessageBox.Show("Вы успешно прошли тест на знание C# !!! ");
                Study += 20;
                vopr15.Visible = false;
                vopr15.Location = new Point(500, 358);
                checkboxvisible();
                function_socr3();
            }
            else { MessageBox.Show("Вы ответили неправильно! "); checkboxvisible(); }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Progress pr1 = new Progress();
            pr1.minutes = min;
            pr1.hours = hours;
            pr1.day = day;
            pr1.month = month;
            pr1.year = year;
            pr1.money = BYN;
            pr1.prBar_Hungry = Hungry;
            pr1.prBar_Drink = Drink;
            pr1.prBar_Health = Health;
            pr1.prBar_Study = Study;
            MethodsForProgress.Serialize(pr1);

            DialogResult exitBox = MessageBox.Show("Вы хотите покинуть игру?", "Выход из игры",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exitBox == DialogResult.Yes)
                this.Close();
        }
    }
}
