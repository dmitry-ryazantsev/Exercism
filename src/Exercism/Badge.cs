public static class Badge
{
    private const string _defaultDepartment = "owner";

    public static string Print(int? id, string name, string? department)
    {
        department = (department ?? _defaultDepartment).ToUpper();

        if (id != null)
        {
            return $"[{id}] - {name} - {department}";
        }
        else
        {
            return $"{name} - {department}";
        }
    }
}
