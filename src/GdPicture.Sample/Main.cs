using System.Windows.Forms;
using GdPicture14;

namespace GdPicture.Sample
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();

			var oLicenceManager = new LicenseManager();
			oLicenceManager.RegisterKEY("");
			cmdLoadPdf.Click += (s, e) => gdViewer1.DisplayFromFile("resources/Fax Fonts.pdf");
			cmdLoadTiff.Click += (s, e) => gdViewer1.DisplayFromFile("resources/Multipage.tiff");
			cmdSaveAsPdf.Click += (s, e) => gdViewer1.SaveDocumentToPDF("resources/newpdf.pdf");
			cmdSaveAsTiff.Click += (s, e) => gdViewer1.SaveDocumentToTIFF("resources/newtiff.tiff", TiffCompression.TiffCompressionAUTO);
		}
	}
}
