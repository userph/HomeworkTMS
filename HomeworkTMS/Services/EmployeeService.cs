using NLog;
using NLog.LayoutRenderers;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


    public class EmployeeService
    {

    public NpgsqlConnection _connection;
    private Logger _logger = LogManager.GetCurrentClassLogger();

    public EmployeeService(NpgsqlConnection connection) 
    
    {
    
       _connection = connection;
    }

    public List<Employee> GetAllEmployees()

    {

        var employeesList = new List<Employee>();

        var cmd = new NpgsqlCommand("select * from public.employee", _connection);
        var reader = cmd.ExecuteReader();
        while (reader.Read())
        {

        var employee = new Employee()

        { 

        Id = reader.GetInt32(0),
        Name = reader.GetString(reader.GetOrdinal("name")),
        City = reader.IsDBNull(reader.GetOrdinal("city")) ? null : reader.GetString(reader.GetOrdinal("city")),
        Age = reader.IsDBNull(reader.GetOrdinal("age")) ? null : reader.GetInt32(reader.GetOrdinal("age"))



        };


        employeesList.Add(employee);
            _logger.Info(employee);

    }


        return employeesList;

    }


    }

