/**************
* Lizzi Llacuna
* 05/23
* Assignment CIS317 - Project Application Design
* 
* Individual is the base class. It will hold basic information on the person
* based on their name, age, birthday, race, and gender.
********************/

public abstract class Individual {
    public int ID { get; set; }
    public string FName { get; set; }
    public string LName { get; set; }
    public int Age { get; set; }
    public string Birthday { get; set; }
    public string Race { get; set; }
    public string Gender { get; set; }

    public Individual(int id, string Fname, string Lname, int age, string bday, string race,
        string gender) {
            ID = id; 
            FName = Fname;
            LName = Lname;
            Age = age;
            Birthday = bday;
            Race = race;
            Gender = gender;
    }

    public override string ToString() {
        return
            $"ID: {ID}\nName: {FName} {LName}\nAge: {Age}\nBirthday: {Birthday}\n" +
            $"Race: {Race}\nGender: {Gender}";
    }
} 
