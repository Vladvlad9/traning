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
    public partial class Increment_Decrement : UserControl
    {
        int current_button = 1;
        public Increment_Decrement()
        {
            InitializeComponent();
        }

        private void Increment_Decrement_Load(object sender, EventArgs e)
        {
            metroTile_Increment_Click(sender, e);

            MySqlConnection connection = new MySqlConnection(Server.connStr);
            connection.Open();
            string query = "select * from passing " +
                "inner join polzovatel on polzovatel.id_passing = passing.id " +
                "where polzovatel.login = '" + Function.login + "' ";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();

            reader.Read();

            Function.check_task = reader.GetString("increment");
            Function.check_task1 = reader.GetString("decrement");
            Function.check_task2 = reader.GetString("relational_operators");
            Function.check_task3 = reader.GetString("logical_operators");
            Function.check_task4 = reader.GetString("finish_incriment_decriment");
            Function.check_task5 = reader.GetString("asignment_operators");
            connection.Close();


            if (Function.check_task == "yes") metroTile_Increment.BackColor = ColorTranslator.FromHtml("#47a447");
            if (Function.check_task1 == "yes") metroTile_Decrement.BackColor = ColorTranslator.FromHtml("#47a447");
            if (Function.check_task2 == "yes") metroTile_Relational_operations.BackColor = ColorTranslator.FromHtml("#47a447");
            if (Function.check_task3 == "yes") metroTile_Logical_operators.BackColor = ColorTranslator.FromHtml("#47a447");
            if (Function.check_task4 == "yes") metroTile_Assignment_operators.BackColor = ColorTranslator.FromHtml("#47a447");
            if (Function.check_task5 == "yes") metroTile_finish_incriment_decriment.BackColor = ColorTranslator.FromHtml("#47a447");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Function.Timer_panel_menu(timer1, metroPanel1, 230);
        }

        private void metroTile_menu_Click(object sender, EventArgs e)
        {
            Function.Back_menu(timer1, metroPanel1, 35);
        }



        private void metroTile_Increment_Click(object sender, EventArgs e)//Инкримент
        {
            current_button = 1;
            Function.Input_Output_Show(1, "increment_decrement");

            fastColoredTextBox_theory.Text = Function.name_traning + "\n\n" + Function.description_algorithm;

            fastColoredTextBox_task.Text = "Задание для усвоения материала: " + "\n\n" + Function.task;

            fastColoredTextBox_code.Text = "using System;\n" +
                "namespace FirstApp\n" +
                "{\n" +
                "   class Program\n" +
                "   {\n" +
                "       static void Main(string[] args)\n" +
                "       {\n" +
                "           // возраст - 20 лет\n" +
                "           int age = 20;\n\n" +
                "           /* ↓ Ваш код ↓ */\n\n\n" +
                "           Console.WriteLine(\"Через год будет: \" + age);\n" +
                "           Console.Redline()\n" +
                "       }\n" +
                "   }\n" +
                "}";
        }

        private void metroTile_Decrement_Click(object sender, EventArgs e)//ДЕкремент
        {
            current_button = 2;
            Function.Input_Output_Show(2, "increment_decrement");

            fastColoredTextBox_theory.Text = Function.name_traning + "\n\n" + Function.description_algorithm;

            fastColoredTextBox_task.Text = "Задание для усвоения материала: " + "\n\n" + Function.task;

            fastColoredTextBox_code.Text = "using System;\n" +
                "namespace FirstApp\n" +
                "{\n" +
                "   class Program\n" +
                "   {\n" +
                "       static void Main(string[] args)\n" +
                "       {\n" +
                "           // возраст - 20 лет\n" +
                "           int age = 20;\n\n" +
                "           /* ↓ Ваш код ↓ */\n\n\n" +
                "           Console.WriteLine(\"В прошлом году было: \" + age);\n" +
                "           Console.Redline()\n" +
                "       }\n" +
                "   }\n" +
                "}";
        }
        
        private void metroTile_Relational_operations_Click(object sender, EventArgs e)//Операторы отношений 
        {
            current_button = 3;
            Function.Input_Output_Show(3, "increment_decrement");

            string remove_relational_operations = Function.description_algorithm.Remove(336);
            string remove_relational_operations1 = Function.description_algorithm.Substring(336, 9);// == Равно;
            string remove_relational_operations2 = Function.description_algorithm.Substring(346, 12);// != Не равно;
            string remove_relational_operations3 = Function.description_algorithm.Substring(359, 9);// > Больше;
            string remove_relational_operations4 = Function.description_algorithm.Substring(369, 9);// < Меньше;
            string remove_relational_operations5 = Function.description_algorithm.Substring(379, 20);// >= Больше или равно;
            string remove_relational_operations6 = Function.description_algorithm.Substring(400, 19);// <= Меньше или равно

            fastColoredTextBox_theory.Text = Function.name_traning + "\n\n" + remove_relational_operations + "\n" + remove_relational_operations1 + "\n" + remove_relational_operations2
                + "\n" + remove_relational_operations3 + "\n" + remove_relational_operations4 + "\n" + remove_relational_operations5 + "\n" + remove_relational_operations6;


            fastColoredTextBox_task.Text = "Задание для усвоения материала: " + "\n\n" + Function.task;
        }

        private void metroTile_Logical_operators_Click(object sender, EventArgs e)//Логические операторы
        {
            current_button = 4;
            Function.Input_Output_Show(4, "increment_decrement");

            string remove_logical_operations = Function.description_algorithm.Remove(120);
            string remove_logical_operations1 = Function.description_algorithm.Substring(121, 6);
            string remove_logical_operations2 = Function.description_algorithm.Substring(128, 8);
            string remove_logical_operations3 = Function.description_algorithm.Substring(137, 20);
            string remove_logical_operations4 = Function.description_algorithm.Substring(158, 19);
            string remove_logical_operations5 = Function.description_algorithm.Substring(178,21);
            string remove_logical_operations6 = Function.description_algorithm.Substring(200, 6);

            fastColoredTextBox_theory.Text = Function.name_traning + "\n\n" + remove_logical_operations + "\n" + remove_logical_operations1 + "\n" + remove_logical_operations2
                + "\n" + remove_logical_operations3 + "\n" + remove_logical_operations4 + "\n" + remove_logical_operations5 + "\n" + remove_logical_operations6;

            fastColoredTextBox_task.Text = "Задание для усвоения материала: " + "\n\n" + Function.task;

        }

        private void metroTile_Assignment_operators_Click(object sender, EventArgs e)//Операторы присваивания
        {
            current_button = 5;
            Function.Input_Output_Show(5, "increment_decrement");

            string remove_assignment_operators = Function.description_algorithm.Remove(298);
            string remove_assignment_operators1 = Function.description_algorithm.Substring(299, 125);
            string remove_assignment_operators2 = Function.description_algorithm.Substring(425, 161);

            fastColoredTextBox_theory.Text = Function.name_traning + "\n\n" + remove_assignment_operators + "\n" + remove_assignment_operators1 + "\n\n" +
                remove_assignment_operators2;

            fastColoredTextBox_task.Text = "Задание для усвоения материала: " + "\n\n" + Function.task;
        }

        private void metroTile_finish_incriment_decriment_Click(object sender, EventArgs e)//Закрепление материала
        {
            current_button = 6;
            Function.Input_Output_Show(6, "increment_decrement");

            fastColoredTextBox_theory.Text = Function.name_traning + "\n\n" + Function.description_algorithm;
        }



        private void metroButton_check_increment_decrement_Click(object sender, EventArgs e)//Кнопка перехода 
        {
            string task_for_incriment = "age++;";//Задание для инкримента
            string task_for_decrement = "age--;";//Задание для инкримента
            string task_for_relational_operations = "";//Задание для операторов отношения
            string task_for_logical_operators = "";//Задание для логических операторов
            string task_for_asignment_operators = "";//Задание для jператоры присваивания
            string task_for_finish_incriment_decriment = "";


            switch (current_button)
            {
                case 1:
                    {
                        if (fastColoredTextBox_code.Text.Contains(task_for_incriment))
                        {
                            Function.Update_table_passing("increment");
                            metroTile_Increment.BackColor = ColorTranslator.FromHtml("#47a447");
                            metroTile_Decrement_Click(sender, e);
                        }
                        else
                            MessageBox.Show("Задание выполнено неправильно. Исправьте код и попробуйте снова.", "Ошибка");
                        break;
                    }
                case 2:
                    {
                        if (fastColoredTextBox_code.Text.Contains(task_for_decrement))
                        {
                            Function.Update_table_passing("decrement");
                            metroTile_Decrement.BackColor = ColorTranslator.FromHtml("#47a447");
                            metroTile_Relational_operations_Click(sender, e);
                        }
                        else
                            MessageBox.Show("Задание выполнено неправильно. Исправьте код и попробуйте снова.", "Ошибка");
                        break;
                    }
                case 3:
                    {
                        if (fastColoredTextBox_code.Text.Contains(task_for_relational_operations))
                        {
                            Function.Update_table_passing("relational_operators");
                            metroTile_Relational_operations.BackColor = ColorTranslator.FromHtml("#47a447");
                            metroTile_Logical_operators_Click(sender, e);
                        }
                        else
                            MessageBox.Show("Задание выполнено неправильно. Исправьте код и попробуйте снова.", "Ошибка");
                        break;
                    }
                case 4:
                    {
                        if (fastColoredTextBox_code.Text.Contains(task_for_logical_operators))
                        {
                            Function.Update_table_passing("logical_operators");
                            metroTile_Logical_operators.BackColor = ColorTranslator.FromHtml("#47a447");
                            metroTile_Assignment_operators_Click(sender, e);
                        }
                        else
                            MessageBox.Show("Задание выполнено неправильно. Исправьте код и попробуйте снова.", "Ошибка");
                        break;

                    }
                case 5:
                    {
                        if (fastColoredTextBox_code.Text.Contains(task_for_asignment_operators))
                        {
                            Function.Update_table_passing("asignment_operators");
                            metroTile_Assignment_operators.BackColor = ColorTranslator.FromHtml("#47a447");
                            metroTile_finish_incriment_decriment_Click(sender, e);
                        }
                        else
                            MessageBox.Show("Задание выполнено неправильно. Исправьте код и попробуйте снова.", "Ошибка");
                        break;
                    }
                case 6:
                    {
                        if (fastColoredTextBox_code.Text.Contains(task_for_finish_incriment_decriment))
                        {
                            Function.Update_table_passing("finish_incriment_decriment");
                            metroTile_finish_incriment_decriment.BackColor = ColorTranslator.FromHtml("#47a447");
                            if (MessageBox.Show("Вы прошли курс \"Инкримент и Дикримент \". Желаеете продолжить", "Поздравление", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
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
