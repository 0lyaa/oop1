using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3._3
{
    internal class Invoice
    //Створити клас Invoice.
    //У тілі класу створити три поля int account, string customer, string provider,
    //які мають бути проініціалізовані один раз(при створенні екземпляра даного класу)
    //без можливості їхньої подальшої зміни.
    //У тілі класу створити два закриті поля string article, int quantity
    //Створити метод розрахунку вартості замовлення з ПДВ та без ПДВ.
    //Написати програму, яка виводить на екран суму оплати замовленого товару із ПДВ або без ПДВ.
    {
        private string article;
        private int quantity;
        int account;
        string customer;
        string provider;

        public Invoice(string article, int quantity, int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
            this.article = article;
            this.quantity = quantity;
        }

        public double WithPDV()
        {
            double pdv = 0.05;

            return (account * pdv) + account;
        }

        public int WithoutPDV()
        {
            return account;
        }

    }

}
