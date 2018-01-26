using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using entity;

namespace tpCargaison
{
    public partial class CargaisonForm : Form
    {
        public CargaisonForm()
        {
            InitializeComponent();
        }

        private void btnAddCargaison_Click(object sender, EventArgs e)
        {
            int distance = Int32.Parse(textBoxDistance.Text);
            string type = comboBoxType.SelectedItem.ToString();

            Cargaision c=null;
            if (type.Equals("Routiere"))
            {
                c = new CargaisonRoutiere(distance);
            }
            if (type.Equals("Aerienne"))
            {
                c = new CargaisonAerienne(distance);
            }
            listBoxCargaison.Items.Add(c);
        }

        private void btnAddMarchandise_Click(object sender, EventArgs e)
        {
            Cargaision c;
            Object o = listBoxCargaison.SelectedItem;
            if (o != null)
            {
                c = (Cargaision)o;
                double poids = Double.Parse(textBoxPoids.Text);
                double volume = Double.Parse(textBoxVolume.Text);
                Marchandise m = new Marchandise(poids, volume);
                c.Add(m);
                dataGridView1.Rows.Add(m.Numero, m.Poids, m.Volume);
            }
        }

        private void listBoxCargaison_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cargaision c=null;
            Object o = listBoxCargaison.SelectedItem;
            if (o != null)
            {
                c = (Cargaision)o;
                List<Marchandise> ms = c.getMarchandises();
                dataGridView1.Rows.Clear();
                foreach (var item in ms)
                {
                    dataGridView1.Rows.Add(item.Numero, item.Poids, item.Volume);
                    textBoxCout.Text = c.Cout().ToString();
                }
            }

            }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
