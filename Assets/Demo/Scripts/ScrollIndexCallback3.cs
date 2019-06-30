using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScrollIndexCallback3 : LoopScrollCell
{
    public Text text;

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
    }

    public void OnClick()
    {
        Debug.Log("Click!");
    }
}
