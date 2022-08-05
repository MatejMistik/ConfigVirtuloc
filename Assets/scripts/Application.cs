using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Element : MonoBehaviour
{
    public Application App { get { return FindObjectOfType<Application>(); } }
}

public class Application : MonoBehaviour
{
    public Downloader downloader;
    public ConfigModel configModel;
    public ConfigViewPosScale configView;
    public ImagesController imagesController;
    public ConfigControllerButtons configControllerButtons;
    public ConfigStateButtonController configStateButtonController;
    public ConfigOpener configOpener;
    public ConfigViewStateButtons configViewStateButtons;
    public ImageSwitchView imageSwitchView;
    public ImageSwitchController imageSwitchController;
    public DropDownController dropDownController;
    public DropDownView dropDownView;
}


/*
 * First downloader is called which via https link can download images and store them inside a list which is transformed into an array for handling of the photos inside the editor.
 *  Image is render on sprite, which is placed in center of the Canvas only for images.
 *  Downloader call
 * 
 * 
 * 
 * 
 * */



