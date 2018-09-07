using EstudosWebMvc.Models.Enums;
using System;

namespace EstudosWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public  DateTime DataSales { get; set; }
        public double Amount { get; set; }
        public SalesStatus Status { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime dataSales, double amount, SalesStatus status, Seller seller)
        {
            Id = id;
            DataSales = dataSales;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
