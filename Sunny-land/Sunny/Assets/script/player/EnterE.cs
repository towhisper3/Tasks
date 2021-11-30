using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterE : MonoBehaviour
{
    public GameObject EnterDialog;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "door")
        {
            EnterDialog.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "door")
        {
            EnterDialog.SetActive(false);
        }
    }
}
