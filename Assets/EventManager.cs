using UnityEngine;
using System.Collections;

public class EventManager : MonoBehaviour 
{
	public static event System.Action OnShowPanel;


	public void ShowPanel()
	{
		if (OnShowPanel != null)
		{
			OnShowPanel();
		}
	}


}
