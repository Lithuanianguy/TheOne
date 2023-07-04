using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class QualityMenu : MonoBehaviour
{

    public RenderPipelineAsset[] qualityLevels;
    public Dropdown dropdown;

    void Start()
    {

        dropdown.value = QualitySettings.GetQualityLevel();

    }


    public void ChangeLevel(int value)
    {
        QualitySettings.SetQualityLevel(value);
        QualitySettings.renderPipeline =  qualityLevels[value];
    }

}
