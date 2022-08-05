using System.Collections;
using System;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
public class Downloader : Element
{

    public Text textHtml;
    public SpriteRenderer spriteRenderer;
    public string[] urls = new string[2] { "https://scontent.fbts4-1.fna.fbcdn.net/v/t1.6435-9/163850202_3664637806938635_1747380468099766199_n.jpg?_nc_cat=100&ccb=1-7&_nc_sid=e3f864&_nc_ohc=X8t4lz8ReEYAX9rhxuY&_nc_ht=scontent.fbts4-1.fna&oh=00_AT-PFeVD0VlTS93HKMN1k9hb-bXx4ulDpPigmqR-DYl0ZA&oe=630F2EB6",
        "https://scontent.fbts4-1.fna.fbcdn.net/v/t39.30808-6/290965714_5054326934636375_2133213513493403742_n.jpg?_nc_cat=103&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=bHSLs6leJaEAX8ReXPf&_nc_ht=scontent.fbts4-1.fna&oh=00_AT9cgq4RV6S6sMPhD6oPcgRFgBrX7DpnwpqucxqOC7VAJg&oe=62ED92E8" };
    public List<Texture2D> textures = new();
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
        int counter = 0;
        foreach (var url in urls)
        {
            
            counter++;
            GetTexture(url, (string error) =>
            {
                Debug.Log("Error " + error);
                textHtml.text = "Error " + error;
            }, (Texture2D texture2D) =>
            {
                Debug.Log("Success ");
                textHtml.text = "Success ";
                SaveImageToList(texture2D);
                if(urls.Length == counter)
                {
                    Sprite sprite = Sprite.Create(texture2D, new Rect(0, 0, texture2D.width, texture2D.height), Vector2.one,256);
                    spriteRenderer.sprite = sprite;
                }
                if(counter == urls.Length) App.imageSwitchController.GetImages(texture2DArray);
            });
        }
        
    }



    private void GetTexture(string url, Action<string> onError, Action<Texture2D> onSuccess)
    {
        StartCoroutine(GetTextureCouritine(url, onError, onSuccess));

    }

    private IEnumerator GetTextureCouritine(string url, Action<string> onError, Action<Texture2D> onSuccess)
    {
        using UnityWebRequest unityWebRequest = UnityWebRequestTexture.GetTexture(url);
        yield return unityWebRequest.SendWebRequest();


        if (unityWebRequest.result == UnityWebRequest.Result.ConnectionError || unityWebRequest.result == UnityWebRequest.Result.ProtocolError)
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

    public void SaveImageToList(Texture2D texture2D)
    {        
        textures.Add(texture2D);
        texture2DArray = textures.ToArray();
    }

    


    // Future version can rely on loading and saving data.

    /*


    private void LoadImageFromDisk(string filename)
    {
        if (!File.Exists(UnityEngine.Application.persistentDataPath + filename))
        {
            Debug.Log("Error: File not found.");
        }

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
    */



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
