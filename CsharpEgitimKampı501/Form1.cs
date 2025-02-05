using CsharpEgitimKampı501.Repositories;
using System;
using System.Windows.Forms;

namespace CsharpEgitimKampı501
{
    public partial class Form1 : Form
    {
        private readonly IProductRepository _productRepository;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {

        }
    }
}
