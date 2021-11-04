using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System.Linq;
using ApplicationToLearnTest;

namespace MyTests
{
    class CompanyTests
    {
        [Test]
        public void CheckIfInvoiceCreate()
        {
            //Arrange
            var invoice = new Invoice(1, 20);
            //Assert
            Assert.IsTrue(invoice.Id == 1 && invoice.Number == 20);
            Assert.IsInstanceOf(typeof(Invoice), invoice);
        }

        [Test]
        public void CheckIfProductCreate()
        {
            //Arrange
            var product = new Product(1, "aparat");
            //Assert
            Assert.IsTrue(product.Id == 1 && product.Name == "aparat");
            Assert.IsInstanceOf(typeof(Product), product);
        }

        [Test]
        public void CheckIfWorkerCreate()
        {
            //Arrange
            var worker = new Worker(1, "Kowalski");
            //Assert
            Assert.IsTrue(worker.Id == 1 && worker.Name == "Kowalski");
            Assert.IsInstanceOf(typeof(Worker), worker);
        }


        [Test]
        public void CheckCompanyCreate()
        {
            //Arrange
            var invoice1 = new Invoice(1, 20);
            var invoice2 = new Invoice(2, 21);
            var invoices = new List<Invoice>();
            invoices.Add(invoice1);
            invoices.Add(invoice2);
            var product1 = new Product(1, "aparat");
            var product2 = new Product(2, "kamera");
            var produsts = new List<Product>();
            produsts.Add(product1);
            produsts.Add(product2);
            var worker1 = new Worker(1, "Kowalski");
            var worker2 = new Worker(2, "Nowak");
            var workers = new List<Worker>();
            workers.Add(worker1);
            workers.Add(worker2);
            var company = new Company(1, "Cyfrowe", workers, produsts, invoices);
            //Assert
            Assert.IsTrue(company.Id == 1 && company.Name == "Cyfrowe" && company.Workers.Any(w => w.Id == 1 && w.Name == "Kowalski") && company.Products.Any(p => p.Id == 1 && p.Name == "aparat") && company.Invoices.Any(i => i.Id == 1 && i.Number == 20));
            Assert.IsTrue(company.Id == 1 && company.Name == "Cyfrowe" && company.Workers.Any(w => w.Id == 2 && w.Name == "Nowak") && company.Products.Any(p => p.Id == 2 && p.Name == "kamera") && company.Invoices.Any(i => i.Id == 2 && i.Number == 21));
            Assert.IsInstanceOf(typeof(Company), company);
        }
    }
}
