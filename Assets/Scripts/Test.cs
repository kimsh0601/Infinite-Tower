using UnityEngine;
using System.Collections;
using Mono.Data.Sqlite;

using System.Data;
using System;



public class Test : MonoBehaviour {

    void Awake()
    {
        string conn = "URI=file:" + Application.dataPath + "/PickAndPlaceDatabase.s3db";
        IDbConnection dbconn;
        dbconn = (IDbConnection)new SqliteConnection(conn);
        dbconn.Open();
        IDbCommand dbcmd = dbconn.CreateCommand();
        Debug.Log("OK");

        string sqlQuery = "SELECT value, name, randomSequence " + "FROM PlaceSequence";
        dbcmd.CommandText = sqlQuery;
        IDataReader reader = dbcmd.ExecuteReader();
        Debug.Log("OK");

        while (reader.Read())
        {
            int value = reader.GetInt32(0);
            string name = reader.GetString(1);
            int rand = reader.GetInt32(2);

            Debug.Log("value= " + value + "  name =" + name + "  random =" + rand);
        }

        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        dbconn.Close();
        dbconn = null;
        Debug.Log("OK");
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
