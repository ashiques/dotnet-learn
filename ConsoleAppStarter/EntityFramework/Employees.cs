using System.ComponentModel.DataAnnotations;

namespace ConsoleAppStarter;

public class Employees
{
    [Key]
    public int employee_id { get; set; }
    public string first_name { get; set; }
    public string last_name { get; set; }
    public override string ToString() => $"[Employee <{first_name} {last_name}>]";
}
