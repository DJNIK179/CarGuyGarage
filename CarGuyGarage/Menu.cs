using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarGuyGarage
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void battonFirma_Click(object sender, EventArgs e)
        {
            Form formFirma = new FormFirma();
            formFirma.Show();
        }

        private void buttonAuto_Click(object sender, EventArgs e)
        {
            Form formAuto = new FormAuto();
            formAuto.Show();
        }

        private void buttonAvailability_Click(object sender, EventArgs e)
        {
            
        }
    }
}
