using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1.Rows.Add("0", "Вий", "Н.В.Гоголь", "Вий", "1967", "437", "Азбука");
            Form1.Rows.Add("1", "Вий", "Н.В.Гоголь", "Вий", "1967", "437", "Азбука");
            Form1.Rows.Add("2", "Вий", "Н.В.Гоголь", "Вий", "1967", "437", "Азбука");
            Form1.Rows.Add("3", "Вий", "Н.В.Гоголь", "Вий", "1967", "437", "Азбука");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
              
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Form1.SelectedRows[0] != null)
        }
    }
}
 