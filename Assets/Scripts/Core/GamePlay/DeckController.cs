using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckController : MonoBehaviour
{
    private Vector3 initialSide;
    private int totalInitialCards;
    public List<CardBase> initListCards;

    // Start is called before the first frame update
    void Start ()
    {
        initialSide = transform.localScale;
        totalInitialCards = initListCards.Count;
    }

    // Update is called once per frame
    void Update ()
    {
      if (Input.GetKeyDown(KeyCode.P))   
        GetCard();
    }

    public void GetCard(){
        if(initListCards.Count > 0) {
        int randCardIndex = Random.Range(0,initListCards.Count);
        CardBase selectedCard = initListCards [randCardIndex];
        initListCards.RemoveAt(randCardIndex);

        Instantiate (selectedCard.gameObject, Vector3.zero, selectedCard.transform.rotation);
        ResizeDeck ();
    }
}

    private void ResizeDeck(){
     
        Vector3 newSize = transform.localScale;
     
       newSize.y = initListCards.Count * initialSide.y / totalInitialCards;
       transform.localScale = newSize;

       if (initListCards.Count == 0){

           GetComponent<Renderer>().enabled = false;
       }
    }

}
