using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingEnabler : MonoBehaviour
{
    public GameObject CraftingTable;
    public Material newMaterial;
    public Material oldMaterial;
    [SerializeField] private GameObject CrafteonOn;
    [SerializeField] private GameObject CrafteonOff;

    public bool enableCrafting = false;

    private void Awake()
    {

        CrafteonOn.SetActive(false);
        CrafteonOff.SetActive(true);
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("CraftingTable"))
        {
            
            CraftingTable.GetComponent<Renderer>().material = newMaterial;
            enableCrafting = true;
            CrafteonOn.SetActive(true);
            CrafteonOff.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("CraftingTable"))
        {
            
            CraftingTable.GetComponent<Renderer>().material = oldMaterial;
            enableCrafting = false;
            CrafteonOn.SetActive(false);
            CrafteonOff.SetActive(true);

        }
    }
}
