using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour
{
    public Text cherryText;
    public Text gemText;
    public Text healthText;
    public Image healthBar;
    public int MaxHealth;
    public int cherryNum;
    public int gemNum;
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
        cherryText.text = cherryNum.ToString();
        gemText.text = gemNum.ToString();
    }
    public void Addhealth()
    {
        if (healthNum < 4 && cherryNum > 0)
        {
            healthNum++;
            cherryNum--;
        }
    }
    public void Hurt()
    {
            healthNum--;
    }
  
  
}
