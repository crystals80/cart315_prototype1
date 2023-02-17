using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpper : MonoBehaviour
{

    public int count = 0;
    public GameObject particlePrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("ToPickUp"))
        {
            GameObject.Instantiate(particlePrefab, gameObject.transform.position, Quaternion.identity);

            GameObject.Destroy(collision.collider.gameObject);

            count++; // or count = count + 1;

            this.GetComponent<AudioSource>().Play();

            Debug.Log("Pick-Up Count" + count);
        }
    }
}