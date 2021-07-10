using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardBase : MonoBehaviour
{

    public int totalManaRequest;
    public string nameCard;
    public string descriptionCard;
    public Texture imgCard;

    public TextMesh textMana;
    public TextMesh textNameCard;
    public TextMesh textDescriptionCard;
    public Renderer renderImgCard;

    // Start is called before the first frame update
    protected void Start()
    {
        textMana.text = totalManaRequest.ToString();
        textNameCard.text = nameCard;
        textDescriptionCard.text = descriptionCard;
        renderImgCard.material.mainTexture = imgCard;
    }

    // Update is called once per frame
    protected void Update()
    {
        
    }

}
