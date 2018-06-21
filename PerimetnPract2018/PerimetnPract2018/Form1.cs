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

        private void calkBtn_Click(object sender, EventArgs e)
        {
            Point[] pts = GetPoints();
            if(pts != null)
            {
                float per = PolygonClass.CalcPerimetr(pts);
                perRes.Text = per.ToString("N2");
                for (int i = 0; i < pts.Length; i++)
                {
                    lengthTable[1, i].Value = PolygonClass.CalcLength(pts[i], pts[(i + 1) % pts.Length]).ToString("N2");
                }
            }
        }

        public Point[] GetPoints()
        {
            try
            {
                Point[] pts = new Point[(int)number.Value];
                for (int i = 0; i < (int)number.Value; i++)
                {
                    pts[i] = new Point();
                    pts[i].x = float.Parse(coordsTable[1, i].Value.ToString());
                    pts[i].y = float.Parse(coordsTable[2, i].Value.ToString());
                }
                return pts;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Error");
                return null;
            }
        }
    }
}
