using UnityEngine;

public class Trap : TempleObjects
{
    //variable privada porque funciona como mecanismo interno
    private bool isActivated = false;
    public override void Interact()
    { //al interactuar se actriva
        if (!isActivated)
        {
            isActivated = true;
            Debug.Log("trap activada");
        }
        else
        { //si ya estaba activa no se puede activar de nuevo
            Debug.Log("la trap ya se activó");
        }
    }
    private void OnTriggerEnter2D(Collider2D other) //logica para que la trap le haga daño al player
    {
        if (isActivated && other.CompareTag("Player")) //verifica si la trampa esta activada y si el objeto que entra en el collider es el jugador
        {
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>(); //busca el componente PlayerHealth en el jugador
            if (playerHealth != null) //si se encontro el componente PlayerHealth, significa que el jugador tiene vida
            {
                playerHealth.TakeDamage(1);
                Debug.Log("ay la trap me hizo daño");
            }
        }
    }
}
