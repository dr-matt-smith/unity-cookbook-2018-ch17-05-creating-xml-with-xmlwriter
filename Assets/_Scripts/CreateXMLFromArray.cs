using UnityEngine;
using System.Collections;

public class CreateXMLFromArray : MonoBehaviour {
	private ArrayList myPlayerList;

	private void Start () {
		myPlayerList = new ArrayList();
		myPlayerList.Add (new PlayerScore("matt", 200) );
		myPlayerList.Add (new PlayerScore("jane", 150) );
		
		string output = PlayerScore.ListToXML( myPlayerList );
        print(output); 
	}
}