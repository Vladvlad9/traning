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
using System.Text.RegularExpressions;
using System.Threading;

namespace tst2
{
    public partial class Introduction : UserControl
    {
        public MySqlConnection conn = new MySqlConnection(Server.connStr);
        public bool b = false;
        public bool ba = false;
<<<<<<< HEAD
        int i = 1;
=======
        string algorithm = "";
        string compiler = "";
>>>>>>> 821be088a35b7bcbb9c003e8de77408d35f20cb9

        public void Label_name_traning() {
            MetroFramework.Controls.MetroLabel label_name_traning = new MetroFramework.Controls.MetroLabel();
            label_name_traning.Size = new Size(81, 20);
            label_name_traning.Location = new Point(593, 0);
            label_name_traning.Text = Function.name_traning;
            Controls.Add(label_name_traning);
            label_name_traning.BringToFront();
        }
<<<<<<< HEAD
=======

        public void Button_next_traning() {
            MetroFramework.Controls.MetroButton button = new MetroFramework.Controls.MetroButton();
            button.Size = new Size(100, 48);
            button.Location = new Point(1244, 3);
            button.Text = "Выполнить";
            Controls.Add(button);
            button.BringToFront();
        }
>>>>>>> 821be088a35b7bcbb9c003e8de77408d35f20cb9
        

        public Introduction()
        {
            InitializeComponent();
        }

        private void timer_panel_menu_Tick(object sender, EventArgs e)
        {
            Function.Timer_panel_menu(timer_panel_menu, metroPanel1, 170);
        }

        private void metroTile_back_Click(object sender, EventArgs e)
        {
            Function.Back_menu(timer_panel_menu, metroPanel1, 35);
        }

        private void Introduction_Load(object sender, EventArgs e)
        {
            metroTile_algorithm_Click(sender, e);
<<<<<<< HEAD
            Function.Check_Job("algorithm", "compilation", "debugger", "using1");
            Function.Check_color_button(metroTile_algorithm, metroTile_compiler, metroTile_debugger, metroTile_libraries);
            
            conn.Close();
        }



        private void metroTile_algorithm_Click(object sender, EventArgs e)
        {
            i = 1;
            Function.Introduction_Show(1);

            string remove_t = Function.description_algorithm.Remove(200);
            string remove_t1 = Function.description_algorithm.Substring(200, 336);
            string remove_t2 = Function.description_algorithm.Substring(536, 59);
            string remove_t3 = Function.description_algorithm.Substring(595);

            fastColoredTextBox_theory.Text = remove_t + "\n" + "\n" + remove_t1 + "\n" + "\n" + remove_t2 + "\n" + "\n" + remove_t3;

            string algorithm_txt = "// A Hello World! program in C# \n " +
                "namespace HelloWorld \n " +
                "{ \n " +
                "   class Hello \n " +
                "   { \n " +
                "      static void Main() \n " +
                "      { \n " +
                "         Console.WriteLine(\"Hello World!\"); \n " +
                "         Console.WriteLine(\"Press any key to exit.\"); \n " +
                "         Console.ReadKey(); \n " +
                "      } \n " +
                "   } \n " +
                "}";

            fastColoredTextBox_code.Text = algorithm_txt;
            fastColoredTextBox_task.Text = Function.task;
            Label_name_traning();
            timer_button.Start();
            fastColoredTextBox_task.Text = "Задание" + "\n" + Function.task;
=======
            conn.Open();
            string query = "SELECT * FROM obychenie.passing " +
                "inner join polzovatel on polzovatel.id = passing.id " +
                "where polzovatel.login = '" + Function.login + "' ";
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();

            string algorithm = reader.GetString("algorithm");
            string compilation = reader.GetString("compilation");
            string debugger = reader.GetString("debugger");
            string using1 = reader.GetString("using");
>>>>>>> 821be088a35b7bcbb9c003e8de77408d35f20cb9


        }
<<<<<<< HEAD
=======



        private void metroTile_algorithm_Click(object sender, EventArgs e)
        {
            Function.Introduction_Show(1);

            string remove_t = Function.description_algorithm.Remove(200);
            string remove_t1 = Function.description_algorithm.Substring(200, 336);
            string remove_t2 = Function.description_algorithm.Substring(536, 59);
            string remove_t3 = Function.description_algorithm.Substring(595);

            fastColoredTextBox_theory.Text = remove_t + "\n" + "\n" + remove_t1 + "\n" + "\n" + remove_t2 + "\n" + "\n" + remove_t3;

            string algorithm_txt = "// A Hello World! program in C# \n " +
                "namespace HelloWorld \n " +
                "{ \n " +
                "   class Hello \n " +
                "   { \n " +
                "      static void Main() \n " +
                "      { \n " +
                "         Console.WriteLine(\"Hello World!\"); \n " +
                "         Console.WriteLine(\"Press any key to exit.\"); \n " +
                "         Console.ReadKey(); \n " +
                "      } \n " +
                "   } \n " +
                "}";

            fastColoredTextBox_code.Text = algorithm_txt;
            fastColoredTextBox_task.Text = Function.task;
            Label_name_traning();
            timer_button.Start();
            fastColoredTextBox_task.Text = "Задание" + "\n" + Function.task;


        }
>>>>>>> 821be088a35b7bcbb9c003e8de77408d35f20cb9
        
        private void metroTile_compiler_Click(object sender, EventArgs e)
        {
            i = 2;
            Function.Introduction_Show(2);

            string remove_txt = Function.description_algorithm.Remove(190);
            string remove_txt1 = Function.description_algorithm.Substring(190);

            fastColoredTextBox_theory.Text = remove_txt + "\n" + "\n" + remove_txt1;
            fastColoredTextBox_code.Text = " ";
            fastColoredTextBox_task.Text = "Задание" + "\n" + Function.task;
        }

        private void metroTile_debugger_Click(object sender, EventArgs e)
        {
            i = 3;
            Function.Introduction_Show(3);

            string remove_txt = Function.description_algorithm.Remove(161);
            string remove_txt1 = Function.description_algorithm.Substring(161);

            fastColoredTextBox_theory.Text = remove_txt + "\n" + "\n" + remove_txt1;

            fastColoredTextBox_code.Text = " ";
            fastColoredTextBox_task.Text = "Задание" + "\n" + Function.task;


        }

        private void metroTile_libraries_Click(object sender, EventArgs e)
        {
            i = 4;
            Function.Introduction_Show(4);

            string remove_txt = Function.description_algorithm.Remove(44);
            string remove_txt1 = Function.description_algorithm.Substring(45, 129);
            string remove_txt2 = Function.description_algorithm.Substring(174, 18);
            string remove_txt3 = Function.description_algorithm.Substring(193, 99);
            string remove_txt4 = Function.description_algorithm.Substring(291);

            fastColoredTextBox_theory.Text = remove_txt + "\n" + "\n" + remove_txt1 + "\n" + remove_txt2 + "\n" + "\n" + remove_txt3 + "\n" + remove_txt4;

            fastColoredTextBox_code.Text = "/*начало секции подключаемых пространств имен*/\n"+
                "using System; \nusing System.Collections.Generic; \nusing System.Linq; \nusing System.Text; \nusing System.Threading.Tasks; \n\n" +
                "namespace FirstApp /*объявление нового пространства имен*/\n" +
                "{\n" +
                "   class Program  /*объявление нового класса*/\n" +
                "   {\n" +
                "       static void Main(string[] args) /*объявление нового метода*/\n" +
                "       {\n\n       }\n   }\n}";
            conn.Close();
            fastColoredTextBox_task.Text = "Задание" + "\n" + Function.task;
<<<<<<< HEAD

        }
=======
>>>>>>> 821be088a35b7bcbb9c003e8de77408d35f20cb9

        private void metroButton_check_job_Click(object sender, EventArgs e)
        {
            switch (i)
            {
                case 1:
                    {
                        Function.Update_table_passing("algorithm");
                        metroTile_algorithm.BackColor = ColorTranslator.FromHtml("#47a447");
                        metroTile_algorithm_Click(sender, e);
                        i++;
                    }
                    break;
                case 2:
                    {
                        Function.Update_table_passing("algorithm");
                        metroTile_algorithm.BackColor = ColorTranslator.FromHtml("#47a447");
                        metroTile_compiler_Click(sender, e);
                        i++;
                        break;
                    }
                case 3:
                    {
                        metroTile_debugger_Click(sender, e);
                        Function.Update_table_passing("compilation");
                        metroTile_compiler.BackColor = ColorTranslator.FromHtml("#47a447");
                        i++;
                        break;
                    }
                case 4:
                    {
                        metroTile_libraries_Click(sender, e);
                        metroTile_debugger.BackColor = ColorTranslator.FromHtml("#47a447");
                        Function.Update_table_passing("debugger");
                        
                        i = 5;
                        break;
                    }
                case 5:
                    {
                        Function.Update_table_passing("using1");
                        metroTile_compiler.BackColor = ColorTranslator.FromHtml("#47a447");
                        if (MessageBox.Show("Вы прошли введение, желаете продолжить", "Поздравление",MessageBoxButtons.OKCancel,MessageBoxIcon.Asterisk) == DialogResult.OK)
                        {
                            if (!Form2.Instance.MetroPanel.Controls.ContainsKey("Training"))
                            {
                                Training profile = new Training();
                                profile.Dock = DockStyle.Fill;
                                Form2.Instance.MetroPanel.Controls.Add(profile);
                            }
                            Form2.Instance.MetroPanel.Controls["Training"].BringToFront();
                            Form2.Instance.MetroBack.Visible = true;
                        }
                        break;
                    }

            }
        }
    }
}
