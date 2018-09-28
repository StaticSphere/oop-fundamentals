namespace InterfaceSegregationBefore
{
    public interface IPersonDbService
    {
        // This works, and the IPersonDbService interface is still following
        // the Single Responsiblity Principle, in that it's only concerned
        // with the CRUD operations for Person records.  However, the
        // IPersonDbService has 5 methods defined on it, which is arguably
        // more than it should have; while they all operate on a Person record
        // with regards to a database, they still have slightly, though very
        // much related, purposes.  But what if a class I'm writing cares
        // ONLY about reading a person record?

        Person GetPersonById(int id);
        Person GetPersonByUserName(string userName);
        int CreatePerson(Person person);
        void UpdatePerson(Person person);
        void DeletePerson(int id);
    }
}
