using Raylib_cs;
namespace cycle{
    static class program{
        public static void Main(){
            redplayer plyr1 = new redplayer();
            blueplayer plyr2 = new blueplayer();
            gameoverplayer gameover = new gameoverplayer();
            playermovement plyrmvmnt = new playermovement();
            playercollsions plyrclsn = new playercollsions();
            List<playertrail> trail1List = new List<playertrail>();
            List<playertrail> trail2List = new List<playertrail>();
            plyr1.player(400, 400, '@', '#', Color.RED, Color.RED, direction.up);
            plyr2.player(800, 400, '@', '#', Color.BLUE, Color.BLUE, direction.up);
            Raylib.SetTargetFPS(10);
            Raylib.InitWindow(1200, 1080, "");
            int movecounter = 0;
            int trailcounter = 0;
            while(!Raylib.WindowShouldClose()){
                movecounter += 1;
                Raylib.ClearBackground(Color.BLACK);
                Raylib.BeginDrawing();
                Raylib.DrawText(movecounter.ToString(), 100, 200, 15, Color.BLUE);
                Raylib.DrawText(trailcounter.ToString(), 200, 200, 25, Color.BLUE);
                Raylib.DrawText(plyr1.getbike().ToString(), plyr1.getx(), plyr1.gety(), 15, plyr1.getbikecolor());
                Raylib.DrawText(plyr2.getbike().ToString(), plyr2.getx(), plyr2.gety(), 15, plyr2.getbikecolor());
                if(Raylib.IsKeyDown(KeyboardKey.KEY_W)){plyrmvmnt.move(plyr1, plyr2, KeyboardKey.KEY_W);}
                if(Raylib.IsKeyDown(KeyboardKey.KEY_A)){plyrmvmnt.move(plyr1, plyr2, KeyboardKey.KEY_A);}
                if(Raylib.IsKeyDown(KeyboardKey.KEY_S)){plyrmvmnt.move(plyr1, plyr2, KeyboardKey.KEY_S);}
                if(Raylib.IsKeyDown(KeyboardKey.KEY_D)){plyrmvmnt.move(plyr1, plyr2, KeyboardKey.KEY_D);}
                if(Raylib.IsKeyDown(KeyboardKey.KEY_I)){plyrmvmnt.move(plyr1, plyr2, KeyboardKey.KEY_I);}
                if(Raylib.IsKeyDown(KeyboardKey.KEY_J)){plyrmvmnt.move(plyr1, plyr2, KeyboardKey.KEY_J);}
                if(Raylib.IsKeyDown(KeyboardKey.KEY_K)){plyrmvmnt.move(plyr1, plyr2, KeyboardKey.KEY_K);}
                if(Raylib.IsKeyDown(KeyboardKey.KEY_L)){plyrmvmnt.move(plyr1, plyr2, KeyboardKey.KEY_L);}
                plyrmvmnt.constantmove(plyr1);
                playertrail trail1 = new playertrail();
                trailcounter += 1;
                trail1.trailsetup(plyr1, plyr1.gettrail(), plyr1.gettrailcolor());
                trail1.trail(plyr1);
                trail1List.Add(trail1);
                for(int i = 0; i < trail1List.Count(); i++){
                    Raylib.DrawText(trail1List[i].gettrail().ToString(), trail1List[i].gettrailx(), trail1List[i].gettraily(), 15, trail1List[i].gettrailcolor());
                }
                plyrmvmnt.constantmove(plyr2);
                playertrail trail2 = new playertrail();
                trailcounter += 1;
                trail2.trailsetup(plyr2, plyr2.gettrail(), plyr2.gettrailcolor());
                trail2.trail(plyr2);
                trail2List.Add(trail2);
                for(int i = 0; i < trail2List.Count(); i++){
                    Raylib.DrawText(trail2List[i].gettrail().ToString(), trail2List[i].gettrailx(), trail2List[i].gettraily(), 15, trail2List[i].gettrailcolor());
                }
                gameover.gameover(plyr1, trail2List, plyrclsn);
                //gameover.gameover(plyr2, trail2List, plyrclsn);
                gameover.gameover(plyr2, trail1List, plyrclsn);
                //gameover.gameover(plyr1, trail1List, plyrclsn);
                Raylib.EndDrawing();
            }

        }
    }
}