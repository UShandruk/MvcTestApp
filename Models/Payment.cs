using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcTestApp.Models
{
    /// <summary>
    /// Платеж
    /// </summary>
    public class Payment
    {
        /// <summary>
        /// Уникальный идентификатор в БД
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Связь с данными таблицы Контрагент
        /// </summary>
        public int CustomerId { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd'/'MM'/'yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Дата")]
        public DateTime Date { get; set; }

        [Display(Name = "Сумма")]
        public decimal Sum { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="id"></param>
        /// <param name="customerId"></param>
        /// <param name="date">Дата</param>
        /// <param name="sum">Сумма</param>
        public Payment(int id, int customerId, DateTime date, decimal sum)
        {
            Id = id;
            CustomerId = customerId;
            Date = date;
            Sum = sum;
        }
    }
}
