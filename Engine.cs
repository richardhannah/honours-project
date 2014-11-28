﻿using UnityEngine;
using System.Collections;
using System;



public class Engine : MonoBehaviour
{

	public string engName;
	public double idle;
	public float maxPower;
	public float throttle;
	public int engNum;


	

		

		// Use this for initialization
		void Start ()
		{


				
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}

		void FixedUpdate ()
		{
				
				Vector3 force = transform.up * (maxPower * (throttle/100));
		//Debug.Log(engName + ": " + (maxPower * (throttle/100)));
				rigidbody.AddForce (force);

		Vector3 torque = new Vector3 ();
				switch (engNum) {
		case 1:
			torque = transform.forward * (maxPower * (throttle / 100) * -1);

		

			break;
		case 2:
			torque = transform.right * (maxPower * (throttle / 100));
			
			
			
			break;
		case 3:
			torque = transform.forward * (maxPower * (throttle / 100));
			
			
			
			break;
		case 4:
			torque = transform.right * (maxPower * (throttle / 100)* -1);
			
			
			
			break;

				}

						//Vector3 torque = transform.forward * (maxPower * (throttle / 10) * torqueDir);
						rigidbody.AddForce (torque);
				
				
		}

		public void IncreaseThrottle ()
		{

				if (throttle < 100) {
						throttle=throttle+0.1f;
				}
		}
	
		public void DecreaseThrottle ()
		{
				if (throttle > 0) {
						throttle=throttle-0.1f;
				}
		
		}

	public void CutEngine(){
		throttle = 0;

		} 
	public void SetThrottle(float value){


		if (value >= 0 && value <= 100) {
						throttle = value;
				}

		}
		

		


	public float getThrottle ()
	{

		//double roundThrt = Math.Round (Convert.ToDouble(throttle), 2);


		return throttle;
	}
}
