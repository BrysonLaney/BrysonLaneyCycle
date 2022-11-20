using Raylib_cs;
class playermovement{
    public void constantmove(player1 plyr){
        if(plyr.getdirection() == direction.up){
            moveup(plyr);
            plyr.trail(plyr);
        }
        if(plyr.getdirection() == direction.down){
            movedown(plyr);
            plyr.trail(plyr);
        }
        if(plyr.getdirection() == direction.left){
            moveleft(plyr);
            plyr.trail(plyr);
        }
        if(plyr.getdirection() == direction.right){
            moveright(plyr);
            plyr.trail(plyr);
        }
    }
    public void move(player1 plyr1, player1 plyr2, Raylib_cs.KeyboardKey key){
        if(!(plyr1.getx() < 0 || plyr1.getx() > 1200 || plyr1.gety() < 0 || plyr1.gety() > 1080)){
            if(Raylib.IsKeyDown(KeyboardKey.KEY_A)){
                moveleft(plyr1);
                plyr1.trail(plyr1);
            }
            if(Raylib.IsKeyPressed(KeyboardKey.KEY_D)){
                moveright(plyr1);
                plyr1.trail(plyr1);
            }
            if(Raylib.IsKeyPressed(KeyboardKey.KEY_W)){
                moveup(plyr1);
                plyr1.trail(plyr1);
            }
            if(Raylib.IsKeyPressed(KeyboardKey.KEY_S)){
                movedown(plyr1);
                plyr1.trail(plyr1);
            }
        }
        if(!(plyr2.getx() < 0 || plyr2.getx() > 1200 || plyr2.gety() < 0 || plyr2.gety() > 1080)){
            if(Raylib.IsKeyPressed(KeyboardKey.KEY_I)){
                moveup(plyr2);
                plyr2.trail(plyr2);
            }
            if(Raylib.IsKeyPressed(KeyboardKey.KEY_K)){
                movedown(plyr2);
                plyr2.trail(plyr2);
            }
            if(Raylib.IsKeyPressed(KeyboardKey.KEY_J)){
                moveleft(plyr2);
                plyr2.trail(plyr2);
            }
            if(Raylib.IsKeyPressed(KeyboardKey.KEY_L)){
                moveright(plyr2);
                plyr2.trail(plyr2);
            }
        }
    }
    public void moveup(player1 plyr){
        if(plyr.getdirection() != direction.down){
            plyr.setdirection(direction.up);
            plyr.subtracty(15);
            plyr.trail(plyr);
        }
    }
    public void moveright(player1 plyr){
        if(plyr.getdirection() != direction.left){
            plyr.setdirection(direction.right);
            plyr.addx(15);
            plyr.trail(plyr);
        }
    }
    public void moveleft(player1 plyr){
        if(plyr.getdirection() != direction.right){
            plyr.setdirection(direction.left);
            plyr.subtractx(15);
            plyr.trail(plyr);
        }
    }public void movedown(player1 plyr){
        if(plyr.getdirection() != direction.up){
            plyr.setdirection(direction.down);
            plyr.addy(15);
            plyr.trail(plyr);
        }
    }
}