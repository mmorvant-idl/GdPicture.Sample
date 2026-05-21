using GdPicture14;
using System;
using System.Diagnostics;

namespace GdPicture.Sample;

internal class Program
{
	private static IntPtr HWND => Process.GetCurrentProcess().MainWindowHandle;

	[STAThread]
	private static void Main(string[] args)
	{

		var licenseManager = new LicenseManager();
		var unlocked = licenseManager.RegisterKEY("KEY");
		if (unlocked == false) throw new Exception("GdPicture license exception. Please check the key.");
	}
}
