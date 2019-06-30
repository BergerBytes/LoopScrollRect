using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UI
{
    public abstract class LoopScrollCell: MonoBehaviour
    {
        public abstract void SetUpOneTimeThings(int index);
        public abstract void PrepareForReuse(int index);
    }
}
