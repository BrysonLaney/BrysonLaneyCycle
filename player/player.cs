using Raylib_cs;
public enum direction{
        up,down,left,right
    }
class player1 : playertrail{
    playertrail plyrtrl = new playertrail();
    playermovement movement = new playermovement();
    private char bike;
    private Color bikecolor;
    private char trail;
    private Color trailcolor;
    private direction playerdirection;
    private int x;
    private int y;
    public void player(int x, int y, char plyr, char trl, Color plyrclr, Color trlclr, direction drctn){
        bike = plyr;
        bikecolor = plyrclr;
        trail = trl;
        trailcolor = trlclr;
        playerdirection = drctn;
        this.x = x;
        this.y = y;
    }
    public char getbike(){
        return bike;
    }
    public void setdirection(direction drctn){
        playerdirection = drctn;
    }
    public char gettrail(){
        return trail;
    }
    public Color getbikecolor(){
        return bikecolor;
    }
    public Color gettrailcolor(){
        return trailcolor;
    }
    public direction getdirection(){
        return playerdirection;
    }
    public void turnwhite(){
        bikecolor = Color.WHITE;
        trailcolor = Color.WHITE;
    }
    public int getx(){
        return x;
    }   
    public int gety(){
        return y;
    }
    public void addx(int move){
        x += move;
    }
    public void addy(int move){
        y += move;
    }
    public void subtractx(int move){
        x -= move;
    }
    public void subtracty(int move){
        y -= move;
    }
}
class redplayer : player1{
    private char bike;
    private Color bikecolor;
    private char trail;
    private Color trailcolor;
    private direction playerdirection;
    public void playerred(char plyr, char trl, Color plyrclr, Color trlclr, direction drctn){
        bike = plyr;
        bikecolor = Color.RED;
        trail = trl;
        trailcolor = Color.RED;
        playerdirection = drctn;
    }
}
class blueplayer : player1{
    private char bike;
    private Color bikecolor;
    private char trail;
    private Color trailcolor;
    private direction playerdirection;
    public void playerblue(char plyr, char trl, Color plyrclr, Color trlclr, direction drctn){
        bike = plyr;
        bikecolor = Color.BLUE;
        trail = trl;
        trailcolor = Color.BLUE;
        playerdirection = drctn;
    }
}
