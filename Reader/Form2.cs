using System;
using System.Windows.Forms;

namespace Reader
{
    // A Windows Form class for table presentation of credit data.
    public partial class Form2 : Form
    {
        public string[] lines = null;

        public Form2()
        {
            InitializeComponent();
        }
        // A method used to load the form using the transformed data provided by 'DebtReader'
        public void Form2_Load()
        {
            Form2 form2 = new Form2();
            DebtReader reader = new DebtReader();

            foreach (string line in lines)
            {
                string[] string_in_line = line.Split('|');
                Array.Resize(ref string_in_line, string_in_line.Length + 1);
                string_in_line[string_in_line.Length - 1] = reader.Overdue(string_in_line[2]).ToString();
                form2.dataGridView1.Rows.Add(string_in_line);
            }

            form2.ShowDialog();
            this.Close();

        }
    }
}
