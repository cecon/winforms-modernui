using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TestingGround
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();

            DataTable dt = new DataTable();
            dt.Columns.Add("checked", typeof( bool));
            dt.Columns.Add("List");
            dt.Rows.Add(new object[] { false, "list 1" });
            dt.Rows.Add(new object[] { false, "list 2" });
            dt.Rows.Add(new object[] { false, "list 3" });
            dt.Rows.Add(new object[] { false, "list 4" });

            metroGrid1.DataSource = dt;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Owner = this;
            f.Show();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void metroGrid1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (((DataTable)metroGrid1.DataSource).Columns[0].ColumnName == "checked" && e.ColumnIndex == 0)
                ((DataTable)metroGrid1.DataSource).Rows[e.RowIndex]["checked"] = !(bool)((DataTable)metroGrid1.DataSource).Rows[e.RowIndex]["checked"];
        }
    }
}
