using UnityEngine;
using System.Collections;

public abstract partial class Entities : MonoBehaviour {

	public float speed;
	public float health;

    protected Status cStat;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //Must be run at start. Everything that all entities do should go here.
    protected void InitializeEntity()
    {
        cStat = GetComponent<Status>();
    }

	public virtual void takeHealth(int amount)
	{
		health = health - amount;
		Debug.Log ("health left" + health);

		if (health <= 0) {
			Die ();
		}
	}

	public virtual void giveHealth(int amount)
	{
		health = health + amount;
		Debug.Log ("health left" + health);


	}

	public virtual void Die()
	{
		//Destroy (gameObject);
	}
}
