using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace AdoDB
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string connectionString = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter =new SqlDataAdapter();
            DataTable userTable=new DataTable("[dbo].[Users]");
            userTable.Columns.Add("userId", typeof (int));
            userTable.Columns.Add("Name", typeof (string));

            //using (var sqlConnection = new SqlConnection(connectionString))
            //{
            //    sqlConnection.Open();
            //    var sqlCommandText = "CREATE TABLE Users(userId int not null identity(1,1) primary key, name NVARCHAR(255))";
            //    var sqlCommandText1 =
            //        "Create Table UserJobs(userId int not null primary key, name NVARCHAR(255))ALTER TABLE [dbo].[UserJobs] ADD Constraint [FK_UserJobs] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ";
            //    var sqlCommand = new SqlCommand(sqlCommandText, sqlConnection);
            //    var sqlCommand1 = new SqlCommand(sqlCommandText1, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlCommand1.ExecuteNonQuery();
            //}
            SqlCommand Command = new SqlCommand("Select * from Users");
            adapter.SelectCommand = Command;
            SqlCommand command = new SqlCommand("Insert into Users(name) values(@name)", connection);
            command.Parameters.Add("@name", SqlDbType.VarChar, 255, "name");
            SqlCommand command1 = new SqlCommand("Update table Users set name ='Abdrei' where name='Vasile3333'");

            adapter.InsertCommand = command1;
            //var row = userTable.NewRow();
            //row["name"] = "Vasile333";
            //userTable.Rows.Add(row);
            adapter.Update(userTable);
            string nume = "Ssdasd";

            string insertcommand = string.Format("Insert into Users(name) values('{0}')", nume);

            connection.Open();
            adapter.InsertCommand = connection.CreateCommand();
            adapter.InsertCommand.CommandText = insertcommand;
            adapter.InsertCommand.ExecuteNonQuery();
            connection.Close();

           // string nume1 = "Vasile";
            int userId = 2;

            SqlCommand updateCommand = connection.CreateCommand();
            updateCommand.CommandText = string.Format("Update Users set name =@name where userId = {0}", userId);
            updateCommand.Parameters.Add("@name", SqlDbType.VarChar, 255, "name");
            updateCommand.Parameters["@name"].Value = "Victor";
           // var row = userTable.NewRow();
           // row["name"] = "Victor";
            adapter.UpdateCommand = updateCommand;

//            adapter.UpdateCommand = connection.CreateCommand();
//            adapter.UpdateCommand.CommandText = updatecommand;
//            string updatecommand = string.Format("Update Users set name ='{0}' where userId = {1}", nume1, userId);
            connection.Open();
//            adapter.UpdateCommand.Parameters.Add("@name", SqlDbType.VarChar, 255, "name");
          
           
            adapter.UpdateCommand.ExecuteNonQuery();
            connection.Close();

            int userId1 = 5;
            //string nameDelete = "George";
            string delete1 = string.Format("Delete from Users where userId = {0}", userId1);
            //string delete1 = string.Format("Delete from Users where name ='{0}'", nameDelete);
            connection.Open();
            adapter.DeleteCommand = connection.CreateCommand();
            adapter.DeleteCommand.CommandText = delete1;
      
            adapter.DeleteCommand.ExecuteNonQuery();
            connection.Close();

        }
    }
}
