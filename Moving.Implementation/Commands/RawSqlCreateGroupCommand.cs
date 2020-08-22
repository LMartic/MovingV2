using Microsoft.EntityFrameworkCore.Internal;
using Moving.Application.Commands;
using Moving.Application.Commands;
using Moving.Application.DataTransfer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Moving.Implementation.Commands
{
    public class RawSqlCreateCustomerCommand : ICreateCustomerCommand
    {
        private readonly IDbConnection dbConnection;

        public RawSqlCreateCustomerCommand(IDbConnection dbConnection)
        {
            this.dbConnection = dbConnection;
        }

        public int Id => 2;

        public string Name => "Create customer using raw SQL";

        public void Execute(CustomerDto request)
        {
            var query = "INSERT INTO Customers (FirstName,LastName,Email,CreatedDate,Phone) VALUES('" + request.FirstName + "','" + request.LastName + "','" + request.Email + "',GETDATE(),'" + request.Phone + "')";
            var command = dbConnection.CreateCommand();
            command.CommandText = query;
            command.ExecuteNonQuery();
        }
    }
}
