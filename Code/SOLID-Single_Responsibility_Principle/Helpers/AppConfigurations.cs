namespace SOLID_Single_Responsibility_Principle.Helpers;

/// <summary>
/// Provides application configuration settings and methods.
/// </summary>
public class AppConfigurations
{
    public static string GetStorageDirectory() => "Storage";

    public static string GetTodoListFileName() => "todolist-1.txt";
}