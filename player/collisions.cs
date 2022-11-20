class playercollsions{
    public bool collision(player1 plyr1, playertrail plyrtrl){
        if(plyr1.getx() >= plyrtrl.gettrailx() && plyr1.getx() <= plyrtrl.gettrailx() + 15 && plyr1.gety() >= plyrtrl.gettraily() && plyr1.gety() <= plyrtrl.gettraily() + 15){
            plyr1.turnwhite();
            plyrtrl.turnwhite();
            return true;
        }
        if(plyr1.getx() < 0 || plyr1.getx() > 1200 || plyr1.gety() < 0 || plyr1.gety() > 1080){
            plyr1.turnwhite();
            plyrtrl.turnwhite();
            return true;
        }
        return false;
    }
    public bool p2collision(player1 plyr2, playertrail plyrtrl){
        if(plyr2.getx() >= plyrtrl.gettrailx() && plyr2.getx() <= plyrtrl.gettrailx() + 15 && plyr2.gety() >= plyrtrl.gettraily() && plyr2.gety() <= plyrtrl.gettraily() + 15){
            plyr2.turnwhite();
            plyrtrl.turnwhite();
            return true;
        }
        if(plyr2.getx() < 0 || plyr2.getx() > 1200 || plyr2.gety() < 0 || plyr2.gety() > 1080){
            plyr2.turnwhite();
            plyrtrl.turnwhite();
            return true;
        }
        return false;
    }
}