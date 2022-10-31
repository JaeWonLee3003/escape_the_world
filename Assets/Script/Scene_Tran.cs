using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Tran : MonoBehaviour
{
    private const bool V = false;
    private bool isEnter = V;
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject gameObject = collision.gameObject;
        if (gameObject.CompareTag("Tpblock"))
        {
            isEnter = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isEnter == true)
        {
            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
               // Scene.LoadScene(Define.Scene.Game);
            }
        }
    }


}
