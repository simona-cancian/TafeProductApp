using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApps
{
    class Product
    {
        const int deliveryCharge = 25;
        const int wrapCharge = 5;

        private decimal price;
        private int quantity;
        private decimal totalPayment;
        private decimal delivery;
        private decimal wrapping;
        private decimal gst;

        private decimal afterDeliveryCharge;
        private decimal afterWrappingCharge;

        private decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        private int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public decimal TotalPayment
        {
            get { return totalPayment; }
            set { totalPayment = value; }
        }


        private decimal Delivery
        {
            get { return delivery; }
            set { delivery = value; }
        }


        private decimal Wrapping
        {
            get { return wrapping; }
            set { wrapping = value; }
        }

        private decimal GST
        {
            get { return gst; }
            set { gst = value; }
        }

        public decimal AfterDeliveryCharge
        {
            get { return afterDeliveryCharge; }
            set { afterDeliveryCharge = value; }
        }

        public decimal AfterWrappingCharge
        {
            get { return afterWrappingCharge; }
            set { afterWrappingCharge = value; }
        }


        //Constructor for Product
        public Product(decimal price, int quantity)
        {
            Price = price;
            Quantity = quantity;
        }

        //Calculate the total payment
        public void calTotalPayment()
        {
            TotalPayment = Price * Quantity;
            AfterDeliveryCharge = (Price * Quantity) + deliveryCharge;
            AfterWrappingCharge = afterDeliveryCharge + wrapCharge;
        }
    }
}
