using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerimetnPract2018
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            GenerateTables();
        }
        private void GenerateTables()
        {
            while ((int)number.Value < coordsTable.RowCount)
            {
                coordsTable.Rows.RemoveAt(coordsTable.RowCount - 1);
                lengthTable.Rows.RemoveAt(lengthTable.RowCount - 1);
            }
            while ((int)number.Value > coordsTable.RowCount)
            {
                coordsTable.Rows.Add();
                lengthTable.Rows.Add();
                coordsTable[0, coordsTable.RowCount - 1].Value = coordsTable.RowCount;
                lengthTable[0, lengthTable.RowCount - 1].Value = lengthTable.RowCount;
            }
        }
        private void number_ValueChanged(object sender, EventArgs e)
        {
            GenerateTables();
        }

        private void randomBtn_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            for(int i = 0; i < (int)number.Value; i++)
            {
                coordsTable[1, i].Value = rand.Next(0, 100);
                coordsTable[2, i].Value = rand.Next(0, 100);
            }
        }
    }
}
