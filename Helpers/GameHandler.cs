namespace BlazorApp_Game.Helpers
{
    public class GameHandler
    {
        //sdelanny vybor       
        public RSPOptions Choose { get; set; }

        //uslov pobedy
        public RSPOptions WinCondition { get; set; }

        //uslov proigral
        public RSPOptions LooseCondition { get; set; }

        //put hranenia Kartinki
        public string Image { get; set; }

        //metod vozvraschenia resultata igry
        public GameState GameRezult(GameHandler opponent)
        {
            if (Choose == opponent.Choose)
                return GameState.Draw;
            if (LooseCondition == opponent.Choose)
                return GameState.Loss;
            return GameState.Victory;
        }

    }
}
