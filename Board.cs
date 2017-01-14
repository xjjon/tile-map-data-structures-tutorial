public class Board{
	
	Tile[,] tiles;
	int width, height;
	
	public Board(int width, int height){
		tiles = new Tile[width, height];
		this.width = width;
		this.height = height;
	}
	
	
	Entity GetAt(int x, int y, LayerType type){
		return tiles[y,x].layers[type];
	}
	
	Tile GetAt(int x, int y){
		return tiles[y,x];
	}
	
	List<Tile> GetNeighbors(int x, int y){
		List<Tile> neighbors = new List<Tile>();
		if(isValid(x + 1, y))
			neighbors.Add(GetAt(x + 1, y));
		if(isValid(x, y - 1))
			neighbors.Add(GetAt(x, y - 1));
		if(isValid(x - 1, y))
			neighbors.Add(GetAt(x - 1, y));
		if(isValid(x, y + 1))
			neighbors.Add(GetAt(x, y + 1));
		
		return neighbors;
		
	}
	
	bool isValid(int x, int y){
		if(x < 0 || x > width - 1 || y < 0 || y > height -1)
			return false;
		return true;
	}
}