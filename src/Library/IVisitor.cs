namespace Library
{

    public interface IVisitor
    {


        public void VisitAge(Node node);

        public void VisitOldest(Node node);

        public void VisitLongestName(Node node);

    }

}