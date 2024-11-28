public class AssignPermissionDTO
{
    public string RoleId { get; set; }
    public List<int> PermissionIds { get; set; }
}

public class PermissionDTO
{
    public int PermissionId { get; set; }
    public string PermissionName { get; set; }
}
