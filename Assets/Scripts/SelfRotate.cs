using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfRotate : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // transform.Rotate(new Vector3(90, 90, 90));
        // transform.rotation = Quaternion.Euler(45, 45, 45);
        transform.Rotate(Vector3.up, Time.deltaTime * 100);
        Vector3 eulerAngles = transform.rotation.eulerAngles;
    }
}
