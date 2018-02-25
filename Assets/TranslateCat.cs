using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateCat : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}



    public IEnumerator MoveCat(Vector3 targetPos) {

        float lerpCount = 0;

        while (true)
        {
            
            Vector3 currPos = Vector3.Lerp(transform.position, targetPos, lerpCount);

            transform.position = currPos;

            lerpCount += Time.deltaTime / 5.0f;

            if(lerpCount >= 1)
            {
                transform.position = targetPos;
                break;
            }

            yield return null;
        }
    }
}
