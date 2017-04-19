using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace tst2
{
    public partial class Arithmetic_operations : UserControl
    {
        int current_button;
        public Arithmetic_operations()
        {
            InitializeComponent();
        }

        private void Arithmetic_operations_Load(object sender, EventArgs e)
        {
            metroTile_obschee_arithmetic_operations_Click(sender, e);

            MySqlConnection connection = new MySqlConnection(Server.connStr);
            connection.Open();
            string query = "select * from passing " +
                "inner join polzovatel on polzovatel.id_passing = passing.id " +
                "where polzovatel.login = '" + Function.login + "' ";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();

            reader.Read();

            Function.check_task = reader.GetString("obschee_arithmetic_operations");
            Function.check_task1 = reader.GetString("equally");
            Function.check_task2 = reader.GetString("plus_arithmetic_operations");
            Function.check_task3 = reader.GetString("minus_arithmetic_operations");
            Function.check_task4 = reader.GetString("multiplication_arithmetic_operations");
            Function.check_task5 = reader.GetString("division_arithmetic_operations");
            Function.check_task6 = reader.GetString("finish_arithmetic_operations");
            connection.Close();

            if (Function.check_task == "yes") metroTile_obschee_arithmetic_operations.BackColor = ColorTranslator.FromHtml("#47a447");
            if (Function.check_task1 == "yes") metroTile_equally.BackColor = ColorTranslator.FromHtml("#47a447");
            if (Function.check_task2 == "yes") metroTile_plus.BackColor = ColorTranslator.FromHtml("#47a447");
            if (Function.check_task3 == "yes") metroTile_minus.BackColor = ColorTranslator.FromHtml("#47a447");
            if (Function.check_task4 == "yes") metroTile_multiplication.BackColor = ColorTranslator.FromHtml("#47a447");
            if (Function.check_task5 == "yes") metroTile_division.BackColor = ColorTranslator.FromHtml("#47a447");
            if (Function.check_task6 == "yes") metroTile_finish_arithmetic_operations.BackColor = ColorTranslator.FromHtml("#47a447");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Function.Timer_panel_menu(timer1, metroPanel1, 230);
        }

        private void metroTile_menu_Click(object sender, EventArgs e)//Меню
        {
            Function.Back_menu(timer1, metroPanel1, 35);
        }



        private void metroTile_obschee_arithmetic_operations_Click(object sender, EventArgs e)//Введение
        {
            current_button = 1;
            Function.Input_Output_Show(1, "arithmetic_operations");

            fastColoredTextBox_theory.Text = Function.name_traning + "\n\n" + Function.description_algorithm;

            fastColoredTextBox_code.Text = "using System;\n" +
                "namespace FirstApp\n" +
                "{\n" +
                "   class Program\n" +
                "   {\n" +
                "       static void Main(string[] args)\n" +
                "       {\n" +
                "           int a, b, c;\n" +
                "           a = 8;\n" +
                "           b = 10;\n" +
                "           c = (a + b) * (a / b);\n" +
                "       }\n" +
                "   }\n" +
                "}";
        }

        private void metroTile_equally_Click(object sender, EventArgs e)//Оператор присваивания.
        {
            current_button = 2;
            Function.Input_Output_Show(2, "arithmetic_operations");

            string remove_equall = Function.description_algorithm.Remove(229);//первая половина текста
            string remove_equall1 = Function.description_algorithm.Substring(230, 8);//пример 
            string remove_equall2 = Function.description_algorithm.Substring(239, 17);//високосный год
            string remove_equall3 = Function.description_algorithm.Substring(257, 20);//int leap_year = 366;
            string remove_equall4 = Function.description_algorithm.Substring(278, 44);//вторая половина

            fastColoredTextBox_theory.Text = Function.name_traning + "\n\n" + remove_equall + "\n\n" + remove_equall1 + "\n" + remove_equall2 +"\n"
                + remove_equall3 + "\n\n" + remove_equall4;

            fastColoredTextBox_code.Text = "using System;\n" +
                "namespace FirstApp\n" +
                "{\n" +
                "   class Program\n" +
                "   {\n" +
                "       static void Main(string[] args)\n" +
                "       {\n" +
                "           // Высота водопада - Анхель (м)\n" +
                "           int height_anhel_waterfall;\n" +
                "           \n" +
                "           // Размер самых маленьких колибри (см)\n" +
                "           float colibri_size;\n" +
                "           \n" +
                "           // Первая буква алфавита\n" +
                "           char first_letter_alphabet;\n" +
                "           \n" +
                "           // Золотое сечение\n" +
                "           double golden_section;\n" +
                "           \n" +
                "           // Земля круглая?\n" +
                "           bool is_round_earth;\n" +
                "       }\n" +
                "   }\n" +
                "}";

            string remove_task_equall = Function.task.Remove(23);//первая часть текста
            string remove_task_equall1 = Function.task.Substring(24, 37);//int height_anhel_waterfall
            string remove_task_equall2 = Function.task.Substring(62, 27);//float colibri_size;
            string remove_task_equall3 = Function.task.Substring(90, 36);//char first_letter_alphabet
            string remove_task_equall4 = Function.task.Substring(127, 38);//double golden_section
            string remove_task_equall5 = Function.task.Substring(166, 32);//bool is_round_earth
            string remove_task_equall6 = Function.task.Substring(199, 80);//вторая часть текста

            fastColoredTextBox_task.Text = "Задание для усвоения материала: " + "\n\n" + remove_task_equall + "\n" + remove_task_equall1 + "\n" +
                remove_task_equall2 + "\n" + remove_task_equall3 + "\n" + remove_task_equall4 + "\n" + remove_task_equall5 + "\n\n" + remove_task_equall6;
        }

        private void metroTile_plus_Click(object sender, EventArgs e)//Сумма
        {
            current_button = 3;
            Function.Input_Output_Show(3, "arithmetic_operations");

            fastColoredTextBox_theory.Text = Function.name_traning + "\n\n" + Function.description_algorithm;

            fastColoredTextBox_task.Text = "Задание для усвоения материала:" + "\n\n" + Function.task;

            fastColoredTextBox_code.Text = "using System;\n" +
                "namespace FirstApp\n" +
                "{\n" +
                "   class Program\n" +
                "   {\n" +
                "       static void Main(string[] args)\n" +
                "       {\n" +
                "           //  Глубина залегания Ядра Земли (км)\n" +
                "           int depth_to_core_earth = 2900;\n" +
                "           //  средний радиус ядра (км)\n" +
                "           int avg_radius_core = 3500;\n" +
                "           \n" +
                "           /* ↓ Ваш код ↓ */\n" +
                "           \n\n" +
                "           Console.WriteLine(\"Радиус Земли приблизительно равен \" + earth_radius + \" км \");\n" +
                "           Console.ReadLine();\n" +
                "       }\n" +
                "   }\n" +
                "}";
        }

        private void metroTile_minus_Click(object sender, EventArgs e)//Разность
        {
            current_button = 4;
            Function.Input_Output_Show(4, "arithmetic_operations");

            string remove_minus = Function.description_algorithm.Remove(269);
            string remove_minus1 = Function.description_algorithm.Substring(270, 7);//Пример
            string remove_minus2 = Function.description_algorithm.Substring(278, 21);
            string remove_minus3 = Function.description_algorithm.Substring(300, 14);

            fastColoredTextBox_theory.Text = Function.name_traning + "\n\n" + remove_minus + "\n\n" + remove_minus1 + "\n" + remove_minus2 + "\n" +
                remove_minus3;
            fastColoredTextBox_task.Text = "Задание для усвоения материала: " + "\n\n" + Function.task;

            fastColoredTextBox_code.Text = "using System;\n" +
                "namespace FirstApp\n" +
                "{\n" +
                "   class Program\n" +
                "   {\n" +
                "       static void Main(string[] args)\n" +
                "       {\n" +
                "           //  высота горы - Джомолунгма (Эверест)\n" +
                "           int qomolangma = 8848;\n" +
                "           //  высота горы - Чогори\n" +
                "           int chogori = 8611;\n\n" +
                "           /* ↓ Ваш код ↓ */\n\n" +
                "           Console.WriteLine(\"Эверест на \" + height_diff + \" метров выше горы Чогори!\");\n" +
                "           Console.ReadLine();\n" +
                "       }\n" +
                "   }\n" +
                "}";
        }

        private void metroTile_multiplication_Click(object sender, EventArgs e)//Произведение
        {
            current_button = 5;
            Function.Input_Output_Show(5, "arithmetic_operations");

            fastColoredTextBox_theory.Text = Function.name_traning + "\n\n" + Function.description_algorithm;
            fastColoredTextBox_task.Text = "Задание для усвоения материала: " + "\n\n" + Function.task;

            fastColoredTextBox_code.Text = "using System;\n" +
                "namespace FirstApp\n" +
                "{\n" +
                "   class Program\n" +
                "   {\n" +
                "       static void Main(string[] args)\n" +
                "       {\n" +
                "           int number = 4;\n\n" +
                "           /* ↓ Ваш код ↓ */\n" +
                "           int square\n\n" +
                "           Console.WriteLine(\"Квадрат \" + number + \"=\" + square);\n" +
                "           Console.ReadLine();\n" +
                "       }\n" +
                "   }\n" +
                "}";

        }

        private void metroTile_division_Click(object sender, EventArgs e)//Деление
        {
            current_button = 6;
            Function.Input_Output_Show(6, "arithmetic_operations");

            string remove_division = Function.description_algorithm.Remove(168);
            string remove_division1 = Function.description_algorithm.Substring(169, 83);
            string remove_division2 = Function.description_algorithm.Substring(253, 35);
            string remove_division3 = Function.description_algorithm.Substring(289, 45);
            string remove_division4 = Function.description_algorithm.Substring(335, 18);
            string remove_division5 = Function.description_algorithm.Substring(354, 176);
            string remove_division6 = Function.description_algorithm.Substring(531, 22);
            string remove_division7 = Function.description_algorithm.Substring(554, 33);//double float_division = 13.0 / 2;
            string remove_division8 = Function.description_algorithm.Substring(588, 183);
            string remove_division9 = Function.description_algorithm.Substring(772, 80);
            string remove_division10 = Function.description_algorithm.Substring(853, 52);
            string remove_division11 = Function.description_algorithm.Substring(906, 25);
            string remove_division12 = Function.description_algorithm.Substring(932, 63);
            string remove_division13 = Function.description_algorithm.Substring(996, 37);
            string remove_division14 = Function.description_algorithm.Substring(1034, 25);
            string remove_division15 = Function.description_algorithm.Substring(1060, 75);

            fastColoredTextBox_theory.Text = Function.name_traning + "\n\n" + remove_division + "\n" + remove_division1 + "\n" + remove_division2 + "\n\n" +
                remove_division3 + "\n" + remove_division4 + "\n\n" + remove_division5 + "\n" + remove_division6 + "\n" + remove_division7 + "\n" + remove_division8 +
                "\n\n" + remove_division9 + "\n" + remove_division10 + "\n" + remove_division11 + "\n\n" + remove_division12 + "\n" + remove_division13 + "\n" +
                remove_division14 + "\n" + remove_division15;

            fastColoredTextBox_task.Text = "Задание для усвоения материала: " + "\n\n" + Function.task;

            fastColoredTextBox_code.Text = "using System;\n" +
                "namespace FirstApp\n" +
                "{\n" +
                "   class Program\n" +
                "   {\n" +
                "       static void Main(string[] args)\n" +
                "       {\n" +
                "           int division; // сюда запишим результат от деления\n" +
                "           int rem_division; // сюда запишим остаток от деления\n\n" +
                "           // целая часть от деления 5 на 2\n" +
                "           division\n" +
                "           Console.WriteLine(\"Целая часть от деления 5 / 2 = \" + division);\n\n\n" +
                "           // остаток от деления 5 на 2\n" +
                "           rem_division\n" +
                "           Console.WriteLine(\"Остаток от деления 5 % 2 = \" + rem_division);\n\n\n" +
                "           // 5.0 разделить на 2.0\n" +
                "           double float_division\n" +
                "           Console.WriteLine(\"Деление как в математике 5.0 / 2.0 = \" + float_division);\n" +
                "           Console.ReadLine();\n" +
                "       }\n" +
                "   }\n" +
                "}";
        }

        private void metroTile_finish_arithmetic_operations_Click(object sender, EventArgs e)//Завершение
        {
            current_button = 7;
            Function.Input_Output_Show(7, "arithmetic_operations");

            fastColoredTextBox_theory.Text = Function.name_traning + "\n\n" + Function.description_algorithm;
            fastColoredTextBox_task.Text = "Задание для усвоения материала: " + "\n\n" + Function.task;

            fastColoredTextBox_code.Text = "using System;\n" +
                "namespace FirstApp\n" +
                "{\n" +
                "   class Program\n" +
                "   {\n" +
                "       static void Main(string[] args)\n" +
                "       {\n" +
                "           int a = 5;\n" +
                "           int b = 3;\n" +
                "           int c = 1;\n\n" +
                "           /* ↓ Ваш код ↓ */\n\n\n" +
                "           Console.WriteLine(\"Дискриминант = \" + discriminant);\n\n\n" +
                "       }\n" +
                "   }\n" +
                "}";
        }




        private void metroButton_check_job_arithmetic_operations_Click(object sender, EventArgs e)//Кнопка "Продолжить"
        {
            string task_for_equall = "int height_anhel_waterfall = 979;";
            string task_for_equall1 = "float colibri_size = 5.7;";
            string task_for_equall2 = "char first_letter_alphabet = 'A';";
            string task_for_equall3 = "double golden_section = 1.61803398875;";
            string task_for_equall4 = "bool is_round_earth = true;";

            string task_for_plus = "int earth_radius = depth_to_core_earth+avg_radius_core;";

            string task_for_minus = "int height_diff = qomolangma - chogori;";

            string task_for_multiplication = "int square = number * number;";

            string task_for_division = "division = 5 / 2;";
            string task_for_division1 = "rem_division = 5 % 2;";
            string task_for_division2 = "double float_division = 5.0 / 2.0;";

            string task_for_finich = "int discriminant = b * b - 4 * a * c;";

            switch (current_button)
            {
                case 1:{
                        Function.Update_table_passing("obschee_arithmetic_operations");
                        metroTile_obschee_arithmetic_operations.BackColor = ColorTranslator.FromHtml("#47a447");
                        metroTile_equally_Click(sender, e);
                        break;
                    }

                case 2:{  
                        if (fastColoredTextBox_code.Text.Contains(task_for_equall) && fastColoredTextBox_code.Text.Contains(task_for_equall1) &&
                            fastColoredTextBox_code.Text.Contains(task_for_equall2) && fastColoredTextBox_code.Text.Contains(task_for_equall3) &&
                            fastColoredTextBox_code.Text.Contains(task_for_equall4)){
                            
                            Function.Update_table_passing("equally");
                            metroTile_equally.BackColor = ColorTranslator.FromHtml("#47a447");
                            metroTile_plus_Click(sender, e);
                        }
                        else
                            MessageBox.Show("Задание выполнено неправильно. Исправьте код и попробуйте снова.", "Ошибка");

                        break;
                    }
                case 3:
                    {
                        if (fastColoredTextBox_code.Text.Contains(task_for_plus))
                        {
                            Function.Update_table_passing("plus_arithmetic_operations");
                            metroTile_plus.BackColor = ColorTranslator.FromHtml("#47a447");
                            metroTile_minus_Click(sender, e);
                        }
                        else
                            MessageBox.Show("Задание выполнено неправильно. Исправьте код и попробуйте снова.", "Ошибка");

                        break;
                    }
                case 4:
                    {
                        if (fastColoredTextBox_code.Text.Contains(task_for_minus))
                        {
                            Function.Update_table_passing("minus_arithmetic_operations");
                            metroTile_minus.BackColor = ColorTranslator.FromHtml("#47a447");
                            metroTile_multiplication_Click(sender, e);
                        }
                        else
                            MessageBox.Show("Задание выполнено неправильно. Исправьте код и попробуйте снова.", "Ошибка");

                        break;
                    }
                case 5:
                    {
                        if (fastColoredTextBox_code.Text.Contains(task_for_multiplication))
                        {
                            Function.Update_table_passing("multiplication_arithmetic_operations");
                            metroTile_multiplication.BackColor = ColorTranslator.FromHtml("#47a447");
                            metroTile_division_Click(sender, e);
                        }
                        else
                            MessageBox.Show("Задание выполнено неправильно. Исправьте код и попробуйте снова.", "Ошибка");

                        break;
                    }
                case 6:
                    {
                        if (fastColoredTextBox_code.Text.Contains(task_for_division) && fastColoredTextBox_code.Text.Contains(task_for_division1) && fastColoredTextBox_code.Text.Contains(task_for_division2))
                        {
                            Function.Update_table_passing("division_arithmetic_operations");
                            metroTile_division.BackColor = ColorTranslator.FromHtml("#47a447");
                            metroTile_finish_arithmetic_operations_Click(sender, e);
                        }
                        else
                            MessageBox.Show("Задание выполнено неправильно. Исправьте код и попробуйте снова.", "Ошибка");

                        break;
                    }
                case 7:
                    {
                        if (fastColoredTextBox_code.Text.Contains(task_for_finich))
                        {
                            Function.Update_table_passing("finish_arithmetic_operations");
                            metroTile_finish_arithmetic_operations.BackColor = ColorTranslator.FromHtml("#47a447");
                            if (MessageBox.Show("Вы прошли курс \"Арифметические операции \". Желаеете продолжить", "Поздравление", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
                            {
                                if (!Form2.Instance.MetroPanel.Controls.ContainsKey("Input_Output"))
                                {
                                    Input_Output profile = new Input_Output();
                                    profile.Dock = DockStyle.Fill;
                                    Form2.Instance.MetroPanel.Controls.Add(profile);
                                }
                                Form2.Instance.MetroPanel.Controls["Input_Output"].BringToFront();
                                Form2.Instance.MetroBack.Visible = true;
                            }
                        }
                        else
                            MessageBox.Show("Задание выполнено неправильно. Исправьте код и попробуйте снова.", "Ошибка");

                        break;
                    }
                    
            }
        }

        
    }
}
