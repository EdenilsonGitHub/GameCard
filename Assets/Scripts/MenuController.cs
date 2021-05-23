using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public GameObject generalMenu;
    public GameObject optionsMenu;

    void Start()
    {
        ActiveMenu (generalMenu);
    }

    
    void Update()
    {
        
    }

    private void HideMenus() {
        generalMenu.SetActive(false);
        optionsMenu.SetActive(false);
    }

    public void ActiveMenu(GameObject menu){
        HideMenus ();
        menu.SetActive (true);
    }

    public void ExitGame(){
        ApplicationControler.ExitGame ();
    }

}
