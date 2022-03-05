﻿using DevExpress.Xpo;

namespace GUS.Module.BusinessObjects
{
    [NonPersistent]
    public abstract class GusBaseObject : XPLiteObject
    {
        public GusBaseObject(Session session) : base(session) { }


        string name;
        string symbol;
        [Key(false)]
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Symbol
        {
            get => symbol;
            set => SetPropertyValue(nameof(Symbol), ref symbol, value);
        }


        [Size(250)]
        public string Name
        {
            get => name;
            set => SetPropertyValue(nameof(Name), ref name, value);
        }
    }
}