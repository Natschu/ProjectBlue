using UnityEngine;

/// <summary>
/// Defined points, where (Collision) Raycast should originate form. 
/// These points should be set in a seperate function every frame.
/// </summary>
public struct RaycastOrigin {
	public Vector2 topLeft, topRight;
	public Vector2 bottomLeft, bottomRight;

	//Maybe put a Set(Bounds) function and skinWidth variable
	//Make a property out of the Vector2 with only a get;
}