using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour
{
    public Text healthText;
    public Image healthBar;
    public int MaxHealth;
    public int healthNum;
    // Start is called before the first frame update
    void Start()
    {
        healthBar = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = (float)healthNum / (float)MaxHealth;
        healthText.text = healthNum.ToString() + "/" + MaxHealth.ToString();
    }
    public void Addhealth()
    {
        healthNum++;
    }
    public void Hurt()
    {
            healthNum--;
    }
  
  
}
