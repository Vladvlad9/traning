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
    public partial class Comments_Form : UserControl
    {
        int i = 1;
<<<<<<< HEAD

        
=======
        static string text2 = "Hello World!";
        string tasc = "using System.Text\r\nnamespace HelloWorld\r\n{\r\n   class Program  /*объявление нового класса*/\r\n   {\r\n       static void Main(string[] args) /*объявление метода main*/\r\n       {\r\n           //Console.WriteLine(\"Hello World!\");\r\n        }\r\n   }\r\n}";

>>>>>>> 821be088a35b7bcbb9c003e8de77408d35f20cb9

        public Comments_Form()
        {
            InitializeComponent();
        }
        private void Comments_Form_Load(object sender, EventArgs e)
        {
            metroTile_Structure_Click(sender, e);

            MySqlConnection connection = new MySqlConnection(Server.connStr);
            connection.Open();
            string query = "select * from passing " +
                "inner join polzovatel on polzovatel.id_passing = passing.id " +
                "where polzovatel.login = '" + Function.login + "' ";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();

            reader.Read();

            Function.check_task = reader.GetString("structure");
            Function.check_task1 = reader.GetString("purpose");
            Function.check_task2 = reader.GetString("singleline_comments");
            Function.check_task3 = reader.GetString("multiline_comments");
            connection.Close();

            if (Function.check_task == "yes") metroTile_Structure.BackColor = ColorTranslator.FromHtml("#47a447");
            if (Function.check_task1 == "yes") metroTile_Purpose.BackColor = ColorTranslator.FromHtml("#47a447");
            if (Function.check_task2 == "yes") metroTile_Singleline_comments.BackColor = ColorTranslator.FromHtml("#47a447");
            if (Function.check_task3 == "yes") metroTile_Multiline_comments.BackColor = ColorTranslator.FromHtml("#47a447");
        }
        

        private void timer_panel_menu_Tick(object sender, EventArgs e)
        {
            Function.Timer_panel_menu(timer_panel_menu, metroPanel1, 230);
        }

        private void metroTile_menu_Click(object sender, EventArgs e)
        {
            Function.Back_menu(timer_panel_menu, metroPanel1, 35);
        }





<<<<<<< HEAD


=======
>>>>>>> 821be088a35b7bcbb9c003e8de77408d35f20cb9
        private void metroTile_Structure_Click(object sender, EventArgs e)
        {
            Function.structure = 1;
            i = 1;
            Function.Input_Output_Show(1, "comments");
            
            string remove_t = Function.description_algorithm.Remove(249);
            string remove_t1 = Function.description_algorithm.Substring(250, 314);
            fastColoredTextBox_theory.Text = remove_t + "\n" + "\n" + remove_t1;
<<<<<<< HEAD

            fastColoredTextBox_code.Text = "/* ↓ Пример структуры простейшей программы на С# ↓ */\n" +
                "using System; \nusing System.Collections.Generic; \nusing System.Linq; \nusing System.Text;\n" +
                "namespace FirstApp /*объявление нового пространства имен*/\n" +
                "{// скобки означают начало\n" +
                "   class Program  /*объявление нового класса*/\n" +
                "   {\n" +
                "       static void Main(string[] args) /*объявление метода main*/\n" +
                "       {\n         Console.WriteLine(\"Hello World!\");// вывод строки в консоль \n       }\n   }\n}";

=======

            fastColoredTextBox_code.Text = "/* ↓ Пример структуры простейшей программы на С# ↓ */\n" +
                "using System; \nusing System.Collections.Generic; \nusing System.Linq; \nusing System.Text;\n" +
                "namespace FirstApp /*объявление нового пространства имен*/\n" +
                "{// скобки означают начало\n" +
                "   class Program  /*объявление нового класса*/\n" +
                "   {\n" +
                "       static void Main(string[] args) /*объявление метода main*/\n" +
                "       {\n         Console.WriteLine(\"Hello World!\");// вывод строки в консоль \n       }\n   }\n}";

>>>>>>> 821be088a35b7bcbb9c003e8de77408d35f20cb9
            fastColoredTextBox_task.Text = "Задание" + " \n" + Function.task;
        }
        
        private void metroTile_Purpose_Click(object sender, EventArgs e)
        {
            Function.purpose = 2;
            i = 2;
            Function.Input_Output_Show(2, "comments");

            string remove_t = Function.description_algorithm.Remove(154);
            string remove_t1 = Function.description_algorithm.Substring(155,38);
            string remove_t2 = Function.description_algorithm.Substring(194, 20);
            string remove_t3 = Function.description_algorithm.Substring(215, 26);
            string remove_t4 = Function.description_algorithm.Substring(242, 163);

            fastColoredTextBox_theory.Text = remove_t + "\n" + remove_t1 + "\n" + remove_t2 + "\n" + remove_t3 + "\n" + remove_t4;
            fastColoredTextBox_task.Text = "Задание" + " \n" + Function.task;
<<<<<<< HEAD

            string text = "/* Это уже\n             многострочный комментарий */";
            string text2 = "Это скомпилируется";

=======

            string text = "/* Это уже\n             многострочный комментарий */";
            string text2 = "Это скомпилируется";

>>>>>>> 821be088a35b7bcbb9c003e8de77408d35f20cb9
            fastColoredTextBox_code.Text = "// Это однострочный комментарий\n" +
                "\n\n" +
                "using System.Text\n" +
                "namespace FirstApp /*объявление пространства имен*/\n" +
                "{\n" +
                "   class Program  /*объявление нового класса*/\n" +
                "   {\n" +
                "       static void Main(string[] args) /*объявление метода main*/\n" +
                "       {\n" +
                "           string s = \""+ text +"\"\n" +
                "           Console.WriteLine (/* Здесь идет комментарий! */ \"" + text2 + "\");\n " +
                "       }\n" +
                "   }\n" +
                "}";
        }

        private void metroTile_Singleline_comments_Click(object sender, EventArgs e)
        {
            i = 3;
            Function.singleline_comments = 3;
            Function.Input_Output_Show(3, "comments");

            
            string remove_t = Function.description_algorithm.Remove(55);
            string remove_t1 = Function.description_algorithm.Substring(56);
            
            fastColoredTextBox_theory.Text = remove_t + "\n"+ remove_t1;
<<<<<<< HEAD
            
            fastColoredTextBox_code.Text = "using System.Text\r\nnamespace HelloWorld\r\n" +
                "{\r\n   class Program  /*объявление нового класса*/\r\n" +
                "   {\r\n" +
                "       static void Main(string[] args) /*объявление метода main*/\r\n" +
                "       {\r\n" +
                "           Console.WriteLine(\"Hello World!\");\r\n" +
                "        }\r\n" +
                "   }\r" +
                "\n}";
=======

            string text2 = "Hello World!";
            fastColoredTextBox_code.Text = "using System.Text\n" +
                "namespace HelloWorld\n" +
                "{\n" +
                "   class Program  /*объявление нового класса*/\n" +
                "   {\n" +
                "       static void Main(string[] args) /*объявление метода main*/\n" +
                "       {\n" +
                "           Console.WriteLine(\"" + text2 + "\");\n " +
                "       }\n" +
                "   }\n" +
                "}";
>>>>>>> 821be088a35b7bcbb9c003e8de77408d35f20cb9
            fastColoredTextBox_task.Text = "Задание для усвоение материала" + "\n" + "\n" + Function.task;
        }

        private void metroTile_Multiline_comments_Click(object sender, EventArgs e)
        {
            i = 4;
            Function.multiline_comments = 4;
            Function.Input_Output_Show(4, "comments");

            string remove_t = Function.description_algorithm;

            fastColoredTextBox_theory.Text = remove_t;
<<<<<<< HEAD
            fastColoredTextBox_task.Text = Function.task;
            fastColoredTextBox_code.Text = "using System.Text\r\nnamespace HelloWorld\r\n" +
                "{\r\n   class Program  /*объявление нового класса*/\r\n" +
                "   {\r\n" +
                "       static void Main(string[] args) /*объявление метода main*/\r\n" +
                "       {\r\n" +
                "           Console.WriteLine(\"Hello World!\");\r\n" +
                "           Console.ReadLine();\r\n" +
                "        }\r\n" +
                "   }\r" +
                "\n}";

        }
        


        private void metroButton_check_job_comments_Click(object sender, EventArgs e)
        {
            string task1 = "//Console.WriteLine(\"Hello World!\");";
            string task2 = "/*Console.WriteLine(\"Hello World!\");\r\n" +
                "           Console.ReadLine();*/";

            switch (i)
            {
                case 1:
                    {//Структура
                        metroTile_Structure_Click(sender, e);
                        Function.Update_table_passing("structure");
                        metroTile_Structure.BackColor = ColorTranslator.FromHtml("#47a447");
                        i++;
                        break;
                    }
                case 2:
                    {
                        metroTile_Purpose_Click(sender, e);
                        Function.Update_table_passing("purpose");
                        metroTile_Purpose.BackColor = ColorTranslator.FromHtml("#47a447");
                        i++;
                        break;
                    }
                case 3:
                    {//Однострочные коммментарии
                        metroTile_Singleline_comments_Click(sender, e);
                        metroTile_Purpose.BackColor = ColorTranslator.FromHtml("#47a447");
=======
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            switch (i)
            {
                case 1:{//Структура
                    metroTile_Structure_Click(sender, e);
                    i++;
                    break;
                }
                case 2:{
                    metroTile_Purpose_Click(sender, e);
                    i++;
                    break;
                }
                case 3:{//Однострочные коммментарии
                        metroTile_Singleline_comments_Click(sender, e);
>>>>>>> 821be088a35b7bcbb9c003e8de77408d35f20cb9
                        i++;
                        break;
                    }

<<<<<<< HEAD

                case 4:
                    {///Многострочные комментарии
                        if (fastColoredTextBox_code.Text.Contains(task1))
                        {
                            Function.Update_table_passing("singleline_comments");
                            metroTile_Multiline_comments_Click(sender, e);
                            metroTile_Singleline_comments.BackColor = ColorTranslator.FromHtml("#47a447");
                            i = 5;
                        }
                        else
                            MessageBox.Show("Задание выполнено не правильно");
                        break;
                    }
                case 5:
                    {
                        if (fastColoredTextBox_code.Text.Contains(task2))
                        {
                            metroTile_Multiline_comments.BackColor = ColorTranslator.FromHtml("#47a447");
                            Function.Update_table_passing("multiline_comments");
                            if (MessageBox.Show("Вы прошли курс коментариев, желаете продолжить", "Поздравление", MessageBoxButtons.OKCancel,MessageBoxIcon.Asterisk) == DialogResult.OK)
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
=======
                    
                case 4:{///Многострочные комментарии
                        if (fastColoredTextBox_code.Text == tasc)
                        {
                            metroTile_Multiline_comments_Click(sender, e);
                            i++;
                        }
                        else
                            MessageBox.Show("Задание выполнено не правильно");
                    break;
                }

>>>>>>> 821be088a35b7bcbb9c003e8de77408d35f20cb9

            }
        }
    }
}
