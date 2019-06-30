using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScrollIndexCallback2 : LoopScrollCell 
{
    public Text text;
    public LayoutElement element;
    private static float[] randomWidths = new float[3] { 100, 150, 50 };

    public override void SetUpOneTimeThings(int index)
    {
    }

    public override void PrepareForReuse(int index)
    {
        string name = "Cell " + index.ToString();
        if (text != null)
        {
            text.text = name;
        }
        element.preferredWidth = randomWidths[Mathf.Abs(index) % 3];
        gameObject.name = name;
    }
}
