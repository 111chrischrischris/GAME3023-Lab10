using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class Save : MonoBehaviour
{
    public GameObject PlayerFile;

    public Animator animator;

    public void SaveGame()
    {
        SaveSystem.SavePlayer(PlayerFile.GetComponent<Player>());
        animator.SetTrigger("FadeOut");
        EditorSceneManager.LoadScene("StartMenu", UnityEngine.SceneManagement.LoadSceneMode.Single);
    }

}
