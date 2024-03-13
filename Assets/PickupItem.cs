using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItem : MonoBehaviour
{
    /* distance de ramassage d'objet */
    [SerializeField]
    private float pickupRange = 2.6f;

    public Inventory inventory;
 
    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if(Physics.Raycast(transform.position, transform.forward, out hit, pickupRange))
        {

            if(hit.transform.CompareTag("Item"))
            {
                Debug.Log("There is an item in front of us");

                /* Si on appuye sur E, ça ajoute l'item dans l'inventaire */
                if (Input.GetKeyDown(KeyCode.E)) 
                {
                    inventory.content.Add(hit.transform.gameObject.GetComponent<Item>().item);
                    Destroy(hit.transform.gameObject);
                }
            }

        }

    }
}
