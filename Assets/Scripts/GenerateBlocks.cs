using UnityEngine;
using System.Collections;
using SimpleJSON;

public class GenerateBlocks : MonoBehaviour {

	public GameObject obj;

	void Start() {
		TextAsset asset = Resources.Load("Map") as TextAsset;
		var json = JSON.Parse(asset.text);

		JSONNode Blocks = json["blocks"];
		foreach(JSONNode node in Blocks.Children) {
			float x = node["position"]["x"].AsFloat;
			float y = node["position"]["y"].AsFloat;
			float z = node["position"]["z"].AsFloat;
			Vector3 position = new Vector3(x, y, z);

			Instantiate(obj, position, Quaternion.identity, transform);
		}
	}

	void Update() {
		// ...?
	}
}
