using Dal.DbOps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyShop
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        public BaseRepository rep;

        public void RefreshGrid()
        {
            dataGridView1.DataSource = rep.Listdt();
        }

        protected virtual void BaseButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Select row to delete");
                return;
            }

            DataRowView row = (DataRowView)dataGridView1.SelectedRows[0].DataBoundItem;

           
            rep.Delete(Convert.ToInt32(row["Id"]));

            RefreshGrid();
        }

        protected virtual void btnClose_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kapanıyor");
            Close();
        }
    }
}
