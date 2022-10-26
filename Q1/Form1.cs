using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_Message
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblDate.Text = string.Empty;
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            string greeting = greet(dt);
            lblDate.Text = greeting + "," + dt.ToString("yyyy/MM/dd");

            MessageBox.Show(dt.ToString());
        }

        private string greet(DateTime dt)
        {
            string msg = string.Empty;
            int hour = dt.Hour;
            if (hour < 12)
            {
                msg = "早安";
            }
            else if (hour >= 12 && hour < 18)
            {
                msg = "午安";
            }
            else
            {
                msg = "晚安";
            }
            return msg;
        }
    }
}
