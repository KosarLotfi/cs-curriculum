using TMPro;
using UnityEngine;
using UnityEditor.Purchasing;

public class HUD : MonoBehaviour
{
    public static HUD hud;
    public int coins;
    public int health;
    public int maxhealth;
    public TextMeshProUGUI coinText;
    public TextMeshProUGUI healthText;

    void Awake()
    {
        if (hud != null && hud != this)
        {
            Destroy(gameObject);
        }
        else
        {
            hud = this;
            DontDestroyOnLoad(gameObject);
        }
    }



    // Start is called before the first frame update
    void Start()
    {
        coins = 0;
        maxhealth = 3;
        health = maxhealth;
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = "coins " + coins;
        healthText.text = "health " + health;
    }
}
