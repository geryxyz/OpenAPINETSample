using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OpenAPISampleClientLib;

public class Try : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("This is just a sample Unity Client for OpenAPI.");
        WeatherForecastClient client = new WeatherForecastClient("https://localhost:44390", new System.Net.Http.HttpClient( ));
        Debug.Log($"The client will get forcasts form {client.BaseUrl} server.");
        var request = client.GetAsync( );
        request.Wait( );
        foreach(var forcast in request.Result)
        {
            Debug.Log(forcast.Summary);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
