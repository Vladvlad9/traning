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
    public partial class Chapter_one : UserControl
    {
        public MySqlConnection conn = new MySqlConnection(Server.connStr);
        

        public void CreateLabel(int top, string text)
        {
            MetroFramework.Controls.MetroLabel label = new MetroFramework.Controls.MetroLabel();
            this.Controls.Add(label);
            label.Top = top;
            label.Left = 75;
            label.Text = text;
            label.Anchor = AnchorStyles.None;
            label.BringToFront();
            label.AutoSize = false;
            label.Size = new Size(1200, 50);
            label.WrapToLine = true;
            
        }

        private void Chapter_one_Load(object sender, EventArgs e)
        {
            
        }

        public Chapter_one()
        {
            InitializeComponent();
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.CSharp;

            conn.Open();
            string query = "SELECT * FROM chapter_one inner join code_date_type on chapter_one.id_code_date_type = code_date_type.id";
            MySqlCommand command = new MySqlCommand(query,conn);
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            metroLabel1.Text = reader.GetString("name");
            string description = reader.GetString("description");
            string description1 = reader.GetString("description1");
            string description2 = reader.GetString("description2");
            string description3 = reader.GetString("code");
            string code_description2 = reader.GetString("code_description2");
            string description4 = reader.GetString("code_description3");
            string description5 = reader.GetString("code_description4");
            string description6 = reader.GetString("code_description5");
            string description7 = reader.GetString("code_description6");

            CreateLabel(50, description + " \n " + description1);//Label1
            CreateLabel(100, description2);//Label2

            conn.Close();


            conn.Open();
            string query_table = "select type as Тип, oblast as Область, size as Размер from type";
            MySqlDataAdapter DA = new MySqlDataAdapter();
            DA.SelectCommand = new MySqlCommand(query_table, conn);

            DataTable table = new DataTable();
            DA.Fill(table);

            BindingSource BS = new BindingSource();
            BS.DataSource = table;
            metroGrid1.DataSource = BS;
            conn.Close();

            
            

            CreateLabel(1115, "Для того, чтобы использовать переменную, ее сначала нужно объявить:");//Label3
            //metroTextBox1.Lines = new string[] {description3, "{" , description4, description5, description6, description7, "}" };
            fastColoredTextBox1.Text = description3 + "\n{" + "\n" + description4 + "\n" + description5 + "\n" + description6 + "\n" + description7 +"\n}";





            conn.Open();
            string query1 = "SELECT * FROM chapter_one inner join code_date_type on chapter_one.id_code_date_type = code_date_type.id where chapter_one.id = 2";
            MySqlCommand command1 = new MySqlCommand(query1, conn);
            MySqlDataReader reader1 = command1.ExecuteReader();
            reader1.Read();

            string description_0 = reader1.GetString("description");
            string description_1 = reader1.GetString("code");
            string description_2 = reader1.GetString("code_description1");
            string description_3 = reader1.GetString("code_description2");

            CreateLabel(1300, description_0);//Label 4
            metroTextBox2.Lines = new string[] { description_1, "{", description_2, description_3, "}" };
            conn.Close();
        }

        
    }
}
