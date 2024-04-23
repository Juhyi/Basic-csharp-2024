using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace schoolGradesManagementApp
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.TopMost = true;
            frm.ShowDialog();
        }
    }
}
