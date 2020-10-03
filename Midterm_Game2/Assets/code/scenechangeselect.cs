using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scenechangeselect : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   
    public void StageOneButtonClick(Button button){
            SceneManager.LoadScene("stageOne");
    }
    public void StageTwoButtonClick(Button button){
            SceneManager.LoadScene("stageTwo");
    }
   
}
