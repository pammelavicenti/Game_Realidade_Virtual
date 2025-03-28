using UnityEngine;

public class Movimentacao : MonoBehaviour
{
    public int a = 1;
    private int c = 10;

    public float b = 50.5f;

    public GameObject meuCubo;

    private Transform meuTransform;

    public float velocidade = 1.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        

        meuTransform = meuCubo.GetComponent<Transform>();


    }

    // Update is called once per frame
    void Update()
    {
        Movimentar();
    }

    public void Movimentar()
    {
        //meuCubo.transform.position = new Vector3(0, 1, 0);
        meuTransform.position = new Vector3(meuTransform.position.x + velocidade, meuTransform.position.y, meuTransform.position.z);

    }
}
