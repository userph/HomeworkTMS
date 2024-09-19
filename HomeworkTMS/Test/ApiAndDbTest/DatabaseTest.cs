using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class DatabaseTest
    {

    private DbConnector _connector;
    private EmployeeService _employeeService;

    [OneTimeSetUp]

    public void ConnectToDatabase()

    { 
        _connector = new DbConnector();
        _employeeService = new EmployeeService(_connector.Connection);
    }


    [Test]

    public void GetAllData()  
    { 
    
        Assert.That(_employeeService.GetAllEmployees().Count(), Is.EqualTo(7));
    
    }

    [OneTimeTearDown]

    public void DisconnectFromDatabase() 
    
    {
        if (_connector != null) 
        
        {
            _connector.CloseConnection();

        }

    }




    }

