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
}