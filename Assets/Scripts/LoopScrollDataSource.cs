using UnityEngine;
using System.Collections;

namespace UnityEngine.UI
{
    public abstract class LoopScrollDataSource
    {
        public abstract void ProvideData(LoopScrollCell cell, int idx, bool initialized);
    }

	public class LoopScrollSendIndexSource : LoopScrollDataSource
    {
		public static readonly LoopScrollSendIndexSource Instance = new LoopScrollSendIndexSource();

		LoopScrollSendIndexSource(){}

        public override void ProvideData(LoopScrollCell cell, int index, bool initialized)
        {
            if (initialized)
            {
                cell.SetUpOneTimeThings(index);
            }
            
            cell.PrepareForReuse(index);
        }
    }

	public class LoopScrollArraySource<T> : LoopScrollDataSource
    {
        T[] objectsToFill;

		public LoopScrollArraySource(T[] objectsToFill)
        {
            this.objectsToFill = objectsToFill;
        }

        public override void ProvideData(LoopScrollCell cell, int index, bool initialized)
        {
            if (initialized)
            {
                cell.SetUpOneTimeThings(index);
            }
            
            cell.PrepareForReuse(index);
        }
    }
}