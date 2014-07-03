.Net
====


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S2_Koniec_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            kategorieTableAdapter1.Fill(ksiazkiDataSet1.Kategorie);
            ksiazkiTableAdapter1.Fill(ksiazkiDataSet1.Ksiazki);

            //var kat = from k in ksiazkiDataSet1.Kategorie select k;
            //comboBox1.DataSource = ksiazkiDataSet1.Kategorie;


            comboBox1.Items.Add("All");
            foreach (var r in ksiazkiDataSet1.Kategorie)
            {
                comboBox1.Items.Add(r);
            }
            comboBox1.DisplayMember = "Kategoria";
        }

        private void comboBox1_Format(object sender, ListControlConvertEventArgs e)
        {
            DataRowView rv = (DataRowView)e.ListItem;
            KsiazkiDataSet.KategorieRow r = (KsiazkiDataSet.KategorieRow)rv.Row;
            e.Value = r.Kategoria;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == -1)
            {
                return;
            }
            DataView widok = ksiazkiDataSet1.Ksiazki.DefaultView;
            if(comboBox1.SelectedIndex == 0)
            {
                widok.RowFilter = "";
            }
            else
            {
                KsiazkiDataSet.KategorieRow row = comboBox1.SelectedItem as KsiazkiDataSet.KategorieRow;
                widok.RowFilter = "IDKategorii=" + row.IDKategorii;
            }
            dataGridView1.DataSource = widok;
        }
    }
}
