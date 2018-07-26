using UnityEngine;
using System.Collections;

public class PlayerLineOfSight : MonoBehaviour
{
    public Camera camera;

    void Start()
    {

    }

    private void Update()
    {
        RaycastHit hit;
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 10, Color.yellow);

        if (Physics.Raycast(ray, out hit))
        {
            Transform objectHit = hit.transform;

            // Do something with the object that was hit by the raycast.
            objectHit.transform.localScale += new Vector3(0, 0.002F, 0);
        }
    }
}