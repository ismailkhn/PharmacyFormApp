using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacyyyyyyyy
{
    public partial class AddMedicinePanel : Form
    {
        public AddMedicinePanel()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState= FormWindowState.Minimized;
        }

        private void AddMedicinePanel_Load(object sender, EventArgs e)
        {

        }
    }
}
