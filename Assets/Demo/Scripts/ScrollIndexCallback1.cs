using UnityEngine;
using UnityEngine.UI;

public class ScrollIndexCallback1 : LoopScrollCell
{
    public Image image;
    public Text text;

    // http://stackoverflow.com/questions/2288498/how-do-i-get-a-rainbow-color-gradient-in-c
    private static Color Rainbow(float progress)
    {
        progress = Mathf.Clamp01(progress);
        var r = 0.0f;
        var g = 0.0f;
        var b = 0.0f;
        var i = (int) (progress * 6);
        var f = progress * 6.0f - i;
        var q = 1 - f;

        switch (i % 6)
        {
            case 0:
                r = 1;
                g = f;
                b = 0;
                break;
            case 1:
                r = q;
                g = 1;
                b = 0;
                break;
            case 2:
                r = 0;
                g = 1;
                b = f;
                break;
            case 3:
                r = 0;
                g = q;
                b = 1;
                break;
            case 4:
                r = f;
                g = 0;
                b = 1;
                break;
            case 5:
                r = 1;
                g = 0;
                b = q;
                break;
        }

        return new Color(r, g, b);
    }

    public override void SetUpOneTimeThings(int index)
    {
    }

    public override void PrepareForReuse(int index)
    {
        var name = "Cell " + index;
        if (text != null) text.text = name;
        if (image != null) image.color = Rainbow(index / 50.0f);
        gameObject.name = name;
    }
}