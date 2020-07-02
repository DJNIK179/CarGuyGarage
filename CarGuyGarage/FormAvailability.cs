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
    public partial class FormAvailability : Form
    {
        public FormAvailability()
        {
            InitializeComponent();
            ShowFirma();
            ShowAuto();
            ShowAvailability();
        }

        void ShowFirma()
        {
            comboBoxFirma.Items.Clear();
            foreach (Firma firma in Program.CarGuyGarage.Firma)
            {
                string[] item = { firma.Id + ". " + firma.Name };
                comboBoxFirma.Items.Add(string.Join(" ", item));
            }
        }

        void ShowAuto()
        {
            comboBoxAuto.Items.Clear();
            foreach (Auto auto in Program.CarGuyGarage.Auto)
            {
                string[] item = { auto.Id + ". " + auto.Model + " " + auto.Price + " " + auto.Date };
                comboBoxAuto.Items.Add(string.Join(" ", item));
            }
        }

        void ShowAvailability()
        {
            listViewAvailability.Items.Clear();
            foreach (Availability availability in Program.CarGuyGarage.Availability)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    availability.Id.ToString(), 
                    availability.IdFirma.ToString(), availability.Firma.Name, 
                    availability.IdAuto.ToString(), availability.Auto.Model,
                    availability.Availability1,
                });
            }
        }
        private void comboBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxFirma.SelectedItem != null 
                && comboBoxAuto.SelectedItem != null
                && comboBoxType.SelectedItem != null)
            {
                Availability availability = new Availability();
                availability.IdFirma = Convert.ToInt32(comboBoxFirma.SelectedItem.ToString().Split('.')[0]);
                availability.IdAuto = Convert.ToInt32(comboBoxAuto.SelectedItem.ToString().Split('.')[0]);
                availability.Availability1 = comboBoxType.Text.ToString();
                Program.CarGuyGarage.Availability.Add(availability);
                Program.CarGuyGarage.SaveChanges();
                ShowAvailability();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewAvailability.SelectedItems.Count == 1)
            {
                Availability availability = listViewAvailability.SelectedItems[0].Tag as Availability;
                availability.IdFirma = Convert.ToInt32(comboBoxFirma.SelectedItem.ToString().Split('.')[0]);
                availability.IdAuto = Convert.ToInt32(comboBoxAuto.SelectedItem.ToString().Split('.')[0]);
                availability.Availability1 = comboBoxType.Text.ToString();
                Program.CarGuyGarage.SaveChanges();
                ShowAvailability();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewAvailability.SelectedItems.Count == 1)
                {
                    Availability availability = listViewAvailability.SelectedItems[0].Tag as Availability;
                    Program.CarGuyGarage.Availability.Remove(availability);
                    Program.CarGuyGarage.SaveChanges();
                    ShowAvailability();
                }
                comboBoxFirma.SelectedItem = null;
                comboBoxAuto.SelectedItem = null;
                comboBoxType.SelectedItem = null;
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эту запись используется!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewAuto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAvailability.SelectedItems.Count == 1)
            {
                Availability availability = listViewAvailability.SelectedItems[0].Tag as Availability;
                comboBoxFirma.SelectedIndex = comboBoxFirma.FindString(availability.IdFirma.ToString());
                comboBoxAuto.SelectedIndex = comboBoxAuto.FindString(availability.IdAuto.ToString());
                comboBoxType.SelectedIndex = comboBoxType.FindString(availability.Availability1.ToString());
            }
            else
            {
                comboBoxFirma.SelectedItem = null;
                comboBoxAuto.SelectedItem = null;
                comboBoxType.SelectedItem = null;
            }
        }
    }
}
