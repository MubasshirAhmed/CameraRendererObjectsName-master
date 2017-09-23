using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{

    private void OnBecameVisible()
    {
        print("Visible");
        GetComponent<MeshRenderer>().enabled = true;
    }
    private void OnBecameInvisible()
    {
        print("Invisible");
        GetComponent<MeshRenderer>().enabled = false;
    }
}
