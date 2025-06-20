using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int vida = 5; //tiene vida y puede ser recibir daño, esta logica se aplica cuando colisiona con trap

    public void TakeDamage(int damage)
    {
        vida -= damage;
        Debug.Log("vida del player: " + vida);

        if (vida <= 0)
        {
            Debug.Log("moriste");
            ReiniciarEscena();
        }
    }
    public void ReiniciarEscena() //si muere se reinicia la escena
    {
        Scene escenaActual = SceneManager.GetActiveScene();
        SceneManager.LoadScene("Game");
    }
}
