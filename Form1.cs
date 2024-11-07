using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Sim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadSimData();

        }
        private void LoadSimData()
        {
            DatabaseConnection dbConn = new DatabaseConnection();
            DataTable simData = dbConn.GetSimData();
            dataGridView1.DataSource = simData;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
