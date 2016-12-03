using UnityEngine;

public class MyMenu : MonoBehaviour
{
	public GameObject myMenu; // set this in the inspector

	public void ToggleMenu()
	{
		myMenu.SetActive(!myMenu.activeInHierarchy);
	}
}