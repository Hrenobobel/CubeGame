using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] KeyCode KeyOne;
    [SerializeField] KeyCode KeyTwo;
    [SerializeField] Vector3 MoveDirection;

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyOne))
        {
            GetComponent<Rigidbody>().velocity += MoveDirection;
        }
        if (Input.GetKey(KeyTwo))
        {
            GetComponent<Rigidbody>().velocity -= MoveDirection;
        }
        if (Input.GetKey(KeyCode.Q))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (this.CompareTag("Player") && other.CompareTag("Finish"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
