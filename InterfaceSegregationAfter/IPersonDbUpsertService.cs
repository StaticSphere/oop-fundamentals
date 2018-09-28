namespace InterfaceSegregationAfter
{
    public interface IPersonDbUpsertService
    {
        int CreatePerson(Person person);
        void UpdatePerson(Person person);
    }
}
