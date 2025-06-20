using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    //se maneja el inventario del jugador (por ahora con la llave)
    public bool HasKey { get; set; } = false;

    //el get y el set en este caso serian 
    //get me deja mirar adentro de mi bolsillo si la llave esta ahi
    //set me deja meter la llave en mi bolsillo o sacarla de ahi
}
