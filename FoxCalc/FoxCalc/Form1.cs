using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;

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
            Except(box1.Text);
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
            Except(box1.Text);
            label1.Text = $"{a}-";
            box1.Clear();
            box1.Focus();
            temp = 2;
            znak = true;
            label2.Text = "-";
        }
        private void Multiply_Click(object sender, EventArgs e) // Умножение
        {
            Except(box1.Text);
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
            Except(box1.Text);
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
            Except(box1.Text);
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
            Except(box1.Text);
            a = Convert.ToInt32(box1.Text);
            label1.Text = $"Sin {a}";
            box1.Clear();
            temp = 5;
            znak = true;
            label2.Text = "Sin";
        }
        private void Cos_Click(object sender, EventArgs e) // Косинус
        {
            Except(box1.Text);
            a = Convert.ToInt32(box1.Text);
            label1.Text = $"Cos {a}";
            box1.Clear();
            temp = 6;
            znak = true;
            label2.Text = "Cos";
        }

        private void Tang_Click(object sender, EventArgs e) // Тангенс
        {
            Except(box1.Text);
            a = Convert.ToInt32(box1.Text);
            label1.Text = $"Tg {a}";
            box1.Clear();
            temp = 7;
            znak = true;
            label2.Text = "Tg";
        }

        private void Ctg_Click(object sender, EventArgs e) // Котангенс
        {
            Except(box1.Text);
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
            Except(box1.Text);
            a = Convert.ToInt32(box1.Text);
            label1.Text = $"X^2 {a}";
            box1.Clear();
            temp = 9;
            znak = true;
            label2.Text = "x^2";
        }
        private void Exp_Click(object sender, EventArgs e) // Экспонента
        {
            Except(box1.Text);
            a = Convert.ToInt32(box1.Text);
            label1.Text = $"Exp {a}";
            box1.Clear();
            temp = 10;
            znak = true;
            label2.Text = "exp";
        }

        private void Sqrt_Click(object sender, EventArgs e) // Квадратный корень
        {
            Except(box1.Text);
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
                    b = 1 / Math.Tan(a);
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

        private void Stats_CheckedChanged(object sender, EventArgs e)
        {
            int count = 0;
            //Подсчет цифр
            foreach (char ch in InputBox.Text)
            {
                if (Char.IsDigit(ch))
                    count++;
            }
            //Подсчет гласных и согласных
            string gl = "уеыаоэяиёюУЕЫАОЭЯИЁЮaeiouAEIOU";
            string sogl = "цкнгшщзхфвпрлджчсмтбЦКНГШЩЗХФВПРЛДЖЧСМТБbcdfghjklmnpqrstvwxyzBCDFGHJKLMNQRSTVWXYZ";
            int i = 0, j = 0;
            //Общее кол-во
            InputBox.Text.ToCharArray().All(z =>
            {
                if (gl.ToCharArray().Contains(z)) i++;
                else if
            (sogl.ToCharArray().Contains(z)) j++; return true; });
            //Вывод
            labelresult.Text = $"Сколько строк: { ((string[])InputBox.Lines).Length.ToString()} \n" +
                $"Сколько слов: { InputBox.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length } \n" +
                $"Сколько цифр: {count} \n" +
                $"Гласных: {i} \n" +
                $"Согласных: {j}";
        }

        private void Lower_CheckedChanged(object sender, EventArgs e)
        {
            string low = InputBox.Text.ToLower();
            outputBox.Text = $"{low}";
        }

        private void Upper_CheckedChanged(object sender, EventArgs e)
        {
            string up = InputBox.Text.ToUpper();
            outputBox.Text = $"{up}";
        }

        private void Strokelength_CheckedChanged(object sender, EventArgs e)
        {
            string l = InputBox.Text.Length.ToString();
            labelresult.Text = $"Длина строки: {l}";
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            InputBox.Text = "";
            outputBox.Text = "";
            labelresult.Text = "";
            strokelength.Checked = false;
            upper.Checked = false;
            lower.Checked = false;
            stats.Checked = false;
            cb5.Checked = false;
            cb6.Checked = false;
            cb7.Checked = false;
        }

        private void Cb7_CheckedChanged(object sender, EventArgs e)
        {
            // нахождение ошибок в строке
            string text = InputBox.Text;
            string[] trues = new string[] { "жи", "ши", "ча", "ща", "чу", "щу" };
            string[] errors = new string[] { "жы", "шы", "чя", "щя", "чю", "щю" };
            for (int i = 0; i < InputBox.Text.Length; i++)// перебираем введенные данные
            {
                for (int j = 0; j < errors.Length; j++) // перебираем ошибки
                {
                    if (InputBox.Text.Contains(errors[j])) // проверка на наличие ошибок
                        text = InputBox.Text.Replace(errors[j], trues[j]); // если они есть, заменяем их
                    outputBox.Text = text;
                }
            }
        }

        private void ConvEqual_Click(object sender, EventArgs e)
        {
            // задаем расход и цены за л бензина
            if (VehiclesBox.SelectedIndex == 0)
                intakeLabel.Text = 8.ToString();
            if (VehiclesBox.SelectedIndex == 1)
                intakeLabel.Text = 4.ToString();
            if (VehiclesBox.SelectedIndex == 2)
                intakeLabel.Text = 33.ToString();
            if (FuelBox.SelectedIndex == 0)
                PriceLabel.Text = 20.50.ToString();
            if (FuelBox.SelectedIndex == 1)
                PriceLabel.Text = 45.95.ToString(); 
            if (FuelBox.SelectedIndex == 2)
                PriceLabel.Text = 41.30.ToString();
            if (FuelBox.SelectedIndex == 3)
                PriceLabel.Text = 47.33.ToString();
            if (FuelBox.SelectedIndex == 4)
                PriceLabel.Text = 52.02.ToString();
            // переменные
                double distance = Convert.ToDouble(inputDistance.Text);
                double fuel = Convert.ToDouble(PriceLabel.Text);
                double intake = Convert.ToDouble(intakeLabel.Text);
                // расчет цены за поездку
                OutputPrice.Text = Math.Round(((distance / 100) * intake) * fuel).ToString();
        }
        private void ClearButConv_Click(object sender, EventArgs e)
        {
            inputDistance.Clear();
            OutputPrice.Clear();
            PriceLabel.Text = "";
            intakeLabel.Text = "";
            FuelBox.SelectedItem = default;
            VehiclesBox.SelectedItem = default;
        }

        private void Cb5_CheckedChanged(object sender, EventArgs e)
        {
            string text = InputBox.Text;
            text = InputBox.Text.Substring(5); // извлечение подстроки
            outputBox.Text = text;
        }

        private void BInputFile_Click(object sender, EventArgs e)
        { // считывание данных
            FileStream file = new FileStream("C:/Users/1/source/repos/FoxForms/FoxCalc/FoxCalc/input.txt", FileMode.OpenOrCreate, FileAccess.Read); // создание файлового потока
            StreamReader reader = new StreamReader(file); // создаем «потоковый читатель» и связываем его с файловым потоком
            inputDistance.Text = reader.ReadToEnd(); // считывание из файла и вставка в поле расстояние
            reader.Close(); // закрываем поток
        }

        private void BOutputFile_Click(object sender, EventArgs e)
        { // запись результатов
            FileStream file1 = new FileStream("C:/Users/1/source/repos/FoxForms/FoxCalc/FoxCalc/output.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(file1);  //создаем «потоковый писатель» и связываем его с файловым потоком
            writer.Write("Стоимость поездки: " + OutputPrice.Text); // запись в файл
            writer.Close(); // закрываем поток
        }

        public void Except(string box1)
        {
            try
            {
                double i = Convert.ToDouble(box1);
                box1 = Convert.ToString(i);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введено нечисловое значение!", "Ошибка");// исключение на ввод букв
            }
        }
    }
}