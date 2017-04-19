using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading;
using tst2.Properties;

namespace tst2 {
    public partial class Form1 : MetroFramework.Forms.MetroForm {

        public MySqlConnection conn = new MySqlConnection(Server.connStr);
        int speed = 30;

        public Form1() {
            InitializeComponent();
            
        }

        private void timer_login_Tick(object sender, EventArgs e) {
            groupBox_Login.Size = new Size(groupBox_Login.Width + speed, groupBox_Login.Height);

            if (groupBox_Login.Width >= 270) 
                timer_login.Stop();
        }//Timet_Login

        private void timer_new_user_Tick(object sender, EventArgs e) {
            groupBox_new_user.Size = new Size(groupBox_new_user.Width + speed, groupBox_new_user.Height);

            if (groupBox_new_user.Width >= 270) 
                timer_new_user.Stop();
            
        }//Timer_new_User

        private void metroButton_login_Click(object sender, EventArgs e) {
            metroButton_new_user.Enabled = true;
            metroButton_login.Enabled = false;
            groupBox_new_user.Size = new Size(0, groupBox_new_user.Height);
            timer_login.Start();
        }//Button login(GrouBox)

        private void metroButton_new_user_Click(object sender, EventArgs e) {
            metroButton_new_user.Enabled = false;
            metroButton_login.Enabled = true;
            groupBox_Login.Size = new Size(0, groupBox_Login.Height);
            timer_new_user.Start();
        }//Button New User(GroupBox)

       

        //Создание нового пользователя
        private void metroButton_new_user_login_Click(object sender, EventArgs e) {
            string date_of_registration = DateTime.Now.ToString("dd MMMM yyyy | HH:mm:ss");//Формат записи даты в БД

            if (metroTextBox_new_user_login.Text == "" || metroTextBox_new_user_password.Text == "") {
                MessageBox.Show("One field is not filled", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                conn.Open();

                int new_us = 0;
                string query = "select count(*) from polzovatel where login = '" + metroTextBox_new_user_login.Text + "'";
                MySqlCommand msc = new MySqlCommand(query, conn);

                new_us = Convert.ToInt32(msc.ExecuteScalar());
                if (new_us > 0)
                    MessageBox.Show("User exist");

                else {
                    string query_new_user = "insert into polzovatel (`login`, `password`, `lastname`, `firstname`, `city`, `age`, `birthday`," +
                        "`date_registration`, `id_time_in_program`,`id_passing`) values ('" + metroTextBox_new_user_login.Text + "','" + metroTextBox_new_user_password.Text + "'," +
                        "'null', 'null', 'null', 'null', '01.01.1900', '" + date_of_registration + "', '" + Function.Add_time_in_program() + "','" + Function.Add_passing() + "')";

                    MySqlCommand MSCom = new MySqlCommand(query_new_user, conn);
                    MSCom.ExecuteNonQuery();
                    conn.Close();
                    

                }
            }
        }//Create new user


        //Ввод логиа и пароля
        private void metroButton_show_login_Click(object sender, EventArgs e) {
            
            int count = 0;
            Function.login = metroTextBox_Login.Text;
            conn.Open();
            string query = "select * from polzovatel where login ='" + metroTextBox_Login.Text + "' and password = '" + metroTextBox_Password.Text + "'";
            MySqlCommand MSC = new MySqlCommand(query, conn);
            MySqlDataReader reader = MSC.ExecuteReader();

            while (reader.Read())
                count =+ 1;

            if (count == 1) {
                Form2 f2 = new Form2()
                {
                    Owner = this
                };
                f2.Show();
            }
            else 
                MessageBox.Show("Username or password note correct");
            
            conn.Close();

            //Запоминание стоит галочка
            if (metroCheckBox_remember.Checked) {
                Settings.Default["CheckBox_remember"] = metroCheckBox_remember.Checked = true;
                Settings.Default.Save();
            }
            else {
                Settings.Default["CheckBox_remember"] = metroCheckBox_remember.Checked = false;
                Settings.Default.Save();
            }

            //Запоминание логина и пароля
            Settings.Default["Login_save"] = metroTextBox_Login.Text;
            Settings.Default["Password_save"] = metroTextBox_Password.Text;
            Settings.Default.Save();

        }// Login User

        private void Form1_Load(object sender, EventArgs e) {
            
            //Проверка, если стоит галочка, что бы открыть форму без логина и пароля
            if (Convert.ToBoolean(Settings.Default["CheckBox_remember"]) == true) {
                metroTextBox_Login.Text = Settings.Default["Login_save"].ToString();
                metroTextBox_Password.Text = Settings.Default["Password_save"].ToString();
                metroButton_show_login_Click(sender, e);
                
            }
        }
    }
    
}
