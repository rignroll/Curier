using UnityEngine;
using System.Collections;

public class Car : MonoBehaviour {
	
public GameObject WheelRight;
public GameObject WheelLeft;
public GameObject WheelDRight;
public GameObject WheelDLeft;
public bool  BackWheels;
public float WheelSpeed;
public float	BrakeTorque =40;
public float	MaxSpeedMagnitude  = 20;
public int WheelRotateAngle= 20;
[SerializeField]
	Transform centre;
	public GameObject []wheels;

	
	void Start () {
		gameObject.GetComponent<Rigidbody>().centerOfMass = centre.localPosition;
	}
	
	void  Update (){
				if (rigidbody.velocity.magnitude > 0.5) {
						foreach (GameObject G in wheels)
								G.transform.Rotate (Vector3.right * Time.deltaTime * rigidbody.velocity.magnitude * 50, Space.Self);
				}


	if (rigidbody.velocity.magnitude < MaxSpeedMagnitude) {
			rigidbody.AddForce(
						if (Input.GetKey ("w") && !Input.GetKey (KeyCode.Space)) { 
								WheelDRight.GetComponent<WheelCollider> ().motorTorque = WheelSpeed;
								WheelDLeft.GetComponent<WheelCollider> ().motorTorque = WheelSpeed;
						}
						if (Input.GetKey ("s")) { 
								WheelDRight.GetComponent<WheelCollider> ().motorTorque = -WheelSpeed;
								WheelDLeft.GetComponent<WheelCollider> ().motorTorque = -WheelSpeed;
				
				
						}
				} else {
			WheelDRight.GetComponent<WheelCollider>().motorTorque = 0;
			WheelDLeft.GetComponent<WheelCollider>().motorTorque = 0;
				}
	if (Input.GetKeyUp("w")) { 
		WheelDRight.GetComponent<WheelCollider>().motorTorque = 0;
		WheelDLeft.GetComponent<WheelCollider>().motorTorque = 0;
	}

	
	
		
	if (Input.GetKeyUp("s")) { 
		WheelDRight.GetComponent<WheelCollider>().motorTorque = 0;
		WheelDLeft.GetComponent<WheelCollider>().motorTorque = 0;
	}
	
	if (Input.GetKeyDown ("a")) { 
	    if(BackWheels){
			WheelRight.transform.Rotate(0,-WheelRotateAngle,0);
			WheelLeft.transform.Rotate(0,-WheelRotateAngle,0);
		 }else{
		 	WheelRight.transform.Rotate(0,WheelRotateAngle,0);
			WheelLeft.transform.Rotate(0,WheelRotateAngle,0);
		 }
	}
		
	if (Input.GetKeyUp ("a")) { 
	 	 if(BackWheels){
			WheelRight.transform.Rotate(0,WheelRotateAngle,0);
			WheelLeft.transform.Rotate(0,WheelRotateAngle,0);
		 }else{
		 	WheelRight.transform.Rotate(0,-WheelRotateAngle,0);
			WheelLeft.transform.Rotate(0,-WheelRotateAngle,0);
		 }
	}
	
	if (Input.GetKeyDown ("d")) { 
		 if(BackWheels){
			WheelRight.transform.Rotate(0,WheelRotateAngle,0);
			WheelLeft.transform.Rotate(0,WheelRotateAngle,0);
		 }else{
		 	WheelRight.transform.Rotate(0,-WheelRotateAngle,0);
			WheelLeft.transform.Rotate(0,-WheelRotateAngle,0);
		 }
	}
		
	if (Input.GetKeyUp ("d")) { 
	 	 if(BackWheels){
			WheelRight.transform.Rotate(0,-WheelRotateAngle,0);
			WheelLeft.transform.Rotate(0,-WheelRotateAngle,0);
		 }else{
		 	WheelRight.transform.Rotate(0,WheelRotateAngle,0);
			WheelLeft.transform.Rotate(0,WheelRotateAngle,0);
		 }
	}
		
	if (Input.GetKeyDown(KeyCode.Space)) { 
			WheelDRight.GetComponent<WheelCollider>().brakeTorque = BrakeTorque;
			WheelDLeft.GetComponent<WheelCollider>().brakeTorque = BrakeTorque;

		}
		if (Input.GetKey (KeyCode.Space)) { 

						WheelDRight.GetComponent<WheelCollider> ().motorTorque = 0;
						WheelDLeft.GetComponent<WheelCollider> ().motorTorque = 0;
				}
	if (Input.GetKeyUp(KeyCode.Space)) { 
	 	 WheelDRight.GetComponent<WheelCollider>().brakeTorque = 0;
			WheelDLeft.GetComponent<WheelCollider>().brakeTorque = 0;
	}
	
	
}
}