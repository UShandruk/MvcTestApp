using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcTestApp.Models
{
    /// <summary>
    /// Контрагент
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Уникальный идентификатор в БД
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        public Customer(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
