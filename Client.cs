/**************
* Lizzi Llacuna
* 05/23
* Assignment CIS317 - Project Application Design
* 
* Client will inherit from the Individual class. It will add an Emergency
* Contact, Diagnosis, bool In School, and Team. Team will be a list that
* shows the names of the individuals on his/her treatment team. 
********************/

public class Client : Individual {
    public string EmergencyContact { get; set; }
    public string Diagnosis { get; set; }
    public int GradeLevel { get; set; }

    public Client (int id, string Fname, string Lname, int age, string bday, string race,
        string gender, string emergencyContact, string diagnosis,
        int grade) : base(id, Fname, Lname, age, bday, race, gender) {
            EmergencyContact = emergencyContact;
            Diagnosis = diagnosis;
            GradeLevel = grade;
    }

    public override string ToString()
    {
        return "\n~ Client Information ~\n" + base.ToString() + "\n" +
            $"Emergency Contact: {EmergencyContact}\nDiagnosis: {Diagnosis}\n" +
            $"Grade Level: {GradeLevel}";
    }
}