namespace SOLID_Interface_Segregation_Principle.Contracts;

public interface IFax
{
    void Fax(string content, IFax destination);
}