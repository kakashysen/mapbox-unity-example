using UnityEngine;
using Mapbox.Map;
using Mapbox.Unity;
using Mapbox.Utils;
using Mapbox.Unity.Utilities;
using Mapbox.Unity.Map;

public class RasterMap : MonoBehaviour
{
	[SerializeField]
	public AbstractMap _map;
	public GameObject current;

	void Start(){

		double lat = 4.697626d;
		double lng = -74.055002d;

		Mapbox.Utils.Vector2d foursquareLocation = new Mapbox.Utils.Vector2d (lat,lng );
		Vector3 _targetPosition = Conversions.GeoToWorldPosition (foursquareLocation,
			_map.CenterMercator,
			_map.WorldRelativeScale).ToVector3xz ();


		Debug.Log ("foursquareLocation" + foursquareLocation.x +" - " + foursquareLocation.y);
		current.transform.position = _targetPosition;
		//current.transform.localScale = new Vector3(0.0009F, 0.009F, 0.0009F);
		Debug.Log ("Entreooooooooo!!!!!! "+ _targetPosition.x +" - "+ _targetPosition.y +" - "+ _targetPosition.z);
	}
}