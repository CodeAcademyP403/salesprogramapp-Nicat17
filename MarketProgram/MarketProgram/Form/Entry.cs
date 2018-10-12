using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketProgram
{
    public partial class Entry : Form
    {
        public Entry()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login(this);
            Hide();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TopSellingStation topSellingStation = new TopSellingStation(this);
            Hide();
            topSellingStation.Show();
        }
    }
}
