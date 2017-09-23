using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRenderer : MonoBehaviour
{
    public GameObject terget;
    //// Use this for initialization
    //void Start()
    //{

    //}

    private bool flag;

    //// Update is called once per frame
    void Update()
    {
        //Plane[] planes = GeometryUtility.CalculateFrustumPlanes(Camera.main);
        //if (GeometryUtility.TestPlanesAABB(planes, terget[0].GetComponent<Renderer>().bounds))
        //    Debug.Log("Visible");
        //else
        //    Debug.Log("InVisible");

        if (terget.GetComponent<Renderer>().isVisible)
        {
            RaycastHit hit;
            Vector3 direction = terget.transform.position - transform.position;
            if (Physics.Raycast(transform.position, direction, out hit, Mathf.Infinity))
            {
                if (hit.collider.name == "Cube1")
                {
                    flag = true;
                    Debug.Log("Visible");
                }
                else
                    flag = false;
            }
        }
        else
            flag = false;
        if (!flag)
            Debug.Log("InVisible");
    }

    //public List<Renderer> visibleRenderers = new List<Renderer>();
    //public List<GameObject> inGameObjects = new List<GameObject>();

    // Update is called once per frame
    //void Update()
    //{
    //FindObjects();
    //FindObjectsByTag();
    //}

    // Find and store visible renderers to a list
    //void FindObjects()
    //{
    //    // Retrieve all renderers in scene
    //    Renderer[] sceneRenderers = FindObjectsOfType<Renderer>();

    //    // Store only visible renderers
    //    visibleRenderers.Clear();
    //    for (int i = 0; i < sceneRenderers.Length; i++)
    //        if (IsVisible(sceneRenderers[i]))
    //            visibleRenderers.Add(sceneRenderers[i]);

    //    // debug console
    //    string result = "Total Renderers = " + sceneRenderers.Length + ".  Visible Renderers = " + visibleRenderers.Count;
    //    foreach (Renderer renderer in visibleRenderers)
    //        result += "\n " + renderer.name;

    //    Debug.Log(result);
    //}

    //// Is the renderer within the camera frustrum?
    //bool IsVisible(Renderer renderer)
    //{
    //    Plane[] planes = GeometryUtility.CalculateFrustumPlanes(Camera.main);
    //    return (GeometryUtility.TestPlanesAABB(planes, renderer.bounds)) ? true : false;
    //}

    //void FindObjectsByTag()
    //{
    //    GameObject[] objectsList = GameObject.FindGameObjectsWithTag("TagObj");

    //    inGameObjects.Clear();
    //    for (int i = 0; i < objectsList.Length; i++)
    //    {
    //        if (/*IsVisibleByTag(objectsList[i])*/objectsList[i].GetComponent<Renderer>().isVisible)
    //        {
    //            inGameObjects.Add(objectsList[i]);
    //        }
    //    }
    //    // debug console
    //    string result = "Total TagObj = " + objectsList.Length + ".  Visible Renderers = " + inGameObjects.Count;
    //    foreach (GameObject go in inGameObjects)
    //        result += "\n " + go.name;

    //    Debug.Log(result);
    //}

    //bool IsVisibleByTag(GameObject go)
    //{
    //    Plane[] planes = GeometryUtility.CalculateFrustumPlanes(Camera.main);
    //    return (GeometryUtility.TestPlanesAABB(planes, go.GetComponent<Renderer>().bounds)) ? true : false;
    //}
}
