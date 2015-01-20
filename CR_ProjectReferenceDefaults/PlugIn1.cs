using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.CodeRush.Core;
using DevExpress.CodeRush.PlugInCore;
using DevExpress.CodeRush.StructuralParser;

namespace CR_ProjectReferenceDefaults
{
	public partial class PlugIn1 : StandardPlugIn
	{
		private bool? _CopyLocal;
		private bool? _SpecificVersion;
    // DXCore-generated code...
		#region InitializePlugIn
		public override void InitializePlugIn()
		{
			base.InitializePlugIn();
			LoadSettings();
		}
		#endregion
		#region FinalizePlugIn
		public override void FinalizePlugIn()
		{
			//
			// TODO: Add your finalization code here.
			//

			base.FinalizePlugIn();
		}
		#endregion

		private void PlugIn1_ReferenceAdded(ReferenceEventArgs ea)
		{
			Reference reference = ea.Reference;

			string result = String.Empty;
			if (_CopyLocal.HasValue && reference.CopyLocal != _CopyLocal.Value)
			{
				reference.CopyLocal = _CopyLocal.Value;
				result += String.Format("CopyLocal set to {0}, ", _CopyLocal.Value);
			}

			if (_SpecificVersion.HasValue && reference.HasReference3() && reference.GetSpecificVersion() != _SpecificVersion.Value)
			{
				reference.SetSpecificVersion(_SpecificVersion.Value);
				result += String.Format("SpecificVersion set to {0}, ", _SpecificVersion.Value);
			}

			if (result == String.Empty)
				return;

			if (result.EndsWith(", "))
				result = result.Remove(result.Length - 2);

			// TODO: Consider playing a small sound notification here.
			CodeRush.ApplicationObject.StatusBar.Text = String.Format("{0}: {1}.", reference.Name, result);
		}

		private static bool? GetStoredState(DecoupledStorage storage, string propertyName)
		{
			CheckState checkState = storage.ReadEnum<CheckState>("ProjectDefaults", propertyName, CheckState.Indeterminate);
			if (checkState == CheckState.Checked)
				return true;
			else if (checkState == CheckState.Unchecked)
				return false;
			else
				return null;
		}

		private void LoadSettings()
		{
			DecoupledStorage storage = OptProjectDefaults.Storage;
			_CopyLocal = GetStoredState(storage, "CopyLocal");
			_SpecificVersion = GetStoredState(storage, "SpecificVersion");
		}

		private void PlugIn1_OptionsChanged(OptionsChangedEventArgs ea)
		{
			if (!ea.OptionsPages.Contains(typeof(OptProjectDefaults)))
				return;

			LoadSettings();
		}
	}
}