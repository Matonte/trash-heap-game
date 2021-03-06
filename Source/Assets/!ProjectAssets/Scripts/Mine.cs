using UnityEngine;
using System.Collections;
public class Mine:Ability 

    // A projectile you lay behind you that explodes when an enemy then touches it. 
{
    Color c;
    protected float cooldown = 0f;
    protected float readyAt = 0f;
    protected string description = "Plant a mine.";
    protected StatBlock owner;

    public float TotalCooldown
    {
        set { }
        get { 
            return cooldown; 
        }
    }

    public float RemainingCooldown
    {
        set { }
        get
        {
            if (readyAt > Time.time)
                return readyAt - Time.time;
            else
                return 0f;
        }
    }

    public string Description
    {
        set { }
        get { 
            return "A plantable exploding mine."; 
        }
    }

    public  void OnActivate()
    {
        OnDequip(owner);
        Transform proj = GameObject.CreatePrimitive(PrimitiveType.Sphere).GetComponent<Transform>();
            proj.position = caster.CC.transform.position;
            proj.localScale = new Vector3(.08f, .08f, .08f);
            proj.gameObject.AddComponent<BasicProjectile>();
            proj.renderer.material.color = c;
        }
    

    public Mine()
    {
        c = Color.gray;
    }

    public Mine(Color color)
    {
        c = color;
    }
  
   
    public  void OnEquip(ref StatBlock newOwner)
    {
        //register with the owner to set the OnTick to listen to an event.
        newOwner.CC.OnTick += OnTick;
        newOwner.CC.OnStruck += OnStruck;
        owner = newOwner;
    }

    public  void OnDequip(ref StatBlock owner)
    {
        //undo anything done in OnEquip
        owner.CC.OnTick -= OnTick;
        owner.CC.OnStruck -= OnStruck;
    }
}
