/**************
* Lizzi Llacuna
* 05/23
* Assignment CIS317 - Project Application Design
* 
* ok, this holds the information for Emergency contacts for 
* Clients and Employees
***************  *****/

public class EmergencyContact : Individual {
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Relation { get; set; }

    public EmergencyContact (int id, string Fname, string Lname, int age, string bday, string race,
        string gender, string phoneNumber, string email, string relation)
        : base(id, Fname, Lname, age, bday, race, gender) {
            PhoneNumber = phoneNumber;
            Email = email;
            Relation = relation;
    }

    public EmergencyContact(int id, string Fname, string Lname,
        string phoneNumber, string email, string relation) : 
        base(id, Fname, Lname) {
            PhoneNumber = phoneNumber;
            Email = email;
            Relation = relation;
            }
}