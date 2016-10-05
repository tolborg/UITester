using UnityEngine;
using System.Collections;

public class PanelController : MonoBehaviour 
{
	private Animator anim;
	private bool isShown = false;


	void Start()
	{
		anim = transform.GetComponent<Animator>();
	}




	void OnEnable()
	{
		EventManager.OnShowPanel += ShowPanel;
	}


	void OnDisable()
	{
		EventManager.OnShowPanel -= ShowPanel;
	}
















	void ShowPanel()
	{
		if (!isShown) 
		{
			anim.Play("PanelSlideIn");
			isShown = true;
		}
		else
		{
			anim.Play("PanelSlideOut");
			isShown = false;
		}

	}

}
