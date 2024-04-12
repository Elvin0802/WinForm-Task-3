namespace Anket2;

partial class Form1
{
	private System.ComponentModel.IContainer components = null;

	protected override void Dispose(bool disposing)
	{
		if (disposing && (components != null))
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	#region Windows Form Designer generated code

	private void InitializeComponent()
	{
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
		UserDataGB = new GroupBox();
		label5 = new Label();
		label4 = new Label();
		label3 = new Label();
		label2 = new Label();
		label1 = new Label();
		AddBtn = new Button();
		BirthDateTxt = new DateTimePicker();
		PNumTxt = new TextBox();
		EmailTxt = new TextBox();
		SurnameTxt = new TextBox();
		HeaderTextRegister = new Label();
		NameTxt = new TextBox();
		groupBox1 = new GroupBox();
		FileNameText = new Label();
		SaveBtn = new Button();
		LoadBtn = new Button();
		UsersList = new ListBox();
		HeaderTextUsers = new Label();
		SaveWindow = new SaveFileDialog();
		LoadWindow = new OpenFileDialog();
		UserDataGB.SuspendLayout();
		groupBox1.SuspendLayout();
		SuspendLayout();
		// 
		// UserDataGB
		// 
		UserDataGB.Controls.Add(label5);
		UserDataGB.Controls.Add(label4);
		UserDataGB.Controls.Add(label3);
		UserDataGB.Controls.Add(label2);
		UserDataGB.Controls.Add(label1);
		UserDataGB.Controls.Add(AddBtn);
		UserDataGB.Controls.Add(BirthDateTxt);
		UserDataGB.Controls.Add(PNumTxt);
		UserDataGB.Controls.Add(EmailTxt);
		UserDataGB.Controls.Add(SurnameTxt);
		UserDataGB.Controls.Add(HeaderTextRegister);
		UserDataGB.Controls.Add(NameTxt);
		UserDataGB.Location = new Point(6, 4);
		UserDataGB.Name = "UserDataGB";
		UserDataGB.Size = new Size(405, 537);
		UserDataGB.TabIndex = 0;
		UserDataGB.TabStop = false;
		// 
		// label5
		// 
		label5.AutoSize = true;
		label5.Font = new Font("Segoe UI", 11F, FontStyle.Underline, GraphicsUnit.Point);
		label5.ForeColor = Color.FromArgb(244, 242, 236);
		label5.Location = new Point(6, 302);
		label5.Name = "label5";
		label5.Size = new Size(140, 25);
		label5.TabIndex = 12;
		label5.Text = "Phone Number";
		// 
		// label4
		// 
		label4.AutoSize = true;
		label4.Font = new Font("Segoe UI", 11F, FontStyle.Underline, GraphicsUnit.Point);
		label4.ForeColor = Color.FromArgb(244, 242, 236);
		label4.Location = new Point(6, 230);
		label4.Name = "label4";
		label4.Size = new Size(58, 25);
		label4.TabIndex = 11;
		label4.Text = "Email";
		// 
		// label3
		// 
		label3.AutoSize = true;
		label3.Font = new Font("Segoe UI", 11F, FontStyle.Underline, GraphicsUnit.Point);
		label3.ForeColor = Color.FromArgb(244, 242, 236);
		label3.Location = new Point(6, 158);
		label3.Name = "label3";
		label3.Size = new Size(87, 25);
		label3.TabIndex = 10;
		label3.Text = "Surname";
		// 
		// label2
		// 
		label2.AutoSize = true;
		label2.Font = new Font("Segoe UI", 11F, FontStyle.Underline, GraphicsUnit.Point);
		label2.ForeColor = Color.FromArgb(244, 242, 236);
		label2.Location = new Point(6, 83);
		label2.Name = "label2";
		label2.Size = new Size(62, 25);
		label2.TabIndex = 9;
		label2.Text = "Name";
		// 
		// label1
		// 
		label1.AutoSize = true;
		label1.Font = new Font("Segoe UI", 11F, FontStyle.Underline, GraphicsUnit.Point);
		label1.ForeColor = Color.FromArgb(244, 242, 236);
		label1.Location = new Point(6, 374);
		label1.Name = "label1";
		label1.Size = new Size(96, 25);
		label1.TabIndex = 8;
		label1.Text = "Birth Date";
		// 
		// AddBtn
		// 
		AddBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		AddBtn.BackColor = Color.FromArgb(190, 38, 35);
		AddBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
		AddBtn.ForeColor = Color.FromArgb(234, 232, 220);
		AddBtn.Location = new Point(91, 471);
		AddBtn.Name = "AddBtn";
		AddBtn.Size = new Size(180, 60);
		AddBtn.TabIndex = 7;
		AddBtn.Text = "Add User";
		AddBtn.UseVisualStyleBackColor = false;
		AddBtn.MouseClick += AddBtn_MouseClick;
		// 
		// BirthDateTxt
		// 
		BirthDateTxt.CalendarForeColor = Color.Snow;
		BirthDateTxt.CalendarMonthBackground = Color.Snow;
		BirthDateTxt.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
		BirthDateTxt.Location = new Point(6, 402);
		BirthDateTxt.Name = "BirthDateTxt";
		BirthDateTxt.Size = new Size(393, 41);
		BirthDateTxt.TabIndex = 6;
		BirthDateTxt.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
		// 
		// PNumTxt
		// 
		PNumTxt.BackColor = Color.FromArgb(234, 232, 220);
		PNumTxt.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
		PNumTxt.Location = new Point(6, 330);
		PNumTxt.Name = "PNumTxt";
		PNumTxt.PlaceholderText = "Enter Phone Number";
		PNumTxt.Size = new Size(393, 41);
		PNumTxt.TabIndex = 4;
		// 
		// EmailTxt
		// 
		EmailTxt.BackColor = Color.FromArgb(234, 232, 220);
		EmailTxt.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
		EmailTxt.Location = new Point(6, 258);
		EmailTxt.Name = "EmailTxt";
		EmailTxt.PlaceholderText = "Enter Email";
		EmailTxt.Size = new Size(393, 41);
		EmailTxt.TabIndex = 3;
		// 
		// SurnameTxt
		// 
		SurnameTxt.BackColor = Color.FromArgb(234, 232, 220);
		SurnameTxt.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
		SurnameTxt.Location = new Point(6, 186);
		SurnameTxt.Name = "SurnameTxt";
		SurnameTxt.PlaceholderText = "Enter Surname";
		SurnameTxt.Size = new Size(393, 41);
		SurnameTxt.TabIndex = 2;
		// 
		// HeaderTextRegister
		// 
		HeaderTextRegister.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
		HeaderTextRegister.ForeColor = Color.FromArgb(234, 232, 220);
		HeaderTextRegister.Location = new Point(6, 23);
		HeaderTextRegister.Name = "HeaderTextRegister";
		HeaderTextRegister.Size = new Size(393, 49);
		HeaderTextRegister.TabIndex = 1;
		HeaderTextRegister.Text = "Register";
		HeaderTextRegister.TextAlign = ContentAlignment.MiddleCenter;
		// 
		// NameTxt
		// 
		NameTxt.BackColor = Color.FromArgb(234, 232, 220);
		NameTxt.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
		NameTxt.Location = new Point(6, 114);
		NameTxt.Margin = new Padding(3, 6, 3, 3);
		NameTxt.Name = "NameTxt";
		NameTxt.PlaceholderText = "Enter Name";
		NameTxt.Size = new Size(393, 41);
		NameTxt.TabIndex = 0;
		// 
		// groupBox1
		// 
		groupBox1.Controls.Add(FileNameText);
		groupBox1.Controls.Add(SaveBtn);
		groupBox1.Controls.Add(LoadBtn);
		groupBox1.Controls.Add(UsersList);
		groupBox1.Controls.Add(HeaderTextUsers);
		groupBox1.Location = new Point(426, 4);
		groupBox1.Name = "groupBox1";
		groupBox1.Size = new Size(544, 537);
		groupBox1.TabIndex = 1;
		groupBox1.TabStop = false;
		// 
		// FileNameText
		// 
		FileNameText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
		FileNameText.ForeColor = Color.FromArgb(244, 242, 236);
		FileNameText.Location = new Point(21, 433);
		FileNameText.Name = "FileNameText";
		FileNameText.Size = new Size(506, 34);
		FileNameText.TabIndex = 10;
		FileNameText.Text = "File: None";
		// 
		// SaveBtn
		// 
		SaveBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		SaveBtn.BackColor = Color.FromArgb(190, 38, 35);
		SaveBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
		SaveBtn.ForeColor = Color.FromArgb(234, 232, 220);
		SaveBtn.Location = new Point(273, 481);
		SaveBtn.Name = "SaveBtn";
		SaveBtn.Size = new Size(180, 50);
		SaveBtn.TabIndex = 8;
		SaveBtn.Text = "Save";
		SaveBtn.UseVisualStyleBackColor = false;
		SaveBtn.MouseClick += SaveBtn_MouseClick;
		// 
		// LoadBtn
		// 
		LoadBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		LoadBtn.BackColor = Color.FromArgb(190, 38, 35);
		LoadBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
		LoadBtn.ForeColor = Color.FromArgb(234, 232, 220);
		LoadBtn.Location = new Point(87, 481);
		LoadBtn.Name = "LoadBtn";
		LoadBtn.Size = new Size(180, 50);
		LoadBtn.TabIndex = 9;
		LoadBtn.Text = "Load";
		LoadBtn.UseVisualStyleBackColor = false;
		LoadBtn.MouseClick += LoadBtn_MouseClick;
		// 
		// UsersList
		// 
		UsersList.BackColor = Color.FromArgb(244, 242, 236);
		UsersList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
		UsersList.FormattingEnabled = true;
		UsersList.ItemHeight = 28;
		UsersList.Location = new Point(21, 75);
		UsersList.Name = "UsersList";
		UsersList.SelectionMode = SelectionMode.MultiSimple;
		UsersList.Size = new Size(506, 340);
		UsersList.TabIndex = 8;
		UsersList.SelectedIndexChanged += UsersList_SelectedIndexChanged;
		// 
		// HeaderTextUsers
		// 
		HeaderTextUsers.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
		HeaderTextUsers.ForeColor = Color.FromArgb(234, 232, 220);
		HeaderTextUsers.Location = new Point(6, 23);
		HeaderTextUsers.Name = "HeaderTextUsers";
		HeaderTextUsers.Size = new Size(532, 49);
		HeaderTextUsers.TabIndex = 7;
		HeaderTextUsers.Text = "Users";
		HeaderTextUsers.TextAlign = ContentAlignment.MiddleCenter;
		// 
		// SaveWindow
		// 
		SaveWindow.FileName = "*.json";
		// 
		// Form1
		// 
		AutoScaleDimensions = new SizeF(8F, 20F);
		AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.FromArgb(14, 55, 70);
		ClientSize = new Size(982, 553);
		Controls.Add(groupBox1);
		Controls.Add(UserDataGB);
		Icon = (Icon)resources.GetObject("$this.Icon");
		Name = "Form1";
		Text = "Anket";
		UserDataGB.ResumeLayout(false);
		UserDataGB.PerformLayout();
		groupBox1.ResumeLayout(false);
		ResumeLayout(false);
	}

	#endregion

	private GroupBox UserDataGB;
	private TextBox PNumTxt;
	private TextBox EmailTxt;
	private TextBox SurnameTxt;
	private Label HeaderTextRegister;
	private TextBox NameTxt;
	private DateTimePicker BirthDateTxt;
	private GroupBox groupBox1;
	private Label HeaderTextUsers;
	private ListBox UsersList;
	private Button AddBtn;
	private Label FileNameText;
	private Button SaveBtn;
	private Button LoadBtn;
	private Label label1;
	private Label label3;
	private Label label2;
	private Label label5;
	private Label label4;
	private SaveFileDialog SaveWindow;
	private OpenFileDialog LoadWindow;
}
