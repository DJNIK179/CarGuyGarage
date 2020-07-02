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
    public partial class FormAuto : Form
    {
        public FormAuto()
        {
            InitializeComponent();
            ShowAuto();
            comboBoxColor.SelectedIndex = 0;
        }
        void ShowAuto()
        {
            listViewAuto.Items.Clear();
            foreach (Auto auto in Program.CarGuyGarage.Auto)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    auto.Id.ToString(), auto.Model, auto.Color,
                    auto.Price, auto.GNamber, auto.Date,
                });
                item.Tag = auto;
                listViewAuto.Items.Add(item);
            }
            listViewAuto.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Auto auto = new Auto();
            auto.Model = textBoxModel.Text;
            auto.Color = comboBoxColor.Text;
            auto.Price = textBoxPrice.Text;
            auto.GNamber = textBoxGNamber.Text;
            auto.Date = textBoxData.Text;
            Program.CarGuyGarage.Auto.Add(auto);
            Program.CarGuyGarage.SaveChanges();
            ShowAuto();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewAuto.SelectedItems.Count == 1)
            {
                Auto auto = listViewAuto.SelectedItems[0].Tag as Auto;
                auto.Model = textBoxModel.Text;
                auto.Color = comboBoxColor.Text;
                auto.Price = textBoxPrice.Text;
                auto.GNamber = textBoxGNamber.Text;
                auto.Date = textBoxData.Text;
                Program.CarGuyGarage.SaveChanges();
                ShowAuto();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewAuto.SelectedItems.Count == 1)
                {
                    Auto auto = listViewAuto.SelectedItems[0].Tag as Auto;
                    Program.CarGuyGarage.Auto.Remove(auto);
                    Program.CarGuyGarage.SaveChanges();
                    ShowAuto();
                }

                textBoxModel.Text = " ";
                comboBoxColor.Text = " ";
                textBoxPrice.Text = " ";
                textBoxGNamber.Text = " ";
                textBoxData.Text = " ";
            }
            catch
            {
                textBoxModel.Text = " ";
                comboBoxColor.Text = " ";
                textBoxPrice.Text = " ";
                textBoxGNamber.Text = " ";
                textBoxData.Text = " ";
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAuto.SelectedItems.Count == 1)
            {
                Auto auto = listViewAuto.SelectedItems[0].Tag as Auto;
                textBoxModel.Text = auto.Model;
                comboBoxColor.Text = auto.Color;
                textBoxPrice.Text = auto.Price;
                textBoxGNamber.Text = auto.GNamber;
                textBoxData.Text = auto.Date;
            }
            else
            {
                textBoxModel.Text = " ";
                comboBoxColor.Text = " ";
                textBoxPrice.Text = " ";
                textBoxGNamber.Text = " ";
                textBoxData.Text = " ";
            }
        }
    }
}
