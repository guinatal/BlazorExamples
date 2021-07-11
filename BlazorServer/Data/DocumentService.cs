using System;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer.Data
{
    public class DocumentService
    {
        public Task<Document[]> GetDocumentsAsync()
        {
            Array documentTypes = Enum.GetValues(typeof(DocumentType));
            Array currencies = Enum.GetValues(typeof(Currency));
            Random random = new();

            return Task.FromResult(Enumerable.Range(1, 50000).Select(index => new Document
            {
                Date = DateTime.Now.AddDays(index),
                Type = (DocumentType)documentTypes.GetValue(random.Next(documentTypes.Length)),
                Supplier = "Coca-Cola",
                OrderNumber = Guid.NewGuid().ToString().Substring(0, 7),
                Currency = (Currency)currencies.GetValue(random.Next(currencies.Length)),
                Net = decimal.Round(0.99M * index, 2),
                Tax = decimal.Round(23M/100M * 0.99M * index, 2),
                Gross = decimal.Round(0.99M * index + (23M/100M * 0.99M * index), 2)
            }).ToArray());
        }

        public void SubmitDocumentsAsync(Document[] documents)
        {

        }
    }
}
