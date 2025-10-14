namespace SOLID_Single_Responsibility_Principle.Helpers;

/// <summary>
/// Provides helper methods for TodoList operations.
/// </summary>
public class TodoListHelper
{
    public static string GetTodoListFilePath() => Path.Combine(AppConfigurations.GetStorageDirectory(), AppConfigurations.GetTodoListFileName());
}