using DevExpress.Persistent.Base;
using DevExpress.Xpo;

namespace GUS.Module.BusinessObjects
{
    [NavigationItem("GUS")]
    [DefaultClassOptions]
    public class RegistrationAuthority : GusBaseObject
    {
        public RegistrationAuthority(Session session) : base(session) { }
    }
}
