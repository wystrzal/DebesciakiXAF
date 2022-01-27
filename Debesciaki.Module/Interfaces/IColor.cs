using System.Drawing;

namespace Debesciaki.Module.Interfaces
{
    public interface IColor
    {
        Color BackColor { get; set; }
        Color ForeColor { get; set; }
        FontStyle FontStyle { get; set; }
    }
}