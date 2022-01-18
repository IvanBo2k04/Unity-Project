using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject Enemy;
    void Start()
    {

    }


    void Update()
    {

    }
    public void ButtonClick()
    {
        GameObject spawner = Instantiate(Enemy, transform.position, Quaternion.identity) as GameObject;
    }
}
