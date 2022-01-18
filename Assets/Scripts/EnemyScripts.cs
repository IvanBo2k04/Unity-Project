using UnityEngine;
using UnityEngine.UI;

public class EnemyScripts : MonoBehaviour
{
    GameObject[] enemy;

    public float Speed;

    public Text text;

    void Start()
    {
        gameObject.SetActive(false);
    }

    void Update()
    {
        transform.Translate(-transform.forward * Time.deltaTime * Speed);

        enemy = GameObject.FindGameObjectsWithTag("Enemy");
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            foreach (GameObject go in enemy)
            {
                Destroy(go);

                text.text = "You Lose";
            }
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            foreach (GameObject go in enemy)
            {
                Destroy(gameObject);

                int i = enemy.Length - 1;

                if (i == 0)
                {
                    text.text = "You Win";
                }
            }
        }
    }
}
