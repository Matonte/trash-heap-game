//Bill Matonte
//10.26.14
//An attempt at a class that creates a fixed stream of projectiles.
//Inherited from IAbility.  


using UnityEngine;
using System.Collections;

public class A_PracticePulse : IAbility
{
    Color c;

    public void OnActivate(StatBlock caster)
    {
        float a = 0;
        for (int i = 0; i < 50; i++)
        {
           Transform proj = GameObject.CreatePrimitive(PrimitiveType.Sphere).GetComponent<Transform>();
        proj.position = caster.CC.transform.position + caster.CC.transform.forward;
        proj.rotation = caster.CC.transform.rotation;
        if (a == 0) { a = Random.value; }
        proj.Rotate(Vector3.up, (a- .5f) * 5f);
        proj.localScale = new Vector3(.1f, .1f, .1f);
        proj.gameObject.AddComponent<BasicProjectile>();
        proj.renderer.material.color = c;
        }
    }

    public A_PracticePulse()
    {
        c = Color.red;
    }

    public A_PracticePulse(Color color)
    {
        c = color;
    }
}
