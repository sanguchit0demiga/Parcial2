using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    public float interactionRange = 2f;
    private TempleObjects closest;
    void Update()
    {

        //el jugador se mueve en x
        float movement = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * movement * speed * Time.deltaTime);

        // busca el objeto mas cercano al presionar R
        if (Input.GetKeyDown(KeyCode.R))
        {
            ClosestObject();
        }

        // interactua con un objeto cercano al presionar E
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (closest != null)
            {
                closest.Interact(); //esto seria polimorfismo xq llamo al metodo sin importar si es un trap, enemy o door
            }
            else
            {
                Debug.Log("no hay objetos cercanos para interactuar");
            }
        }

        void ClosestObject()
        {

            //aca se obtuenen todos los objetos que heredan de templeobjects
            TempleObjects[] objects = FindObjectsOfType<TempleObjects>();
            float menorDistancia = Mathf.Infinity;
            closest = null;


            //se recorre el array de objetos y se calcula la distancia al jugador y el mas cercano
            foreach (TempleObjects obj in objects) {
                float distance = Vector2.Distance(transform.position, obj.transform.position);
                if (distance < menorDistancia && distance <= interactionRange)
                {
                    menorDistancia = distance;
                    closest = obj;
                }
            }
            if (closest != null)
            {
                Debug.Log("objecto cercano: " + closest.name);
            }
            else
            {
                Debug.Log("no hay obj dentro del rango");
            }
        }
    }
}

