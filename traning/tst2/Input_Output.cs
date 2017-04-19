using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tst2
{
    public partial class Input_Output : UserControl
    {
        public Input_Output()
        {
            InitializeComponent();
        }
        

        private void metroTile_Comments_Click(object sender, EventArgs e)
        {
            if (!Form2.Instance.MetroPanel.Controls.ContainsKey("Comments_Form"))
            {
                Comments_Form profile = new Comments_Form();
                profile.Dock = DockStyle.Fill;
                Form2.Instance.MetroPanel.Controls.Add(profile);
            }
            Form2.Instance.MetroPanel.Controls["Comments_Form"].BringToFront();
            Form2.Instance.MetroBack.Visible = true;
        }

        private void metroTile_Data_types_Click(object sender, EventArgs e)
        {
            if (!Form2.Instance.MetroPanel.Controls.ContainsKey("Data_types"))
            {
                Data_types profile = new Data_types();
                profile.Dock = DockStyle.Fill;
                Form2.Instance.MetroPanel.Controls.Add(profile);
            }
            Form2.Instance.MetroPanel.Controls["Data_types"].BringToFront();
            Form2.Instance.MetroBack.Visible = true;
        }

        private void metroTile_Arithmetic_operations_Click(object sender, EventArgs e)
        {
            if (!Form2.Instance.MetroPanel.Controls.ContainsKey("Arithmetic_operations"))
            {
                Arithmetic_operations profile = new Arithmetic_operations();
                profile.Dock = DockStyle.Fill;
                Form2.Instance.MetroPanel.Controls.Add(profile);
            }
            Form2.Instance.MetroPanel.Controls["Arithmetic_operations"].BringToFront();
            Form2.Instance.MetroBack.Visible = true;
        }

        private void metroTile_Increment_decrement_Click(object sender, EventArgs e)
        {
            if (!Form2.Instance.MetroPanel.Controls.ContainsKey("Increment_Decrement"))
            {
                Increment_Decrement profile = new Increment_Decrement();
                profile.Dock = DockStyle.Fill;
                Form2.Instance.MetroPanel.Controls.Add(profile);
            }
            Form2.Instance.MetroPanel.Controls["Increment_Decrement"].BringToFront();
            Form2.Instance.MetroBack.Visible = true;
        }
    }
}
