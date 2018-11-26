using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using UnityEngine.SceneManagement;
using System.Collections;
using System;

public class buttonTest
{

    [UnityTest] //This test ensures that portals correctly teleport the box.
    public IEnumerator testButton()
    {
        SceneManager.LoadScene("buttonTestScene");
        yield return new WaitForFixedUpdate();


        yield return new WaitForSeconds(3);

        var breakable = GameObject.FindGameObjectWithTag("breakable");
        Assert.IsNull(breakable);
    }
}
