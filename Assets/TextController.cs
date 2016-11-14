using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	
	private enum States {cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, freedom};
	private States myState;
	
	// Use this for initialization
	void Start () {
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
		if(myState == States.cell) {
			state_cell();
		}
	}
	
	void state_cell () {
	
		text.text = "You are in a prison cell and you want to escape. There are " + 
					"some dirty sheets on the bed, a mirror on the wall, and the door " + 
					"is locked from the outside.\n\n" + 
					"Press S to view Sheets, M to view Mirror and L to view Lock";
					
		if(Input.GetKeyDown(KeyCode.S)) {
			myState = States.sheets_0;
		}
		
		if(Input.GetKeyDown(KeyCode.M)) {
			
		}
		
		if(Input.GetKeyDown(KeyCode.L)) {
			
		}
		
	}
}
