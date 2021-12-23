using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainManagerMenu : MonoBehaviour
{
    public static MainManagerMenu Instance;

    public string name;
    public int record;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        MainManager mainManager = new MainManager();
        mainManager.LoadRecord();
    }
}
