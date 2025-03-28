using UnityEngine;
using UnityEngine.InputSystem;

public class ChamarTiro : MonoBehaviour
{
    public GameObject tiro;
    public InputActionProperty input;
    private float frequenciaTiros = 0.25f;
    private float tempoUltimoTiro = 0f;

    public AudioSource somTiro;

   

    void Start()
    {
       input.action.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (input.action.IsPressed() && Time.time > tempoUltimoTiro)
        {
            Atirar();
            tempoUltimoTiro = Time.time + frequenciaTiros;
        }
    }

    public void Atirar()
    {
        Instantiate(tiro, transform.position, Quaternion.identity);
        somTiro.Play();
    }
}
