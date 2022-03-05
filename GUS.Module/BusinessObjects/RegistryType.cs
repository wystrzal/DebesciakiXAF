using DevExpress.Persistent.Base;
using DevExpress.Xpo;

namespace GUS.Module.BusinessObjects
{

    [NavigationItem("GUS")]
    [DefaultClassOptions]
    public class RegistryType : GusBaseObject
    {
        public RegistryType(Session session) : base(session) { }
    }
}