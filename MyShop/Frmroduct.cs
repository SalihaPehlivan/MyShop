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
    public partial class Frmroduct : BaseForm
    {
       
        public Frmroduct()
        {
            InitializeComponent();

            rep = new ProductRepository();
            RefreshGrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmProEdit frm = new FrmProEdit();
            frm.ShowDialog();

            RefreshGrid();
        }

        private void button1_Click(object sender, EventArgs e)
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

       
    }
}
