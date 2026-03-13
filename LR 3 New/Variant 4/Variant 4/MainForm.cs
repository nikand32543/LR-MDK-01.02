
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Variant_4
{
    public partial class MainForm: Form
    {
        private Dictionary<string, int> orders_ = new Dictionary<string, int>();
        private StorageMedicines medicines_ = new StorageMedicines();
        private List<Medicines> allmedicines_ = new List<Medicines>();
        
        public MainForm()
        {
            InitializeComponent();
            allmedicines_ = medicines_.Load();
            MedicinesListBox.Items.Add("От головной боли");
            MedicinesListBox.Items.Add("От кашля");
            MedicinesListBox.Items.Add("От аллергии");

            MedicinesListBox.SelectedIndex = 0;
        }

            private void MedicinesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GroupComboBox.Items.Clear();
            foreach (Medicines medicines in allmedicines_)
            {
                if (medicines.Category == MedicinesListBox.SelectedItem.ToString())
                {
                    GroupComboBox.Items.Add(medicines);
                }
            }
            GroupComboBox.DisplayMember = "Name";
            GroupComboBox.SelectedIndex = 0;
        }

        private void GroupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Medicines med = GroupComboBox.SelectedItem as Medicines;
            priceLabel.Text = med.Price + "  руб.";
            MedPictureBox.Load(med.Photo);
            DescriptionLabel.Text = med.Description;
            QuantityTextBox.Text = "0";
            ExpirationLabel.Text = med.Date;
            SuppLabel.Text = med.Supplier;
            ManufacLabel.Text = med.Manufacturer;
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            if (orders_.ContainsKey(MedicinesListBox.SelectedItem.ToString()))
            {
                orders_[MedicinesListBox.SelectedItem.ToString()] += Convert.ToInt32(QuantityTextBox.Text);
                BasketRichTextBox.Clear();
                foreach (string key in orders_.Keys)
                {
                    BasketRichTextBox.AppendText(key + " " + orders_[key] + " шт." + "\n");
                }
            }
            else
            {
                orders_.Add(MedicinesListBox.SelectedItem.ToString(), Convert.ToInt32(QuantityTextBox.Text));
                BasketRichTextBox.Clear();
                foreach (string key in orders_.Keys)
                {
                    BasketRichTextBox.AppendText(key + " " + orders_[key] + " шт." + "\n");
                }
            }
        }
    }
    
}
