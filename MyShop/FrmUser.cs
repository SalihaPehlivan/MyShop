using Dal.DbOps;
using Dal.Entities;
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
    public partial class FrmUser : BaseForm
    {
        public FrmUser()
        {
            InitializeComponent();
            rep = new UserRepositry();
            RefreshGrid();
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Select row to delete");
                return;
            }

            DataRowView row = (DataRowView)dataGridView1.SelectedRows[0].DataBoundItem;

            UserRepositry rep = new UserRepositry();
            rep.Delete(Convert.ToInt32(row["Id"]));

            RefreshGrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UserEditForm frm = new UserEditForm();
            frm.ShowDialog();
            RefreshGrid();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Select row to Edit");
                return;
            }



            DataRowView userRow = (DataRowView)dataGridView1.SelectedRows[0].DataBoundItem;

            UserEntity user = new UserEntity();
            user.Credit = Convert.ToDecimal(userRow["Credit"]);
            user.FullName = userRow["FullName"].ToString();
            user.Id = Convert.ToInt32(userRow["Id"]);
            user.Password = userRow["Password"].ToString();
            user.UserName = userRow["UserName"].ToString();

            UserEditForm frm = new UserEditForm(user);
            frm.ShowDialog();
            RefreshGrid();
        }

        protected override void btnClose_Click(object sender, EventArgs e)
        {
            MessageBox.Show("USer Kapanıyor");
            base.btnClose_Click(sender, e);
        }

    }
}
