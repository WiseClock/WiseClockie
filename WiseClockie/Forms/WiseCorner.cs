using System;
using System.ComponentModel;

[TypeConverterAttribute(typeof(WiseCornerConverter))]
public class WiseCorner
{
    private int _topLeft, _topRight, _bottomRight, _bottomLeft;

    [Category("WiseClokie"), Description("Set all the corner radius."), RefreshProperties(RefreshProperties.All)]
    public int All
    {
        get
        {
            if (_topLeft == _topRight && _topRight == _bottomRight && _bottomRight == _bottomLeft)
            {
                return _topLeft;
            }
            return -1;
        }
        set
        {
            if (value < 0)
            {
                value = 0;
            }
            _topLeft = value;
            _topRight = value;
            _bottomRight = value;
            _bottomLeft = value;
        }
    }

    [Category("WiseClokie"), Description("Set the top left corner radius."), RefreshProperties(RefreshProperties.All)]
    public int TopLeft
    {
        get { return _topLeft; }
        set { _topLeft = (value < 0) ? 0 : value; }
    }

    [Category("WiseClokie"), Description("Set the top right corner radius."), RefreshProperties(RefreshProperties.All)]
    public int TopRight
    {
        get { return _topRight; }
        set { _topRight = (value < 0) ? 0 : value; }
    }

    [Category("WiseClokie"), Description("Set the bottom right corner radius."), RefreshProperties(RefreshProperties.All)]
    public int BottomRight
    {
        get { return _bottomRight; }
        set { _bottomRight = (value < 0) ? 0 : value; }
    }

    [Category("WiseClokie"), Description("Set the bottom left corner radius."), RefreshProperties(RefreshProperties.All)]
    public int BottomLeft
    {
        get { return _bottomLeft; }
        set { _bottomLeft = (value < 0) ? 0 : value; }
    }

    public WiseCorner()
        : this(0, 0, 0, 0)
    {
    }

    public WiseCorner(int all)
        : this(all, all, all, all)
    {
    }

    public WiseCorner(int topLeft, int topRight, int bottomRight, int bottomLeft)
    {
        _topLeft = topLeft;
        _topRight = topRight;
        _bottomLeft = bottomLeft;
        _bottomRight = bottomRight;
    }

    public override string ToString()
    {
        return _topLeft + ", " + _topRight + ", " + _bottomRight + ", " + _bottomLeft;
    }
}
