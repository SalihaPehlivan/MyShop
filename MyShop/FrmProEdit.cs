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
    public partial class FrmProEdit : Form
    {
        public FrmProEdit()
        {
            InitializeComponent();

            List<CategoryEntity> catList = new List<CategoryEntity>();

            CategoryRepository rep = new CategoryRepository();

            catList = rep.List();

            comboBoxCat.DataSource = catList;

            comboBoxCat.DisplayMember = "Name";
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductEntity p = new ProductEntity();
            p.Name = txtName.Text;
            p.Price = Convert.ToDecimal(txtPrice.Text);
            p.ProductCode = txtpC.Text;
            p.Stock = Convert.ToInt32(txtStock.Text);

            CategoryEntity selectedCat = (CategoryEntity)comboBoxCat.SelectedItem;

            p.CategoryId = selectedCat.Id;

            ProductRepository rep = new ProductRepository();

            rep.Insert(p);
            this.Close();
        }
    }
}
