using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private AudioClip som;
    private AudioSource player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Jogar() 
    {
        TocarSom();
        Invoke("SelPersonagem", 1f);

    }  

    public void Creditos()
    {
        SceneManager.LoadScene("Creditos");
    }

    public void MenuPrincipal()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }

    public void Configuracao()
    {
        SceneManager.LoadScene("Configuracao");
    }

    public void Sonic()
    {
        SceneManager.LoadScene("Sonic");
    }
    public void Sanji()
    {
        SceneManager.LoadScene("Sanji");
    }
    public void Ghost()
    {
        SceneManager.LoadScene("Ghost");
    }

    public void TocarSom()
    {
        player.PlayOneShot(som);
    }

    public void SelPersonagem()
    {
        SceneManager.LoadScene("SelPersonagem");
    }

    public void Dungen()
    {
        SceneManager.LoadScene("Dungen");
    }

    public void DungenEnter()
    {
        SceneManager.LoadScene("DungenEnter");
    }

    public void DungenBattle()
    {
        SceneManager.LoadScene("DungenBattle");
    }

    public void ProximaFase()
    {
        SceneManager.LoadScene("ProximaFase");
    }

    public void Bonus()
    {
        SceneManager.LoadScene("Bonus");
    }

    public void Bonus2()
    {
        SceneManager.LoadScene("Bonus2");

    }

    public void BonusFinal()
    {
        SceneManager.LoadScene("BonusFinal");
    }
}
