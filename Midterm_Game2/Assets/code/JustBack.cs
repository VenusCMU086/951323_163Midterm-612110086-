using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JustBack : MonoBehaviour
{
    [SerializeField] Button backBB;
     void Update()
    {
        backBB.onClick.AddListener(delegate{BackToTheFutureButtonClick(backBB);});
    }

    // Start is called before the first frame update
    public void BackToTheFutureButtonClick(Button button){
            SceneManager.UnloadSceneAsync("stageSelect");
            SceneManager.LoadScene("MainMenu");
    }
}
