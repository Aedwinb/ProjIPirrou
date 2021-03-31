using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractSkill : MonoBehaviour
{
    public GameObject target;
    Vector3 originalPosition;
    float timer;
    bool startTimer = false;
    [SerializeField] UnityEngine.Events.UnityEvent eventList;

    // Start is called before the first frame update
    void Start()
    {
        originalPosition = this.transform.position;
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.GetComponent<OVRGrabbable>().isGrabbed == false)
        {
            //this.transform.position = Vector3.MoveTowards(this.transform.position, originalPosition, 0.4f);
            this.transform.position = originalPosition;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            this.gameObject.SetActive(false);
            eventList.Invoke();
        }
    }
}
