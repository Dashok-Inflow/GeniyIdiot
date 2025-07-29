using System;
using System.Windows.Forms;

namespace ГенийИдиотWindowsFormsApp1
{
    public partial class WelcomeForm : Form
    {
        private Timer timer;

        public WelcomeForm(Timer timer)
        {
            InitializeComponent();
            this.timer = timer;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            timer.Start();

            Close();
        }
    }
}
