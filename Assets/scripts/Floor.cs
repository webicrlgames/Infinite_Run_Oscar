using UnityEngine;

public class Floor : MonoBehaviour
{
    public float speed;
    public Vector3 Fstart;
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("FDeath"))
        {
            Destroy(this.gameObject);
        }
    }
}
