namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Room room = new Room ("dordlu",325,4);
            Hotel hotel = new Hotel("hilton", 332);

            double roomId;
            double Price;
            string name;
            double personCapacity;
            bool isAvaible;

           bool f=false;
           string choice;
            do
            {
                Console.WriteLine("1.otaq elave et  2.rezervasiya et");
                choice =Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("otaq adi daxil et");
                        name = Console.ReadLine();

                        bool isroomId = false;
                     
                      
                            do
                            {
                                Console.WriteLine("otaq nomresi daxil et");
                                isroomId = double.TryParse(Console.ReadLine(), out roomId);
                            } while (!isroomId);
                      
                        do
                        {
                            Console.WriteLine("otaq odenisi daxil et");
                            isroomId = double.TryParse (Console.ReadLine(), out Price );

                        }while (!isroomId);

                        do
                        {
                            Console.WriteLine("otaq nece neferlikdir?");
                            isroomId= double.TryParse (Console.ReadLine(),out personCapacity);

                        }while (!isroomId);

                        case "2":
                        break;





                   break;
                    default:
                }


            } while (!f);
        }
    }
}
