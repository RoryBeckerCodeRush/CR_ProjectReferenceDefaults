using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.CodeRush.Core;

namespace CR_ProjectReferenceDefaults
{
	[UserLevel(UserLevel.NewUser)]
	public partial class OptProjectDefaults : OptionsPage
	{
		private const string STR_StatusDelimiter = " - ";
		// DXCore-generated code...
		#region Initialize
		protected override void Initialize()
		{
			base.Initialize();
			RestoreDefaultSettings();
		}
		#endregion

		#region GetCategory
		public static string GetCategory()
		{
			return @"Project";
		}
		#endregion
		#region GetPageName
		public static string GetPageName()
		{
			return @"Default Reference Properties";
		}
		#endregion

		private void OptProjectDefaults_CommitChanges(object sender, CommitChangesEventArgs ea)
		{
			ea.Storage.WriteEnum("ProjectDefaults", "SpecificVersion", chkSpecificVersion.CheckState);
			ea.Storage.WriteEnum("ProjectDefaults", "CopyLocal", chkCopyLocal.CheckState);
		}

		private void OptProjectDefaults_PreparePage(object sender, OptionsPageStorageEventArgs ea)
		{
			DecoupledStorage storage = ea.Storage;
			chkSpecificVersion.CheckState = storage.ReadEnum<CheckState>("ProjectDefaults", "SpecificVersion", CheckState.Indeterminate);
			chkCopyLocal.CheckState = storage.ReadEnum<CheckState>("ProjectDefaults", "CopyLocal", CheckState.Indeterminate);
		}

		private void RestoreDefaultSettings()
		{
			chkSpecificVersion.CheckState = CheckState.Indeterminate;
			chkCopyLocal.CheckState = CheckState.Indeterminate;
		}
		private void OptProjectDefaults_RestoreDefaults(object sender, OptionsPageEventArgs ea)
		{
			RestoreDefaultSettings();
		}

		private void chkCopyLocal_CheckStateChanged(object sender, EventArgs e)
		{
			CheckBox checkBox = sender as CheckBox;
			if (checkBox == null)
				return;
			string text = checkBox.Text;
			int dashIndex = text.IndexOf(STR_StatusDelimiter);
			if (dashIndex >= 0)
				text = text.Remove(dashIndex);

			switch (checkBox.CheckState)
			{
				case CheckState.Checked:
					text += STR_StatusDelimiter + "(will be set to true)";
					break;
				case CheckState.Indeterminate:
					text += STR_StatusDelimiter + "(will not be changed)";
					break;
				case CheckState.Unchecked:
					text += STR_StatusDelimiter + "(will be set to false)";
					break;
			}
			checkBox.Text = text;
		}
	}
}