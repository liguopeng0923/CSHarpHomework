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
    public partial class addOrderForm : Form
    {
        public OrderService orderService;
        private mainForm form;
        public int guestId;
        public string guestName;
        public string commodityName;
        public int commodityId;
        public int commodityPrice;
        public int orderId;

        public addOrderForm(OrderService orderService, mainForm form)
        {
            InitializeComponent();
            this.OrderService = orderService;
            this.Form = form;

        }
        public OrderService OrderService { get => orderService; set => orderService = value; }
        public mainForm Form { get => form; set => form = value; }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        OrderItem orderItem = new OrderItem();
        private void submitButton_Click(object sender, EventArgs e)
        {
            Create();
            bool isTheSameItem = true;
            if (!isTheSameItem)
            {
                 orderItem = new OrderItem();
            }
            Guests guests = new Guests(guestId, guestName);
            Commodity commodity = new Commodity(commodityId, commodityName, commodityPrice);
            orderItem.Guests = guests;
            orderItem.CommoditiesList.Add(commodity);
            orderItem.OrderId1 = orderId;
            for (int i = 0; i < OrderService.Orders.Count(); i++)
            {
                if (orderItem.OrderId1 == OrderService.Orders[i].OrderId1)
                {
                    MessageBox.Show("此订单号已存在，请重新输入");
                    Clear();
                    return;
                }
            }
            DialogResult Dr = MessageBox.Show("您是否仍需为此订单购买商品", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (Dr == DialogResult.OK)
            {
                isTheSameItem = true;
                Clear1();
            }
            else
            {
                isTheSameItem = false;
                this.OrderService.Add(orderItem);
                Form.orderBindingSource.DataSource = OrderService.Orders;
                Form.orderBindingSource.ResetBindings(true);
                this.Visible = false;
            }
        }
        private void Create()
        {
            int.TryParse(customerIdTextBox.Text, out guestId);
            int.TryParse(commodityPriceTextBox.Text, out commodityPrice);
            int.TryParse(commodityIdTextBox.Text, out commodityId);
            int.TryParse(orderIdTextBox.Text, out orderId);
            guestName = customerNameTextBox.Text;
            commodityName = commodityNameTextBox.Text;
           
           
        }
        private void Clear1()
        {
            commodityIdTextBox.Clear();
            commodityNameTextBox.Clear();
            commodityPriceTextBox.Clear();
            customerNameTextBox.Enabled = false;
            customerIdTextBox.Enabled = false;
            orderIdTextBox.Enabled = false;
        }
        private void Clear()
        {
            commodityIdTextBox.Clear();
            commodityNameTextBox.Clear();
            commodityPriceTextBox.Clear();
            customerNameTextBox.Clear();
            customerIdTextBox.Clear();
            orderIdTextBox.Clear();
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addOrderForm_Load(object sender, EventArgs e)
        {

        }
    }
}
