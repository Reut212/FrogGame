using UnityEngine;

public class CarSpawner : MonoBehaviour {

	public float spawnDelay = .3f;

	public GameObject Car1;

	public Transform[] spawnPoints;

	float nextTimeToSpawn = 0f;

	void Update ()
	{
		if (nextTimeToSpawn <= Time.time)
		{
			SpawnCar();
			nextTimeToSpawn = Time.time + spawnDelay;
		}
	}

	void SpawnCar ()
	{
		int randomIndex = Random.Range(0, spawnPoints.Length);
		Transform spawnPoint = spawnPoints[randomIndex];

		Instantiate(Car1, spawnPoint.position, spawnPoint.rotation);
	}

}
