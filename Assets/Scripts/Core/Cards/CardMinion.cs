using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardMinion : CardBase
{

    public int attackPower;

    public TextMesh textAttack;

    // Start is called before the first frame update
    void Start()
    {
        base.Start ();
        textAttack.text = attackPower.ToString ();
    }

    // Update is called once per frame
    void Update()
    {
        base.Update ();
    }
}
