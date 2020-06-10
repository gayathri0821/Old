using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject1
{
    public partial class MinuteBook : Form
    {
        public MinuteBook()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string topicname = txtTopicname.Text;
            string details = txtDetails.Text;
            string datetime = dateTime.Text;
            MessageBox.Show("Saved Successfully....");
            txtTopicname.Clear();
            txtDetails.Clear();
            
        }

        private void btnshowentrys_Click(object sender, EventArgs e)
        {
            MinuteBookEntrys mi = new MinuteBookEntrys();
            mi.Show();
            this.Hide();
        }
    }
}
