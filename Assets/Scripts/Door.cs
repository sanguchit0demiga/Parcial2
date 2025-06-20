using UnityEngine;

public class Door : TempleObjects
{
   private bool isOpen = false; //variable para saber si la puerta esta abierta o no(empieza cerrada)

    public override void Interact()
    {
        if (!isOpen) //si la puerta no esta abierta
        {
            //busca el objeto PlayerInventory en la escena
            PlayerInventory inventory = Object.FindAnyObjectByType<PlayerInventory>();

            //se encontro el inventario y que tenia una llave
            if (inventory != null && inventory.HasKey)
            {
                isOpen = true;
                Debug.Log("abriste la puerta con la llave");
               
                gameObject.SetActive(false); //desactiva la puerta 
            }
            else
            {
                Debug.Log("necesitas una llave");
            }
        }
        
    }
}