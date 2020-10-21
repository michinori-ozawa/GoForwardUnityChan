using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour
{

        // キューブの移動速度
        private float speed = -12;

        // 消滅位置
        private float deadLine = -10;


        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update ()
        {
                // キューブを移動させる
                transform.Translate (this.speed * Time.deltaTime, 0, 0);

                // 画面外に出たら破棄する
                if (transform.position.x < this.deadLine)
                {
                        Destroy (gameObject);
                }
        }
		
		// called when the cube hits the floor_後ろのCol2Dは分かりやすく名前を付けた
		void OnCollisionEnter2D(Collision2D col2D)
		{
			    //もしタグが「cube」なら音を再生する
                if (col2D.gameObject.tag== "cube")
                {
                        GetComponent<AudioSource>().Play();
                }
				
				//もしタグが「ground」なら音を再生する
                if (col2D.gameObject.tag== "ground")
                {
                        GetComponent<AudioSource>().Play();
                }
				
		}
		
}