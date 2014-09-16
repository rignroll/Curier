var WheelRight:GameObject;
var WheelLeft:GameObject;
var BackWheels:boolean;
var BackFront:boolean;
var WheelSpeed:float;
var WheelRpmMax:float;
private var WheelRotateAngle = 20;
gameObject.GetComponent(Rigidbody).centerOfMass = Vector3 (0, -0.6*2.3, 0);
function Update () {

	if (Input.GetKeyDown ("w")) { 
		//if (WheelRight.GetComponent (WheelCollider).rpm<WheelRpmMax){
			WheelRight.GetComponent (WheelCollider).motorTorque = WheelSpeed;
			WheelLeft.GetComponent (WheelCollider).motorTorque = WheelSpeed;
	//	}else{
		//WheelRight.GetComponent (WheelCollider).motorTorque = 0;
		//WheelLeft.GetComponent (WheelCollider).motorTorque = 0;
	//	}
	}
	if (Input.GetKeyUp("w")) { 
		WheelRight.GetComponent (WheelCollider).motorTorque = 0;
		WheelLeft.GetComponent (WheelCollider).motorTorque = 0;
	}
	
	if (Input.GetKeyDown ("s")) { 
	//	if (WheelRight.GetComponent (WheelCollider).rpm<WheelRpmMax){
		WheelRight.GetComponent (WheelCollider).motorTorque = -WheelSpeed;
		WheelLeft.GetComponent (WheelCollider).motorTorque = -WheelSpeed;
	//	}	
	}
	if (Input.GetKeyUp("s")) { 
		WheelRight.GetComponent (WheelCollider).motorTorque = 0;
		WheelLeft.GetComponent (WheelCollider).motorTorque = 0;
	}
	
	if (Input.GetKeyDown ("a")) { 
	    if(BackWheels){
			WheelRight.transform.Rotate(0,-WheelRotateAngle,0);
			WheelLeft.transform.Rotate(0,-WheelRotateAngle,0);
		 }else{
		 	WheelRight.transform.Rotate(0,WheelRotateAngle,0);
			WheelLeft.transform.Rotate(0,WheelRotateAngle,0);
		 }
		// WheelRight.GetComponent (WheelCollider).motorTorque = 0;
		//WheelLeft.GetComponent (WheelCollider).motorTorque = 0;
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
		// WheelRight.GetComponent (WheelCollider).motorTorque = 0;
		//WheelLeft.GetComponent (WheelCollider).motorTorque = 0;
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
	
	
}