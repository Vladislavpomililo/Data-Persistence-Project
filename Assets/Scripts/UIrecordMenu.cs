using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIrecordMenu : MonoBehaviour
{
    [SerializeField] private Text record_1;

    private string recordStringName;
    private int recordIntCount;

    private void Start()
    {
       LoadRecord();

       record_1.text = "1. "+ recordStringName + " : " + recordIntCount+ " очей.";
    }


    [Serializable]
    class SaveData
    {
        public string Name;
        public int Record;
    }

    public void LoadRecord()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            recordStringName = data.Name;
            recordIntCount = data.Record;
        }
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
