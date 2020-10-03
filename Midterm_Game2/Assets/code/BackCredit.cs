using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackCredit : MonoBehaviour
{
    [SerializeField] Button backBB;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         backBB.onClick.AddListener(delegate{BackToTheFutureButtonClick(backBB);});
    }

     public void BackToTheFutureButtonClick(Button button){
            SceneManager.UnloadSceneAsync("Credit");
            SceneManager.LoadScene("MainMenu");
    }
}
