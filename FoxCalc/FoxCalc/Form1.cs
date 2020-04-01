using System;
using System.Windows.Forms;

namespace FoxCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double a, b;
        public int temp;
        public bool znak = true;
        private void N0_Click(object sender, EventArgs e) // Кнопка "0"
        {
            box1.Text = box1.Text + 0;
            label1.Text = label1.Text + "0";
        }
        private void N1_Click(object sender, EventArgs e) // Кнопка "1"
        {
            box1.Text = box1.Text + 1;
            label1.Text = label1.Text + "1";
        }
        private void N2_Click(object sender, EventArgs e) // Кнопка "2"
        {
            box1.Text = box1.Text + 2;
            label1.Text = label1.Text + "2";
        }
        private void N3_Click(object sender, EventArgs e) // Кнопка "3"
        {
            box1.Text = box1.Text + 3;
            label1.Text = label1.Text + "3";
        }
        private void N4_Click(object sender, EventArgs e) // Кнопка "4"
        {
            box1.Text = box1.Text + 4;
            label1.Text = label1.Text + "4";
        }
        private void N5_Click(object sender, EventArgs e) // Кнопка "5"
        {
            box1.Text = box1.Text + 5;
            label1.Text = label1.Text + "5";
        }
        private void N6_Click(object sender, EventArgs e) // Кнопка "6"
        {
            box1.Text = box1.Text + 6;
            label1.Text = label1.Text + "6";
        }
        private void N7_Click(object sender, EventArgs e) // Кнопка "7"
        {
            box1.Text = box1.Text + 7;
            label1.Text = label1.Text + "7";
        }
        private void N8_Click(object sender, EventArgs e) // Кнопка "8"
        {
            box1.Text = box1.Text + 8;
            label1.Text = label1.Text + "8";
        }
        private void N9_Click(object sender, EventArgs e) // Кнопка "9"
        {
            box1.Text = box1.Text + 9;
            label1.Text = label1.Text + "9";
        }
        private void Plus_Click(object sender, EventArgs e) // Сложение
        {
           except(box1.Text);
                a = Convert.ToInt32(box1.Text);
                label1.Text = $"{a}+";
                box1.Clear();
                box1.Focus();
                temp = 1;
                znak = true;
                label2.Text = "+";
        }
        private void Minus_Click(object sender, EventArgs e) // Вычитание
        {
            except(box1.Text);
            label1.Text = $"{a}-";
            box1.Clear();
            box1.Focus();
            temp = 2;
            znak = true;
            label2.Text = "-";
        }
        private void Multiply_Click(object sender, EventArgs e) // Умножение
        {
            except(box1.Text);
            a = Convert.ToInt32(box1.Text);
            label1.Text = $"{a}*";
            box1.Clear();
            box1.Focus();
            temp = 3;
            znak = true;
            label2.Text = "*";
        }
        private void Segment_Click(object sender, EventArgs e) // Деление
        {
                except(box1.Text);
                a = Convert.ToInt32(box1.Text);
                label1.Text = $"{a}/";
                box1.Clear();
                box1.Focus();
                temp = 4;
                znak = true;
                label2.Text = "/";
        }
        private void Equal_Click(object sender, EventArgs e) // Кнопка равно
        {
                except(box1.Text);
                 Calc(temp);
                box1.Text = Convert.ToString(b);
        }
        private void Clear_Click(object sender, EventArgs e) // Кнопка очистки
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            box1.Clear();
            a = 0;
            b = 0;
        }
        private void Sin_Click(object sender, EventArgs e) // Синус
        {
                except(box1.Text);
                a = Convert.ToInt32(box1.Text);
                label1.Text = $"Sin {a}";
                box1.Clear();
                temp = 5;
                znak = true;
                label2.Text = "Sin";
        }
        private void Cos_Click(object sender, EventArgs e) // Косинус
        {
            except(box1.Text);
            a = Convert.ToInt32(box1.Text);
            label1.Text = $"Cos {a}";
            box1.Clear();
            temp = 6;
            znak = true;
            label2.Text = "Cos";
        }

        private void Tang_Click(object sender, EventArgs e) // Тангенс
        {
            except(box1.Text);
            a = Convert.ToInt32(box1.Text);
            label1.Text = $"Tg {a}";
            box1.Clear();
            temp = 7;
            znak = true;
            label2.Text = "Tg";
        }

        private void Ctg_Click(object sender, EventArgs e) // Котангенс
        {
            except(box1.Text);
            a = Convert.ToInt32(box1.Text);
            label1.Text = $"Сtg {a}";
            box1.Clear();
            temp = 8;
            znak = true;
            label2.Text = "Сtg";
        }

        private void Sign_Click(object sender, EventArgs e) // Кнопка +/-
        {
            if (znak == true)
            {
                box1.Text = "-" + box1.Text;
                znak = false;
            }
            else if (znak == false)
            {
                box1.Text = box1.Text.Replace("-", "");
                znak = true;
            }
        }

        private void Square_Click(object sender, EventArgs e) // Возведение в степень
        {
            except(box1.Text);
            a = Convert.ToInt32(box1.Text);
            label1.Text = $"X^2 {a}";
            box1.Clear();
            temp = 9;
            znak = true;
            label2.Text = "x^2";
        }
        private void Exp_Click(object sender, EventArgs e) // Экспонента
        {
            except(box1.Text);
            a = Convert.ToInt32(box1.Text);
            label1.Text = $"Exp {a}";
            box1.Clear();
            temp = 10;
            znak = true;
            label2.Text = "exp";
        }

        private void Sqrt_Click(object sender, EventArgs e) // Квадратный корень
        {
            except(box1.Text);
            a = Convert.ToInt32(box1.Text);
            label1.Text = $"sqrt {a}";
            box1.Clear();
            temp = 11;
            znak = true;
            label2.Text = "sqrt";
                if (a < 0)  // если число а отрицательное, то выдает ошибку
                MessageBox.Show("Корень из отрицательного числа выводить нельзя", "Ошибка");
        }
        private void Oct_CheckedChanged(object sender, EventArgs e) // перевод в восьмиричную сс
        {
            int s = Convert.ToInt32(box1.Text);
            label1.Text = $"oct {s}";
            box1.Text = Convert.ToString(s, 8);
            label2.Text = "oct";
        }

        private void Bin_CheckedChanged(object sender, EventArgs e) // двоичная сс
        {
            int s = Convert.ToInt32(box1.Text);
            label1.Text = $"bin {s}";
            box1.Text = Convert.ToString(s, 2);
            label2.Text = "bin";
        }

        private void Hex_CheckedChanged(object sender, EventArgs e) // 16-ричная сс
        {
            int s = Convert.ToInt32(box1.Text);
            label1.Text = $"hex {s}";
            box1.Text = Convert.ToString(s, 16);
            label2.Text = "hex";
        }

        private void Dec_CheckedChanged(object sender, EventArgs e) // десятичная сс
        {
            int s = Convert.ToInt32(box1.Text);
            label1.Text = $"dec {s}";
            box1.Text = Convert.ToString(s, 10);
            label2.Text = "dec";
        }
        public void Calc(int temp) // Кнопка =
        {
            switch (temp)
            {
                case 1:
                    b = a + Convert.ToInt32(box1.Text);
                    box1.Text = b.ToString();
                    break;
                case 2:
                    b = a - Convert.ToInt32(box1.Text);
                    box1.Text = b.ToString();
                    break;
                case 3:
                    b = a * Convert.ToInt32(box1.Text);
                    box1.Text = b.ToString();
                    break;
                case 4:
                    b = a / Convert.ToInt32(box1.Text);
                    box1.Text = b.ToString();
                    break;
                case 5:
                    b = Math.Sin(a);
                    box1.Text = b.ToString();
                    break;
                case 6:
                    b = Math.Cos(a);
                    box1.Text = b.ToString();
                    break;
                case 7:
                    b = Math.Tan(a);
                    box1.Text = b.ToString();
                    break;
                case 8:
                    b = 1/Math.Tan(a);
                    box1.Text = b.ToString();
                    break;
                case 9:
                    b = Math.Pow(a, 2);
                    box1.Text = b.ToString();
                    break;
                case 10:
                    b = Math.Exp(a);
                    box1.Text = b.ToString();
                    break;
                case 11:
                    b = Math.Sqrt(a);
                    box1.Text = b.ToString();
                    break;
                default:
                    break;
            }
        }

        private void Cb1_CheckedChanged(object sender, EventArgs e) // длина строки
        {
            string l = InputBox.Text.Length.ToString();
            labelresult.Text = $"Длина строки: {l}";
        }

        private void Cb2_CheckedChanged(object sender, EventArgs e) // заглавные
        {
            string up = InputBox.Text.ToUpper();
            outputBox.Text = $"{up}";
        }

        private void Cb3_CheckedChanged(object sender, EventArgs e) // строчные
        {
            string low = InputBox.Text.ToLower();
            outputBox.Text = $"{low}";
        }

        public void except(string box1)
        {
            try
            {
                int i = Convert.ToInt32(box1);
                box1 = Convert.ToString(i);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введено нечисловое значение!", "Ошибка");// исключение на ввод букв
            }
        }
    }
}