namespace Abode.Unity
{
  using UnityEngine;

  public static class TransformExtensions
  {
    public static Transform FindDeep(this Transform transform, string name)
    {
      Transform found = transform.Find(name);
      if(found == null)
      {
        foreach(Transform child in transform)
        {
          found = child.FindDeep(name);
          if(found != null) break;
        }
      }

      return found;
    }
  }
}
