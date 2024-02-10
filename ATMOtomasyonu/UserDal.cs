using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMOtomasyonu
{
    internal class UserDal
    {
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;initial catalog=BankUsers; integrated security = true");

        public List<BankUser> GetAll()
        {

            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from USERS", _connection);
            SqlDataReader reader = command.ExecuteReader();
            List<BankUser> bankUsers = new List<BankUser>();
            while (reader.Read())
            {
               BankUser user = new BankUser 
               { 
                    Id = (int)reader["Id"],
                    UserName = (string)reader["UserName"],
                    Balance = (decimal)reader["Balance"],
                    Password = (string)reader["Password"],
                    IsPersonel =Convert.ToBoolean(reader["IsPersonel"]) ,
                   Iban = (string)reader["Iban"]

               };
               bankUsers.Add(user);
            }
            reader.Close();
            _connection.Close();
            return bankUsers;
        }
        public BankUser GetBankUsersFromName(string name)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from Users", _connection);
            SqlDataReader reader = command.ExecuteReader();
            List<BankUser> bankUsers = new List<BankUser>();
            while (reader.Read())
            {
                BankUser user = new BankUser
                {
                    Id = (int)reader["Id"],
                    UserName = (string)reader["UserName"],
                    Balance = (decimal)reader["Balance"],
                    Password = (string)reader["Password"]

                };
                bankUsers.Add(user);
            }
            reader.Close();
            _connection.Close();
            foreach (BankUser bankUser in bankUsers)
            {
                if (bankUser.UserName == name)
                {
                    return bankUser;
                }
            }
            return null;
            
        }
        public void Add(BankUser bankUser)
        {
            ConnectionControl();
            string userName = bankUser.UserName;
            string password = bankUser.Password;
            
            SqlCommand command = new SqlCommand($"INSERT INTO Users (username,balance,password,IsPersonel,Iban) VALUES ('{userName}',@balance,'{password}',@isPersonel,@iban)", _connection);
            command.Parameters.AddWithValue("@balance",bankUser.Balance);
            command.Parameters.AddWithValue("@isPersonel", bankUser.IsPersonel);
            command.Parameters.AddWithValue("@iban", bankUser.Iban);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void Update(BankUser bankUser)
        {
            ConnectionControl();
            string userName = bankUser.UserName;
            string password = bankUser.Password;
            int id = bankUser.Id;
            SqlCommand command = new SqlCommand(
                $"update Users set username = '{userName}',balance = @balance, password = '{password}', IsPersonel = @isPersonel, Iban = @iban where id = {id}", _connection);
            command.Parameters.AddWithValue("@balance",bankUser.Balance);
            command.Parameters.AddWithValue("@isPersonel", bankUser.IsPersonel);
            command.Parameters.AddWithValue("@iban", bankUser.Iban);
            command.ExecuteNonQuery();
            _connection.Close();

        }
        public void UpdatePassword(BankUser bankUser, string newPassword)
        {
            ConnectionControl();
            string password = newPassword;
            int id = bankUser.Id;
            SqlCommand command = new SqlCommand(
                $"update Users set  password = '{password}' where id = {id}", _connection);
            command.ExecuteNonQuery();
            _connection.Close();

        }
        public void UpdateBalance(BankUser bankUser,decimal balanceDiffrence)
        {
            ConnectionControl();
            int id = bankUser.Id;
            SqlCommand command = new SqlCommand(
                $"update Users set balance = @balance where id = {id}", _connection);
            command.Parameters.AddWithValue("@balance", bankUser.Balance+balanceDiffrence);
            command.ExecuteNonQuery();
            _connection.Close();

        }
        public void Delete(BankUser bankUser)
        {
            ConnectionControl();
            int id = bankUser.Id;
            SqlCommand command = new SqlCommand($"Delete from Users where id ={id}",_connection);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
    }
}
