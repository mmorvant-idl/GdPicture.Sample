namespace GdPicture.Sample
{
	partial class Main
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdLoadPdf = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gdViewer1 = new GdPicture14.GdViewer();
            this.cmdLoadTiff = new System.Windows.Forms.Button();
            this.cmdSaveAsTiff = new System.Windows.Forms.Button();
            this.cmdSaveAsPdf = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmdSaveAsPdf);
            this.panel1.Controls.Add(this.cmdSaveAsTiff);
            this.panel1.Controls.Add(this.cmdLoadTiff);
            this.panel1.Controls.Add(this.cmdLoadPdf);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 450);
            this.panel1.TabIndex = 0;
            // 
            // cmdLoadPdf
            // 
            this.cmdLoadPdf.Location = new System.Drawing.Point(3, 26);
            this.cmdLoadPdf.Name = "cmdLoadPdf";
            this.cmdLoadPdf.Size = new System.Drawing.Size(121, 23);
            this.cmdLoadPdf.TabIndex = 0;
            this.cmdLoadPdf.Text = "Load PDF";
            this.cmdLoadPdf.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gdViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(127, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(673, 450);
            this.panel2.TabIndex = 1;
            // 
            // gdViewer1
            // 
            this.gdViewer1.AllowDropFile = false;
            this.gdViewer1.AnimateGIF = true;
            this.gdViewer1.AnnotationDropShadow = true;
            this.gdViewer1.AnnotationEnableMultiSelect = true;
            this.gdViewer1.AnnotationResizeRotateHandlesColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.gdViewer1.AnnotationResizeRotateHandlesScale = 1F;
            this.gdViewer1.AnnotationSelectionLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gdViewer1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.gdViewer1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.gdViewer1.BackColor = System.Drawing.Color.Black;
            this.gdViewer1.BackgroundImage = null;
            this.gdViewer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gdViewer1.ClipAnnotsToPageBounds = true;
            this.gdViewer1.ClipRegionsToPageBounds = true;
            this.gdViewer1.ContinuousViewMode = true;
            this.gdViewer1.DisplayQuality = GdPicture14.DisplayQuality.DisplayQualityAutomatic;
            this.gdViewer1.DisplayQualityAuto = true;
            this.gdViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdViewer1.DocumentAlignment = GdPicture14.ViewerDocumentAlignment.DocumentAlignmentMiddleCenter;
            this.gdViewer1.DocumentPosition = GdPicture14.ViewerDocumentPosition.DocumentPositionMiddleCenter;
            this.gdViewer1.DrawPageBorders = true;
            this.gdViewer1.EnableDeferredPainting = true;
            this.gdViewer1.EnabledProgressBar = true;
            this.gdViewer1.EnableFuzzySearch = false;
            this.gdViewer1.EnableICM = false;
            this.gdViewer1.EnableMenu = true;
            this.gdViewer1.EnableMouseWheel = true;
            this.gdViewer1.EnableTextSelection = true;
            this.gdViewer1.ForceScrollBars = false;
            this.gdViewer1.ForceTemporaryMode = false;
            this.gdViewer1.ForeColor = System.Drawing.Color.Black;
            this.gdViewer1.Gamma = 1F;
            this.gdViewer1.HQAnnotationRendering = true;
            this.gdViewer1.IgnoreDocumentResolution = false;
            this.gdViewer1.KeepDocumentPosition = false;
            this.gdViewer1.Location = new System.Drawing.Point(0, 0);
            this.gdViewer1.LockViewer = false;
            this.gdViewer1.MagnifierHeight = 90;
            this.gdViewer1.MagnifierWidth = 160;
            this.gdViewer1.MagnifierZoomX = 2F;
            this.gdViewer1.MagnifierZoomY = 2F;
            this.gdViewer1.MouseButtonForMouseMode = GdPicture14.MouseButton.MouseButtonLeft;
            this.gdViewer1.MouseMode = GdPicture14.ViewerMouseMode.MouseModePan;
            this.gdViewer1.MouseWheelMode = GdPicture14.ViewerMouseWheelMode.MouseWheelModeZoom;
            this.gdViewer1.Name = "gdViewer1";
            this.gdViewer1.PageBordersColor = System.Drawing.Color.Black;
            this.gdViewer1.PageBordersPenSize = 1;
            this.gdViewer1.PageDisplayMode = GdPicture14.PageDisplayMode.MultiplePagesView;
            this.gdViewer1.PdfDisplayFormField = true;
            this.gdViewer1.PdfEnableFileLinks = true;
            this.gdViewer1.PdfEnableLinks = true;
            this.gdViewer1.PdfIncreaseTextContrast = false;
            this.gdViewer1.PdfShowDialogForPassword = true;
            this.gdViewer1.PdfShowOpenFileDialogForDecryption = true;
            this.gdViewer1.PdfVerifyDigitalCertificates = false;
            this.gdViewer1.PreserveViewRotation = true;
            this.gdViewer1.RectBorderColor = System.Drawing.Color.Black;
            this.gdViewer1.RectBorderSize = 1;
            this.gdViewer1.RectIsEditable = true;
            this.gdViewer1.RegionsAreEditable = true;
            this.gdViewer1.RenderGdPictureAnnots = true;
            this.gdViewer1.ScrollBars = true;
            this.gdViewer1.ScrollLargeChange = ((short)(50));
            this.gdViewer1.ScrollSmallChange = ((short)(1));
            this.gdViewer1.SilentMode = true;
            this.gdViewer1.Size = new System.Drawing.Size(673, 450);
            this.gdViewer1.TabIndex = 0;
            this.gdViewer1.ViewRotation = System.Drawing.RotateFlipType.RotateNoneFlipNone;
            this.gdViewer1.Zoom = 1D;
            this.gdViewer1.ZoomCenterAtMousePosition = false;
            this.gdViewer1.ZoomMode = GdPicture14.ViewerZoomMode.ZoomMode100;
            this.gdViewer1.ZoomStep = 25;
            // 
            // cmdLoadTiff
            // 
            this.cmdLoadTiff.Location = new System.Drawing.Point(0, 55);
            this.cmdLoadTiff.Name = "cmdLoadTiff";
            this.cmdLoadTiff.Size = new System.Drawing.Size(121, 23);
            this.cmdLoadTiff.TabIndex = 0;
            this.cmdLoadTiff.Text = "Load TIFF";
            this.cmdLoadTiff.UseVisualStyleBackColor = true;
            // 
            // cmdSaveAsTiff
            // 
            this.cmdSaveAsTiff.Location = new System.Drawing.Point(0, 84);
            this.cmdSaveAsTiff.Name = "cmdSaveAsTiff";
            this.cmdSaveAsTiff.Size = new System.Drawing.Size(121, 23);
            this.cmdSaveAsTiff.TabIndex = 0;
            this.cmdSaveAsTiff.Text = "Save as Tiff";
            this.cmdSaveAsTiff.UseVisualStyleBackColor = true;
            // 
            // cmdSaveAsPdf
            // 
            this.cmdSaveAsPdf.Location = new System.Drawing.Point(0, 113);
            this.cmdSaveAsPdf.Name = "cmdSaveAsPdf";
            this.cmdSaveAsPdf.Size = new System.Drawing.Size(121, 23);
            this.cmdSaveAsPdf.TabIndex = 0;
            this.cmdSaveAsPdf.Text = "Save as PDF";
            this.cmdSaveAsPdf.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button cmdLoadPdf;
		private System.Windows.Forms.Panel panel2;
		private GdPicture14.GdViewer gdViewer1;
		private System.Windows.Forms.Button cmdSaveAsTiff;
		private System.Windows.Forms.Button cmdLoadTiff;
		private System.Windows.Forms.Button cmdSaveAsPdf;
	}
}
