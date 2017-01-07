using UnityEngine;
using System.Collections;
using SimpleJSON;

public class GenerateBlocks : MonoBehaviour {
	
	void Start() {
		TextAsset asset = Resources.Load("World") as TextAsset;
		JSONNode world = JSON.Parse(asset.text);

		if(world["blocks"] == null) {
			throw new System.ArgumentException("Expected the world to have a list of blocks.");
		}

		foreach(JSONNode node in world["blocks"].Children) {
			if(node["type"] == null || node["position"] == null) {
				throw new System.ArgumentException("Expected the block to have a type and position.\n" + node.ToString());
			}

			string type = node["type"].Value.Replace(':', '_');
			GameObject model = Resources.Load("Blocks/Models/" + type) as GameObject;
			if(model == null) {
				model = GameObject.CreatePrimitive(PrimitiveType.Cube);
				Debug.LogWarning("Could not find a model for this block; defaulting to a white cube.\n" + node.ToString());
			}

			float x = node["position"]["x"].AsFloat;
			float y = node["position"]["y"].AsFloat;
			float z = node["position"]["z"].AsFloat;
			Vector3 position = new Vector3(x, y, z);

			Instantiate(model, position, Quaternion.identity, transform);
		}
	}

	void Update() {
		// ...?
	}
}
