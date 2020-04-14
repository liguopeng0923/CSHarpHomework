using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApp1;
namespace WindowsFormsApp2
{
    public partial class mainForm : Form
    {
        public  OrderService orderService = new OrderService();

        public mainForm()
        {
            InitializeComponent();
            
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            addOrderForm addOrder = new addOrderForm(orderService,this);
            addOrder.Visible = true;
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void orderDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void orderItemDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void selectResultButton_Click(object sender, EventArgs e)
        {
            int m;

            switch (this.selectComboBox.Text) {
                case "订单号":
                    int.TryParse(selectTextBox.Text, out m);
                    orderBindingSource.DataSource = orderService.SelectByOrderId(m);
                    break;
                case "商品名": orderBindingSource.DataSource = orderService.SelectByCommodityName(selectTextBox.Text); break;
                case "顾客名": orderBindingSource.DataSource = orderService.SelectByGuestName(selectTextBox.Text);break;
                case "总价": orderBindingSource.DataSource = orderService.Sort();break;
                default:
                    orderBindingSource.DataSource = orderService.Sort();break;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void alterButton_Click(object sender, EventArgs e)
        {
            OrderItem orderItem = orderBindingSource.Current as OrderItem;
            orderService.Alter(orderItem);
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            orderService.Export();
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            
            orderBindingSource.DataSource= orderService.import();
        }
    }
}
