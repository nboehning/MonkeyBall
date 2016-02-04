using UnityEngine;
using System.Collections;

public class BananaTouch : MonoBehaviour {
    


	// Update is called once per frame
	void Update ()
    {
        // Make sure you always have a touch before trying to
        // compute touches
        if (Input.touchCount <= 0)
            return;

        foreach(Touch next in Input.touches)
        {
            if(next.phase == TouchPhase.Began)
            {
                // Moved - Move the finger over screen
                // Stationary - Holding the finger in one spot
                // Ended - Self explanatory
                // Canceled - Errored out

                RaycastHit hit;
                Ray touchRay = Camera.main.ScreenPointToRay(next.position);

                if(Physics.Raycast(touchRay, out hit))
                {
                    // Grab the object and senda message, seaching all scripts on object until it finds a "Touched" function
                    // Calles the touched function and erases any error messages if it doesn't find the function
                    hit.transform.parent.gameObject.SendMessage("Touched", SendMessageOptions.DontRequireReceiver);
                    Debug.Log(hit.transform.gameObject.name);
                }
            }
        }
	}
}
