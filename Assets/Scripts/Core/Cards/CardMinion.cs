using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardMinion : CardBase
{

    public int attackPower;

    public TextMesh textAttack;
    public TextMesh textLife;

    private CardLife cardLife;

    // Start is called before the first frame update
    void Start()
    {
        base.Start ();
        cardLife = GetComponent<CardLife> ();
        textAttack.text = attackPower.ToString ();
        textLife.text = cardLife.GetCurrentLife().ToString();
    }

    // Update is called once per frame
    void Update()
    {
        base.Update ();
    }
}
