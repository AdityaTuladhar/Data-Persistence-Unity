using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;

public class UiManager : MonoBehaviour
{
    public Text bestScore;

    public InputField nameField;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnStartClick()
    {
        Saver.Instance.PlayerName = nameField.text;
        SceneManager.LoadScene(1);
    }

    public void OnQuitClick()
    {
        EditorApplication.ExitPlaymode();
        Application.Quit();
    }
}
