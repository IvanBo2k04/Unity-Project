using UnityEngine;

public class EnemyScripts : MonoBehaviour
{
    //public GameObject BackWall;

    PlayerScript player;

    public float Speed;

    void Start()
    {
        player = GameObject.FindObjectOfType<PlayerScript>();
    }


    void Update()
    {
        transform.Translate(-transform.forward * Time.deltaTime * Speed);

        if (Vector3.Distance(transform.position, player.transform.position) < 2f)
        {
            Destroy(gameObject);
        }
    }
}
