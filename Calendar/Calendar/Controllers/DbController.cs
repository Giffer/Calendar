using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;


namespace Calendar.Controllers
{
    public class DbController
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public DbController()
        {
            InitializeConnection();
        }

        public void InitializeConnection()
        {
            server = "mysql16.unoeuro.com";
            database = "dqi_nu_db";
            uid = "dqi_nu";
            password = "giffer1603";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE="  + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
        
            connection = new MySqlConnection(connectionString);
        }
       // Kræver selvfølge en instanciering af en connection fra frameworket Mysql.data.Mysqlclient; // brug google hvis du i tvivl.


          //connection string =   
          //server = "mysql16.unoeuro.com";
          //database = "dqi_nu_db";
          //uid = "dqi_nu";
          //password = "giffer1603";
          //string connectionString;
          //connectionString = "SERVER=" + server + ";" + "DATABASE=" +
          //database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
//----------------------------------------------------------------------
//den er sammensat, hvis man er mere vant til at skrive den anderledes, vil det være: 

//cs=DataSource="mysql16.unoeuro.com";initial catalog="dqi_nu_db";password="giffer1603"; // til  ms sql
//----------------------------------------------------------------------
//til MySQl vil det være: 

//cs= SERVER="mysql16.unoeuro.com";DATABASE="dqi_nu_db";UID="dqi_nu";PASSWORD="giffer1603"; 
//----------------------------------------------------------------------
//hvis der mangles oplysninger til connection til db via MYSQL BENCHWORK:

//IP:
//94.231.107.223
//DB: dqi_nu
//PW: giffer1603
//port:3306

    }
}
