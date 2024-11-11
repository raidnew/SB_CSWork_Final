namespace WebAPI.Interfaces
{
    public interface IOrder
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Message { get; set; }
        int status { get; set; }
    }
}
