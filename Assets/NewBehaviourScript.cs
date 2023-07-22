using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject go1 = new GameObject();
        go1.name = "go1";
        go1.AddComponent<Rigidbody>();

        GameObject go2 = new GameObject("go2");
        go2.AddComponent<Rigidbody>();

        GameObject go3 = new GameObject("go3", typeof(Rigidbody), typeof(BoxCollider));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

