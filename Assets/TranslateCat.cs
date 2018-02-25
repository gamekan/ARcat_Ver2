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
        float distance = Vector3.Distance(transform.position, targetPos);

        while (true)
        {
            
            Vector3 currPos = Vector3.Lerp(transform.position, targetPos, lerpCount);

            transform.position = currPos;

            lerpCount += Time.deltaTime / (distance * 10.0f);

            if(lerpCount >= 1)
            {
                transform.position = targetPos;
                break;
            }

            yield return null;
        }
    }
}
