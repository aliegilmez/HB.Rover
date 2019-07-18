namespace HB.Rover.BusinessLogic.Abstract
{
    public interface IRover
    {
        Direction GetDirection(char direcitonChar);
        void ProcessDirectionList();
        void ProcessDirection(char direction);
        void ProcessMove();
        void ProcessDirectionInstruction(char directionChar);
    }
}
