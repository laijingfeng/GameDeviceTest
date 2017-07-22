using UnityEngine;
using UnityEngine.UI;

public class Info : MonoBehaviour
{
    private Text txt;
    private Transform lt;
    private Transform rb;
    private Button btn;

    void Awake()
    {
        btn = this.transform.FindChild("Button").GetComponent<Button>();
        lt = this.transform.FindChild("LT");
        rb = this.transform.FindChild("RB");
        txt = this.transform.FindChild("Text").GetComponent<Text>();

        btn.onClick.AddListener(() => 
        {
            DoTest();
        });
    }

    void Start()
    {
        DoTest();
    }

    [ContextMenu("DoTest")]
    private void DoTest()
    {
        txt.text = "";
        AddInfo(string.Format("deviceModel:{0}", SystemInfo.deviceModel));
        AddInfo(string.Format("deviceName:{0}", SystemInfo.deviceName));
        AddInfo(string.Format("deviceType:{0}", SystemInfo.deviceType));
        AddInfo(string.Format("deviceUniqueIdentifier:{0}", SystemInfo.deviceUniqueIdentifier));
        AddInfo(string.Format("graphicsDeviceID:{0}", SystemInfo.graphicsDeviceID));
        AddInfo(string.Format("graphicsDeviceName:{0}", SystemInfo.graphicsDeviceName));
        AddInfo(string.Format("graphicsDeviceType:{0}", SystemInfo.graphicsDeviceType));
        AddInfo(string.Format("graphicsDeviceVendor:{0}", SystemInfo.graphicsDeviceVendor));
        AddInfo(string.Format("graphicsDeviceVendorID:{0}", SystemInfo.graphicsDeviceVendorID));
        AddInfo(string.Format("graphicsDeviceVersion:{0}", SystemInfo.graphicsDeviceVersion));
        AddInfo(string.Format("graphicsMemorySize:{0}", SystemInfo.graphicsMemorySize));
        AddInfo(string.Format("graphicsMultiThreaded:{0}", SystemInfo.graphicsMultiThreaded));
        AddInfo(string.Format("maxTextureSize:{0}", SystemInfo.maxTextureSize));
        AddInfo(string.Format("operatingSystem:{0}", SystemInfo.operatingSystem));
        AddInfo(string.Format("processorCount:{0}", SystemInfo.processorCount));
        AddInfo(string.Format("processorFrequency:{0}", SystemInfo.processorFrequency));
        AddInfo(string.Format("processorType:{0}", SystemInfo.processorType));
        AddInfo(string.Format("systemMemorySize:{0}", SystemInfo.systemMemorySize));
        
        AddInfo(string.Format("DPI:{0}", Screen.dpi));
        AddInfo(string.Format("LTLocalPos:{0}", lt.localPosition));
        AddInfo(string.Format("LTPos:{0}", lt.position));
        AddInfo(string.Format("RBLocalPos:{0}", rb.localPosition));
        AddInfo(string.Format("RBPos:{0}", rb.position));
        AddInfo(string.Format("ScreenSize:{0},{1}", Screen.width, Screen.height));
        AddInfo(string.Format("Resolutions:{0},{1}", Screen.resolutions[0].width, Screen.resolutions[0].height));
    }

    private void AddInfo(string str)
    {
        if (string.IsNullOrEmpty(txt.text))
        {
            txt.text += "\n" + str;
        }
        else
        {
            txt.text += "\n" + str;
        }
    }
}