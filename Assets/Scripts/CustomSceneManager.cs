using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Facebook.Unity;
using LitJson;

public class CustomSceneManager : MonoBehaviour {

    private string accessToken=null;
	// Use this for initialization
	void Start () {
        FB.Init(OnInitComplete);

    }

    // Update is called once per frame
    void Update () {
		
	}

    public void OpenLogin()
    {
        SceneManager.LoadScene("Login");
    }

    public void ExitApp()
    {
        Application.Quit();
    }

    public void FacebookLogin()
    {
        FB.LogInWithReadPermissions(new List<string>() { "public_profile", "email", "user_friends" }, this.HandleResult);

    }
    protected void HandleResult(IResult result)
    {
        if (result == null)
        {
            return;
        }


        Debug.Log("open home");
        SceneManager.LoadScene("Home");
        Debug.Log(result.ToString());
        /**
         * 
         * {"access_token":"...","user_id":"...","callback_id":"...","key_hash":"...","permissions":"...","expiration_timestamp":"...","last_refresh":"...","opened":...,"declined_permissions":"..."}
         */
        Debug.Log(result.RawResult.ToString());
        JsonData data = JsonMapper.ToObject(result.RawResult.ToString());
        Debug.Log(data["access_token"]);
        
    }

    private void OnInitComplete()
    {
        
        string logMessage = string.Format(
            "OnInitCompleteCalled IsLoggedIn='{0}' IsInitialized='{1}'",
            FB.IsLoggedIn,
            FB.IsInitialized);
        Debug.Log(logMessage);

        if (AccessToken.CurrentAccessToken != null)
        {
           Debug.Log(AccessToken.CurrentAccessToken.ToString());
            accessToken=AccessToken.CurrentAccessToken.ToString();
        }
    }

    
}


