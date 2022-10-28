using UnityEngine;

public class Timedest : MonoBehaviour
{
    [SerializeField]
    GameObject obj;

    public void DestroyObj()
    {
        if(Input.GetKeyUp(KeyCode.J))
        {
            Destroy(obj);
        }

    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


}
