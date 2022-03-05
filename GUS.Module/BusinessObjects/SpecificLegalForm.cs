using DevExpress.Persistent.Base;
using DevExpress.Xpo;

namespace GUS.Module.BusinessObjects
{
    [NavigationItem("GUS")]
    [DefaultClassOptions]
    public class SpecificLegalForm : GusBaseObject
    {
        public SpecificLegalForm(Session session) : base(session) { }     
    }
}