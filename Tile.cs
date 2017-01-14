public class Tile{
	
	bool isPassable;		//Is there collision
	int floorSprite;		//Sprite ID of floor
	
	Dictionary<LayerType, Entity> layers = new Dictionary<LayerType, Entity>();
	
	
}

public enum LayerType{
	Doodad, Mob, Effect, Trigger
}
