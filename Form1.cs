using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_zakupów
{
    public partial class projekt : Form
    {
        public projekt()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if(progressBar1.Value < 100)
            {
                if(textBox1.Text.Length > 0)
                {
                    if (listBox1.Items.Contains(textBox1.Text))
                    {
                        DialogResult result = MessageBox.Show("Element już istnieje! czy chcesz go dodać?", "Uwaga", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.No)
                        {
                            return;
                        }
                    }
                    listBox1.Items.Add(textBox1.Text);
                    AktualizujProgres();
                    textBox1.Text= "";
                }
                else
                {
                    MessageBox.Show("Wartość jest pusta!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lista jest już pełna", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            int zaznaczonyIndeks = listBox1.SelectedIndex;
            if(zaznaczonyIndeks != -1)
            {
               listBox1.Items.RemoveAt(zaznaczonyIndeks); //Usuwanie zaznaczonego indeksu
                AktualizujProgres();
            }
            else
            {
                MessageBox.Show("Żaden element nie został zaznaczony", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AktualizujProgres()
        {
            int iloscElementowNaLiscie = listBox1.Items.Count;
            progressBar1.Value = iloscElementowNaLiscie * 10;

        }

        private void btnCzysc_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            AktualizujProgres();
        }
    }
}
