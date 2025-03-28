using TMPro;
using UnityEngine;

public class SistemaDePontos : MonoBehaviour
{
    public int pontos = 0;
    public int vidas = 3;

    public TextMeshProUGUI textoPontos;
    public TextMeshProUGUI textoVidas;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AdicionarPontos(int pontosParaAdicionar)
    {
        pontos += pontosParaAdicionar;
        textoPontos.text = pontos.ToString();
    }

    public void RetirarVida(int vidas)
    {
        this.vidas -= vidas;
        textoVidas.text = vidas.ToString();
    }





}
