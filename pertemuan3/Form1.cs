using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pertemuan3
{
    public partial class Form1 : Form
    {
        // Ganti "SERVER" sesuai dengan SQL Server Anda
        private string connectionString = "Data Source=LAPTOP-SOF8NSPF\\FIRYAL;Initial Catalog=OrganisasiMahasiswa;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
