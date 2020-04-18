using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        Debug.Log(GameObject.Find("BabyCollider").transform.position);
    }
}
