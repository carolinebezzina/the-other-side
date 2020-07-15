using UnityEngine;
using System.Collections;

public class GirlFollow : MonoBehaviour {
	
	public Transform target;
	public float speed = 3;
	public Animator girlAnim;
	public Transform girl;
	public UnityEngine.AI.NavMeshAgent nav;
	
	void Start(){
		nav = GetComponent <UnityEngine.AI.NavMeshAgent>();
	}
	
	void Update(){

		transform.LookAt (target.position);

		girl.eulerAngles = new Vector3 (0, transform.eulerAngles.y, 0);

		if (Vector3.Distance (transform.position, target.position) > 2f) {
			nav.SetDestination (target.position);
		} 

		if (nav.velocity.magnitude < 0.05) {
			girlAnim.SetBool ("isMoving", false);
		} else {
			girlAnim.SetBool ("isMoving", true);
		}
	}
}