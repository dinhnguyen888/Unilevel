using System.ComponentModel.DataAnnotations;

public class RoleDTO
{
    public string Id { get; set; }
    public string Name { get; set; }
    public int GroupRoleId { get; set; }
    public string GroupRoleName { get; set; }
}

public class CreateRoleDTO
{
    [Required]
    public string Name { get; set; }
    [Required]
    public int GroupRoleId { get; set; }
}

public class UpdateRoleDTO
{
    [Required]
    public string Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public int GroupRoleId { get; set; }
}

