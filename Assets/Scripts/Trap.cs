using UnityEngine;

public class Trap : TempleObjects
{
    //variable privada porque funciona como mecanismo interno
    private bool isActivated = false;
    public override void Interact()
    {
        if (!isActivated)
        {
            isActivated = true;
            Debug.Log("Trap activated");
        }
        else
        {
           Debug.Log("Trap is already activated");
        }
    }
}
