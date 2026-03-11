using OnixRuntime.Api.Maths;
using OnixRuntime.Api.World;

namespace OnixSM64.Runtime;

public struct WorldSnapshot {
	public BoundingBox[] NearbyCollisions;
	public string StandingBlockName;
	public int WaterLevel;
	public bool IsValid;
}
