using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    
    private float checkPointPositionX, checkPointPositionY;

    void Start()
    {
        if (PlayerPrefs.GetFloat("checkPointPositionX")!=0)
        {
            transform.position=(new Vector2(PlayerPrefs.GetFloat("checkPointPositionX"), PlayerPrefs.GetFloat("checkPointPositionY")));
           
        }
    }

    public void ReachedCheckPoint(float x,float y)
    {
        PlayerPrefs.SetFloat("checkPointPositionX", x);

        PlayerPrefs.SetFloat("checkPointPositionX", y);
    }
    public void PlayerDamaged()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
   
}
