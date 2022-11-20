using Raylib_cs;
class gameoverplayer{
    public bool endofgame;
    public void gameover(player1 plyr1, List<playertrail> plyrtrl2, playercollsions clsn){
        for(int i = 0; i < plyrtrl2.Count(); i++){
            if(clsn.collision(plyr1, plyrtrl2[i])){
                plyr1.turnwhite();
            }
        }
    }
}
