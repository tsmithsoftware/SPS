namespace ADOv2.Interfaces
{
    /**the second constraint forces our entities to implement IEntity – 
    an abstraction created for the application. 
        The IEntity interface forces entities to have a readable Id property, 
        and we can then use this property in the FindById method. IEntity is defined with the following code.**/
    public interface IEntity
    {
        int Id { get; }
    }
}