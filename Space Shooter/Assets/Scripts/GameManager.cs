using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] private GameObject menu;
    [SerializeField] private GameObject botoesMenu;
    [SerializeField] private GameObject botoesSeleçao;
    [SerializeField] private GameObject[] space_Ship;
    [SerializeField] private Transform spawn;
    
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f;
    botoesMenu.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        botoesMenu.SetActive(false);
        botoesSeleçao.SetActive(true);
    
    }
    public void ExitGame()
    {
        Application.Quit();
    }

    public void SelectShipOne()
    {
        Time.timeScale = 1f;
        menu.SetActive(false);
        botoesSeleçao.SetActive(false);
        Instantiate(space_Ship[0], spawn);
        
        
    }

    public void SelectShipTwo()
    {
        Time.timeScale = 1f;
        botoesSeleçao.SetActive(false);
        menu.SetActive(false);
        Instantiate(space_Ship[1], spawn);
        
    }

    public void SelectShipThree()
    {
        Time.timeScale = 1f;
        botoesSeleçao.SetActive(false);
        menu.SetActive(false);
        Instantiate(space_Ship[2], spawn);    
        
    }

    public void BackToMenu()
    {
        Time.timeScale = 0f;
        menu.SetActive(true);
        botoesMenu.SetActive(true);
    }
}
