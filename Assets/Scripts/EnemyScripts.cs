using UnityEngine;
using UnityEngine.UI;

public class EnemyScripts : MonoBehaviour
{
    GameObject[] enemy;

    public float Speed;

    public Text text;

    GameObject button;

    public Button WinButton;
    public Button LoseButton;

    void Start()
    {
        gameObject.SetActive(false);

        button = GameObject.FindGameObjectWithTag("Win Button");
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
            PlayerScript.Destroy(GameObject.FindGameObjectWithTag("Player"));

            LoseButton.gameObject.SetActive(true);
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
                    PlayerScript.Destroy(GameObject.FindGameObjectWithTag("Player"));
                    text.text = "You Win";
                    WinButton.gameObject.SetActive(true);
                }
            }
        }
    }
}
