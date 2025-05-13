using UnityEngine;
using UnityEngine.SceneManagement;

public class menuPrincipalMenager : MonoBehaviour
{
    [SerializeField] private GameObject menuMain;
    [SerializeField] private GameObject menuoptions;

    public void jogar()
    {

    }
    public void abrirOptions()
    {
        menuMain.SetActive(false);
        menuoptions.SetActive(true);

    }
    public void fecharOptions()
    {
        menuoptions.SetActive(false);
        menuMain.SetActive(true);
        
    }
    public void abrirCredits()
    {

    }
    public void fecharCredits()
    {

    }

}
