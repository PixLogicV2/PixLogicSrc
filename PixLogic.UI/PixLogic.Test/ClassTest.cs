using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Drawing;
using PixLogic.DAL;

namespace PixLogic.Test
{
    [TestFixture]
    public class ClassTest
    {
        Database database = new Database();

        [Test]
        public void quickTest()
        {
            int result = 2;
            result += 3;
            Assert.AreEqual(5, result);
        }

        [Test]
        public void addItem()
        {
            string name = "NameItem";
            string descrip = "DescripItem";
            bool dispo = true;
            float price = 8.50f;
            Image image = null;
            string refe = "Reference";
            int quantity = 5;

            using (var ctx = new DataContext())
            {
                ctx.Database.ExecuteSqlCommand("TRUNCATE TABLE Item");
            }

            database.AddItem(name, descrip, dispo, price, image, refe, quantity);

            using (var ctx = new DataContext())
            {
                var items = from i in ctx.Items
                               select i;
                int nb = items.Count<Item>();
                var item = items.FirstOrDefault<Item>();

                Assert.AreEqual(1, nb);
                Assert.AreEqual(name, item.name);
                Assert.AreEqual(descrip, item.description);
                Assert.AreEqual(dispo, item.dispo);
                Assert.AreEqual(price, item.price);
                Assert.AreEqual(image, item.image);
                Assert.AreEqual(refe, item.reference);
                Assert.AreEqual(quantity, item.quantity);
            }

            using (var ctx = new DataContext())
            {
                ctx.Database.ExecuteSqlCommand("TRUNCATE TABLE Item");
            }
        }

        [Test]
        public void deleteItem()
        {
            string name = "NameItem";
            string descrip = "DescripItem";
            bool dispo = true;
            float price = 8.50f;
            Image image = null;
            string refe = "Reference";
            int quantity = 5;

            using (var ctx = new DataContext())
            {
                ctx.Database.ExecuteSqlCommand("TRUNCATE TABLE Item");
            }

            database.AddItem(name, descrip, dispo, price, image, refe, quantity);
            database.DeleteItem(name);
            using (var ctx = new DataContext())
            {
                var items = from i in ctx.Items
                            select i;
                int nb = items.Count<Item>();

                Assert.AreEqual(0, nb);

                ctx.Database.ExecuteSqlCommand("TRUNCATE TABLE Item");
            }
        }

        [Test]
        public void UpdateItem()
        {
            string name = "NameItem";
            string newName = "NewNameItem";
            string descrip = "DescripItem";
            bool dispo = true;
            float price = 8.50f;
            Image image = null;
            string refe = "Reference";
            int quantity = 5;

            using (var ctx = new DataContext())
            {
                ctx.Database.ExecuteSqlCommand("TRUNCATE TABLE Item");
            }

            database.AddItem(name, descrip, dispo, price, image, refe, quantity);
            database.UpdateItem(name, newName, descrip, dispo, price, image, refe, quantity);

            using (var ctx = new DataContext())
            {
                var items = from i in ctx.Items
                            select i;
                var item = items.FirstOrDefault<Item>();
                Assert.AreEqual(newName, item.name);

                ctx.Database.ExecuteSqlCommand("TRUNCATE TABLE Item");
            }
        }
    }
}
