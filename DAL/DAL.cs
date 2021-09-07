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
        //static string connectionString = @"Data source = (LocalDB)\MSSQLLocalDB;Initial Catalog = DbMvcTestApp; Integrated Security = True";
        static string connectionString = @"Data source = (LocalDB)\MSSQLLocalDB;Initial Catalog = DbMvcTestApp; Integrated Security = True";

        /// <summary>
        /// Получить список контрагентов
        /// </summary>
        public static List<Customer> GetCustomers()
        {
            List<Customer> listCustomer = new List<Customer>();

            string sqlExpression = "sp_SelectCustomers";

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
                        string name = reader.GetString(1);
                        Customer customer = new Customer(id, name);
                        listCustomer.Add(customer);
                    }
                }
                reader.Close();
            }

            return listCustomer;
        }

        /// <summary>
        /// Платежи
        /// </summary>
        public static DbSet<Payment> Payments { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        //}
    }
}
