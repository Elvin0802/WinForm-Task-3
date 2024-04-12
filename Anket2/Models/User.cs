namespace Anket2.Models;

public class User
{
	public string Name { get; set; }
	public string Surname { get; set; }
	public string Email { get; set; }
	public string PhoneNum { get; set; }
	public DateTime BirthDate { get; set; }

	public User(string name, string surname, string email, string phoneNum, DateTime birthDate)
	{
		Name = name;
		Surname = surname;
		Email = email;
		PhoneNum = phoneNum;
		BirthDate = birthDate;
	}

	public override string ToString() =>
			$"-->  {Name}  //  {Surname} .";
}
