using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Atalasoft.Imaging;
using Atalasoft.Imaging.WinControls;
using Atalasoft.Imaging.Codec;
using WinDemoHelperMethods;

namespace FolderThumbs
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private bool _shadowBoxBackground;
		private Atalasoft.Imaging.WinControls.BorderContainer _borderContainer;
		private Atalasoft.Imaging.WinControls.FolderThumbnailView folderThumbnailView1;
		private Atalasoft.Imaging.WinControls.WorkspaceViewer workspaceViewer1;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ToolBar toolBar1;
		private System.Windows.Forms.ToolBarButton tbLoadFolder;
		private System.Windows.Forms.ToolBarButton tbExpand;
		private System.Windows.Forms.ToolBarButton tbSort;
		private System.Windows.Forms.ToolBarButton tbLable;
		private System.Windows.Forms.ToolBarButton tbBackground;
		private System.Windows.Forms.ToolBarButton tbLoadMethod;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ContextMenu menuSort;
		private System.Windows.Forms.MenuItem menuSortNone;
		private System.Windows.Forms.MenuItem menuSortFilename;
		private System.Windows.Forms.MenuItem menuSortModified;
		private System.Windows.Forms.MenuItem menuSortSize;
		private System.Windows.Forms.MenuItem menuSortType;
		private System.Windows.Forms.MenuItem menuSortDisplayName;
		private System.Windows.Forms.ContextMenu menuLabel;
		private System.Windows.Forms.MenuItem menuLabelNone;
		private System.Windows.Forms.MenuItem menuLabelFilename;
		private System.Windows.Forms.MenuItem menuLabelDateModified;
		private System.Windows.Forms.MenuItem menuLabelSize;
		private System.Windows.Forms.MenuItem menuLabelType;
		private System.Windows.Forms.MenuItem menuLabelDisplayName;
		private System.Windows.Forms.ToolBarButton toolBarButton3;
		private System.Windows.Forms.ToolBarButton tbAbout;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.ToolBarButton mySize;
		private System.Windows.Forms.ContextMenu menuSize;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.ContextMenu menuThumbnailBackground;
		private System.Windows.Forms.MenuItem menuBackgroundNone;
		private System.Windows.Forms.MenuItem menuBackgroundShadow;
		private System.Windows.Forms.MenuItem menuItem12;
		private System.Windows.Forms.MenuItem menuBackgroundSelect;
		private System.ComponentModel.IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			HelperMethods.PopulateDecoders(RegisteredDecoders.Decoders);
			this.folderThumbnailView1.ExtensionFilter = HelperMethods.GenerateDecoderSearchPattern();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this._borderContainer = new Atalasoft.Imaging.WinControls.BorderContainer();
			this.folderThumbnailView1 = new Atalasoft.Imaging.WinControls.FolderThumbnailView();
			this.workspaceViewer1 = new Atalasoft.Imaging.WinControls.WorkspaceViewer();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.panel2 = new System.Windows.Forms.Panel();
			this.toolBar1 = new System.Windows.Forms.ToolBar();
			this.tbLoadFolder = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.tbSort = new System.Windows.Forms.ToolBarButton();
			this.menuSort = new System.Windows.Forms.ContextMenu();
			this.menuSortNone = new System.Windows.Forms.MenuItem();
			this.menuSortFilename = new System.Windows.Forms.MenuItem();
			this.menuSortModified = new System.Windows.Forms.MenuItem();
			this.menuSortSize = new System.Windows.Forms.MenuItem();
			this.menuSortType = new System.Windows.Forms.MenuItem();
			this.menuSortDisplayName = new System.Windows.Forms.MenuItem();
			this.tbLable = new System.Windows.Forms.ToolBarButton();
			this.menuLabel = new System.Windows.Forms.ContextMenu();
			this.menuLabelNone = new System.Windows.Forms.MenuItem();
			this.menuLabelFilename = new System.Windows.Forms.MenuItem();
			this.menuLabelDateModified = new System.Windows.Forms.MenuItem();
			this.menuLabelSize = new System.Windows.Forms.MenuItem();
			this.menuLabelType = new System.Windows.Forms.MenuItem();
			this.menuLabelDisplayName = new System.Windows.Forms.MenuItem();
			this.mySize = new System.Windows.Forms.ToolBarButton();
			this.menuSize = new System.Windows.Forms.ContextMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			this.menuItem9 = new System.Windows.Forms.MenuItem();
			this.tbLoadMethod = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
			this.tbExpand = new System.Windows.Forms.ToolBarButton();
			this.tbBackground = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
			this.tbAbout = new System.Windows.Forms.ToolBarButton();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.menuThumbnailBackground = new System.Windows.Forms.ContextMenu();
			this.menuBackgroundNone = new System.Windows.Forms.MenuItem();
			this.menuBackgroundShadow = new System.Windows.Forms.MenuItem();
			this.menuItem12 = new System.Windows.Forms.MenuItem();
			this.menuBackgroundSelect = new System.Windows.Forms.MenuItem();
			this._borderContainer.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// _borderContainer
			// 
			this._borderContainer.Controls.Add(this.folderThumbnailView1);
			this._borderContainer.Dock = System.Windows.Forms.DockStyle.Left;
			this._borderContainer.Location = new System.Drawing.Point(0, 36);
			this._borderContainer.Name = "_borderContainer";
			this._borderContainer.Size = new System.Drawing.Size(168, 322);
			this._borderContainer.TabIndex = 0;
			// 
			// folderThumbnailView1
			// 
			this.folderThumbnailView1.AutoDragDrop = false;
			this.folderThumbnailView1.BackColor = System.Drawing.SystemColors.Window;
			this.folderThumbnailView1.DragDistanceTrigger = 20;
			this.folderThumbnailView1.DragSelectionColor = System.Drawing.Color.Red;
			this.folderThumbnailView1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.folderThumbnailView1.HighlightBackgroundColor = System.Drawing.SystemColors.Highlight;
			this.folderThumbnailView1.HighlightTextColor = System.Drawing.SystemColors.HighlightText;
			this.folderThumbnailView1.LoadErrorMessage = "";
			this.folderThumbnailView1.LoadMethod = Atalasoft.Imaging.WinControls.ThumbLoadMethod.WhenVisible;
			this.folderThumbnailView1.Location = new System.Drawing.Point(2, 2);
			this.folderThumbnailView1.MaxWorkerThreads = 3;
			this.folderThumbnailView1.Name = "folderThumbnailView1";
			this.folderThumbnailView1.SelectionRectangleBackColor = System.Drawing.Color.FromArgb(((System.Byte)(120)), ((System.Byte)(198)), ((System.Byte)(214)), ((System.Byte)(245)));
			this.folderThumbnailView1.SelectionRectangleLineColor = System.Drawing.Color.FromArgb(((System.Byte)(49)), ((System.Byte)(106)), ((System.Byte)(197)));
			this.folderThumbnailView1.Size = new System.Drawing.Size(164, 318);
			this.folderThumbnailView1.TabIndex = 0;
			this.folderThumbnailView1.Text = "folderThumbnailView1";
			this.folderThumbnailView1.ThumbnailBackground = null;
			this.folderThumbnailView1.ThumbnailSize = new System.Drawing.Size(100, 100);
			this.folderThumbnailView1.ThumbnailOffset = new System.Drawing.Point(0, 0);
			this.folderThumbnailView1.ToolTipControl = null;
			this.folderThumbnailView1.SelectedIndexChanged += new System.EventHandler(this.folderThumbnailView1_SelectedIndexChanged);
			this.folderThumbnailView1.FolderLoadProgress += new System.EventHandler(this.folderThumbnailView1_FolderLoadProgress);
			// 
			// workspaceViewer1
			// 
			this.workspaceViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.workspaceViewer1.AntialiasDisplay = Atalasoft.Imaging.WinControls.AntialiasDisplayMode.ScaleToGray;
			this.workspaceViewer1.Asynchronous = true;
			this.workspaceViewer1.DisplayProfile = null;
			this.workspaceViewer1.Location = new System.Drawing.Point(176, 0);
			this.workspaceViewer1.Magnifier.BackColor = System.Drawing.Color.White;
			this.workspaceViewer1.Magnifier.BorderColor = System.Drawing.Color.Black;
			this.workspaceViewer1.Magnifier.Size = new System.Drawing.Size(100, 100);
			this.workspaceViewer1.Name = "workspaceViewer1";
			this.workspaceViewer1.OutputProfile = null;
			this.workspaceViewer1.ScrollPosition = new System.Drawing.Point(0, 0);
			this.workspaceViewer1.Selection = null;
			this.workspaceViewer1.Size = new System.Drawing.Size(464, 318);
			this.workspaceViewer1.TabIndex = 1;
			this.workspaceViewer1.Text = "workspaceViewer1";
			// 
			// progressBar1
			// 
			this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.progressBar1.Location = new System.Drawing.Point(0, 358);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(648, 16);
			this.progressBar1.TabIndex = 3;
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.workspaceViewer1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 36);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(648, 322);
			this.panel2.TabIndex = 4;
			// 
			// toolBar1
			// 
			this.toolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																						this.tbLoadFolder,
																						this.toolBarButton1,
																						this.tbSort,
																						this.tbLable,
																						this.mySize,
																						this.tbLoadMethod,
																						this.toolBarButton2,
																						this.tbExpand,
																						this.tbBackground,
																						this.toolBarButton3,
																						this.tbAbout});
			this.toolBar1.DropDownArrows = true;
			this.toolBar1.ImageList = this.imageList1;
			this.toolBar1.Location = new System.Drawing.Point(0, 0);
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.ShowToolTips = true;
			this.toolBar1.Size = new System.Drawing.Size(648, 36);
			this.toolBar1.TabIndex = 5;
			this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
			// 
			// tbLoadFolder
			// 
			this.tbLoadFolder.ImageIndex = 4;
			this.tbLoadFolder.ToolTipText = "Load Folder";
			// 
			// toolBarButton1
			// 
			this.toolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbSort
			// 
			this.tbSort.DropDownMenu = this.menuSort;
			this.tbSort.ImageIndex = 5;
			this.tbSort.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
			this.tbSort.ToolTipText = "Sort";
			// 
			// menuSort
			// 
			this.menuSort.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuSortNone,
																					 this.menuSortFilename,
																					 this.menuSortModified,
																					 this.menuSortSize,
																					 this.menuSortType,
																					 this.menuSortDisplayName});
			// 
			// menuSortNone
			// 
			this.menuSortNone.Index = 0;
			this.menuSortNone.Text = "None";
			this.menuSortNone.Click += new System.EventHandler(this.menuSortNone_Click);
			// 
			// menuSortFilename
			// 
			this.menuSortFilename.Index = 1;
			this.menuSortFilename.Text = "Filename";
			this.menuSortFilename.Click += new System.EventHandler(this.menuSortFilename_Click);
			// 
			// menuSortModified
			// 
			this.menuSortModified.Index = 2;
			this.menuSortModified.Text = "Date Modified";
			this.menuSortModified.Click += new System.EventHandler(this.menuSortModified_Click);
			// 
			// menuSortSize
			// 
			this.menuSortSize.Index = 3;
			this.menuSortSize.Text = "Size";
			this.menuSortSize.Click += new System.EventHandler(this.menuSortSize_Click);
			// 
			// menuSortType
			// 
			this.menuSortType.Index = 4;
			this.menuSortType.Text = "Type";
			this.menuSortType.Click += new System.EventHandler(this.menuSortType_Click);
			// 
			// menuSortDisplayName
			// 
			this.menuSortDisplayName.Index = 5;
			this.menuSortDisplayName.Text = "Display Name";
			this.menuSortDisplayName.Click += new System.EventHandler(this.menuSortDisplayName_Click);
			// 
			// tbLable
			// 
			this.tbLable.DropDownMenu = this.menuLabel;
			this.tbLable.ImageIndex = 0;
			this.tbLable.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
			this.tbLable.ToolTipText = "Label";
			// 
			// menuLabel
			// 
			this.menuLabel.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuLabelNone,
																					  this.menuLabelFilename,
																					  this.menuLabelDateModified,
																					  this.menuLabelSize,
																					  this.menuLabelType,
																					  this.menuLabelDisplayName});
			// 
			// menuLabelNone
			// 
			this.menuLabelNone.Index = 0;
			this.menuLabelNone.Text = "None";
			this.menuLabelNone.Click += new System.EventHandler(this.menuLabelNone_Click);
			// 
			// menuLabelFilename
			// 
			this.menuLabelFilename.Index = 1;
			this.menuLabelFilename.Text = "Filename";
			this.menuLabelFilename.Click += new System.EventHandler(this.menuLabelFilename_Click);
			// 
			// menuLabelDateModified
			// 
			this.menuLabelDateModified.Index = 2;
			this.menuLabelDateModified.Text = "Date Modified";
			this.menuLabelDateModified.Click += new System.EventHandler(this.menuLabelDateModified_Click);
			// 
			// menuLabelSize
			// 
			this.menuLabelSize.Index = 3;
			this.menuLabelSize.Text = "Size";
			this.menuLabelSize.Click += new System.EventHandler(this.menuLabelSize_Click);
			// 
			// menuLabelType
			// 
			this.menuLabelType.Index = 4;
			this.menuLabelType.Text = "Type";
			this.menuLabelType.Click += new System.EventHandler(this.menuLabelType_Click);
			// 
			// menuLabelDisplayName
			// 
			this.menuLabelDisplayName.Index = 5;
			this.menuLabelDisplayName.Text = "Display Name";
			this.menuLabelDisplayName.Click += new System.EventHandler(this.menuLabelDisplayName_Click);
			// 
			// mySize
			// 
			this.mySize.DropDownMenu = this.menuSize;
			this.mySize.ImageIndex = 8;
			this.mySize.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
			// 
			// menuSize
			// 
			this.menuSize.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuItem1,
																					 this.menuItem2,
																					 this.menuItem3,
																					 this.menuItem4,
																					 this.menuItem5,
																					 this.menuItem6,
																					 this.menuItem7,
																					 this.menuItem8,
																					 this.menuItem9});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.Text = "24 x 24";
			this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 1;
			this.menuItem2.Text = "36 x 36";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 2;
			this.menuItem3.Text = "48 x 48";
			this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 3;
			this.menuItem4.Text = "100 x 100";
			this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 4;
			this.menuItem5.Text = "128 x 128";
			this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 5;
			this.menuItem6.Text = "255 x 255";
			this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 6;
			this.menuItem7.Text = "512 x 512";
			this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
			// 
			// menuItem8
			// 
			this.menuItem8.Index = 7;
			this.menuItem8.Text = "1024 x1024";
			this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
			// 
			// menuItem9
			// 
			this.menuItem9.Index = 8;
			this.menuItem9.Text = "2048 x 2048";
			this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
			// 
			// tbLoadMethod
			// 
			this.tbLoadMethod.ImageIndex = 6;
			this.tbLoadMethod.Pushed = true;
			this.tbLoadMethod.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
			this.tbLoadMethod.ToolTipText = "Load When Visible";
			// 
			// toolBarButton2
			// 
			this.toolBarButton2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbExpand
			// 
			this.tbExpand.ImageIndex = 2;
			this.tbExpand.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
			this.tbExpand.ToolTipText = "Expand Thumbnails";
			// 
			// tbBackground
			// 
			this.tbBackground.DropDownMenu = this.menuThumbnailBackground;
			this.tbBackground.ImageIndex = 1;
			this.tbBackground.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
			this.tbBackground.ToolTipText = "Use Thumbnail Background";
			// 
			// toolBarButton3
			// 
			this.toolBarButton3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbAbout
			// 
			this.tbAbout.ImageIndex = 7;
			this.tbAbout.ToolTipText = "About...";
			// 
			// imageList1
			// 
			this.imageList1.ImageSize = new System.Drawing.Size(24, 24);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Fuchsia;
			// 
			// menuThumbnailBackground
			// 
			this.menuThumbnailBackground.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																									this.menuBackgroundNone,
																									this.menuBackgroundShadow,
																									this.menuItem12,
																									this.menuBackgroundSelect});
			// 
			// menuBackgroundNone
			// 
			this.menuBackgroundNone.Index = 0;
			this.menuBackgroundNone.Text = "None";
			this.menuBackgroundNone.Click += new System.EventHandler(this.menuBackgroundNone_Click);
			// 
			// menuBackgroundShadow
			// 
			this.menuBackgroundShadow.Index = 1;
			this.menuBackgroundShadow.Text = "Shadow Box";
			this.menuBackgroundShadow.Click += new System.EventHandler(this.menuBackgroundShadow_Click);
			// 
			// menuItem12
			// 
			this.menuItem12.Index = 2;
			this.menuItem12.Text = "-";
			// 
			// menuBackgroundSelect
			// 
			this.menuBackgroundSelect.Index = 3;
			this.menuBackgroundSelect.Text = "Select...";
			this.menuBackgroundSelect.Click += new System.EventHandler(this.menuBackgroundSelect_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(648, 374);
			this.Controls.Add(this._borderContainer);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.toolBar1);
			this.Name = "Form1";
			this.Text = "Folder Thumbnail Demo";
			this._borderContainer.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void LoadFolder()
		{
			if (this.folderBrowserDialog1.ShowDialog(this) == DialogResult.OK)
			{
				//clear progress
				this.progressBar1.Value = 0;
				//get number of images for progress
				this.progressBar1.Maximum = this.folderThumbnailView1.GetFolderImageCount(this.folderBrowserDialog1.SelectedPath);
				//start loading thumbnails
				this.folderThumbnailView1.ImageFolder = this.folderBrowserDialog1.SelectedPath;
			}
		}

		private void folderThumbnailView1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (this.folderThumbnailView1.FocusedItem != null)
			{
				this.workspaceViewer1.Open(this.folderThumbnailView1.FocusedItem.FilePath);
			}
		}

		private void folderThumbnailView1_FolderLoadProgress(object sender, System.EventArgs e)
		{
			this.progressBar1.Increment(1);
			if (this.progressBar1.Value == this.progressBar1.Maximum)
				this.progressBar1.Value = 0;
		}

		private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch (e.Button.ToolTipText)
			{
				case "About...":
					AtalaDemos.AboutBox.About aboutBox = new AtalaDemos.AboutBox.About("About Atalasoft Folder Thumbs Demo",
						"Folder Thumbs Demo");
					aboutBox.Description = @"The FolderThumbnailView is a control (derived from the ThumbnailView class) that will display images in a directory as thumbnails.  This is useful for displaying the contents of a directory on disk.  The demo shows how the thumbnails can be resized, reordered, and used to show a larger version of the image in the viewer.  A background image may also be added to the thumbnails, along with many other features available in the thumbnail control.";
					aboutBox.ShowDialog();
					break;
				case "Load Folder":
					LoadFolder();
					break;
				case "Expand Thumbnails":
					if (e.Button.Pushed)
						this._borderContainer.Dock = DockStyle.Fill;
					else
						this._borderContainer.Dock = DockStyle.Left;
					break;
				case "Load When Visible":
					this.folderThumbnailView1.LoadMethod = (e.Button.Pushed ? ThumbLoadMethod.WhenVisible : ThumbLoadMethod.EntireFolder);
					break;
			}
		}

		#region Change Thumbnail Sorting

		private void menuSortNone_Click(object sender, System.EventArgs e)
		{
			this.folderThumbnailView1.SortBy = ThumbViewAttribute.None;
		}

		private void menuSortFilename_Click(object sender, System.EventArgs e)
		{
			this.folderThumbnailView1.SortBy = ThumbViewAttribute.FileName;
		}

		private void menuSortModified_Click(object sender, System.EventArgs e)
		{
			this.folderThumbnailView1.SortBy = ThumbViewAttribute.DateModified;
		}

		private void menuSortSize_Click(object sender, System.EventArgs e)
		{
			this.folderThumbnailView1.SortBy = ThumbViewAttribute.Size;
		}

		private void menuSortType_Click(object sender, System.EventArgs e)
		{
			this.folderThumbnailView1.SortBy = ThumbViewAttribute.Type;
		}

		private void menuSortDisplayName_Click(object sender, System.EventArgs e)
		{
			this.folderThumbnailView1.SortBy = ThumbViewAttribute.DisplayName;
		}

		#endregion

		#region Change Thumbnail Label

		private void menuLabelDisplayName_Click(object sender, System.EventArgs e)
		{
			this.folderThumbnailView1.DisplayText = ThumbViewAttribute.DisplayName;
		}

		private void menuLabelType_Click(object sender, System.EventArgs e)
		{
			this.folderThumbnailView1.DisplayText = ThumbViewAttribute.Type;
		}

		private void menuLabelSize_Click(object sender, System.EventArgs e)
		{
			this.folderThumbnailView1.DisplayText = ThumbViewAttribute.Size;
		}

		private void menuLabelDateModified_Click(object sender, System.EventArgs e)
		{
			this.folderThumbnailView1.DisplayText = ThumbViewAttribute.DateModified;
		}

		private void menuLabelFilename_Click(object sender, System.EventArgs e)
		{
			this.folderThumbnailView1.DisplayText = ThumbViewAttribute.FileName;
		}

		private void menuLabelNone_Click(object sender, System.EventArgs e)
		{
			this.folderThumbnailView1.DisplayText = ThumbViewAttribute.None;
		}

		#endregion

		#region Change Thumbnail Size

		private void menuItem1_Click(object sender, System.EventArgs e)
		{
			if (this.folderThumbnailView1.ThumbnailSize.Width == 24)
				return;

			this.progressBar1.Value = 0;
			if (this._shadowBoxBackground)
				this.CreateShadowBackground(24);
			else
				this.folderThumbnailView1.ThumbnailSize = new Size(24,24);
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			if (this.folderThumbnailView1.ThumbnailSize.Width == 36)
				return;

			this.progressBar1.Value = 0;
			if (this._shadowBoxBackground)
				this.CreateShadowBackground(36);
			else
				this.folderThumbnailView1.ThumbnailSize = new Size(36,36);
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			if (this.folderThumbnailView1.ThumbnailSize.Width == 48)
				return;

			this.progressBar1.Value = 0;
			if (this._shadowBoxBackground)
				this.CreateShadowBackground(48);
			else
				this.folderThumbnailView1.ThumbnailSize = new Size(48,48);
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			if (this.folderThumbnailView1.ThumbnailSize.Width == 100)
				return;

			this.progressBar1.Value = 0;
			if (this._shadowBoxBackground)
				this.CreateShadowBackground(100);
			else
				this.folderThumbnailView1.ThumbnailSize = new Size(100,100);
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			if (this.folderThumbnailView1.ThumbnailSize.Width == 128)
				return;

			this.progressBar1.Value = 0;
			if (this._shadowBoxBackground)
				this.CreateShadowBackground(128);
			else
				this.folderThumbnailView1.ThumbnailSize = new Size(128,128);
		}

		private void menuItem6_Click(object sender, System.EventArgs e)
		{
			if (this.folderThumbnailView1.ThumbnailSize.Width == 255)
				return;

			this.progressBar1.Value = 0;
			if (this._shadowBoxBackground)
				this.CreateShadowBackground(255);
			else
				this.folderThumbnailView1.ThumbnailSize = new Size(255,255);
		}

		private void menuItem7_Click(object sender, System.EventArgs e)
		{
			if (this.folderThumbnailView1.ThumbnailSize.Width == 512)
				return;

			this.progressBar1.Value = 0;
			if (this._shadowBoxBackground)
				this.CreateShadowBackground(512);
			else
				this.folderThumbnailView1.ThumbnailSize = new Size(512,512);
		}

		private void menuItem8_Click(object sender, System.EventArgs e)
		{
			if (this.folderThumbnailView1.ThumbnailSize.Width == 1024)
				return;

			this.progressBar1.Value = 0;
			if (this._shadowBoxBackground)
				this.CreateShadowBackground(1024);
			else
				this.folderThumbnailView1.ThumbnailSize = new Size(1024,1024);
		}

		private void menuItem9_Click(object sender, System.EventArgs e)
		{
			if (this.folderThumbnailView1.ThumbnailSize.Width == 2048)
				return;

			this.progressBar1.Value = 0;
			if (this._shadowBoxBackground)
				this.CreateShadowBackground(2048);
			else
				this.folderThumbnailView1.ThumbnailSize = new Size(2048,2048);
		}

		#endregion

		#region Change Thumbnail Background

		private void menuBackgroundNone_Click(object sender, System.EventArgs e)
		{
			this.folderThumbnailView1.SuspendLayout();
			this.folderThumbnailView1.ThumbnailBackground = null;
			this.folderThumbnailView1.CaptionSpacing = 4;
			this.folderThumbnailView1.Spacing = 8;
			this.folderThumbnailView1.ThumbnailOffset = Point.Empty;
			this.folderThumbnailView1.ResumeLayout(true);
		}

		private void menuBackgroundShadow_Click(object sender, System.EventArgs e)
		{
			CreateShadowBackground(this.folderThumbnailView1.ThumbnailSize.Width);
		}

		private void CreateShadowBackground(int thumbnailSize)
		{
			this._shadowBoxBackground = true;

			// Create a nice drop shadow background.
			AtalaImage tmpImage = new AtalaImage(thumbnailSize + 10, thumbnailSize + 10, PixelFormat.Pixel32bppBgra, Color.FromArgb(0, Color.Fuchsia));
			Atalasoft.Imaging.Drawing.Canvas c = new Atalasoft.Imaging.Drawing.Canvas(tmpImage);
			c.DrawRectangle(new Rectangle(0, 0, tmpImage.Width - 6, tmpImage.Height - 6), new Atalasoft.Imaging.Drawing.AtalaPen(Color.Black), new Atalasoft.Imaging.Drawing.SolidFill(Color.White));
			Atalasoft.Imaging.ImageProcessing.Effects.DropShadowCommand shadow = new Atalasoft.Imaging.ImageProcessing.Effects.DropShadowCommand(new Point(3, 3), Color.FromArgb(120, 0, 0, 0), 2, false);
			AtalaImage result = shadow.Apply(tmpImage).Image;
			tmpImage.Dispose();

			this.folderThumbnailView1.SuspendLayout();
			this.folderThumbnailView1.ThumbnailOffset = new Point(2, 2);
			this.folderThumbnailView1.CaptionSpacing = 12;
			this.folderThumbnailView1.Spacing = 14;
			this.folderThumbnailView1.SelectedItemStyle = SelectedItemRenderStyle.DefaultAboveBackground;
			this.folderThumbnailView1.ThumbnailBackground = result.ToBitmap();
			result.Dispose();
			this.folderThumbnailView1.ThumbnailSize = new Size(thumbnailSize, thumbnailSize);
			this.folderThumbnailView1.ResumeLayout(true);
		}

		private void menuBackgroundSelect_Click(object sender, System.EventArgs e)
		{
			if (this.openFileDialog1.ShowDialog(this) == DialogResult.OK)
				this.folderThumbnailView1.ThumbnailBackground = Image.FromFile(this.openFileDialog1.FileName);
		}

		#endregion
	}
}
