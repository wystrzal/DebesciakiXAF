using DevExpress.Persistent.Base;
using DevExpress.Xpo;

namespace GUS.Module.BusinessObjects
{
    [NavigationItem("GUS")]
    [DefaultClassOptions]
    public class FinancingForm : GusBaseObject
    {
        public FinancingForm(Session session) : base(session) { }
    }
}
