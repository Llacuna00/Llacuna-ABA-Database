using System.Data.SQLite;
using System.IO.Pipes;

public class SuccessDb {
    public static SQLiteConnection Connect (string database) {
        string db = @"Data Source=" + database;
        SQLiteConnection conn = new SQLiteConnection (db);

        try { 
            conn.Open ();
        } catch (Exception e) {
            Console.WriteLine(e.Message);
        }

        return conn;
    }
   
//Individual table and editing
//I don't think we need individual here
    /*public static void CreateIndividualTable(SQLiteConnection conn) {
        /*making the table string name, int age, string bday, 
        string race, string gender
        string sql =
            "CREATE TABLE IF NOT EXISTS Individual(\n"
            + " ID integer PRIMARY KEY\n"
            + " ,FName varchar(20)\n"
            + " ,LName varchar(20)\n"
            + " ,Age integer\n"
            + " ,Birthday varchar(50)\n"
            + " ,Race varchar(20)\n"
            + " ,Gender varchar(20));";
        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        cmd.ExecuteNonQuery();
    }

    public static void AddIndividual(SQLiteConnection conn, Individual I) {
        string sql = string.Format(
            "INSERT INTO Individual(ID, FName, LName, Age, Birthday, Race, Gender)"
                + "VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')",
                I.ID, I.FName, I.LName, I.Age, I.Birthday, I.Race, I.Gender); 
        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        cmd.ExecuteNonQuery();
    }

    public static void UpdateIndividual(SQLiteConnection conn, Individual I) {
        string sql = string.Format(
        "UPDATE Individual SET FName='{0}', LName='{1}', Age='{2}', Birthday='{3}', Race='{4}'"
            + ", Gender='{5}' WHERE ID='{6}'", I.FName, I.LName, I.Age, I.Birthday, I.Race,
            I.Gender, I.ID);
        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        cmd.ExecuteNonQuery();
    }

    public static void DeleteIndividual(SQLiteConnection conn, Individual I) {
        string sql = string.Format(
        "DELETE from Individual WHERE ID='{0}'", I.ID);
        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        cmd.ExecuteNonQuery();
    }*/

//Employee table and editing
    public static void CreateEmployeeTable(SQLiteConnection conn) {
        /*double pay, bool fulltime, string level*/
        string sql =
            "CREATE TABLE IF NOT EXISTS Employee(\n"
            + " ID integer PRIMARY KEY\n"
            + " ,FName varchar(20)\n"
            + " ,LName varchar(20)\n"
            + " ,Age integer\n"
            + " ,Birthday varchar(50)\n"
            + " ,Race varchar(20)\n"
            + " ,Gender varchar(20)\n"
            + " ID integer PRIMARY KEY\n"
            + " ,Pay Real\n"
            + " ,Fulltime varchar(3)\n"
            + " ,Level varchar(50));";
        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        cmd.ExecuteNonQuery();
    }

    public static void AddEmployee(SQLiteConnection conn, Employee E) {
        string sql = string.Format(
            "INSERT INTO Employee(ID, Pay, Fulltime, Level)"
                + "VALUES('{0}', '{1}', '{2}', '{3}', '{4}'",
                E.ID, E.Pay, E.Fulltime, E.Level); 
        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        cmd.ExecuteNonQuery();
    }

    public static void UpdateEmployee(SQLiteConnection conn, Employee E) {
        string sql = string.Format(
        "UPDATE Individual SET Pay='{0}', Fulltime='{1}', Level='{2}', WHERE ID='{3}'",
            E.Pay, E.Fulltime, E.Level, E.ID);
        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        cmd.ExecuteNonQuery();
    }

    public static void DeleteEmployee(SQLiteConnection conn, Employee E) {
        string sql = string.Format(
        "DELETE from Employee WHERE ID='{0}'", E.ID);
        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        cmd.ExecuteNonQuery();
    }

//Client table and editing
    public static void CreateClientTable(SQLiteConnection conn) {
        /*dstring emergencyContact, string diagnosis,
        int grade*/
        string sql =
            "CREATE TABLE IF NOT EXISTS Client(\n"
            + " ID integer PRIMARY KEY\n"
            + " ,FName varchar(20)"
            + " ,LName varchar(20)"
            + " ,Diagnosis varchar(50)"
            + " ,Grade integer);";
        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        cmd.ExecuteNonQuery();
    }

        public static void AddClient(SQLiteConnection conn, Client C) {
        string sql = string.Format(
            "INSERT INTO Individual(ID, FName, LName, Diagnosis, Grade)"
                + "VALUES('{0}', '{1}', '{2}', '{3}', '{4}'",
                C.ID, C.FName, C.LName, C.Diagnosis, C.GradeLevel); 
        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        cmd.ExecuteNonQuery();
    }

    public static void UpdateClient(SQLiteConnection conn, Client C) {
        string sql = string.Format(
        "UPDATE Individual SET FName='{0}', LName='{1}', Diagnosis='{2}', Grade='{3}', WHERE ID='{4}'",
            C.FName, C.LName, C.Diagnosis, C.GradeLevel, C.ID);
        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        cmd.ExecuteNonQuery();
    }

    public static void DeleteClient(SQLiteConnection conn, Client C) {
        string sql = string.Format(
        "DELETE from Employee WHERE ID='{0}'", C.ID);
        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        cmd.ExecuteNonQuery();
    }

//EmergencyContact table and editing
    public static void CreateEmergencyTable(SQLiteConnection conn) {
        /*contact1 : Individual {string PhoneNumber, string Email}
        Contact2 : Individual {string PhoneNumber, string Email}*/
        string sql =
            "CREATE TABLE IF NOT EXISTS Emergency Contact(\n"
            + " ID integer PRIMARY KEY\n"
            + " ,FName varchar(20)\n"
            + " ,LName varchar(20)\n"
            + " ,PhoneNumber varchar(10)\n"
            + " ,Email varchar(25));";
        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        cmd.ExecuteNonQuery();
    }
    //int id, string Fname, string Lname, string relation, string phoneNumber, string email
    public static void AddEmergencyContactTable(SQLiteConnection conn, EmergencyContact EC) {
        string sql = string.Format(
            "INSERT INTO Individual(ID, FName, LName, PhoneNumber, Email)"
                + "VALUES('{0}', '{1}', '{2}', '{3}', '{4}'",
                EC.ID, EC.FName, EC.LName, EC.PhoneNumber, EC.Email); 
        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        cmd.ExecuteNonQuery();
    }

    public static void UpdateEmergencyContact(SQLiteConnection conn, EmergencyContact EC) {
        string sql = string.Format(
        "UPDATE Individual SET FName='{0}', LName='{1}', Diagnosis='{2}', Grade='{3}', WHERE ID='{4}'",
            EC.FName, EC.LName, EC.PhoneNumber, EC.Email, EC.ID);
        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        cmd.ExecuteNonQuery();
    }

    public static void DeleteEmergencyContact(SQLiteConnection conn, EmergencyContact EC) {
        string sql = string.Format(
        "DELETE from Employee WHERE ID='{0}'", EC.ID);
        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        cmd.ExecuteNonQuery();
    }

    public static List<Individual> GetAllEmployees(SQLiteConnection conn) {
        List<Individual> people = new List<Individual>();
        string sql = "SELECT * FROM Employee";
        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = sql;

        SQLiteReadEventArgs rdr = cmd.ExecuteReader();

        while (rdr.Read()) {
            Individual.Add(new Individual(rdr.GetGetInt32()));
        }
    }
}