using System;
using System.Drawing;
using System.Windows.Forms;

namespace PV2_UAS
{
	public partial class SplashScreen : Form
	{
		public SplashScreen()
		{
			InitializeComponent();
		}
		
		void Timer1Tick(object sender, EventArgs e) // Timer ticking in interval 100.
		{
			if (progressBar1.Value == 100) // When progress bar reached 100...
			{
				timer1.Enabled = false; // disabling timer.
				MainForm formutama = new MainForm();
				formutama.Show(); // Showing MainForm.cs.
				this.Hide(); //Hiding this form.
			}
			else
			{
				progressBar1.Value += 10;
			}
		}
	}
}
