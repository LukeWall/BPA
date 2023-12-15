using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret1 : MonoBehaviour
{
    public GameObject sword;

    public IEnumerator SwordSwing()
    {
        sword.GetComponent<Animator>().Play("New State");
        yield return new WaitForSeconds(1.0f);
        sword.GetComponent<Animator>().Play("New State 0");
        yield break;
    }
}
