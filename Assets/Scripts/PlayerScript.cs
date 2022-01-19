using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float Speed;

    void Start()
    {
        gameObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            //if (Input.GetKeyDown(KeyCode.S))
            //{
            //    transform.Rotate(new Vector3(0, 0, 180));                
            //}

            transform.Translate(transform.forward * Time.deltaTime * Speed);

            //if (Input.GetKeyUp(KeyCode.S))
            //{
            //    transform.Rotate(new Vector3(0, 0, 0));
            //}

        }
        if (Input.GetKey(KeyCode.W))
        {
            //if (Input.GetKeyDown(KeyCode.W))
            //{
            //    transform.Rotate(new Vector3(0, 0, 0));
            //    transform.Rotate(new Vector3(0, 0, 0));                
            //}

            transform.Translate(-transform.forward * Time.deltaTime * Speed);

            //if (Input.GetKeyUp(KeyCode.W))
            //{
            //    transform.Rotate(new Vector3(0, 0, 0));
            //}
        }
        if (Input.GetKey(KeyCode.A))
        {
            //if (Input.GetKey(KeyCode.A))
            //{
            //    transform.Rotate(new Vector3(0, 0, 0));
            //    transform.Rotate(new Vector3(0, 0, -90));               
            //}

            transform.Translate(-transform.right * Time.deltaTime * Speed);

            //if (Input.GetKeyUp(KeyCode.A))
            //{
            //    transform.Rotate(new Vector3(0, 0, 0));
            //    transform.Rotate(new Vector3(0, 0, 0));
            //}

        }
        if (Input.GetKey(KeyCode.D))
        {
            //if (Input.GetKeyDown(KeyCode.D))
            //{
            //    transform.Rotate(new Vector3(0, 0, 0));
            //    transform.Rotate(new Vector3(0, 0, 90));                
            //}

            transform.Translate(transform.right * Time.deltaTime * Speed);

            //if (Input.GetKeyUp(KeyCode.D))
            //{
            //    transform.Rotate(new Vector3(0, 0, 0));
            //}
        }
    }
}
