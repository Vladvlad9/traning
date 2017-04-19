using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using MySql.Data.MySqlClient;

namespace tst2
{
    public partial class Data_types : UserControl
    {
        int current_button = 1;
        public Data_types()
        {
            InitializeComponent();
        }

        public void Text_code()
        {
            fastColoredTextBox_code.Text = "using System;\n" +
                "namespace FirstApp\n" +
                "{\n" +
                "   class Program\n" +
                "   {\n" +
                "       static void Main(string[] args)\n" +
                "       {\n" +
                "           /* ↓ Ваш код ↓ */\n" +
                "       }\n" +
                "   }\n" +
                "}";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Function.Timer_panel_menu(timer1, metroPanel1, 230);
        }

        private void metroTile_menu_Click(object sender, EventArgs e)
        {
            Function.Back_menu(timer1, metroPanel1, 35);
        }

        private void Data_types_Load(object sender, EventArgs e)
        {
            metroTile_obschee_Click(sender, e);

            MySqlConnection connection = new MySqlConnection(Server.connStr);
            connection.Open();
            string query = "select * from passing " +
                "inner join polzovatel on polzovatel.id_passing = passing.id " +
                "where polzovatel.login = '" + Function.login + "' ";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();

            reader.Read();

            Function.check_task = reader.GetString("obschee_date_type");
            Function.check_task1 = reader.GetString("integer_type");
            Function.check_task2 = reader.GetString("float_type");
            Function.check_task3 = reader.GetString("char_type");
            Function.check_task4 = reader.GetString("double_type");
            Function.check_task5 = reader.GetString("bool_type");
            Function.check_task6 = reader.GetString("const_data_type");
            Function.check_task7 = reader.GetString("finish_data_type");
            connection.Close();

            if (Function.check_task == "yes") metroTile_obschee_date_type.BackColor = ColorTranslator.FromHtml("#47a447");
            if (Function.check_task1 == "yes") metroTile_integer_type.BackColor = ColorTranslator.FromHtml("#47a447");
            if (Function.check_task2 == "yes") metroTile_float_type.BackColor = ColorTranslator.FromHtml("#47a447");
            if (Function.check_task3 == "yes") metroTile_double_type.BackColor = ColorTranslator.FromHtml("#47a447");
            if (Function.check_task4 == "yes") metroTile_char_type.BackColor = ColorTranslator.FromHtml("#47a447");
            if (Function.check_task5 == "yes") metroTile_bool_type.BackColor = ColorTranslator.FromHtml("#47a447");
            if (Function.check_task6 == "yes") metroTile_const_data_type.BackColor = ColorTranslator.FromHtml("#47a447");
            if (Function.check_task7 == "yes") metroTile_const_data_type.BackColor = ColorTranslator.FromHtml("#47a447");
        }



        private void metroTile_obschee_Click(object sender, EventArgs e)//Введение
        {
            current_button = 1;
            Function.Input_Output_Show(1, "data_types");

            string remove_obschee = Function.description_algorithm.Remove(211);
            string remove_obschee1 = Function.description_algorithm.Substring(212, 161);
            string remove_obschee2 = Function.description_algorithm.Substring(374,128);
            string remove_obschee3 = Function.description_algorithm.Substring(503, 23);
            string remove_obschee_int = Function.description_algorithm.Substring(527, 20);
            string remove_obschee_float = Function.description_algorithm.Substring(548, 21);
            string remove_obschee_char = Function.description_algorithm.Substring(570, 18);
            string remove_obschee_double = Function.description_algorithm.Substring(589, 39);
            string remove_obschee_bool = Function.description_algorithm.Substring(629, 17);

            fastColoredTextBox_theory.Text = Function.name_traning + "\n\n" + remove_obschee + "\n" + remove_obschee1 + "\n" + remove_obschee2 + "\n\n" + remove_obschee3 + "\n" + 
                remove_obschee_int + "\n" + remove_obschee_float + "\n" + remove_obschee_char + "\n" + remove_obschee_double + "\n" + remove_obschee_bool;

            fastColoredTextBox_task.Text = Function.task;

            fastColoredTextBox_code.Text = "using System;\n" +
                "namespace FirstApp\n" +
                "{\n" +
                "   class Program\n" +
                "   {\n" +
                "       static void Main(string[] args)\n" +
                "       {\n" +
                "           int i_number;\n" +
                "           float f_number;\n" +
                "           char c_number;\n" +
                "           double d_number;\n" +
                "           bool b_number;\n" +
                "       }\n" +
                "   }\n" +
                "}";
        }

        private void metroTile_integer_type_Click(object sender, EventArgs e)//Целочисленный тип
        {
            current_button = 2;
            Function.Input_Output_Show(2, "data_types");
            string remove_integer_type = Function.description_algorithm.Remove(61);
            string remove_integer_type2 = Function.description_algorithm.Substring(62, 107);
            string remove_integer_type3 = Function.description_algorithm.Substring(171, 29);
            string remove_integer_type4 = Function.description_algorithm.Substring(200, 18);
            string remove_integer_type5 = Function.description_algorithm.Substring(218, 56);

            fastColoredTextBox_theory.Text = Function.name_traning + "\n\n" + remove_integer_type + "\n" + remove_integer_type2 + "\n\n" + remove_integer_type3 +
                "\n" + remove_integer_type4 + "\n\n" + remove_integer_type5;

            fastColoredTextBox_task.Text = "Задание для усвоения материала:" + "\n\n" + Function.task;

            Text_code();

        }

        private void metroTile_float_type_Click(object sender, EventArgs e)//FLOAT
        {
            current_button = 3;
            Function.Input_Output_Show(3, "data_types");

            string remove_float = Function.description_algorithm.Remove(65);
            string remove_float1 = Function.description_algorithm.Substring(66, 74);
            string remove_float2 = Function.description_algorithm.Substring(141,7);
            string remove_float3 = Function.description_algorithm.Substring(149, 9);

            fastColoredTextBox_theory.Text = Function.name_traning + "\n\n" + remove_float + "\n" + remove_float1 + "\n\n" + remove_float2 + "\n" + remove_float3;
            fastColoredTextBox_task.Text = "Задание для усвоения материала:" + "\n\n" + Function.task;
            Text_code();//fastColoredTextBox_code
        }

        private void metroTile_double_type_Click(object sender, EventArgs e)//Double
        {
            current_button = 4;
            Function.Input_Output_Show(5, "data_types");

            string remove_double = Function.description_algorithm.Remove(154);
            string remove_double1 = Function.description_algorithm.Substring(155, 63);
            string remove_double2 = Function.description_algorithm.Substring(219, 90);

            fastColoredTextBox_task.Text = "Задание для усвоения материала:" + "\n\n" + Function.task;
            fastColoredTextBox_theory.Text = Function.name_traning + "\n\n" + remove_double + "\n" + remove_double1 + "\n" + remove_double2;
            
            Text_code();//fastColoredTextBox_code 


        }

        private void metroTile_char_type_Click(object sender, EventArgs e)//Char
        {
            current_button = 5;
            Function.Input_Output_Show(4, "data_types");

            string remove_char = Function.description_algorithm.Remove(123);
            string remove_char1 = Function.description_algorithm.Substring(124, 46);
            string remove_char2 = Function.description_algorithm.Substring(171, 124);
            string remove_char3 = Function.description_algorithm.Substring(296, 54);
            
            fastColoredTextBox_theory.Text = Function.name_traning + "\n\n" + remove_char + "\n" + remove_char1 + "\n" + remove_char2 + "\n" + remove_char3;
            fastColoredTextBox_task.Text = "Задание для усвоения материала:" +"\n\n"+ Function.task;
            Text_code();//fastColoredTextBox_code
        }

        private void metroTile_bool_type_Click(object sender, EventArgs e)//Bool
        {
            current_button = 6;
            Function.Input_Output_Show(6, "data_types");

            string rename_bool = Function.description_algorithm.Remove(112);
            string rename_bool1 = Function.description_algorithm.Substring(113, 94);
            string rename_bool2 = Function.description_algorithm.Substring(208, 49);

            fastColoredTextBox_theory.Text = Function.name_traning + "\n\n" + rename_bool + "\n" + rename_bool1 + "\n" + rename_bool2;
            fastColoredTextBox_task.Text = "Задание для усвоения материала:" + "\n\n" + Function.task;
            Text_code();//fastColoredTextBox_code
        }

        private void metroTile_const_data_type_Click(object sender, EventArgs e)//COnst
        {
            current_button = 7;
            Function.Input_Output_Show(7, "data_types");

            string rename_const = Function.description_algorithm.Remove(229);
            string rename_const1 = Function.description_algorithm.Substring(230, 29);
            string rename_const2 = Function.description_algorithm.Substring(260, 18);
            string rename_const3 = Function.description_algorithm.Substring(279, 22);
            string rename_const4 = Function.description_algorithm.Substring(301, 28);
            fastColoredTextBox_theory.Text = Function.name_traning + "\n\n" + rename_const + "\n" + rename_const1 + "\n" + rename_const2 + "\n" + rename_const3 + "\n" + rename_const4;
            

            string rename_task_const = Function.task.Remove(23);
            string rename_task_const1 = Function.task.Substring(24, 51);
            string rename_task_const2 = Function.task.Substring(76, 63);
            string rename_task_const3 = Function.task.Substring(140, 50);
            fastColoredTextBox_task.Text = "Задание для усвоения материала:" + "\n\n" + rename_task_const + "\n" + rename_task_const1 + "\n" 
                + rename_task_const2 + "\n" + rename_task_const3;

            Text_code();//fastColoredTextBox_code
        }

        private void metroTile_finish_data_type_Click(object sender, EventArgs e)//Закрепление материала
        {
            current_button = 8;
            Function.Input_Output_Show(8, "data_types");

            Text_code();//fastColoredTextBox_code
            fastColoredTextBox_theory.Text = Function.description_algorithm;

            string rename_finish = Function.task.Remove(55);
            string rename_finish1 = Function.task.Substring(56, 46);
            string rename_finish2 = Function.task.Substring(103, 52);
            string rename_finish3 = Function.task.Substring(156, 44);
            string rename_finish4 = Function.task.Substring(201, 70);

            fastColoredTextBox_task.Text = "Задание для усвоения материала:" + "\n\n" + rename_finish + "\n" + rename_finish1 + "\n" + rename_finish2 +
                "\n" + rename_finish3 + "\n" + rename_finish4;
        }



        private void metroButton_check_job_data_type_Click(object sender, EventArgs e)
        {
            string tast_for_integer_type = "int height_anhel_waterfall;";
            string task_for_float_type = "float colibri_size;";
            string task_for_double_type = "double golden_section;";
            string task_for_char_type = "char first_letter_alphabet;";
            string task_for_bool_type = "bool is_round_earth;";

            string task_for_const = "const int degrees_circle = 360;";
            string task_for_const1 = "const float diameter_poker_chips = 0.39;";
            string task_for_const2 = "const char oldest_letter = 'o';";

            string task_for_finish_int = "int number_apples = 10;";
            string task_for_finish_float = "float cost_one_apple = 42.54;";
            string task_for_finish_double = "double cost_one_apple = 42.54;";
            string task_for_finish_char = "char vit_c = 'C';";

            

            switch (current_button)
            {
                case 1://metroTile_integer_type_Click
                    {
                        metroTile_integer_type_Click(sender, e);
                        Function.Update_table_passing("obschee_date_type");
                        metroTile_obschee_date_type.BackColor = ColorTranslator.FromHtml("#47a447");
                        break;
                    }
                case 2://metroTile_float_type_Click
                    {
                        if (fastColoredTextBox_code.Text.Contains(tast_for_integer_type))
                        {
                            metroTile_float_type_Click(sender, e);
                            Function.Update_table_passing("integer_type");
                            metroTile_integer_type.BackColor = ColorTranslator.FromHtml("#47a447");

                            SaveFileDialog save = new SaveFileDialog();
                            save.Filter = "cs file (*.cs)|.cs";
                            if (save.ShowDialog() == DialogResult.OK)
                            {
                                File.WriteAllText(save.FileName, fastColoredTextBox_code.Text);
                                Process.Start(@"C:\Windows\Microsoft.NET\Framework\v3.5\csc.exe", save.FileName);
                            }
                        }
                        else
                            MessageBox.Show("Задание выполнено не правильно");
                        
                        break;
                    }
                case 3://metroTile_double_type_Click
                    {
                        if (fastColoredTextBox_code.Text.Contains(task_for_float_type))
                        {
                            metroTile_double_type_Click(sender, e);
                            Function.Update_table_passing("float_type");
                            metroTile_float_type.BackColor = ColorTranslator.FromHtml("#47a447");
                        }
                        else
                            MessageBox.Show("Задание выполнено не правильно");
                        
                        break;
                    }
                case 4://metroTile_char_type_Click
                    {
                        if (fastColoredTextBox_code.Text.Contains(task_for_double_type))
                        {
                            metroTile_char_type_Click(sender, e);
                            Function.Update_table_passing("double_type");
                            metroTile_double_type.BackColor = ColorTranslator.FromHtml("#47a447");
                        }
                        else
                            MessageBox.Show("Задание выполнено не правильно");

                        break;
                    }
                case 5://metroTile_char_type_Click
                    {
                        if (fastColoredTextBox_code.Text.Contains(task_for_char_type))
                        {
                            metroTile_bool_type_Click(sender, e);
                            Function.Update_table_passing("char_type");
                            metroTile_char_type.BackColor = ColorTranslator.FromHtml("#47a447");
                        }
                        else
                            MessageBox.Show("Задание выполнено не правильно");

                        break;
                    }
                case 6://metroTile_bool_type_Click
                    {
                        if (fastColoredTextBox_code.Text.Contains(task_for_bool_type))
                        {
                            metroTile_const_data_type_Click(sender, e);
                            Function.Update_table_passing("bool_type");
                            metroTile_bool_type.BackColor = ColorTranslator.FromHtml("#47a447");
                        }
                        else
                            MessageBox.Show("Задание выполнено не правильно");

                        break;
                    }
                case 7://metroTile_const_data_type_Click
                    {
                        if (fastColoredTextBox_code.Text.Contains(task_for_const) && fastColoredTextBox_code.Text.Contains(task_for_const1) && fastColoredTextBox_code.Text.Contains(task_for_const2))
                        {
                            metroTile_finish_data_type_Click(sender, e);
                            Function.Update_table_passing("const_data_type");
                            metroTile_const_data_type.BackColor = ColorTranslator.FromHtml("#47a447");
                        }
                        else
                            MessageBox.Show("Задание выполнено не правильно");

                        break;
                    }
                case 8:
                    {
                        if (fastColoredTextBox_code.Text.Contains(task_for_finish_int) || fastColoredTextBox_code.Text.Contains(task_for_finish_float) || fastColoredTextBox_code.Text.Contains(task_for_finish_double) && fastColoredTextBox_code.Text.Contains(task_for_finish_char))
                        {
                            Function.Update_table_passing("finish_data_type");
                            metroTile_finish_data_type.BackColor = ColorTranslator.FromHtml("#47a447");
                            if (MessageBox.Show("Вы прошли курс Типы данных. Желаеете продолжить","Поздравление",MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
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
                            MessageBox.Show("Задание выполнено не правильно");

                        break;
                    }
            }
        }

        
    }
}
