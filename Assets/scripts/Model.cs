using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
public class Downloader : MonoBehaviour
{

    [SerializeField] Text textHtml;
    // Start is called before the first frame update
    void Start()
    {
        string url = "https://google.com";
        Get(url, (string error) =>
        {
            //Error
            Debug.Log("Error " + error);
            textHtml.text = "Error " + error;
        }, (string text) =>
        {
            //Success
            Debug.Log("Success " + text);
            textHtml.text = "Success " + text;
        });
    }

    private void Get(string url, Action<string> onError, Action<string> onSuccess)
    {
        StartCoroutine(GetCouritine(url, onError, onSuccess));

    }

    private IEnumerator GetCouritine(string url, Action<string> onError, Action<string> onSuccess)
    {
        using (UnityWebRequest unityWebRequest = UnityWebRequest.Get(url))
        {
            yield return unityWebRequest.SendWebRequest();


            if (unityWebRequest.isNetworkError || unityWebRequest.isHttpError)
            {
                //Debug.Log("Error" + unityWebRequest.error);
                onError(unityWebRequest.error);
            }
            else
            {
                //Debug.Log("Received" + unityWebRequest.downloadHandler.text);
                onSuccess(unityWebRequest.downloadHandler.text);

            }

        }
    }

    private void GetTexture(string url, Action<string> onError, Action<Texture2D> onSuccess)
    {
        StartCoroutine(GetTextureCouritine(url, onError, onSuccess));

    }

    private IEnumerator GetTextureCouritine(string url, Action<string> onError, Action<Texture2D> onSuccess)
    {
        using (UnityWebRequest unityWebRequest = UnityWebRequestTexture.GetTexture(url))
        {
            yield return unityWebRequest.SendWebRequest();


            if (unityWebRequest.isNetworkError || unityWebRequest.isHttpError)
            {
                //Debug.Log("Error" + unityWebRequest.error);
                onError(unityWebRequest.error);
            }
            else
            {
                //Debug.Log("Received" + unityWebRequest.downloadHandler.text);
                DownloadHandlerTexture downloadHandlerTexture = unityWebRequest.downloadHandler as DownloadHandlerTexture;
                onSuccess(downloadHandlerTexture.texture);

            }

        }
    }

}
