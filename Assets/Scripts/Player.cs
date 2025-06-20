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
            ClosestObject(); //tmb llama al ClosestObject para asegurarse de que el objeto mas cercano se actualice antes de interactuar
            if (closest != null) //verifica si hay un objeto cercano para interactar y luego llama al metodo o no
            {
                closest.Interact();
            }
            else
            {
                Debug.Log("no hay objetos cercanos para interactuar");
            }
        }
    }

        void ClosestObject()
        {

            //aca se obtuenen todos los objetos que heredan de templeobjects
            TempleObjects[] objects = Object.FindObjectsByType<TempleObjects>(FindObjectsSortMode.None);
            float menorDistancia = Mathf.Infinity; 
            closest = null; 


            //se recorre el array de objetos y se calcula la distancia al jugador y el mas cercano
            foreach (TempleObjects obj in objects) {
                float distance = Vector2.Distance(transform.position, obj.transform.position); //calcula la distancia entre el jugador y el objeto
            if (distance < menorDistancia && distance <= interactionRange) //verifica si la distancia es menor a la menor distancia encontrada y si esta dentro del rango de interaccion
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


