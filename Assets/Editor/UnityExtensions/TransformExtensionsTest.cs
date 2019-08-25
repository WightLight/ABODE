namespace Abode.Unity.Tests
{
  using UnityEngine;
  using NUnit.Framework;
  
  public class TransformExtensionsTest
  {
    [Test]
    public void ReturnsNullWhenNoChildExistsWithTheGivenName()
    {
      Transform transform = new GameObject().transform;

      Transform found = transform.FindDeep("Name");

      Assert.That(found, Is.Null);
    }

    [Test]
    public void FindsChildrenOneLevelDeep()
    {
      Transform subjectToFind = new GameObject("Name").transform;
      Transform transform = new GameObject().transform;
      subjectToFind.parent = transform;

      Transform found = transform.FindDeep("Name");

      Assert.That(found, Is.SameAs(subjectToFind));
    }

    [Test]
    public void FindsChildrenDeeperThanOneLevel()
    {
      Transform subjectToFind = new GameObject("Name").transform;
      Transform intermediate = new GameObject().transform;
      Transform transform = new GameObject().transform;
      intermediate.parent = transform;
      subjectToFind.parent = intermediate;

      Transform found = transform.FindDeep("Name");

      Assert.That(found, Is.SameAs(subjectToFind));
    }
  }
}
