using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardBase : LifeBase
{

    public int totalManaRequest;

    public TextMesh textLife;
    public TextMesh textMana;

    // Start is called before the first frame update
    protected void Start()
    {
        base.Start();
        textLife.text = currentLife.ToString();
        textMana.text = totalManaRequest.ToString();
    }

    // Update is called once per frame
    protected void Update()
    {
        base.Update();
    }

    public override void OnDamage ()
    {

    }

    public override void OnDie ()
    {
        
    }
}
