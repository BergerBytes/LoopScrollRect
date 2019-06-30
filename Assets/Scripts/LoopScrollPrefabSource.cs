using UnityEngine;
using System.Collections;
using Sirenix.OdinInspector;

namespace UnityEngine.UI
{
    [System.Serializable]
    [TableList]
    public class LoopScrollPrefabSource 
    {
        public LoopScrollCell prefab;
        public int poolSize = 5;

        private bool inited = false;
        public virtual GameObject GetObject()
        {
            if(!inited)
            {
                SG.ResourceManager.Instance.InitPool(prefab, poolSize);
                inited = true;
            }
            return SG.ResourceManager.Instance.GetObjectFromPool(prefab);
        }

        public virtual void ReturnObject(Transform go)
        {
            go.SendMessage("ScrollCellReturn", SendMessageOptions.DontRequireReceiver);
            SG.ResourceManager.Instance.ReturnObjectToPool(go.gameObject);
        }
    }
}
