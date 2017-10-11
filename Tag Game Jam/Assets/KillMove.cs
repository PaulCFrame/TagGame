using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillMove : MonoBehaviour
{
    public GameObject paulWins;
    public GameObject tristanWins;
    public GameObject paul;
    public GameObject tristan;
    public bool gameOver;

    public void Start()
    {
        gameOver = false;
    }

    public void Update()
    {
        if (gameOver == true)
        {
            if (Input.anyKey)
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene("PaulScene");
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "paul")
        {
            //disable script that locks position
            tristanWins.SetActive(true);
            paul.GetComponent<PaulMove>().enabled = false;
            gameOver = true;
        }

        if (other.gameObject.tag == "tristan")
        {
            //disable script that locks position
            paulWins.SetActive(true);
            paul.GetComponent<TristanMove>().enabled = false;
            gameOver = true;
        }
    }
}
