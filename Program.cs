/**************
* Lizzi Llacuna
* 05/23
* Assignment CIS317 - Project Application Design
* 
* Main Application
********************/

using System.Data.SQLite;

public class SucessABA {
    public static void Main(String[] args) {
        const string DbName = "Success.db";
        SQLiteConnection conn = SuccessDb.Connect(DbName);

        if (conn != null) {
            Console.WriteLine("Connected to SuccessABA Database! Welcome!");
            Console.WriteLine("Lizzi Llacuna - Final Project");
            
            //Individuals
            SuccessDb.CreateEmployeeTable(conn);
            SuccessDb.AddEmployee(conn, new Employee(654, "Lizzi", "Llacuna",
                24, "April 25, 2000", "Two or more","Female", 20.25, true,
                "Behavioral Technician"));
            SuccessDb.AddEmployee(conn, new Employee(789, "Jessica", "Llama",
                22, "January 1, 2002", "Caucasian", "Female", 20.25, false,
                "Behavioral Technician"));
            SuccessDb.AddEmployee(conn, new Employee(123, "Kay", "Lima",
                26, "June 7, 1998", "Two or more", "nonbinary", 25.25, true,
                "Behavioral Technician Lead"));
            SuccessDb.AddEmployee(conn, new Employee(852, "Ryan", "Lucas",
                30, "December 7, 1994", "Black", "Male", 35.00, true, "BCBA"));
            SuccessDb.AddEmployee(conn, new Employee(147, "Luke", "Lyra",
                25, "May 22, 1999", "Hispanic", "Male", 22.50, true,
                "Assistant Manager"));
            SuccessDb.AddEmployee(conn, new Employee(369, "Shayla", "Lexington",
                31, "November 21, 1993", "Pacific Asian", "Female", 35.20, true,
                "Operations Manager"));

            //Employee
            SuccessDb.CreateEmployeeTable(conn);
            
            //Clients
            SuccessDb.CreateClientTable(conn);
            SuccessDb.AddClient(conn, new Client(951, "Mason", "Rambo", 5,
                "August 23, 2018", "Black", "Male", "Mom - 7579846321",
                "Autism, ADHD", 0));
            SuccessDb.AddClient(conn, new Client(753, "Sunny", "Rush", 9,
                "September 9, 2014", "Asian", "Female", "Grandma - 7576396396",
                "Autism, paralytic gait, Tourette Syndrome", 2));
            SuccessDb.AddClient(conn, new Client(842, "Riley", "Ryans", 14,
                "February 13, 2010", "Caucasian", "Male", "Dad - 7578410256",
                "Autism", 8));
            SuccessDb.AddClient(conn,new Client(953, "Zed", "Rex", 6,
                "March 30, 2018", "Caucasian", "Male", "Mom - 7579846369",
                "Autism, Asthma, Migraines", 1));

            //Emergency Contacts
            SuccessDb.CreateEmergencyTable(conn);
        } else {
            Console.WriteLine("Unable to connect to SuccessABA Database");
        }
        
        //string name, int age, string bday, string race, string gender,
        //int id, double pay, bool fulltime, string level
        Individual Lizzi = new Employee(654, "Lizzi", "Llacuna", 24, "April 25, 2000", "Two or more",
            "Female", 20.25, true, "Behavioral Technician");
        Individual Jessica = new Employee(789, "Jessica", "Llama", 22, "January 1, 2002", "Caucasian",
            "Female", 20.25, false, "Behavioral Technician");
        Individual Kay = new Employee(123, "Kay", "Lima", 26, "June 7, 1998", "Two or more", "nonbinary",
            25.25, true, "Behavioral Technician Lead");
        Individual Ryan = new Employee(852, "Ryan", "Lucas", 30, "December 7, 1994", "Black",
            "Male", 35.00, true, "BCBA");
        Individual Luke = new Employee(147, "Luke", "Lyra", 25, "May 22, 1999", "Hispanic",
            "Male", 22.50, true, "Assistant Manager");
        Individual Shayla = new Employee(369, "Shayla", "Lexington", 31, "November 21, 1993", "Pacific Asian",
            "Female", 35.20, true, "Operations Manager");

        //now some clients
        //string name, int age, string bday, string race,
        //string gender, string emergencyContact, string diagnosis,
        //int grade
        Individual Mason = new Client(951, "Mason", "Rambo", 5, "August 23, 2018", "Black",
            "Male", "Mom - 7579846321", "Autism, ADHD", 0);
        Individual Sunny = new Client(753, "Sunny", "Rush", 9, "September 9, 2014", "Asian",
            "Female", "Grandma - 7576396396", "Autism, paralytic gait, Tourette Syndrome",
            2);
        Individual Riley = new Client(842, "Riley", "Ryans", 14, "February 13, 2010", "Caucasian",
            "Male", "Dad - 7578410256", "Autism", 8);
        Individual Zed = new Client(953, "Zed", "Rex", 6, "March 30, 2018", "Caucasian", "Male",
            "Mom - 7579846369", "Autism, Asthma, Migraines", 1);

        //add them to the list?
        List<Individual> MasonTeam = new List<Individual>();
        MasonTeam.Add(Lizzi);
        MasonTeam.Add(Kay);
        MasonTeam.Add(Ryan);

        List<Individual> SunnyTeam = new List<Individual>();
        SunnyTeam.Add(Jessica);
        SunnyTeam.Add(Kay);
        SunnyTeam.Add(Ryan);

        List<Individual> RileyTeam = new List<Individual>();
        RileyTeam.Add(Lizzi);
        RileyTeam.Add(Jessica);
        RileyTeam.Add(Ryan);

        List<Individual> ZedTeam = new List<Individual>();
        ZedTeam.Add(Kay);
        ZedTeam.Add(Ryan);

        //print the Employees
        Console.WriteLine(Lizzi);
        Console.WriteLine(Kay);
        Console.WriteLine(Ryan);
        Console.WriteLine(Luke);
        Console.WriteLine(Shayla);

        //Print the kids and their Teams
        Console.WriteLine(Mason);
        Console.WriteLine("Mason's Team");
        foreach(Individual individual in MasonTeam) {
            PrintTeam(individual);
        }
        Console.WriteLine(Sunny);
        Console.WriteLine(Riley);
        Console.WriteLine(Zed);

        //make the printing of the team possible
        static void PrintTeam(Individual individual) {
            Console.WriteLine(individual.FName + " " + individual.LName);
        }

        //need to make database
    }
}
