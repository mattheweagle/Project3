using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using UnityEngine.SceneManagement;
using System.Collections;
using System;

public class test1
{

    [UnityTest] //This test ensures that portals correctly teleport the player.
    public IEnumerator playerTeleports()
    {
        SceneManager.LoadScene("theTestScene");
        yield return new WaitForFixedUpdate();
        Transform avocado = GameObject.FindGameObjectWithTag("Player").transform;

        Vector2 prev = avocado.position;
        for (int i = 0; i < 100; i++)
        {
            yield return new WaitForFixedUpdate();
            Vector2 pos = avocado.position;
            Vector2 deltaPos = pos - prev;
            prev = pos;
            if (deltaPos.y > 0)
            {
                yield return new WaitForSeconds(1);
                yield break;
            }
        }
        Assert.Fail();
    }

    [UnityTest] //This test ensures that tortilla chips correctly move towards the player.
    public IEnumerator testChipAI()
    {
        SceneManager.LoadScene("theTestScene");
        yield return new WaitForFixedUpdate();
        Transform tortilla = GameObject.FindGameObjectWithTag("chip").transform;
        Transform avocado = GameObject.FindGameObjectWithTag("Player").transform;

        Vector2 prev = tortilla.position;
        Vector2 prevAvocadoPos = avocado.position;
        for (int i = 0; i < 40; i++)
        {
            yield return new WaitForFixedUpdate();

            Vector2 pos = tortilla.position;
            Vector2 deltaPos = pos - prev;
            prev = pos;
            if (prevAvocadoPos.x < 0)
            {
                if (deltaPos.x > 0)
                {
                    yield return new WaitForSeconds(1);
                    Assert.Fail();
                }
            }
            else if (prevAvocadoPos.x > 0)
            {
                if (deltaPos.x < 0)
                {
                    yield return new WaitForSeconds(1);
                    Assert.Fail();
                }
            }
            prevAvocadoPos = avocado.position;
        }
        yield break;
    }

    [UnityTest] //This test ensures that hazards reset the scene when the player touches them.
    public IEnumerator testHazards()
    {
        SceneManager.LoadScene("theTestScene");
        yield return new WaitForFixedUpdate();
        Scene prevScene = SceneManager.GetActiveScene();

        for (int i = 0; i < 1000; i++)
        {
            yield return new WaitForFixedUpdate();
            Scene scene = SceneManager.GetActiveScene();
            if (prevScene != scene)
            {
                yield return new WaitForSeconds(1);
                yield break;
            }
        }
        Assert.Fail();
    }
}