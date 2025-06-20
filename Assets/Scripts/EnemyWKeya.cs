using UnityEngine;

//hereda de la clase base enemy, pero este dropea una llave para desbloquear un a puerta
public class EnemyWKeya : Enemy
{
    public GameObject keyPrefab; //prefab de la llave que va a dropear al morir
   
   
    public override void Die()
    {
        base.Die(); //llama al metodo de la clase base Enemy, que es el que se encarga de destruir al enemigo
        Debug.Log("omg el enemigo dropeo una llave :OOOOOOOOOOOwtf)");
        Instantiate(keyPrefab, transform.position, Quaternion.identity); //instancia la llave en la posicion del enemigo
    }
}
