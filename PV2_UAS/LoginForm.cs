using System;
using System.Drawing;
using System.Windows.Forms;

namespace PV2_UAS
{
	
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}
		
		void LoginFormLoad(object sender, EventArgs e)
		{
			textBoxPassword.PasswordChar = '\u25CF'; // Turning input char in textBoxPassword to 'dot'.
		}
		
		void BtnLoginClick(object sender, EventArgs e)
		{
			string uname = "admin"; // Username
			string pword = "admin"; // Password
			
			if (textBoxUsername.Text == uname && textBoxPassword.Text == pword) // Account validity checking.
			{
				SplashScreen mysplashscreen = new SplashScreen();
				mysplashscreen.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Sorry, your data didn't match with the system", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				textBoxUsername.Clear();
				textBoxPassword.Clear();
			}
		}
		
		void BtnClearClick(object sender, EventArgs e) // Clear the textboxes.
		{
			textBoxUsername.Clear();
			textBoxPassword.Clear();
		}
		
		void labelShowMouseDown(object sender, MouseEventArgs e) // Turning char in textBoxPassword to reguler if mouse down
		{
			textBoxPassword.PasswordChar = '\0';
		}
		void labelShowMouseUp(object sender, MouseEventArgs e) // Turning input char in textBoxPassword to 'dot' if mouse up
		{
			textBoxPassword.PasswordChar = '\u25CF';
		}
		void TextBoxUsernameTextChanged(object sender, EventArgs e)
		{
	
		}
		
	}
}
