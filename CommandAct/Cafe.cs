namespace CommandAct
{
    public class Cafe
    {
        public void MakeCoffee()
        {
            Console.WriteLine("Elaborando pedido capuccino vainilla...");

        }

        public void CancelCoffee()
        {
            Console.WriteLine("Cancelando orden...");
        }

        public void MakeTea()
        {
            Console.WriteLine("Haciendo té...");
        }

        public void CancelTea()
        {
            Console.WriteLine("Cancelando la orden de té.");
        }

        public void UndoLastOrder()
        {
            Console.WriteLine("Deshaciendo la última orden.");
        }
    }
}
