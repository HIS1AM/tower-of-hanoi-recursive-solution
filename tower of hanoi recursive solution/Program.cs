MoveDisks(4, 1, 3, 2);

static void MoveDisks(int n, int s, int f, int t)
{
    if(n > 0)
    {
        MoveDisks(n - 1, s, t, f);
        Console.WriteLine($"move disk {n} from tower {s} to tower {f}");
        MoveDisks(n - 1, t, f, s);
    }
}