RedGreenBlue rgbBody = new RedGreenBlue();
rgbBody.red = 240;
rgbBody.green = 240;
rgbBody.blue = 240;
//rgbBody.opacity = 0.5F;

Console.WriteLine($"Le fond de mon site web a une couleur rgb({rgbBody.red},{rgbBody.green}, {rgbBody.blue})");
Console.WriteLine($"Le fond est opaque à {rgbBody.opacity * 100} %");

RedGreenBlue rgbText = rgbBody;
rgbText.red = (ushort)(255 - rgbText.red);
rgbText.green = (ushort)(255 - rgbText.green);
rgbText.blue = (ushort)(255 - rgbText.blue);
rgbText.opacity = 1 - rgbText.opacity;

Console.WriteLine($"Les textes de mon site web sont d'une couleur rgb({rgbText.red},{rgbText.green}, {rgbText.blue})");
Console.WriteLine($"Les textes sont opaques à {rgbText.opacity * 100} %");

Console.WriteLine($"Le fond de mon site web a une couleur rgb({rgbBody.red},{rgbBody.green}, {rgbBody.blue})");
Console.WriteLine($"Le fond est opaque à {rgbBody.opacity * 100} %");
public struct RedGreenBlue
{
    /// <summary>
    /// Red is a value who represent the red channel of a color. His value is between 0 and 255.
    /// </summary>
    public ushort red;
    /// <summary>
    /// Green is a value who represent the green channel of a color. His value is between 0 and 255.
    /// </summary>
    public ushort green;
    /// <summary>
    /// Blue is a value who represent the blue channel of a color. His value is between 0 and 255.
    /// </summary>
    public ushort blue;
    /// <summary>
    /// Opacity is a value who represent the opacity channel of a color. His value is between 0 and 1.
    /// </summary>
    public float opacity;
}

