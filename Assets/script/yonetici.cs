using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class yonetici : MonoBehaviour
{
    public GameObject panel,pausepanel,mavitop,yesiltop,ortatop;
    public static bool oyunbasladi = false;
    public bool pauseacik = false;
    
    
    public void oyna()
    {
        panel.SetActive(false);
        oyunbasladi = true;
        ortadakitop.yesilsayi = 0;
        ortadakitop.mavisayi = 0;
        mavitop.transform.position = new Vector3(-9.05f,4.21f,0.47f);
        yesiltop.transform.position = new Vector3(-19.08f,4.35f,0.47f);
        ortatop.transform.position = new Vector3(-13.54f,4.323f,0.47f);
        Time.timeScale = 1f;

    }
    
    private void Update() 
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(oyunbasladi == true && pauseacik == false)
            {
                pausepanel.SetActive(true);
                Time.timeScale =0f;
                pauseacik = true;
            }
            else if(oyunbasladi == true && pauseacik == true)
            {
                pausepanel.SetActive(false);
                Time.timeScale=1f;
                pauseacik = false;
            }    
        }

    }
    public void mneuyedon()
    {
        panel.SetActive(true);
        oyunbasladi = false;
        pausepanel.SetActive(false);
        pauseacik = false;
        

    }
}
