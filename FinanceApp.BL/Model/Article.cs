using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinanceApp.BL.Model
{
    public class Article
    {
        #region Свойства
        /// <summary>
        /// Поле Id класса Article
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Поле Name класса Article
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Поле Type класса Article
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Поле PubDate класса Article
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime PubDate { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Поле Description класса Article
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Поле Price класса Article
        /// </summary>
        public double Price { get; set; }
        #endregion

        public Article() { }

        public Article(string name, string type, string description, double price)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Поле имя не может быть пустым", nameof(name));
            }

            if (string.IsNullOrWhiteSpace(type))
            {
                throw new ArgumentNullException("Поле тип не может быть пустым", nameof(type));
            }

            if (string.IsNullOrWhiteSpace(description))
            {
                throw new ArgumentNullException("Поле описание не может быть пустым", nameof(description));
            }

            if (double.IsNaN(price))
            {
                throw new ArgumentNullException("Поле сумма не может быть пустым", nameof(price));
            }


            Name = name;
            Type = type;
            Description = description;
            Price = price;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
