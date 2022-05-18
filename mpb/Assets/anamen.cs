using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class anamen : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("bolum1");
    }

    public void çıkıs()
    {
        Debug.Log("ÇIKIŞ YAPILDI");
        Application.Quit();
    }
    public void ANAMENDÖN()
    {
        SceneManager.LoadScene("anamenü");
    }
    public void sonrakibölüm()
    {
        SceneManager.LoadScene("bolum2");
    }
    public void PlayGame2()
    {
        SceneManager.LoadScene("bolum2");
    }
    public void BOLUMLER()
    {
        SceneManager.LoadScene("BOLUMLER");
    }
}
