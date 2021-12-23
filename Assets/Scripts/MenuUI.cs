using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUI : MonoBehaviour
{
    [SerializeField] InputField inputFieldName;
    private string nameTest;

    private void Update()
    {
        if(inputFieldName.text != nameTest)
        {
            nameTest = inputFieldName.text;
            MainManagerMenu.Instance.name = inputFieldName.text;
        }
    }

    public void StartGame() 
    {
        SceneManager.LoadScene(1);
    }

    public void RecordGame()
    {
        SceneManager.LoadScene(2);
    }
}
