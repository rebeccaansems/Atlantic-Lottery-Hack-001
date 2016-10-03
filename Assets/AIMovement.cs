using UnityEngine;
using System.Collections;

public class AIMovement : MonoBehaviour {

    int framesToChangeDirection, frameCounter;
    float xMovement, yMovement;

	// Use this for initialization
	void Start () {
        framesToChangeDirection = Random.Range(60, 360);

        frameCounter = 0;
        xMovement = Random.Range(-0.07f, 0.07f);
        yMovement = Random.Range(-0.07f, 0.07f);
    }
	
	// Update is called once per frame
	void Update () {

        if(frameCounter == framesToChangeDirection)
        {
            frameCounter = 0;
            xMovement = Random.Range(-0.07f, 0.07f);
            yMovement = Random.Range(-0.07f, 0.07f);
        }

        if(transform.position.x < -7.5 || transform.position.x > 7.5)
        {
            xMovement = xMovement * -1;
        }

        if (transform.position.y < -2.3 || transform.position.y > 4.2)
        {
            yMovement = yMovement * -1;
        }

        this.transform.position = new Vector2(this.transform.position.x + xMovement, this.transform.position.y + yMovement);
        frameCounter++;
    }
}
