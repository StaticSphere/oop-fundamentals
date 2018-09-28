using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationBefore
{
    public class PersonDbService : IPersonDbService
    {
        public Person GetPersonById(int id)
        {
            // Code here would get a person from the DB by their Id.
            return new Person();
        }

        public Person GetPersonByUserName(string userName)
        {
            // Code here would get a person from the DB by their user name.
            return new Person();
        }

        public int CreatePerson(Person person)
        {
            // Code here would create a new person record in the DB,
            // and return the ID of that new record.
            return 0;
        }

        public void UpdatePerson(Person person)
        {
            // Code here would update an existing person record in the DB.
        }

        public void DeletePerson(int id)
        {
            // Code here would delete an existing person record from the DB.
        }
    }
}
