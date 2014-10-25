using System;
using System.ComponentModel;
using System.Globalization;

public class WiseCornerConverter : ExpandableObjectConverter
{
    public override bool CanConvertTo(ITypeDescriptorContext context, System.Type destinationType)
    {
        if (destinationType == typeof(WiseCorner))
        {
            return true;
        }
        return base.CanConvertTo(context, destinationType);
    }

    public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, System.Type destinationType)
    {
        if (destinationType == typeof(System.String) && value is WiseCorner)
        {
            WiseCorner wc = (WiseCorner)value;
            return wc.TopLeft + ", " + wc.TopRight + ", " + wc.BottomRight + ", " + wc.BottomLeft;
        }
        return base.ConvertTo(context, culture, value, destinationType);
    }

    public override bool CanConvertFrom(ITypeDescriptorContext context, System.Type sourceType)
    {
        if (sourceType == typeof(string))
            return true;
        return base.CanConvertFrom(context, sourceType);
    }

    public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
    {
        if (value is string)
        {
            try
            {
                string str = (string)value;
                string[] corners = str.Split(',');

                int topLeft = int.Parse(corners[0].Trim());
                int topRight = int.Parse(corners[1].Trim());
                int bottomRight = int.Parse(corners[2].Trim());
                int bottomLeft = int.Parse(corners[3].Trim());

                WiseCorner wc = new WiseCorner();
                wc.TopLeft = topLeft;
                wc.TopRight = topRight;
                wc.BottomRight = bottomRight;
                wc.BottomLeft = bottomLeft;

                return wc;
            }
            catch
            {
                throw new ArgumentException("Cannot convert '" + (string)value + "' to WiseCorner!");
            }
        }
        return base.ConvertFrom(context, culture, value);
    }
}