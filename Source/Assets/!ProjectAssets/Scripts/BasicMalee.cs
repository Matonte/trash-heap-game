//Bill Matonte
//10.24.14
//Class for melee behavior. 
//This class inherits monobehavior. 


using UnityEngine;
using System.Collections;

public class BasicMelee : MonoBehaviour
{
    public float speed = 10f;

    Transform myTrans;
    // Use this for initialization
    void Start()
    {
        myTrans = GetComponent<Transform>();
        Destroy(gameObject, .1f);
    }

    // Update is called once per frame
    void Update()
    {
        myTrans.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
