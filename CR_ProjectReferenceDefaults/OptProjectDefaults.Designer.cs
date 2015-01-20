using System;
using DevExpress.CodeRush.Core;

namespace CR_ProjectReferenceDefaults
{
	partial class OptProjectDefaults
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		public OptProjectDefaults()
		{
			/// <summary>
			/// Required for Windows.Forms Class Composition Designer support
			/// </summary>
			InitializeComponent();
		}

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
			this.chkCopyLocal = new System.Windows.Forms.CheckBox();
			this.chkSpecificVersion = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			this.SuspendLayout();
			// 
			// chkCopyLocal
			// 
			this.chkCopyLocal.AutoSize = true;
			this.chkCopyLocal.Location = new System.Drawing.Point(18, 35);
			this.chkCopyLocal.Name = "chkCopyLocal";
			this.chkCopyLocal.Size = new System.Drawing.Size(75, 17);
			this.chkCopyLocal.TabIndex = 2;
			this.chkCopyLocal.Text = "CopyLocal";
			this.chkCopyLocal.ThreeState = true;
			this.chkCopyLocal.UseVisualStyleBackColor = true;
			this.chkCopyLocal.CheckStateChanged += new System.EventHandler(this.chkCopyLocal_CheckStateChanged);
			// 
			// chkSpecificVersion
			// 
			this.chkSpecificVersion.AutoSize = true;
			this.chkSpecificVersion.Location = new System.Drawing.Point(18, 58);
			this.chkSpecificVersion.Name = "chkSpecificVersion";
			this.chkSpecificVersion.Size = new System.Drawing.Size(97, 17);
			this.chkSpecificVersion.TabIndex = 3;
			this.chkSpecificVersion.Text = "SpecificVersion";
			this.chkSpecificVersion.ThreeState = true;
			this.chkSpecificVersion.UseVisualStyleBackColor = true;
			this.chkSpecificVersion.CheckStateChanged += new System.EventHandler(this.chkCopyLocal_CheckStateChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(394, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "This page controls default property settings for newly added project references.";
			// 
			// OptProjectDefaults
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.chkCopyLocal);
			this.Controls.Add(this.chkSpecificVersion);
			this.Name = "OptProjectDefaults";
			this.CommitChanges += new DevExpress.CodeRush.Core.OptionsPage.CommitChangesEventHandler(this.OptProjectDefaults_CommitChanges);
			this.PreparePage += new DevExpress.CodeRush.Core.OptionsPage.PreparePageEventHandler(this.OptProjectDefaults_PreparePage);
			this.RestoreDefaults += new DevExpress.CodeRush.Core.OptionsPage.RestoreDefaultsEventHandler(this.OptProjectDefaults_RestoreDefaults);
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		///
		/// Gets a DecoupledStorage instance for this options page.
		///
		public static DecoupledStorage Storage
		{
			get
			{
				return DevExpress.CodeRush.Core.CodeRush.Options.GetStorage(GetCategory(), GetPageName());
			}
		}
		///
		/// Returns the category of this options page.
		///
		public override string Category
		{
			get
			{
				return OptProjectDefaults.GetCategory();
			}
		}
		///
		/// Returns the page name of this options page.
		///
		public override string PageName
		{
			get
			{
				return OptProjectDefaults.GetPageName();
			}
		}
		///
		/// Returns the full path (Category + PageName) of this options page.
		///
		public static string FullPath
		{
			get
			{
				return GetCategory() + "\\" + GetPageName();
			}
		}

		///
		/// Displays the DXCore options dialog and selects this page.
		///
		public new static void Show()
		{
			DevExpress.CodeRush.Core.CodeRush.Command.Execute("Options", FullPath);
		}

		private System.Windows.Forms.CheckBox chkCopyLocal;
		private System.Windows.Forms.CheckBox chkSpecificVersion;
		private System.Windows.Forms.Label label2;
	}
}