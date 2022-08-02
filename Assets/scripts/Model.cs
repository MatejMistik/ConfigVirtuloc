using System.Collections;
using System;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
public class Model : MonoBehaviour
{

    public Text textHtml;
    public SpriteRenderer spriteRenderer;
    public List<Texture2D> textures = new List<Texture2D>();
    public Texture2D[] texture2DArray;
    // Start is called before the first frame update
    void Start()
    {
        /*string url = "https://google.com";
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
        */


        string imagesUrl = "https://scontent.fbts4-1.fna.fbcdn.net/v/t39.30808-6/290965714_5054326934636375_2133213513493403742_n.jpg?_nc_cat=103&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=bHSLs6leJaEAX8ReXPf&_nc_ht=scontent.fbts4-1.fna&oh=00_AT9cgq4RV6S6sMPhD6oPcgRFgBrX7DpnwpqucxqOC7VAJg&oe=62ED92E8";
        GetTexture(imagesUrl, (string error) =>
        {
            Debug.Log("Error " + error);
            textHtml.text = "Error " + error;
        }, (Texture2D texture2D) =>
        {
            Debug.Log("Success ");
            textHtml.text = "Success ";
            Debug.Log(texture2D);
            SaveImageToList(texture2D);
            Sprite sprite = Sprite.Create(texture2D, new Rect(0,0,texture2D.width, texture2D.height), Vector2.zero);
            spriteRenderer.sprite = sprite;
        });
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
               // SaveImageToLocalFiles(downloadHandlerTexture);
                


            }

        }
    }

    public void SaveImageToList(Texture2D texture2D)
    {        
        textures.Add(texture2D);
        texture2DArray = textures.ToArray();
    }

    public void OnLoadImageButtonClick()
    {
        if (!File.Exists(UnityEngine.Application.persistentDataPath))
        {
            Debug.Log("Error: File not found.");
        }

        LoadImageFromDisk();
    }

    private void LoadImageFromDisk()
    {
        byte[] textureBytes = File.ReadAllBytes(UnityEngine.Application.persistentDataPath);
        Texture2D texture2D = new Texture2D(0, 0);
        texture2D.LoadImage(textureBytes);
        Sprite sprite = Sprite.Create(texture2D, new Rect(0, 0, texture2D.width, texture2D.height), Vector2.zero);
        spriteRenderer.sprite = sprite;

    }

    private void SaveImageToLocalFiles(DownloadHandlerTexture downloadHandlerTexture)
    {

        byte[] textureBytes = downloadHandlerTexture.texture.EncodeToPNG();
        File.WriteAllBytes(UnityEngine.Application.persistentDataPath, textureBytes);
    }


    /*
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
    */

}
