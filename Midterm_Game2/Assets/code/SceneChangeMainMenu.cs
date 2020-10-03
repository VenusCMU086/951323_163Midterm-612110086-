using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChangeMainMenu : MonoBehaviour
{
   public void StageButtonClick(Button button){
       SceneManager.LoadScene("stageSelect");
   }

   public void OptionsButtonClick(Button button){
       if(!gameManager.Instance.OptionActivate){
           SceneManager.LoadScene("Options", LoadSceneMode.Additive);
           gameManager.Instance.OptionActivate = true;
       }
   }
    public void HelpButtonClick(Button button){
             SceneManager.LoadScene("Credit");
       }

    public void ExitButtonClick(Button button){
        Application.Quit();
    }
}
