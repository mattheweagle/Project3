using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using UnityEngine.SceneManagement;
using System.Collections;
using System;

public class doorTest
{

    [UnityTest] //This test ensures that portals correctly teleport the box.
    public IEnumerator testDoor()
    {
        SceneManager.LoadScene("doorTestScene");
        yield return new WaitForFixedUpdate();
        var curScene = SceneManager.GetActiveScene().buildIndex;

        yield return new WaitForSeconds(3);

        Assert.AreEqual(curScene +1, SceneManager.GetActiveScene().buildIndex);
    }
}

