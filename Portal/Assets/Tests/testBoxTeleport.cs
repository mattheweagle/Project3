using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using UnityEngine.SceneManagement;
using System.Collections;
using System;

public class testBoxTeleport
{

    [UnityTest] //This test ensures that portals correctly teleport the box.
    public IEnumerator boxTeleportTest()
    {
        SceneManager.LoadScene("boxTeleportTestScene");
        yield return new WaitForFixedUpdate();
        Transform box = GameObject.FindGameObjectWithTag("box").transform;

        Vector2 prev = box.position;
        for (int i = 0; i < 100; i++)
        {
            yield return new WaitForFixedUpdate();
            Vector2 pos = box.position;
            Vector3 deltaPos = pos - prev;
            prev = pos;
            if (deltaPos.y > 0)
            {
                yield return new WaitForSeconds(1);
                yield break;
            }
        }
        Assert.Fail();
    }
}
