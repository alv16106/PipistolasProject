using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShootableBox : MonoBehaviour {

	//The box's current health point total
	public int currentHealth = 100;
	public Text health;

	public void Damage(int damageAmount)
	{
		//subtract damage amount when Damage function is called
		currentHealth -= damageAmount;
		health.text = "Vida: " + currentHealth;

		//Check if health has fallen below zero
		if (currentHealth <= 0) 
		{
			//if health has fallen below zero, deactivate it 
			gameObject.SetActive (false);
		}
	}
}
