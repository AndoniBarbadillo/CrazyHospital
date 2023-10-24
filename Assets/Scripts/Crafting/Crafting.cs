using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crafting : MonoBehaviour
{
    public CraftingEnabler craftingenabler;
    [SerializeField] GameObject MesaCrafteo;
    public float maxRaycastDistance;
    bool isObjectPlaced = false;

    private void Awake()
    {
        craftingenabler.GetComponent<CraftingEnabler>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(MesaCrafteo.transform.position, Vector3.up);

        // Declara una variable para almacenar la información de colisión
        RaycastHit hit;

        // Realiza el raycast
        if (Physics.Raycast(ray, out hit, maxRaycastDistance))
        {

          GameObject  hitobject = hit.collider.gameObject;
            // Comprueba si el objeto que ha colisionado tiene un componente Collider
            if (hit.collider == null)
            {
                // Acción a realizar cuando un objeto cae sobre el cubo

                isObjectPlaced = false;
                

                // Puedes realizar acciones adicionales aquí, como cambiar el material, aplicar fuerzas, etc.
            }
            
            if(hit.collider !=null)
            {
                Debug.Log("Objeto detectado: " + hitobject.name);
                if (hitobject.CompareTag("Medizinak"))
                {
                    isObjectPlaced = true;
                }
                
               
            }

           
            
        }

        // Dibuja el raycast en el editor
        Debug.DrawRay(MesaCrafteo.transform.position, Vector3.up * maxRaycastDistance, Color.red);

        if (craftingenabler.enableCrafting)
        {
            Debug.Log("Si Crafteo");
            Crafteo();
            
        }
        else
        {
            Debug.Log("No Crafteo");
        }
    }
    
    void Crafteo()
    {
        if (isObjectPlaced)
        {
            Debug.Log("Hay un material de crafteo");
        }
        else if(!isObjectPlaced)
        {
            Debug.Log("No hay material de crafteo");
        }
    }

  
}
