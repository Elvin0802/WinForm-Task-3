using Anket2.Models;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Anket2;

public partial class Form1 : Form
{
	private List<User> Users { get; set; } = new List<User>();

	public Form1()
	{
		InitializeComponent();
	}

	private void AddBtn_MouseClick(object sender, MouseEventArgs e)
	{
		if (AddBtn.Text == "Add User")
		{
			if (NameTxt.Text == "" || SurnameTxt.Text == "" || EmailTxt.Text == "" || PNumTxt.Text == "" || NameTxt.Text.All(c => c == ' ') || SurnameTxt.Text.All(c => c == ' ') || EmailTxt.Text.All(c => c == ' ') || PNumTxt.Text.All(c => c == ' '))
			{
				MessageBox.Show("Butun Melumatlar Doldurulmalidir !", "Save Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			Users.Add(
				new User(NameTxt.Text, SurnameTxt.Text, EmailTxt.Text, PNumTxt.Text, BirthDateTxt.Value));

			UsersList.DataSource = null;
			UsersList.DataSource = Users;

			MessageBox.Show($"{Users[Users.Count-1].Name} Added", "User Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		else if (AddBtn.Text == "Change Data")
		{
			var u = Users[UsersList.SelectedIndex];

			u.Name = NameTxt.Text;
			u.Surname = SurnameTxt.Text;
			u.Email = EmailTxt.Text;
			u.PhoneNum = PNumTxt.Text;
			u.BirthDate = BirthDateTxt.Value;
			
			MessageBox.Show($"Data Change is Successful.", "User Data", MessageBoxButtons.OK,MessageBoxIcon.Information);

			UsersList.DataSource = null;
			UsersList.DataSource = Users;
		}
	}

	private void UsersList_SelectedIndexChanged(object sender, EventArgs e)
	{
		User selectedUser = (User)UsersList.SelectedItem;

		if (selectedUser != null)
		{
			AddBtn.Text = "Change Data";

			NameTxt.Text = selectedUser.Name;
			SurnameTxt.Text = selectedUser.Surname;
			EmailTxt.Text = selectedUser.Email;
			PNumTxt.Text = selectedUser.PhoneNum;
			BirthDateTxt.Value = selectedUser.BirthDate;
		}
		else
		{
			AddBtn.Text = "Add User";

			NameTxt.Text = "";
			SurnameTxt.Text = "";
			EmailTxt.Text = "";
			PNumTxt.Text = "";
			BirthDateTxt.Value = new DateTime(2000, 1, 1);
		}
	}

	private void LoadBtn_MouseClick(object sender, MouseEventArgs e)
	{
		if (LoadWindow.ShowDialog() == DialogResult.OK)
		{
			try
			{
				var users = JsonMethods.Read(LoadWindow.FileName);

				if (users == null)
				{
					MessageBox.Show("File Loaded , But Users is null", "Laod Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);

					return;
				}

				Users = users;

				UsersList.DataSource = null;
				UsersList.DataSource = Users;

				FileNameText.Text = $"File: {LoadWindow.FileName}";

				MessageBox.Show("File Loaded", "Laod Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch
			{
				MessageBox.Show("File Not Loaded", "Laod Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		else
			MessageBox.Show("File Not Found !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
	}

	private void SaveBtn_MouseClick(object sender, MouseEventArgs e)
	{
		if (SaveWindow.ShowDialog() == DialogResult.OK)
		{
			var result = JsonMethods.Write(Users, SaveWindow.FileName);

			if (result == 1)
				MessageBox.Show("File Saved.", "File Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
			else
				MessageBox.Show("Error ! Please Check Operation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}
