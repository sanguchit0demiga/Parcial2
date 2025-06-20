using UnityEngine;

public abstract class TempleObjects : MonoBehaviour, IInteractable
{
    public abstract void Interact();
   
}

//todo lo que sea un objeto dentro del templo va a heredar esta clase y por lo tanto van a tener el metodo para interactuar