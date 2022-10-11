using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float speed = 5.0f;
    private GameObject focalPoint;
    public bool roidRage;
    private float roidStrength = 15.0f;
    public GameObject roidRing;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("focalPoint");
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        playerRb.AddForce( focalPoint.transform.forward * speed * forwardInput);
        roidRing.transform.position = transform.position + new Vector3(0, 1f, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Steroids"))
        {
            roidRage = true;
            Destroy(other.gameObject);
            StartCoroutine(roidRecovery());
            roidRing.gameObject.SetActive(true);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Police") && roidRage)
        {
            Rigidbody enemyRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer = (collision.gameObject.transform.position - transform.position);
            Debug.Log("Collided with " + collision.gameObject.name + "with Roid meter set to" + roidRage);
            enemyRigidbody.AddForce(awayFromPlayer * roidStrength, ForceMode.Impulse);
        }
    }
    IEnumerator roidRecovery ()
    {
        yield return new WaitForSeconds(7);
        roidRage = false;
        roidRing.gameObject.SetActive(false);
    }
}
