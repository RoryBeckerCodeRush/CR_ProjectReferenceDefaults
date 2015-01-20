using System.ComponentModel.Composition;
using DevExpress.CodeRush.Common;

namespace CR_ProjectReferenceDefaults
{
  [Export(typeof(IVsixPluginExtension))]
  public class CR_ProjectReferenceDefaultsExtension : IVsixPluginExtension { }
}