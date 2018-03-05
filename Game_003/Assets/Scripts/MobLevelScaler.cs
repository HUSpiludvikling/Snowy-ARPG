using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobLevelScaler : MonoBehaviour {

    public int MobLevel = 1;

    public float MobHealthStart = 100f;

    public float MobLevelTimesScaler;

    public float MobScaler = 1.1f;

    public float MobHealthTotal;

    public int MobDamageStart = 5;

    public double MobDamageTotal;

	// Use this for initialization
	void Start () {
        MobLevelTimesScaler = MobLevel * MobScaler;

        MobHealthTotal = MobLevelTimesScaler * MobHealthStart;

        MobDamageTotal = MobDamageStart * MobLevelTimesScaler;

	}
}
