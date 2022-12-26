using StackAndQueue;

namespace StackAndQue
{
    public class Pogram
    {
        static void Main(string[] args)
        {
            Stack_s stack_S=new Stack_s();
            stack_S.push(70);
            stack_S.push(30);
            stack_S.push(56);
            stack_S.Display();

            stack_S.peek();

            stack_S.pop();

            stack_S.Display();
        }
    }
}
