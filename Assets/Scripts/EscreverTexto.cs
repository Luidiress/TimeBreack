using System.Collections;
using TMPro;
using UnityEngine;

public class EscreverTexto : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI texto;
    [TextArea]
    [SerializeField] private string mensagemCompleta;
    [SerializeField] private float velocidadeDigitacao = 0.05f;
    [SerializeField] private AudioSource velocidadeTexto = null;

    private bool escrevendo = false;

    void Start()
    {
        texto.text = "";
        StartCoroutine(DigitarTexto());
    }

    // Update is called once per frame
   private IEnumerator DigitarTexto()
    {
        escrevendo = true;
        foreach (char letra in mensagemCompleta)
        {
            texto.text += letra;
            yield return new WaitForSeconds(velocidadeDigitacao);
            
        }

        escrevendo = false;
    }
}
