using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private Text nameText;
    [SerializeField] private InputField namePlayer;

    public string Name;

    public static MenuManager Instance;

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    public void StartGame()
    {
        Name = namePlayer.ToString();
        SaveName();
        SceneManager.LoadScene(1);
    }

    public void LoadColorClicked()
    {
        LoadName();
    }

    [System.Serializable]
    class SaveData
    {
        public string Name;
    }

    public void SaveName()
    {
        SaveData data = new SaveData();
        data.Name = Name;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadName()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            Name = data.Name;
        }
    }
}
