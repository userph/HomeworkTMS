using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;


    public class DbConnector
    {

    protected Logger _logger = LogManager.GetCurrentClassLogger();


    public NpgsqlConnection Connection { get; init; }


    public DbConnector()
    
    {

        var connectionString = $"Host={Configurator.ReadConfiguration().DbSettings.Db_Server};" +
                               $"Port={Configurator.ReadConfiguration().DbSettings.Db_Port};" +
                               $"Database={Configurator.ReadConfiguration().DbSettings.Db_Name};" +
                               $"User Id={Configurator.ReadConfiguration().DbSettings.Db_Username};" +
                               $"Password={Configurator.ReadConfiguration().DbSettings.Db_Password};";
            


   


        try
        {

            Connection = new NpgsqlConnection(connectionString);
            Connection.Open();
        }

        catch (Exception ex)
        
        { 
        
            _logger.Error(ex, "Failed to connect to database");
            throw;
        
        }






    
    }


    public void CloseConnection()

    {
        Connection.Close();

    }


}

