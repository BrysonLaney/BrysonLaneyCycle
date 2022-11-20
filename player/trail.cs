using Raylib_cs;
class playertrail{
    private char trailchar;
    private Color trailcolor;
    private int trailx;
    private int traily;
    private direction plyrdrctn;
    public void trailsetup(player1 plyr, char trl, Color clr){
        trailx = plyr.getx();
        traily = plyr.gety();
        trailchar = trl;
        trailcolor = clr;
        plyrdrctn = plyr.getdirection();
    }
    public void trail(player1 plyr){
        direction temp = plyr.getdirection();
        if(temp == plyrdrctn){
            if(temp == direction.up){
                traily += 15;
                trailx = trailx;
            }
            if(temp == direction.down){
                traily -= 15;
                trailx = trailx;
            }
            if(temp == direction.right){
                trailx -= 15;
                traily = traily;
            }
            if(temp == direction.left){
                trailx += 15;
                traily = traily;
            }
        }
        else{
            plyrdrctn =temp;
        }
    }
    public Color gettrailcolor(){
        return trailcolor;
    }
    public int gettraily(){
        return traily;
    }
    public int gettrailx(){
        return trailx;
    }
    public void turnwhite(){
        trailcolor = Color.WHITE;
    }
    public char gettrail(){
        return trailchar;
    }
}