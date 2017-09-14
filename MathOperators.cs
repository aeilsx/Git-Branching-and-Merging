using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Math : MonoBehaviour {

	public int valueOne;
	public int valueTwo;
	public int valueThree;
	public int valueFour;
	public int valueFive;
	public int valueSix;
	public int valueSeven;
	public int valueEight;
	private int result;

	
	//Math Operators
	//multiple varibles are used to hold multiple values but the same varibles can be used in multiple equations.
	//the varables can be used to hold values and the varables can be added, subtracted, divided, and multiplied.
	//making the ints public make them accessable and the value changable in unity
	//result needs to go first in the code
	//+ - / * all act as math operators in code
	//in print(math opperators won't be displayed unless in quotaions
	//multiple math operators can be used in the same equation
	//the + + in the print() is used to include each varible when the program is run

	 //Use this for initialization
	void Start () {
		DoMath();
		
	}
	
	// Update is called once per frame
	void DoMath () {
		 result = valueOne + valueTwo;
		 print(valueOne + "+" + valueTwo + "=" + result);

		 result = valueThree - valueFour;
		 print(valueThree + "-" + valueFour + "=" + result);

		 result = valueFive / valueSix;
		 print(valueFive + "/" + valueSix + "=" + result);

		 result = valueSeven * valueEight;
		 print(valueSeven + "*" + valueEight + "=" + result);

		 result = valueThree + valueFive - valueSeven;
		 print(valuethree + "+" + valueFive + "-" + valueSeven + "=" + result);
	}
}
