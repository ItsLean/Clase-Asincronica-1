using Clase_Asincronica_1;

class Program
{
    static void Main(string[] args)
    {
        LinkedList list = new LinkedList();

        list.AddLast(10);
        list.AddLast(20);
        list.AddLast(30);
        list.AddFirst(5);

        Console.WriteLine("Lista después de agregar elementos:");
        list.PrintList();

        list.DeleteWithValue(20);
        Console.WriteLine("Lista después de eliminar el elemento 20:");
        list.PrintList();
    }
}
