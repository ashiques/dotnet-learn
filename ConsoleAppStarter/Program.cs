
using ConsoleAppStarter;
using Microsoft.Extensions.DependencyInjection;
using Npgsql;


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Adding added the other details for getting into console");



        string connectionString = "Host=localhost;Port=5432;User Id=myuser;Password=secret;Database=mydatabase";
        var connection = new NpgsqlConnection(connectionString);
        connection.Open();

        using var command = new NpgsqlCommand("SELECT * FROM employees", connection);
        using var reader = command.ExecuteReader();
        while (reader.Read())
        {
            Console.WriteLine(reader["first_name"]);
            Console.WriteLine(reader["last_name"]);
        }

        connection.Close();


        using var context = new EmployeeDbContext();
        var users = context.employees.ToList();
        foreach (var item in users)
        {
            Console.WriteLine(item.ToString());
        }
    }
}