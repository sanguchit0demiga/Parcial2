using UnityEngine;

public class Key : MonoBehaviour
{
    //cuando el jugador entra en contacto con la llave se le agrega al inventario y se destruye la llave
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("llave agarrada");
            PlayerInventory inv= other.GetComponent<PlayerInventory>();
            if (inv != null)
            {
               inv.HasKey = true; //le dice al inventario del jugador que tiene una llave
                Destroy(gameObject); //destruye la llave
            }
        }
    }
}
