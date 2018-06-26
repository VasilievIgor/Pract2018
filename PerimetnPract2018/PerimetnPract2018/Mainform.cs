using System;
using System.Windows.Forms;

namespace PerimeterPract2018
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            GenerateTables();
        }
        /// <summary>
        /// Method to generate tables in datagrids
        /// </summary>
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
        /// <summary>
        /// ValueChanged event handler for numericUpDown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void number_ValueChanged(object sender, EventArgs e)
        {
            GenerateTables();
        }
        /// <summary>
        /// Button for generatin random points
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void randomBtn_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            for(int i = 0; i < (int)number.Value; i++)
            {
                coordsTable[1, i].Value = rand.Next(0, 100);
                coordsTable[2, i].Value = rand.Next(0, 100);
            }
        }
        /// <summary>
        /// Button to calculate result
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calkBtn_Click(object sender, EventArgs e)
        {
            //Get array of points
            Point[] pts = GetPoints();
            if(pts != null)
            {
                //Calc perimetr
                float per = PolygonClass.CalcPerimeter(pts);
                //Show result in textBox
                perRes.Text = per.ToString("N2");
                //Calculate lengthes of all sides
                for (int i = 0; i < pts.Length; i++)
                {
                    lengthTable[1, i].Value = PolygonClass.CalcLength(pts[i], pts[(i + 1) % pts.Length]).ToString("N2");
                }
            }
        }
        /// <summary>
        /// Method to get array of points from table
        /// </summary>
        /// <returns>Array of points</returns>
        public Point[] GetPoints()
        {
            try
            {
                Point[] pts = new Point[(int)number.Value];
                //Go through all points and parse the coordinates
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
                //If there were error
                MessageBox.Show(e.Message, "Error");
                return null;
            }
        }
    }
}
