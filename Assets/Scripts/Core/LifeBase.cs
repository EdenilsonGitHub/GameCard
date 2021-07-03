using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LifeBase : MonoBehaviour
{

    public int totalLife;

    private int currentLife;

    // Start is called before the first frame update
    protected void Start()
    {
        currentLife = totalLife;
    }
    
    // Update is called once per frame
    protected void Update()
    {
        
    }

    public void ApplyDamage(int damage) {
        currentLife -= damage;
        OnDamage ();

        if (currentLife <= 0) {
            OnDie();
        }
    }

    public abstract void OnDamage();
    public abstract void OnDie();

}
