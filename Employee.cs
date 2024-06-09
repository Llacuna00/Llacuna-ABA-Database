/**************
* Lizzi Llacuna
* 05/23
* Assignment CIS317 - Project Application Design
* 
* Employee is a child of individual and inherits its traits (name, age, bday,
* race, and gender) while adding on a few traits of its own. EmployeeID, pay
* (meaning how much they are being paid), bool Fulltime and level.
********************/

using System.Dynamic;
using System.Security.Cryptography;


public class Employee : Individual {
    public double Pay {get; set;}
    public bool Fulltime {get; set;}
    public string Level {get; set;}

    public Employee(int id, string Fname, string Lname, int age, string bday, string race, 
        string gender, double pay, bool fulltime, string level) : base(id, Fname, Lname, age, bday,
        race, gender) {
            Pay = pay;
            Fulltime = fulltime;
            Level = level;
        }

    public override string ToString()
    {
        return "\n~ Employee Information ~\n" + base.ToString() + "\n" +
            $"Current Pay: {Pay}\nFulltime: {EmploymentType()}\n"
            + $"Employee Level: {Level}";
    }

    //set Fulltime to yes/no
    protected string EmploymentType() {
        return Fulltime ? "Yes" : "No";
    }
}