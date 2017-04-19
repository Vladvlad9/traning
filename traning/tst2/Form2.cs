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

namespace tst2 {
    public partial class Form2 : MetroFramework.Forms.MetroForm {
        public MySqlConnection conn = new MySqlConnection(Server.connStr);
        static Form2 _instance;
        int yar, day, hour, minutes, second;

        public static Form2 Instance {
            get {
                if (_instance == null)
                    _instance = new Form2();
                return _instance;
            }
        }

        public MetroFramework.Controls.MetroPanel MetroPanel {
            get { return metroPanel3; }
            set { metroPanel3 = value; }
        }
        public MetroFramework.Controls.MetroLink MetroBack {
            get { return metroLink_Back; }
            set { metroLink_Back = value; }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            //conn.Close();
            timer_in_program.Stop();
        }

        public Form2() {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e) {
            metroLink_Back.Visible = false;
            _instance = this;
            UserControl1 uc1 = new UserControl1();
            uc1.Dock = DockStyle.Fill;
            metroPanel3.Controls.Add(uc1);

            timer_in_program.Start();


            this.StyleManager = metroStyleManager1;
            metroStyleManager1.Style = Function.stule;
            metroStyleManager1.Theme = Function.theme;
        }

        private void metroLink_Back_Click(object sender, EventArgs e) {
            metroPanel3.Controls["UserControl1"].BringToFront();
            metroLink_Back.Visible = false;
            Options o = new Options();
            


        }

        private void timer_in_program_Tick(object sender, EventArgs e)
        {
            conn.Open();
            string query = "select timeprogram.id, polzovatel.id, timeprogram.yar, timeprogram.day, timeprogram.hour, timeprogram.minutes, timeprogram.second " +
                "from polzovatel inner join timeprogram on polzovatel.id_time_in_program = timeprogram.id " +
                "where polzovatel.id = '" + Function.ID() + "'";
            MySqlCommand command = new MySqlCommand(query,conn);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                yar = reader.GetInt32("yar");
                day = reader.GetInt32("day");
                hour = reader.GetInt32("hour");
                minutes = reader.GetInt32("minutes");
                second = reader.GetInt32("second");                
            }
            conn.Close();
            Form2 f2 = new Form2();
            
            second += 1;
            if (second == 60){
                second = 0;
                minutes += 1;
            }
            if (minutes == 60){
                minutes = 0;
                hour += 1;
            }
            if (hour == 24){
                hour = 0;
                day += 1;
            }
            if (day == 365){
                day = 0;
                yar += 1;
            }

            conn.Open();
            string query_time = "update timeprogram set `yar` = '" + yar + "', `day` = '" + day + "', `hour` = '" + hour + "', " +
                "`minutes` = '" + minutes + "', `second` = '" + second + "' where timeprogram.id = '" + Function.ID() + "'";

            MySqlCommand command1 = new MySqlCommand(query_time, conn);
            command1.ExecuteNonQuery();
            conn.Close();

        }
    }
}
