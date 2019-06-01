using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoxelCube : MonoBehaviour {

	void Start () {


		for(int i=0; i < 8; i++){
			for(int j=0; j < 8; j++){
				for(int k=0; k < 8; k++){
				VoxelTools.MakeCube(i, j, k);
				}

			}
		}
		
	}

	void Update(){

		if(Input.GetKeyDown(KeyCode.Q)){
			VoxelTools.MakeAllCubesFall();
		}
	}
	
}
