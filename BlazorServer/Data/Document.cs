using System;

namespace BlazorServer.Data
{
    public class Document
    {
        public DateTime Date { get; set; }

        public DocumentType Type { get; set; }

        public string Supplier { get; set; }

        public string OrderNumber { get; set; }

        public Currency Currency { get; set; }

        public decimal Net { get; set; }

        public decimal Tax { get; set; }

        public decimal Gross { get; set; }
    }

    public enum DocumentType
    {
        Debit,
        Credit
    }

    public enum Currency
    {
        GBP,
        EUR,
        USD
    }
}
