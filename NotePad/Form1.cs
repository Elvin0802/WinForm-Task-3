using System.Windows.Forms;

namespace NotePad
{
	public partial class Form1 : Form
	{
		public bool isBold { get; set; } = false;
		public bool isItalic { get; set; } = false;
		public bool isUnderLined { get; set; } = false;


		public Form1()
		{
			InitializeComponent();

			foreach (var fon in FontFamily.Families)
				FontBox.Items.Add(fon.Name);

			foreach (var colorValue in Enum.GetValues(typeof(KnownColor)))
				ColorBox.Items.Add(Color.FromKnownColor((KnownColor)colorValue));

			for (byte val = 1; val < byte.MaxValue; val++)
				SizeBox.Items.Add(val);
		}

		private void buttonLoad_MouseClick(object sender, MouseEventArgs e)
		{
			if (LoadFileWindow.ShowDialog() == DialogResult.OK)
			{
				if (File.Exists(LoadFileWindow.FileName))
				{
					try
					{
						var tx = File.ReadAllText(LoadFileWindow.FileName);
						AppText.Text = tx;
					}
					catch
					{
						MessageBox.Show("File Not Loaded", "Laod Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				else
					MessageBox.Show("File Not Found !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void buttonSave_MouseClick(object sender, MouseEventArgs e)
		{
			if (SaveFileWindow.ShowDialog() == DialogResult.OK)
			{
				try
				{
					File.WriteAllText(SaveFileWindow.FileName, AppText.Text);
					MessageBox.Show("File Saved", "Save Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				catch
				{
					MessageBox.Show("File Not Saved", "Save Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void FontBox_TextChanged(object sender, EventArgs e)
		{
			var s = AppText.Font.Name;
			try
			{
				if (FontFamily.Families.Any(font => font.Name == FontBox.Text))
					AppText.Font = new Font(FontBox.Text, float.Parse(SizeBox.Text));
				else
					throw new Exception();
			}
			catch
			{
				MessageBox.Show("Font Not Changed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				FontBox.Text = s;
			}
		}

		private void ColorBox_TextChanged(object sender, EventArgs e)
		{
			var s = AppText.ForeColor;
			try
			{
				AppText.ForeColor = Color.FromName(ColorBox.Text);
			}
			catch
			{
				MessageBox.Show("Color Not Changed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				ColorBox.Text = s.Name;
			}
		}

		private void SizeBox_TextChanged(object sender, EventArgs e)
		{
			var s = AppText.Font.Size;
			try
			{
				var sf = float.Parse(SizeBox.Text);
				if (sf < 256f && sf > 0f)
					AppText.Font = new Font(FontBox.Text, float.Parse(SizeBox.Text));
				else
					throw new Exception();
			}
			catch
			{
				MessageBox.Show("Size Not Changed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				SizeBox.Text = s.ToString();
			}
		}

		private void ToBold_MouseClick(object sender, MouseEventArgs e)
		{
			FontStyle style = AppText.Font.Style;

			isBold = !isBold;

			if (isBold)
				style |= FontStyle.Bold;
			else
				style &= ~FontStyle.Bold;

			ApplyFontStyle(style);
		}

		private void ToUnderLine_MouseClick(object sender, MouseEventArgs e)
		{
			FontStyle style = AppText.Font.Style;

			isUnderLined = !isUnderLined;

			if (isUnderLined)
				style |= FontStyle.Underline;
			else
				style &= ~FontStyle.Underline;

			ApplyFontStyle(style);
		}

		private void ToItalic_MouseClick(object sender, MouseEventArgs e)
		{
			FontStyle style = AppText.Font.Style;

			isItalic = !isItalic;

			if (isItalic)
				style |= FontStyle.Italic;
			else
				style &= ~FontStyle.Italic;

			ApplyFontStyle(style);
		}

		private void ToLeftAlign_MouseClick(object sender, MouseEventArgs e)
		{
			AppText.SelectionAlignment = HorizontalAlignment.Left;
		}

		private void ToRightAlign_MouseClick(object sender, MouseEventArgs e)
		{
			AppText.SelectionAlignment = HorizontalAlignment.Right;
		}

		private void ToCenterAlign_MouseClick(object sender, MouseEventArgs e)
		{
			AppText.SelectionAlignment = HorizontalAlignment.Center;
		}

		private void ApplyFontStyle(FontStyle fs)
		{
			AppText.Font = new Font(FontBox.Text, float.Parse(SizeBox.Text), fs);
		}

		private void Form1_SizeChanged(object sender, EventArgs e)
		{
			AppText.Size = new Size(((Form)sender).Width - 20, ((Form)sender).Height - 160);
		}
	}

}
