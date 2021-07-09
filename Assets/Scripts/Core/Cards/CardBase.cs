using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardBase : LifeBase
{

    public int totalManaRequest;
    public string nameCard;
    public string descriptionCard;
    public Texture imgCard;

    public TextMesh textLife;
    public TextMesh textMana;
    public TextMesh textNameCard;
    public TextMesh textDescriptionCard;
    public Renderer renderImgCard;

    // Start is called before the first frame update
    protected void Start()
    {
        base.Start();
        textLife.text = currentLife.ToString();
        textMana.text = totalManaRequest.ToString();
        textNameCard.text = nameCard;
        textDescriptionCard.text = descriptionCard;
        renderImgCard.material.mainTexture = imgCard;
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
