using System;
using DevExpress.CodeRush.Core;

namespace CR_ProjectReferenceDefaults
{
	public static class Extensions
	{
		// private static methods...
		#region GetReference3
		private static VSLangProj80.Reference3 GetReference3(Reference reference)
		{
			VSLangProj80.Reference3 foundReference = null;
			EnvDTE.Project dteProject = CodeRush.Solution.FindEnvDTEProject(reference.Project.Name);
			if (dteProject != null)
			{
				VSLangProj.VSProject vsProject = dteProject.Object as VSLangProj.VSProject;
				foundReference = vsProject.References.Find(reference.Name) as VSLangProj80.Reference3;
			}
			return foundReference;
		}
		#endregion

		// public static methods...
		#region SetSpecificVersion
		public static void SetSpecificVersion(this Reference reference, bool specificVersion)
		{
			VSLangProj80.Reference3 reference3 = GetReference3(reference);
			if (reference3 == null)
				return;

			reference3.SpecificVersion = specificVersion;
		}
		#endregion
		#region GetSpecificVersion
		/// <summary>
		/// Gets the value of the SpecificVersion property of the specified reference.
		/// Note: This method can throw a null ref exception if specified reference does 
		/// not represent a VSLangProj80.Reference3 instance. You can call HasReference3
		/// to determine if this reference represents a VSLangProj80.Reference3.
		/// </summary>
		public static bool GetSpecificVersion(this Reference reference)
		{
			VSLangProj80.Reference3 reference3 = GetReference3(reference);
			return reference3.SpecificVersion;
		}
		#endregion
		#region HasReference3
		/// <summary>
		/// Returns true if the specified Reference corresponds to a 
		/// VSLangProj80.Reference3 instance.
		/// </summary>
		public static bool HasReference3(this Reference reference)
		{
			return GetReference3(reference) != null;
		}
		#endregion
	}
}
