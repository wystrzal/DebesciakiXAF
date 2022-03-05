using DevExpress.Persistent.Base;
using DevExpress.Xpo;

namespace GUS.Module.BusinessObjects
{
    [NavigationItem("GUS")]
    [DefaultClassOptions]
    public class BasicLegalForm : GusBaseObject
    {
        public BasicLegalForm(Session session) : base(session) { }
    }
}
