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
    public partial class FormFirma : Form
    {
        public FormFirma()
        {
            InitializeComponent();
            ShowFirma();
        }

        void ShowFirma()
        {
            listViewFirma.Items.Clear();
            foreach (Firma firma in Program.CarGuyGarage.Firma)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    firma.Id.ToString(), firma.Name, firma.Adress,
                    firma.Phone, firma.Email,
                });
                item.Tag = firma;
                listViewFirma.Items.Add(item);
            }
            listViewFirma.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Firma firma = new Firma();
            firma.Name = textBoxName.Text;
            firma.Adress = textBoxAdress.Text;
            firma.Phone = textBoxPhone.Text;
            firma.Email = textBoxEmail.Text;
            Program.CarGuyGarage.Firma.Add(firma);
            Program.CarGuyGarage.SaveChanges();
            ShowFirma();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewFirma.SelectedItems.Count == 1)
            {
                Firma firma = listViewFirma.SelectedItems[0].Tag as Firma;
                firma.Name = textBoxName.Text;
                firma.Adress = textBoxAdress.Text;
                firma.Phone = textBoxPhone.Text;
                firma.Email = textBoxEmail.Text;
                Program.CarGuyGarage.SaveChanges();
                ShowFirma();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewFirma.SelectedItems.Count == 1)
                {
                    Firma firma = listViewFirma.SelectedItems[0].Tag as Firma;
                    Program.CarGuyGarage.Firma.Remove(firma);
                    Program.CarGuyGarage.SaveChanges();
                    ShowFirma();
                }

                textBoxName.Text = " ";
                textBoxAdress.Text = " ";
                textBoxPhone.Text = " ";
                textBoxEmail.Text = " ";
            }
            catch
            {
                textBoxName.Text = " ";
                textBoxAdress.Text = " ";
                textBoxPhone.Text = " ";
                textBoxEmail.Text = " ";
            }
        }

        private void listViewFirma_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewFirma.SelectedItems.Count == 1)
            {
                Firma firma = listViewFirma.SelectedItems[0].Tag as Firma;
                textBoxName.Text = firma.Name;
                textBoxAdress.Text = firma.Adress;
                textBoxPhone.Text = firma.Phone;
                textBoxEmail.Text = firma.Email;
            }
            else
            {
                textBoxName.Text = " ";
                textBoxAdress.Text = " ";
                textBoxPhone.Text = " ";
                textBoxEmail.Text = " ";
            }
        }
    }
}
