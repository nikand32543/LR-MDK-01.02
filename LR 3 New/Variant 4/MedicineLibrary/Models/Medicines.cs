

using System;


namespace Variant_4
{
    public class Medicines
    {
        private string name_;
        private double price_;
        private string photo_;
        private string description_;
        private DateTime shelfLifeDate_;
        private string supplier_;
        private string manufacturer_;
        private string category_;

        public Medicines(string name, double price, string photo, string description, DateTime date, string supplier, string manufacturer, string category)
        {
            name_ = name;
            price_ = price;
            photo_ = photo;
            description_ = description;
            shelfLifeDate_ = date;
            supplier_ = supplier;
            manufacturer_ = manufacturer;
            category_ = category;
        }

        public string Name
        {
            get { return name_; }
        }

        public string Price
        {
            get { return price_.ToString(); }
        }

        public string Photo
        {
            get { return photo_; }
        }

        public string Description
        {
            get { return description_; }
        }
        public string Date
        {
            get { return shelfLifeDate_.ToString("MM.yyyy"); }
        }
        public string Supplier
        {
            get { return supplier_; } 
        }
        public string Manufacturer
        { 
            get { return manufacturer_; }
        }
        public string Category
        {
            get { return category_; }
        }
        public string GetFullInfo()
        {
            return $"Название: {name_}\n" +
                   $"Категория: {category_}\n" +
                   $"Цена: {price_:F2} руб.\n" +
                   $"Производитель: {manufacturer_}\n" +
                   $"Поставщик: {supplier_}\n" +
                   $"Срок годности: {shelfLifeDate_:MM.yyyy}\n" +
                   $"Описание: {description_}";
        }
    }
}
