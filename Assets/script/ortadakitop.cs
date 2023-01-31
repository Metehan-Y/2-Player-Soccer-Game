using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ortadakitop : MonoBehaviour
{

    public Text yesilscore;
    public Text maviscore;
    public static int yesilsayi;
    public static int mavisayi;
    public GameObject goal;
    bool gol=false;
    bool bekleme = false;
    public AudioSource adsc;
    public Rigidbody rb;
    public float hiz = 10.0f;
    public bool duvar = false;
    public bool top1degdi = false;
    public bool topdegdi = false;
        
    

    private void Update() 
    {
        yesilscore.text = yesilsayi.ToString();
        maviscore.text = mavisayi.ToString();
        StartCoroutine ("Coutdown");
       

        
    }

    

   
    private void OnTriggerEnter(Collider temas) 
    {
        if(temas.gameObject.tag.Equals("mavi"))
        {
            Debug.Log("mavideyim");
            if(bekleme == false)
            {
                adsc.Play();
                yesilsayi += 1;
                gol=true;
            }
            


        }
        else if(temas.gameObject.tag.Equals("yesil"))
        {
            Debug.Log("yesildeyim");
            if(bekleme == false)
            {
                adsc.Play();
                mavisayi +=1;
                gol=true;
            }
            
        }

        
       

    }
    

    void OnCollisionEnter(Collision temas)
    {
        if(temas.gameObject.tag.Equals("top"))
        {
            topdegdi = true;
            
        }
        else if(temas.gameObject.tag.Equals("top1"))
        {
             
            top1degdi = true;

        }
        else if(temas.gameObject.tag.Equals("duvar"))
        {
            duvar=true;
            top1degdi=false;
            topdegdi=false;
        }
        
    
        if(temas.gameObject.tag.Equals("top") && top1degdi == true)
        {
            Vector3 direction = transform.position - temas.transform.position;
            direction = direction.normalized;
            GetComponent<Rigidbody>().velocity = direction *  (-2);
            Debug.Log("2kat ters yon");
        }
        else if(temas.gameObject.tag.Equals("top1") && topdegdi == true)
        {
            Vector3 direction = transform.position - temas.transform.position;
            direction = direction.normalized;
            GetComponent<Rigidbody>().velocity = direction *  (-2);
            Debug.Log("2kat ters yon");
        }
        else
        {
            Debug.Log("ekstrahizyok");
        }
        
    }
    
    private IEnumerator Coutdown()
    {
        if(gol == true)
        {
            bekleme = true;
            goal.SetActive(true);

            yield return new WaitForSeconds (3);
            
            bekleme = false;
            goal.SetActive(false);
            this.gameObject.transform.position = new Vector3(-13.54f,4.323f,0.47f);
            gol = false;
           
            
        }
       
       
    }

  
}