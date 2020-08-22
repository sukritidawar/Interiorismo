using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaneMatManager : MonoBehaviour
{
    public Material PlaneMat;
    public Button[] planetextbuttons;
    // Start is called before the first frame update
    void Awake()
    {
        foreach(var b in planetextbuttons)
        {
            Texture tex = b.transform.Find("Mask/RawImage").GetComponent<RawImage>().texture;
            b.onClick.AddListener(()=>OnClickButton(tex));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnClickButton(Texture tex)
    {
        PlaneMat.mainTexture = tex;
    }
}
