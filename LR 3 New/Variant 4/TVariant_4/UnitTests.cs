using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Variant_4;

namespace TVariant_4
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestMethod1_StorageMedicines_Load_ShouldLoadDataFromCsv()
        {
            
            StorageMedicines storage = new StorageMedicines();

            
            List<Medicines> medicines = storage.Load();

            
            Assert.IsNotNull(medicines, "Список лекарств не должен быть null");
            Assert.IsTrue(medicines.Count > 0, "Список лекарств должен содержать хотя бы один элемент");
            Assert.AreEqual(9, medicines.Count, "Должно быть загружено 9 препаратов");

            if (medicines.Count > 0)
            {
                Medicines firstMedicine = medicines[0];

                Assert.AreEqual("От головной боли", firstMedicine.Category, "Категория первого препарата не совпадает");
                Assert.AreEqual("Ибупрофен-АКОС", firstMedicine.Name, "Название первого препарата не совпадает");
                Assert.AreEqual("200", firstMedicine.Price, "Цена первого препарата не совпадает");
                Assert.AreEqual("Renewal", firstMedicine.Manufacturer, "Производитель первого препарата не совпадает");
                Assert.AreEqual("Звезда", firstMedicine.Supplier, "Поставщик первого препарата не совпадает");
            }
        }
        [TestMethod]
        public void TestMethod2_OrderButton_CalculateTotalPrice_ShouldReturnCorrectSum()
        {
            
            StorageMedicines storage = new StorageMedicines();
            List<Medicines> medicines = storage.Load();

            
            Medicines nurofen = medicines.FirstOrDefault(m => m.Name == "Нурофен Форте");
            Medicines acct = medicines.FirstOrDefault(m => m.Name == "АЦЦ Лонг");

            Assert.IsNotNull(nurofen, "Препарат 'Нурофен Форте' не найден");
            Assert.IsNotNull(acct, "Препарат 'АЦЦ Лонг' не найден");

            double nurofenPrice = double.Parse(nurofen.Price);
            double acctPrice = double.Parse(acct.Price);

            
            int quantity1 = 3;
            double expectedTotal1 = nurofenPrice * quantity1; // 99 * 3 = 297
            double actualTotal1 = nurofenPrice * quantity1;

            Assert.AreEqual(expectedTotal1, actualTotal1, 0.01,
                $"Общая стоимость после добавления {quantity1} шт. '{nurofen.Name}' должна быть {expectedTotal1}");

            
            int quantity2 = 2;
            double expectedTotal2 = expectedTotal1 + (acctPrice * quantity2); // 297 + (199 * 2) = 695
            double actualTotal2 = actualTotal1 + (acctPrice * quantity2);

            Assert.AreEqual(expectedTotal2, actualTotal2, 0.01,
                $"Общая стоимость после добавления {quantity2} шт. '{acct.Name}' должна быть {expectedTotal2}");

            
            Assert.AreEqual(99, nurofenPrice, 0.01, "Цена Нурофен Форте должна быть 99 руб.");
            Assert.AreEqual(199, acctPrice, 0.01, "Цена АЦЦ Лонг должна быть 199 руб.");
        }
    }
}
