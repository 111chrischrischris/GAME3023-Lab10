using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyTrigger : MonoBehaviour
{
    public Animator musicAnim;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player player = collision.GetComponent<Player>();
        if (player != null)
        {
            StartCoroutine(ChangeScene());
        }
    }

    IEnumerator ChangeScene() 
    {
        musicAnim.SetTrigger("fadeOut");
        animator.SetTrigger("FadeOut");
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Battle");
        Debug.Log("Loaded Battle Scene");

    }
}
