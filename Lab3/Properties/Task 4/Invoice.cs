using System;

namespace Lab3
{
    public class Invoice
    {
        public readonly int account;
        public readonly string customer;
        public readonly string provider;
        public int price = 10;

        private string article { get; set; }
        private int totalPrice;
        private int quantity { get; set; } = 20;

        public Invoice(int num, string buyer, string seller)
        {
            account = num;
            customer = buyer;
            provider = seller;

        }
        public Invoice(int num, string buyer, string seller, int pricer)
        {
            account = num;
            customer = buyer;
            provider = seller;

        }

        public void withPDV()
        {
            totalPrice = price*quantity;
            Console.WriteLine($"Тотальна вартість товару: {totalPrice}");
            totalPrice /= 100;
            totalPrice *= 80;
            Console.WriteLine($"Вартість товару після вирахунку ПДВ: {totalPrice}");
        }
        public void noPDV()
        {
            totalPrice = price * quantity;
            Console.WriteLine($"Вартість товару без урахунку ПДВ: {totalPrice}");
        }

    }
}
