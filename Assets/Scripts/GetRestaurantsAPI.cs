using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetRestaurantsAPI : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(getWWW());
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    IEnumerator getWWW()
    {
        // First define the url, this should be a valid url
        string url = "https://www.halalbites.org/api/latest-app-version/android";

        WWW www = new WWW(url);
        while (!www.isDone)
            yield return null;

        if (string.IsNullOrEmpty(www.error))
        {
            Debug.Log(www.text);

        }
        else
            Debug.Log(www.error);

    }
}
