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
   // public View view;
    public Controller controller;
    public ConfigModel configModel;
    public ConfigView configView;
    //public ImagesController imagesController;
    public ConfigControllerButtons configControllerButtons;
    public ConfigStateButtonController configStateButtonController;
    public ConfigOpener configOpener;

}




