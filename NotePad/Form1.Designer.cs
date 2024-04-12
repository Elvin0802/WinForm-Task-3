namespace NotePad
{
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
			labelFont = new Label();
			labelSize = new Label();
			labelFontStyle = new Label();
			labelAlignment = new Label();
			labelColor = new Label();
			FontBox = new ComboBox();
			ColorBox = new ComboBox();
			SizeBox = new ComboBox();
			ToBold = new Button();
			ToRightAlign = new Button();
			ToCenterAlign = new Button();
			ToLeftAlign = new Button();
			ToItalic = new Button();
			ToUnderLine = new Button();
			buttonLoad = new Button();
			buttonSave = new Button();
			AppText = new RichTextBox();
			LoadFileWindow = new OpenFileDialog();
			SaveFileWindow = new SaveFileDialog();
			SuspendLayout();
			// 
			// labelFont
			// 
			labelFont.Location = new Point(12, 9);
			labelFont.Name = "labelFont";
			labelFont.Size = new Size(105, 30);
			labelFont.TabIndex = 0;
			labelFont.Text = "Font";
			labelFont.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// labelSize
			// 
			labelSize.Location = new Point(123, 9);
			labelSize.Name = "labelSize";
			labelSize.Size = new Size(100, 30);
			labelSize.TabIndex = 99;
			labelSize.Text = "Size";
			labelSize.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// labelFontStyle
			// 
			labelFontStyle.Location = new Point(234, 9);
			labelFontStyle.Name = "labelFontStyle";
			labelFontStyle.Size = new Size(120, 30);
			labelFontStyle.TabIndex = 2;
			labelFontStyle.Text = "Font Style";
			labelFontStyle.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// labelAlignment
			// 
			labelAlignment.Location = new Point(372, 9);
			labelAlignment.Name = "labelAlignment";
			labelAlignment.Size = new Size(120, 30);
			labelAlignment.TabIndex = 3;
			labelAlignment.Text = "Alignment";
			labelAlignment.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// labelColor
			// 
			labelColor.Location = new Point(512, 9);
			labelColor.Name = "labelColor";
			labelColor.Size = new Size(140, 30);
			labelColor.TabIndex = 4;
			labelColor.Text = "Color";
			labelColor.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// FontBox
			// 
			FontBox.BackColor = Color.LightGray;
			FontBox.FormattingEnabled = true;
			FontBox.Location = new Point(12, 41);
			FontBox.Margin = new Padding(2);
			FontBox.Name = "FontBox";
			FontBox.Size = new Size(125, 27);
			FontBox.TabIndex = 5;
			FontBox.Text = "Arial";
			FontBox.TextChanged += FontBox_TextChanged;
			// 
			// ColorBox
			// 
			ColorBox.BackColor = Color.LightGray;
			ColorBox.FormattingEnabled = true;
			ColorBox.Location = new Point(512, 43);
			ColorBox.Margin = new Padding(2);
			ColorBox.Name = "ColorBox";
			ColorBox.Size = new Size(140, 27);
			ColorBox.TabIndex = 6;
			ColorBox.Text = "WindowText";
			ColorBox.TextChanged += ColorBox_TextChanged;
			// 
			// SizeBox
			// 
			SizeBox.BackColor = Color.LightGray;
			SizeBox.FormattingEnabled = true;
			SizeBox.Location = new Point(150, 41);
			SizeBox.Margin = new Padding(2);
			SizeBox.Name = "SizeBox";
			SizeBox.Size = new Size(60, 27);
			SizeBox.TabIndex = 7;
			SizeBox.Text = "12";
			SizeBox.TextChanged += SizeBox_TextChanged;
			// 
			// ToBold
			// 
			ToBold.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
			ToBold.Location = new Point(235, 42);
			ToBold.Name = "ToBold";
			ToBold.Size = new Size(32, 27);
			ToBold.TabIndex = 8;
			ToBold.Text = "B";
			ToBold.UseVisualStyleBackColor = true;
			ToBold.MouseClick += ToBold_MouseClick;
			// 
			// ToRightAlign
			// 
			ToRightAlign.Location = new Point(447, 42);
			ToRightAlign.Name = "ToRightAlign";
			ToRightAlign.Size = new Size(32, 27);
			ToRightAlign.TabIndex = 9;
			ToRightAlign.Text = "R";
			ToRightAlign.UseVisualStyleBackColor = true;
			ToRightAlign.MouseClick += ToRightAlign_MouseClick;
			// 
			// ToCenterAlign
			// 
			ToCenterAlign.Location = new Point(409, 42);
			ToCenterAlign.Name = "ToCenterAlign";
			ToCenterAlign.Size = new Size(32, 27);
			ToCenterAlign.TabIndex = 10;
			ToCenterAlign.Text = "C";
			ToCenterAlign.UseVisualStyleBackColor = true;
			ToCenterAlign.MouseClick += ToCenterAlign_MouseClick;
			// 
			// ToLeftAlign
			// 
			ToLeftAlign.Location = new Point(371, 42);
			ToLeftAlign.Name = "ToLeftAlign";
			ToLeftAlign.Size = new Size(32, 27);
			ToLeftAlign.TabIndex = 11;
			ToLeftAlign.Text = "L";
			ToLeftAlign.UseVisualStyleBackColor = true;
			ToLeftAlign.MouseClick += ToLeftAlign_MouseClick;
			// 
			// ToItalic
			// 
			ToItalic.Font = new Font("Arial", 10F, FontStyle.Italic, GraphicsUnit.Point);
			ToItalic.Location = new Point(311, 42);
			ToItalic.Name = "ToItalic";
			ToItalic.Size = new Size(32, 27);
			ToItalic.TabIndex = 12;
			ToItalic.Text = "I";
			ToItalic.UseVisualStyleBackColor = true;
			ToItalic.MouseClick += ToItalic_MouseClick;
			// 
			// ToUnderLine
			// 
			ToUnderLine.Font = new Font("Arial", 10F, FontStyle.Underline, GraphicsUnit.Point);
			ToUnderLine.Location = new Point(273, 42);
			ToUnderLine.Name = "ToUnderLine";
			ToUnderLine.Size = new Size(32, 27);
			ToUnderLine.TabIndex = 13;
			ToUnderLine.Text = "U";
			ToUnderLine.UseVisualStyleBackColor = true;
			ToUnderLine.MouseClick += ToUnderLine_MouseClick;
			// 
			// buttonLoad
			// 
			buttonLoad.BackColor = Color.Silver;
			buttonLoad.Location = new Point(712, 14);
			buttonLoad.Margin = new Padding(5);
			buttonLoad.Name = "buttonLoad";
			buttonLoad.Size = new Size(120, 40);
			buttonLoad.TabIndex = 14;
			buttonLoad.Text = "Load File";
			buttonLoad.UseVisualStyleBackColor = false;
			buttonLoad.MouseClick += buttonLoad_MouseClick;
			// 
			// buttonSave
			// 
			buttonSave.BackColor = Color.Silver;
			buttonSave.Location = new Point(712, 64);
			buttonSave.Margin = new Padding(5);
			buttonSave.Name = "buttonSave";
			buttonSave.Size = new Size(120, 40);
			buttonSave.TabIndex = 15;
			buttonSave.Text = "Save File";
			buttonSave.UseVisualStyleBackColor = false;
			buttonSave.MouseClick += buttonSave_MouseClick;
			// 
			// AppText
			// 
			AppText.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
			AppText.Location = new Point(1, 112);
			AppText.Name = "AppText";
			AppText.RightToLeft = RightToLeft.No;
			AppText.Size = new Size(840, 540);
			AppText.TabIndex = 1;
			AppText.Text = "";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(9F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Gainsboro;
			ClientSize = new Size(842, 653);
			Controls.Add(AppText);
			Controls.Add(buttonSave);
			Controls.Add(buttonLoad);
			Controls.Add(ToUnderLine);
			Controls.Add(ToItalic);
			Controls.Add(ToLeftAlign);
			Controls.Add(ToCenterAlign);
			Controls.Add(ToRightAlign);
			Controls.Add(ToBold);
			Controls.Add(SizeBox);
			Controls.Add(ColorBox);
			Controls.Add(FontBox);
			Controls.Add(labelColor);
			Controls.Add(labelAlignment);
			Controls.Add(labelFontStyle);
			Controls.Add(labelSize);
			Controls.Add(labelFont);
			Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(3, 2, 3, 2);
			MaximizeBox = false;
			MaximumSize = new Size(860, 700);
			MinimumSize = new Size(860, 700);
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Notepad";
			ResumeLayout(false);
		}

		#endregion

		private Label labelFont;
		private Label labelSize;
		private Label labelFontStyle;
		private Label labelAlignment;
		private Label labelColor;
		private ComboBox FontBox;
		private ComboBox ColorBox;
		private ComboBox SizeBox;
		private Button ToBold;
		private Button ToRightAlign;
		private Button ToCenterAlign;
		private Button ToLeftAlign;
		private Button ToItalic;
		private Button ToUnderLine;
		private Button buttonLoad;
		private Button buttonSave;
		private RichTextBox AppText;
		private OpenFileDialog LoadFileWindow;
		private SaveFileDialog SaveFileWindow;
	}
}
