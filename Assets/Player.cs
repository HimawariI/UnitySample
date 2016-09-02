using UnityEngine;
using System.Collections;
public class Player : MonoBehaviour {
	// 速度
	public Vector2 SPEED = new Vector2(0.005f, 0.005f);
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		// 移動処理
		//Move();
		//transform.Rotate(0, 5, 0);
		//transform.Translate(0,1,0);
		Move2();
	}
	void Move2(){
		Vector2 Position = transform.position;
		Position.y += SPEED.y;
		transform.position = Position;
	}
	// 移動関数
	void Move(){
		// 現在位置をPositionに代入
		Vector2 Position = transform.position;
		// 左キーを押し続けていたら
		if(Input.GetKey("left")){
			// 代入したPositionに対して加算減算を行う
			Position.x -= SPEED.x;
		} else if(Input.GetKey("right")){ // 右キーを押し続けていたら
			// 代入したPositionに対して加算減算を行う
			Position.x += SPEED.x;
		} else if(Input.GetKey("up")){ // 上キーを押し続けていたら
			// 代入したPositionに対して加算減算を行う
			Position.y += SPEED.y;
		} else if(Input.GetKey("down")){ // 下キーを押し続けていたら
			// 代入したPositionに対して加算減算を行う
			Position.y -= SPEED.y;
		}
		// 現在の位置に加算減算を行ったPositionを代入する
		transform.position = Position;
	}

}