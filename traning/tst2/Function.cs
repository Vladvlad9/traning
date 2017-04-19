using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace tst2 {
    public static class Function {
        public static MySqlDataReader reader;

        public static int yar;
        public static int day;
        public static int hour;
        public static int minutes;
        public static int second;

        public static bool back = true;

        public static string login = "";
        


        public static MetroFramework.MetroColorStyle stule;
        public static MetroFramework.MetroThemeStyle theme;


        public static string description_algorithm = "";
        public static string name_traning = "";
        public static string task = "";

        public static string check_task, check_task1, check_task2, check_task3, check_task4, check_task5, check_task6, check_task7;
        public static string algorithm, compiler, debugger, using1;
        public static int structure, purpose, singleline_comments, multiline_comments;





        public static int algorithm, compiler, debugger, libraries;
        public static int structure, purpose, singleline_comments, multiline_comments;






        //Нахождение ID пользователя
        public static int ID() {
            int id = 0;
            MySqlConnection connection = new MySqlConnection(Server.connStr);
            connection.Open();
            string query = "select id from polzovatel where login = '" + Function.login + "'";
            MySqlCommand MSC = new MySqlCommand(query,connection);
            id = Convert.ToInt32(MSC.ExecuteScalar());
            connection.Close();
            return id;
        }


        //Изменение информации о пользователе
        public static void Rename_field(MetroFramework.Controls.MetroTextBox m_textbox, string name_field) {
            string query = "update polzovatel set `"+ name_field + "` = '"+ m_textbox.Text + "' where `id` = '" + Function.ID() + "'";
            MySqlConnection connection = new MySqlConnection(Server.connStr);
            connection.Open();
            if (m_textbox.Text == "") 
                MessageBox.Show("Please fill in this field", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else {
                MySqlCommand MSC = new MySqlCommand(query,connection);
                MSC.ExecuteReader();
            }
            connection.Close();
        }

        
        //Добавление нового поля с новым временем и выводом его в общий профиль
        public static int Add_time_in_program(){
            int id = 0;
            MySqlConnection connection = new MySqlConnection(Server.connStr);
            connection.Open();
            string query = "insert into timeprogram (`yar`, `day`, `hour`, `minutes`, `second`) values ('0', '0', '0', '0', '0')";
            MySqlCommand command = new MySqlCommand(query,connection);
            command.ExecuteNonQuery();
            connection.Close();

            connection.Open();
            string query_id = "select id from timeprogram order by id desc limit 1";
            MySqlCommand MSCommand = new MySqlCommand(query_id,connection);
            MySqlDataReader reader = MSCommand.ExecuteReader();

            reader.Read();
            id = reader.GetInt32("id");
            connection.Close();

            return id;
        }

        public static int Add_passing()
        {
            int id = 0;
            MySqlConnection connection = new MySqlConnection(Server.connStr);
            connection.Open();
            string querty_add_passing = "insert into passing (`algorithm`, `compilation`, `debugger`, `using1`, `structure`, `purpose`, `singleline_comments`, `multiline_comments`) VALUES ('no', 'no', 'no', 'no', 'no', 'no', 'no', 'no')";
            MySqlCommand command = new MySqlCommand(querty_add_passing, connection);
            command.ExecuteNonQuery();
            connection.Close();


            connection.Open();
            string query_id_passing = "select id from passing order by id desc limit 1";
            MySqlCommand MSCommand = new MySqlCommand(query_id_passing, connection);
            MySqlDataReader reader = MSCommand.ExecuteReader();

            reader.Read();
            id = reader.GetInt32("id");

            connection.Close();
            return id;
        }
        
        //Открытие панели
        public static void Timer_panel_menu(Timer timer, MetroFramework.Controls.MetroPanel panel, int width)
        {
            panel.Size = new Size(width, panel.Size.Height);
            if (panel.Size.Width == width)
                timer.Stop();
        }

        //Закрытие панели
        public static void Back_menu(Timer timer, MetroFramework.Controls.MetroPanel panel, int width)
        {
            if (back){
                timer.Start();
                back = false;
            }
            else{
                panel.Size = new Size(width, panel.Size.Height);
                back = true;
            }
        }



        public static void Introduction_Show(int Id){
            MySqlConnection connection = new MySqlConnection(Server.connStr);
            connection.Open();

            string query = "select * " +
                           "from traning " +
                           "inner join introduction on traning.id = introduction.id " +
                           "where traning.id = '" + Id + "'";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();

            name_traning = reader.GetString("name");
            description_algorithm = reader.GetString("description");
            task = reader.GetString("task");
            connection.Close();
        }

        public static void Input_Output_Show(int Id, string table)
        {
            MySqlConnection connection = new MySqlConnection(Server.connStr);
            connection.Open();

            string query = "select * " +
                           "from input_output " +
                           "left join traning on input_output.id = traning.id " +
                           "right join " + table + " on input_output.id = " + table + ".id " +
                           "where "+ table + ".id = '" + Id + "'";

            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();

            name_traning = reader.GetString("name");
            description_algorithm = reader.GetString("description");
            task = reader.GetString("task");

            connection.Close();
        }


        public static void Update_table_passing(string name)
        {
            MySqlConnection connection = new MySqlConnection(Server.connStr);
            connection.Open();
            string query_passing = "update passing SET " + name + " = 'yes' where id = '" + Function.ID() + "'";
            MySqlCommand command = new MySqlCommand(query_passing, connection);
            command.ExecuteNonQuery();
            connection.Close();

        }


        public static void Check_Job(string namepassing, string namepassing1, string namepassing2, string namepassing3)
        {
            MySqlConnection connection = new MySqlConnection(Server.connStr);
            connection.Open();
            string query = "select * from passing " +
                "inner join polzovatel on polzovatel.id_passing = passing.id " +
                "where polzovatel.login = '" + login + "' ";
            MySqlCommand command = new MySqlCommand(query, connection);
            reader = command.ExecuteReader();

            reader.Read();

            check_task = reader.GetString(namepassing);
            check_task1 = reader.GetString(namepassing1);
            check_task2 = reader.GetString(namepassing2);
            check_task3 = reader.GetString(namepassing3);
            connection.Close();


        }

        public static void Check_color_button(MetroFramework.Controls.MetroTile button, MetroFramework.Controls.MetroTile button1, MetroFramework.Controls.MetroTile button2, MetroFramework.Controls.MetroTile button3)
        {
            if (Function.check_task == "yes") button.BackColor = ColorTranslator.FromHtml("#47a447");
            if (Function.check_task1 == "yes") button1.BackColor = ColorTranslator.FromHtml("#47a447");
            if (Function.check_task2 == "yes") button2.BackColor = ColorTranslator.FromHtml("#47a447");
            if (Function.check_task3 == "yes") button3.BackColor = ColorTranslator.FromHtml("#47a447");
        }
    }
}
