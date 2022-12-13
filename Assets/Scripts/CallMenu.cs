using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallMenu : MonoBehaviour
{
    public MainMenu MainMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       //if ESC pressed calls option menu 
       if (Input.GetKeyDown(KeyCode.Escape))

        {
            MainMenu.gameObject.SetActive(!MainMenu.gameObject.activeSelf);
        }
    }
}
