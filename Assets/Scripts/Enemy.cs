using UnityEngine;
//clase base de enemy,sus caracteristicas principales son que tiene vida, puede tomar daño y se destruye
public class Enemy : TempleObjects
{
    protected int vida = 3; //protected xq solo pueden acceder clases hijas y esta misma clase, esto es una forma de encapsulamiento
   

    public override void Interact()
    {
        TakeDamage(1); //llama al metodo de la clase base TempleObjects, que es el que se encarga de tomar daño
    }

    public virtual void TakeDamage(int damage)
    {
        vida -= damage; //reduce la vida del enemigo
        Debug.Log("vida restante: " + vida);
        if (vida <= 0)
        {
            Die();
            
        }
    }
    public virtual void Die()
    {
   
        Destroy(gameObject); //destruye al enemigo
    }
}
