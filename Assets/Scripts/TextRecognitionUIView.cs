/*============================================================================== 
 * Copyright (c) 2012-2014 Qualcomm Connected Experiences, Inc. All Rights Reserved. 
 * ==============================================================================*/
using UnityEngine;
using System.Collections;

public class TextRecognitionUIView : ISampleAppUIView {
    
    #region PUBLIC_MEMBER_VARIABLES
    public event System.Action TappedToClose;
    public SampleAppUIBox mBox;
    public SampleAppUILabel mTextRecognitionLabel;
    public SampleAppUICheckButton mAboutLabel;
    public SampleAppUIButton mCloseButton;
    #endregion PUBLIC_MEMBER_VARIABLES

    #region PRIVATE_MEMBER_VARIABLES
    private SampleAppsUILayout mLayout;
    #endregion PRIVATE_MEMBER_VARIABLES

    #region PUBLIC_METHODS
    
    public void LoadView()
    {
        mLayout = new SampleAppsUILayout();
        mTextRecognitionLabel = mLayout.AddLabel("Text Reco");
        mAboutLabel = mLayout.AddSimpleButton("About");

        Rect CloseButtonRect = new Rect(0, Screen.height - (100 * Screen.width) / 800.0f, Screen.width, (70.0f * Screen.width) / 800.0f);
        mCloseButton = mLayout.AddButton("Close", CloseButtonRect);
    }
    
    public void UnLoadView()
    {
        mTextRecognitionLabel = null;
        mAboutLabel = null;
    }
    
    public void UpdateUI(bool tf)
    {
        if(!tf)
        {
            return;
        }

        mLayout.Draw();
    }

    public void OnTappedToClose ()
    {
        if(this.TappedToClose != null)
        {
            this.TappedToClose();
        }
    }
    #endregion PUBLIC_METHODS
}

