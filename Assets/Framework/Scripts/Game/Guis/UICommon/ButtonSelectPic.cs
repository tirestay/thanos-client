using UnityEngine;

[AddComponentMenu("UICommon/Button/Select Pic")]
public class ButtonSelectPic : GuiBase
{		 
	public UISprite spriteSelect;

	public bool resetAfterPress = true;

    public bool IsCheckBox;

	public enum SelectState
	{
		EnableState = 0,
		DisableState ,
	}

    [HideInInspector]
    public SelectState state = SelectState.EnableState;

	public void ShowSelectPic(bool show)
	{
		if(spriteSelect.gameObject.activeInHierarchy != show)
		{
			spriteSelect.gameObject.SetActive(show);	
		}
	}


	void Awake()
	{
		//ShowSelectPic(false);
	}

	void OnEnable()
	{		
		ErrorTip();
	}

	void ErrorTip()
	{
		if(transform.GetComponent<BoxCollider>() == null)
		{
			Debug.LogError("ButtonSelectPic need BoxCollider");
		}

		if(spriteSelect == null)
		{
			Debug.LogError("ButtonSelectPic need spriteSelect");
		}
	}

	void SelectPic( bool pressed)
	{
        if (state == SelectState.DisableState)
        {
            return;
        }
		if (pressed) {
            if (IsCheckBox)
            {
                ShowSelectPic(!spriteSelect.gameObject.activeInHierarchy);
            }
            else
            {
                ShowSelectPic(true);
            }
		}
		else {
			if(resetAfterPress)		
			{
				ShowSelectPic(false);
			}
		}

	}

	void OnDisable()
	{ 
		state = SelectState.DisableState;
	}

    protected override void OnPress(bool pressed)
    {
        base.OnPress(pressed);
        SelectPic(pressed);
         
        if (Handler != null)
        {
            Handler(PrIe, pressed);
        } 
    }


} 
