//string connectionString = "Server = (localdb)\\mssqllocaldb; Database = Cars; Trusted_Connection = True; MultipleActiveResultSets = true";
using System.Data.SqlClient;

string connectionString = "Server = (localdb)\\mssqllocaldb; Database = cars1; Trusted_Connection = True; MultipleActiveResultSets = true";

SqlConnection connection = new SqlConnection(connectionString);


//Create a new Database
//SqlCommand sqlCommand = new SqlCommand("CREATE DATABASE cars1", connection);


//Create a table in the Database
string sqlString = "CREATE TABLE CARS(ID INT PRIMARY KEY, BRAND VARCHAR(50), MODEL VARCHAR(50), YEAR INT)";
SqlCommand sqlCommand = new SqlCommand(sqlString, connection);

//INSERT DATA IN TABLE
sqlCommand.CommandText = "INSERT INTO CARS VALUES(1,'VOLVO','V40',2020)";
sqlCommand.CommandText = "INSERT INTO CARS VALUES(2,'VOLVO','V60',1990);" +
                            "INSERT INTO CARS VALUES(3,'BMW','S60',2022);";

//SELECT DATA FROM TABLE
sqlCommand.CommandText = "SELECT * FROM CARS";

//UPDATE DATA IN TABLE
sqlCommand.CommandText = "UPDATE CARS SET YEAR = 2000 WHERE ID = 3";

//DELETE DATA IN TABLE
sqlCommand.CommandText = "DELETE FROM CARS WHERE ID < 2";


connection.Open();

sqlCommand.ExecuteNonQuery();//FOR INSERT, CREATE, UPDATE, DELETE


//FOR SELECT use execute reader
/*var result = sqlCommand.ExecuteReader();
while(result.Read())
{
    Console.WriteLine(result.GetValue(2).ToString());
}
*/

connection.Close();
