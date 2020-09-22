using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public static int PlayerHealth;
    public static int Lives;
    public Sprite FullHeart;
    public Sprite HalfHeart;
    public Sprite EmptyHeart;
    public Text LivesDisplay;

    public List<SpriteRenderer> Hearts;
    
    

    private void Start()
    {
        string fromjson = File.ReadAllText(Application.dataPath + "PlayerSaveData.json");
        DbManager dbMgr = JsonUtility.FromJson<DbManager>(fromjson);
        PlayerHealth = dbMgr.dbHealth;
        Lives = dbMgr.dbLives;
    }

    private void Update()
    {
        string fromjson = File.ReadAllText(Application.dataPath + "PlayerSaveData.json");
        DbManager dbMgr = JsonUtility.FromJson<DbManager>(fromjson);
        if (PlayerHealth == 6)
        {
            Hearts[2].sprite = FullHeart;
            Hearts[1].sprite = FullHeart;
            Hearts[0].sprite = FullHeart;
        }
        if(PlayerHealth == 5)
        {
            Hearts[2].sprite = HalfHeart;
            Hearts[1].sprite = FullHeart;
            Hearts[0].sprite = FullHeart;
        }
        if(PlayerHealth == 4)
        {
            Hearts[2].sprite = EmptyHeart;
            Hearts[1].sprite = FullHeart;
            Hearts[0].sprite = FullHeart;
        }
        if(PlayerHealth == 3)
        {
            Hearts[2].sprite = EmptyHeart;
            Hearts[1].sprite = HalfHeart;
            Hearts[0].sprite = FullHeart;
        }
        if(PlayerHealth == 2)
        {
            Hearts[2].sprite = EmptyHeart;
            Hearts[1].sprite = EmptyHeart;
            Hearts[0].sprite = FullHeart;
        }
        if(PlayerHealth == 1)
        {
            Hearts[2].sprite = EmptyHeart;
            Hearts[1].sprite = EmptyHeart;
            Hearts[0].sprite = HalfHeart;
        }
        if(PlayerHealth == 0)
        {
            Hearts[2].sprite = EmptyHeart;
            Hearts[1].sprite = EmptyHeart;
            Hearts[0].sprite = EmptyHeart;
            Lives--;
            PlayerHealth = 6;
        }
        LivesDisplay.text ="Lives: " + dbMgr.dbLives.ToString();
    }
}
