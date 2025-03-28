using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyCollision : MonoBehaviour
{
    private SistemaDePontos sistemaDePontos;

    private void Start()
    {
        sistemaDePontos = GameObject.Find("Pontuacao").GetComponent<SistemaDePontos>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(2);
        }
        else if (other.CompareTag("Tiro"))
        {
            sistemaDePontos.AdicionarPontos(10);
            Destroy(other.gameObject);
            Destroy(gameObject);

        }  
        else if (other.CompareTag("End"))
        {
            sistemaDePontos.RetirarVida(1);
            Destroy(gameObject);
            
            if(sistemaDePontos.vidas == 0)
            {
                SceneManager.LoadScene(2);
            }
        }





    }

}
