using DevExpress.Persistent.Base;
using DevExpress.Xpo;

namespace GUS.Module.BusinessObjects
{
    [NavigationItem("GUS")]
    [DefaultClassOptions]
    public class FoundingBody : GusBaseObject
    {
        public FoundingBody(Session session) : base(session) { }
    }
}
