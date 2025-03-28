using UnityEngine;

public class Tiro : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private Rigidbody rb;
    public float velocidade = 10.0f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(-transform.right * velocidade, ForceMode.Impulse);

        Destroy(gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
