using System;
using System.Drawing;
using System.Globalization;
using DevExpress.Xpo.Metadata;

namespace Debesciaki.Module.BusinessObjects
{
    public class ColorValueConverter : ValueConverter
    {
        public override Type StorageType => typeof(string);

        public override object ConvertFromStorageType(object value)
        {
            if (value is null) return Color.Empty;

            if (!(value is string))
            {
                if (!(value.ToString().Length == 8)) return Color.Empty;
            }

            int argb = int.Parse(((string)value).Replace("#", string.Empty), NumberStyles.HexNumber);
            return Color.FromArgb(argb);
        }

        public override object ConvertToStorageType(object value)
        {
            if (value is null) return null;
            if (!(value is Color)) return null;
            Color color = (Color)value;
            return string.Format("#{0:X2}{1:X2}{2:X2}{3:X2}", color.A, color.R, color.G, color.B);
        }
    }
}
