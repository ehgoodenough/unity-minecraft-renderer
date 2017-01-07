using UnityEngine;
using System.Collections;
using SimpleJSON;

public class GenerateBlocks : MonoBehaviour {

	void Start() {
		var json = JSON.Parse("{\"message\":\"Hello!!\"}");
		string message = json["message"];
		Debug.Log(message);
	}

	void Update() {
		// ...?
	}
}
