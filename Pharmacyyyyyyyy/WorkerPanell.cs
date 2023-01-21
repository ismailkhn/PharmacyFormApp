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
    public partial class WorkerPanell : Form
    {
        public WorkerPanell()
        {
            InitializeComponent();
        }

        private void medicineToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMedicinePanel adp= new AddMedicinePanel();
            adp.ShowDialog();
        }
    }
}
