namespace InterfaceSegregationAfter
{
    public interface IPersonDbQueryService
    {
        Person GetPersonById(int id);
        Person GetPersonByUserName(string userName);
    }
}
