using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int health = 2;
    [SerializeField] private int points = 0;
    [SerializeField] private int gunRotateSpeed = 1;
    public static GameManager instance;
    void Awake()
    {
        if (instance==null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    public GameManager getInstance()
    {
        return instance;
    }
    public void AddPoints(int amount){
        points+= amount;
        GameCanvasController.instance.AddPoints(points);
        if (points % 5 == 0)
        {
            GunRotateSpeed++;
        }
    }
    public void RemoveHealth(){
        health--;
        GameCanvasController.instance.sliderFill.fillAmount = GetHealth * 0.1f;
        if (health < 1)
        {
            GameCanvasController.instance.LoseGame();
        }
    }
    public int GetHealth => health;
    public void SetHealth(int amount){
        health = amount;
    }
    public int GunRotateSpeed {get {return gunRotateSpeed;} set{gunRotateSpeed = value;}}
}
