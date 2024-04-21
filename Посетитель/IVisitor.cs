namespace Посетитель
{
    public interface IVisitor
    {
        void VisitLion(Lion lion);
        void VisitMonkey(Monkey monkey);
    }
}