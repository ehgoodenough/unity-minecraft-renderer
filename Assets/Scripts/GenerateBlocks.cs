using UnityEngine;
using System.Collections;
using SimpleJSON;

public class GenerateBlocks : MonoBehaviour {

	void Start() {
		TextAsset asset = Resources.Load("Map") as TextAsset;
		var json = JSON.Parse(asset.text);

		string message = json["message"];
		Debug.Log(message);
	}

	void Update() {
		// ...?
	}
}
