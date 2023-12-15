namespace ThreadsApp.Controls;

public class FontAwesomeLabel : Label
{
    const string FAS = "FAS";
    const string FAR = "FAR";
    const string FAB = "FAB";

    public FontAwesomeLabel(FontAwesomeStyle style, string icon)
    {
        FontFamily = style switch
        {
            FontAwesomeStyle.Solid => FAS,
            FontAwesomeStyle.Regular => FAR,
            FontAwesomeStyle.Brand => FAB,
            _ => throw new NotImplementedException()
        };

        Text = icon;
    }

}

public enum FontAwesomeStyle
{
    Brand,
    Regular,
    Solid
}
