using UnityEngine;

public class InfoTrigger : MonoBehaviour
{
    public GameObject painelParaMostrar;

    // Quando o jogador entra na área
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera") || other.name.Contains("XR Origin"))
        {
            painelParaMostrar.SetActive(true);
        }
    }

    // Quando o jogador sai da área
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera") || other.name.Contains("XR Origin"))
        {
            painelParaMostrar.SetActive(false);
        }
    }
}