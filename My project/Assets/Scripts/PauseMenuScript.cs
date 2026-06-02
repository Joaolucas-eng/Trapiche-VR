using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI; // arraste o Canvas do menu de pausa aqui no Inspector
    private bool isPaused = false;

    void Update()
    {
        // Ativa/desativa o menu quando o jogador aperta ESC
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Retornar();
            }
            else
            {
                Pausar();
            }
        }
    }

    public void Pausar()
    {
        pauseMenuUI.SetActive(true);   // mostra o menu
        Time.timeScale = 0f;           // congela o jogo
        isPaused = true;
    }

    public void Retornar()
    {
        pauseMenuUI.SetActive(false);  // esconde o menu
        Time.timeScale = 1f;           // volta ao tempo normal
        isPaused = false;
    }

    public void Sair()
    {
        Time.timeScale = 1f;           // garante que o tempo volte ao normal
        SceneManager.LoadScene(0); // pal
    }
}