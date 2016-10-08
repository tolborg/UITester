using UnityEngine;
using System.Collections;

public class PanelController : MonoBehaviour 
{

	Animator animator;


	void Start()
	{
		animator = GetComponent<Animator>();
	}






	public void TogglePanel()
	{

		if (animator.GetBool("isActive"))
		{
			animator.SetBool("isActive", false);
		}
		else
		{
			animator.SetBool("isActive", true);
		}
			
	}


}
