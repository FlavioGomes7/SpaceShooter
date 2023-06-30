using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    //Instanciate
    public static GameManager instance;

    //Menu
    [SerializeField] private GameObject Panel;
    [SerializeField] private GameObject botoesMenu;
    [SerializeField] private GameObject botoesSeleçao;
    [SerializeField] private GameObject botoesPause;

    //Ship
    [SerializeField] private GameObject[] space_Ship;
    [SerializeField] private Transform spawn;

    //Hud
    [SerializeField] private GameObject hud;
    [SerializeField] private GameObject highScoreHud;
    [SerializeField] private TextMeshProUGUI hpHud;
    [SerializeField] private TextMeshProUGUI pontHud;
    public int points;
    private int highScore;

    


    void Awake()
    {
        instance = this;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f;
        highScore = 0;
        highScoreHud.GetComponent<TextMeshProUGUI>().SetText("Pontução Maxima: " + highScore);
        botoesMenu.SetActive(true);
        highScoreHud.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
    
    }

    //HUD MANAGER
    public void AddPoints(int value)
    {
        points += value;
        pontHud.SetText("Pontuação: " + points);
    }

    public void ResetPoints()
    {
        points = 0;
        pontHud.SetText("Pontuação: " + points);
    }

    public void NewHighScore()
    {
        if(points > highScore)
        {
            highScore = points;
            highScoreHud.GetComponent<TextMeshProUGUI>().SetText("Pontução Maxima: " + highScore);
        }
    }

    public void ShowLife(int life)
    {
        hpHud.SetText("Vida: " + life);
    }
    //HUD MANAGER


    // MENU MENAGER
    public void StartGame()
    {
        botoesMenu.SetActive(false);
        botoesSeleçao.SetActive(true);
        hud.SetActive(false);
        highScoreHud.SetActive(false);
    
    }
    public void ExitGame()
    {
        Application.Quit();
    }

    public void SelectShipOne()
    {
        Time.timeScale = 1f;
        Panel.SetActive(false);
        botoesSeleçao.SetActive(false);
        Instantiate(space_Ship[0], spawn);
        hud.SetActive(true);
        
        
    }

    public void SelectShipTwo()
    {
        Time.timeScale = 1f;
        botoesSeleçao.SetActive(false);
        Panel.SetActive(false);
        Instantiate(space_Ship[1], spawn);
        hud.SetActive(true);
    }

    public void SelectShipThree()
    {
        Time.timeScale = 1f;
        botoesSeleçao.SetActive(false);
        Panel.SetActive(false);
        Instantiate(space_Ship[2], spawn);
        hud.SetActive(true);  
        
    }

    public void BackToMenu()
    {
        Time.timeScale = 0f;
        Panel.SetActive(true);
        botoesMenu.SetActive(true);
        botoesPause.SetActive(false);
        botoesSeleçao.SetActive(false);
        hud.SetActive(false);
        highScoreHud.SetActive(true);
        Destroy(GameObject.FindGameObjectWithTag("Enemy"));
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        Panel.SetActive(true);
        hud.SetActive(false);
        botoesPause.SetActive(true);

    }
    
    public void Resume()
    {
        Time.timeScale = 1f;
        Panel.SetActive(false);
        hud.SetActive(true);
        botoesPause.SetActive(false);
    }
    //MENU MANAGER

    public void ClearEnemies(string tag)
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(tag);
        foreach(GameObject target in enemies)
        {
            Destroy(target);
        }
    }
}
