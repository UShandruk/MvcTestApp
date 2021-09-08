using MvcTestApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MvcTestApp
{
    /// <summary>
    /// Класс для работы с базой данных
    /// </summary>
    public static class DAL
    {
        static string connectionString = @"Data source = (LocalDB)\MSSQLLocalDB;Initial Catalog = DbMvcTestApp; Integrated Security = True";

        /// <summary>
        /// Получить список контрагентов и платежей
        /// </summary>
        public static List<CustomerPayment> GetCustomerPayment()
        {
            List<CustomerPayment> listCustomerPayment = new List<CustomerPayment>();

            string sqlExpression = "sp_SelectCustomersPayments";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string customerName = reader.GetString(1);
                        int paymentId = reader.GetInt32(2);
                        int customerId = reader.GetInt32(3);
                        DateTime date = reader.GetDateTime(4);
                        decimal sum = reader.GetDecimal(5);
                        CustomerPayment customerPayment = new CustomerPayment(id, customerId, paymentId, customerName, date, sum);
                        listCustomerPayment.Add(customerPayment);
                    }
                }
                reader.Close();
            }

            return listCustomerPayment;
        }

        /// <summary>5490,00
        /// Платежи
        /// </summary>
        public static DbSet<Payment> Payments { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        //}
    }
}
