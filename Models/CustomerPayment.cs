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
        public decimal Sum { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="id">Уникальный идентификатор в БД</param>
        /// <param name="customerId">Связь с данными таблицы Контрагент</param>
        /// <param name="paymentId">Связь с данными таблицы Платежи</param>
        /// <param name="customerName">Наименование контрагента</param>
        /// <param name="date">Дата</param>
        /// <param name="sum">Сумма</param>
        public CustomerPayment(int id, int customerId, int paymentId, string customerName, DateTime date, decimal sum)
        {
            Id = id;
            CustomerId = customerId;
            PaymentId = paymentId;
            CustomerName = customerName;
            Date = date;
            Sum = sum;
        }
    }
}
