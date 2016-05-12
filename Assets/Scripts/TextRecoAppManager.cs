/*============================================================================== 
 * Copyright (c) 2012-2014 Qualcomm Connected Experiences, Inc. All Rights Reserved. 
 * ==============================================================================*/

using UnityEngine;
using System.Collections;

/// <summary>
/// This class takes care of running initialization and update calls for TextEventHandler as part of the same thread
/// </summary>
public class TextRecoAppManager : AppManager 
{
    #region PUBLIC_MEMBER_VARIABLES
    public TextEventHandler m_TextEventHandler;
    #endregion PUBLIC_MEMBER_VARIABLES
    
    #region BASE_CLASS_OVERRIDE_METHODS
    public override void InitManager ()
    {
        base.InitManager ();
        m_TextEventHandler.InitHandler();
    }
    
    public override void Draw ()
    {
        base.Draw();
        
        switch(mActiveViewType)
        {
            case ViewType.ARCAMERAVIEW:
                m_TextEventHandler.Draw();
                break;
        }
    }
    
    public override void UpdateManager ()
    {
        base.UpdateManager ();
        m_TextEventHandler.UpdateHandler();
    }
    #endregion BASE_CLASS_OVERRIDE_METHODS
    
    
}
