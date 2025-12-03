class Dice
{
    private static Random rng = new Random(); 
    private int antalSider;

    public Dice(int antalSider)
    {
        this.antalSider = antalSider;
    }

    public int Throw()
    {
        int rand1 =  rng.Next(1,antalSider + 1); // Tal mellem 1-antalsider.

        return rand1;
    }

}