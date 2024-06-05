abstract class Middleware
{
    private Middleware next;

    public Middleware LinkWith(Middleware next)
    {
        this.next = next;

        return next;
    }

    public abstract bool Check(string email, string password);

    protected bool CheckNext(string email, string password)
    {
        return next == null ? true : next.Check(email, password);
    }

}
