using System;
using System.Windows.Forms;

namespace Graph.ErrorBox
{
    public partial class ErrorBox : Form
    {
        public ErrorBox()
        {
            InitializeComponent();
        }

        public string Data
        {
            get { return Message.Text; }
            set { Message.Text = value; }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
