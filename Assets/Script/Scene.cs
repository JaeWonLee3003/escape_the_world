using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{

    public string sceneToLoad;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }

}