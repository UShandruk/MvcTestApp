using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcTestApp.Models
{
    public class CustomerPayment
    {
        /// <summary>
        /// Уникальный идентификатор в БД
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Связь с данными таблицы Контрагент
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// Связь с данными таблицы Платежи
        /// </summary>
        public int PaymentId { get; set; }

        /// <summary>
        /// Наименование контрагента
        /// </summary>
        public string CustomerName { get; set; }

        /// <summary>
        /// Дата пплатежа
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Сумма платежа
        /// </summary>
        public double Sum { get; set; }
    }
}
