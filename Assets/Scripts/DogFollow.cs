using UnityEngine;
using System.Collections;

public class DogFollow : MonoBehaviour {
	
	public Transform target;
	public float speed = 3;
	public Animator dogAnim;
	public Transform dog;
	public UnityEngine.AI.NavMeshAgent nav;
	
	void Start(){
		nav = GetComponent <UnityEngine.AI.NavMeshAgent>();
	}
	
	void Update(){

		transform.LookAt (target.position);

		dog.eulerAngles = new Vector3 (0, transform.eulerAngles.y, 0);

		if (Vector3.Distance (transform.position, target.position) > 2f) {
			nav.SetDestination (target.position);
		} 

		if (nav.velocity.magnitude < 0.05) {
			dogAnim.SetBool ("isMoving", false);
		} else {
			dogAnim.SetBool ("isMoving", true);
		}
	}
}