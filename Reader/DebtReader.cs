using System;
using System.IO;
using System.Windows.Forms;

namespace Reader
{
    // A class describing credit data import from .txt file and it's implementation.
    public partial class DebtReader : Form
    {
        string sSelectedFile;

        public DebtReader()
        {
            InitializeComponent();
        }
        private void DebtReader_Load(object sender, EventArgs e)
        {
           
        }
        // Button implementation of input for file directory
        private void Button1_Click(object sender, EventArgs e)
        {
            DebtReader reader = new DebtReader();
            Form2 f2 = new Form2
            {
                lines = reader.Read()
            };
            f2.Form2_Load();
        }
        // Functionality for the proces of .txt file reading. (.txt --> string[])
        private string[] Read()
        {
            OpenFileDialog choofdlog = new OpenFileDialog
            {
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 1,
                Multiselect = true
            };

            if (choofdlog.ShowDialog() == DialogResult.OK)
                sSelectedFile = choofdlog.FileName;
            else
                sSelectedFile = string.Empty;

            string[] lines = File.ReadAllLines(@"" + sSelectedFile);

            return lines;
        }
        // Credit deadline validation.
        public bool Overdue(string payday)
        {
            return DateTime.Parse(payday) - DateTime.Now.Date > TimeSpan.FromDays(0);
        }
    }
}
