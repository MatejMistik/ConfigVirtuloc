using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigStateButtonController : Element
{

    public void OnClickSaveButton()
    {
        App.dataHandlerController.SaveImageData();
        App.dataHandlerController.SaveSlidersData();
        //SaveImageRes();
        CloseConfig();

        //App.imagesModel.imageCanvas.renderMode = RenderMode.ScreenSpaceCamera;

    }

    public void OnClickDeleteButton()
    {
        App.dataHandlerController.DeleteData();
        App.dataHandlerController.DeleteSliderData();
    }

    public void CloseConfig()
    {
        App.configOpener.configuratorViewGameObject.SetActive(false);

        //App.imagesModel.imageCanvas.renderMode = RenderMode.ScreenSpaceCamera;
    }

    public void SaveImageRes()
    {
        var newpixels = App.imageSwitchController.texture2DArray[App.imageSwitchController.i].GetPixels32();
        App.imageSwitchController.texture2DArray[App.imageSwitchController.i].Reinitialize((int) App.configModel.sliderResX.value, (int) App.configModel.sliderResY.value);
        App.imageSwitchController.texture2DArray[App.imageSwitchController.i].SetPixels32(newpixels);
        App.imageSwitchController.texture2DArray[App.imageSwitchController.i].Apply();

    }

}
