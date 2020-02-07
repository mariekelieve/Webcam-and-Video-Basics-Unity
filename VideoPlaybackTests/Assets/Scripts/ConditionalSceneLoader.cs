using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using SimpleVAS;

public class ConditionalSceneLoader : MonoBehaviour
{
    public bool changeOnKey;

    public static int currentCondition;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (changeOnKey)
            if (Input.GetKeyDown("space"))
                OnNextButton();
    }


    public void OnNextButton() {
        string sceneToLoad = ConditionDictionary.selectedOrder[QuestionManager.currentCondition];
        if (sceneToLoad != "")
                SceneManager.LoadScene(sceneToLoad);
        else
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

