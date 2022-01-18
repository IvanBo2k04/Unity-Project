using UnityEngine;
using UnityEngine.UI;

public class EnemyBossScript : MonoBehaviour
{
    Text Win;

    PlayerScript player;

    public float Speed;

    void Start()
    {
        player = GameObject.FindObjectOfType<PlayerScript>();
        Win = Text.FindObjectOfType<Text>();

    }


    void Update()
    {
        transform.Translate(-transform.forward * Time.deltaTime * Speed);

        if (Vector3.Distance(transform.position, player.transform.position) < 1f)
        {
            Destroy(gameObject);
            Win.text = "You win";
        }
    }
}

