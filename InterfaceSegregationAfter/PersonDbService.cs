namespace InterfaceSegregationAfter
{
    // Notice that the PersonDbService class is implementing ALL 3
    // interfaces.  That's Ok.  Each interface is not required to be
    // implemented by a different class (though depending on complexity,
    // it COULD still be a good idea). The fact that the interface methods
    // are broken apart means that now, if the method I'm writing ONLY
    // needs to query Person data, I can just give an IPersonDbQueryService
    // instance, and now my code completion tools ONLY list the query-based
    // methods. This increases maintainability.

    public class PersonDbService :
        IPersonDbQueryService,
        IPersonDbUpsertService,
        IPersonDbDeleteService
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
