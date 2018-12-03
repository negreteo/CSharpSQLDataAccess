using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace FormUI
{
  public class DataAcccess
  {
    public List<Person> GetPeople(string lastName)
    {
      using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
      {
        // Using a T-SQL statement
        //var output = connection.Query<Person>($"SELECT * FROM People WHERE LastName='{ lastName}'").ToList();
        // Using a SQL stored procedure
        var output = connection.Query<Person>("dbo.People_GetByLastName @LastName", new { LastName=lastName}).ToList();
        return output;
      }       

    }

    public void InsertPerson(string firstName, string lastName, string email, string phone)
    {
      using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
      {
        //Person person = new Person() {
        //  FirstName = firstName,
        //  LastName = lastName,
        //  EmailAddress = email,
        //  PhoneNumber = phone
        //};

        List<Person> people = new List<Person>();

        people.Add(new Person()
        {
          FirstName = firstName,
          LastName = lastName,
          EmailAddress = email,
          PhoneNumber = phone
        });

        connection.Execute("dbo.People_Insert @FirstName, @LastName, @EmailAddress, @PhoneNumber", people);
      }
    }


  }
}
