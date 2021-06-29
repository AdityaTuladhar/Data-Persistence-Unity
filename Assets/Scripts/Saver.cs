using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class Saver : MonoBehaviour
{

    public static Saver Instance;

    public string PlayerName;

    public int HighScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    
    [System.Serializable]
    class SaveData
    {
        public int HighScore;
        public string PlayerName;
    }
    
    public void SaveScore()
    {
        SaveData data = new SaveData();
        data.PlayerName = PlayerName;
        data.HighScore = HighScore;

        string json = JsonUtility.ToJson(data);
        
        File.WriteAllText(Application.persistentDataPath+"/savefile.json",json);
    }

    public int HighestScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);

            SaveData data = JsonUtility.FromJson<SaveData>(json);

            return data.HighScore;
        }
        else
        {
            return 0;
        }
    }
    
    public string HighestScorePlayer()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);

            SaveData data = JsonUtility.FromJson<SaveData>(json);

            return data.PlayerName;
        }
        else
        {
            return null;
        }
    }
}
