using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void IniciarJogo()
    {
        // Troque "CenaDoJogo" pelo nome exato da cena principal
        SceneManager.LoadScene("MainScreen");
    }
}
